Option Strict On
Option Explicit On

Imports System.IO
Imports AxShockwaveFlashObjects
Imports System.Security.Principal
Imports System.Collections.Specialized
Imports System.Collections.ObjectModel


Module GUIDosboxFunction

    ''' <summary>
    ''' Crée un nouveau OpenFileDialogs et retourne le chemin du fichier sélectionné.
    ''' </summary>
    ''' <returns>Le chemin du fichier sélectionné</returns>
    Public Function ofd() As String
        Dim opFD As New OpenFileDialog
        opFD.Title = "GUI Dosbox"
        opFD.Multiselect = False
        opFD.FileName = Nothing
        opFD.ShowDialog()
        Return opFD.FileName
    End Function

    ''' <summary>
    ''' Crée un nouveau FolderBrowserDialog et retourne le chemin du dossier sélectionné.
    ''' </summary>
    ''' <returns>Le chemin du dossier sélectionné</returns>
    Public Function fbd() As String
        Dim opFD As New FolderBrowserDialog
        opFD.RootFolder = Environment.SpecialFolder.MyComputer
        opFD.ShowDialog()
        Return opFD.SelectedPath
    End Function

    ''' <summary>
    ''' Retourne les compte d'utilisateurs sur l'ordinateur spécifié.
    ''' </summary>
    ''' <param name="MachineName">The computer to get user accounts from</param>
    Public Function GetLocalUsers(ByVal MachineName As String) As List(Of String)
        Dim WinNt As New DirectoryServices.DirectoryEntry("WinNT://" & MachineName)
        Dim UserList As New List(Of String)
        For Each User As DirectoryServices.DirectoryEntry In WinNt.Children
            If User.SchemaClassName = "User" Then
                UserList.Add(User.Name)
            End If
        Next
        Return UserList
    End Function

    ''' <summary>
    ''' Retourne les groupes actif sur l'ordinateur spécifié.
    ''' </summary>
    ''' <param name="MachineName">The computer to get user accounts from</param>
    Public Function GetLocalGroup(ByVal MachineName As String) As List(Of String)
        Dim WinNt As New DirectoryServices.DirectoryEntry("WinNT://" & MachineName)
        Dim GroupList As New List(Of String)
        For Each Group As DirectoryServices.DirectoryEntry In WinNt.Children
            If Group.SchemaClassName = "Group" Then
                GroupList.Add(Group.Name)
            End If
        Next
        Return GroupList
    End Function

    ''' <summary>
    ''' Renvoi la liste des lettres utilisées par les lecteurs (Drive) 
    ''' </summary>
    Public Function UsedDrive() As StringCollection
        Dim lecteurs As New StringCollection
        Dim drives As ReadOnlyCollection(Of DriveInfo) = My.Computer.FileSystem.Drives
        For Each drive As DriveInfo In drives
            Dim lecteur As String = drive.ToString.Substring(0, drive.ToString.Length - 1)
            lecteurs.Add(lecteur.ToString)
        Next
        Return lecteurs
    End Function


    ''' <summary>
    ''' Renvoi une liste de lettre disponible pour un lecteur
    ''' </summary>
    Public Function AvailableDrive() As StringCollection

        'Création d'un StringCollection avec les lettre de l'alphabet
        Dim alphabet As New StringCollection()
        Dim lowerBound As Integer = Convert.ToInt16("a"c)
        Dim upperBound As Integer = Convert.ToInt16("z"c)
        For i As Integer = lowerBound To upperBound - 1
            Dim driveLetter As Char = ChrW(i)
            alphabet.Add(driveLetter.ToString())
        Next

        'Supprime les lettre déja utiliser par un lecteur
        For Each drive In UsedDrive()
            alphabet.Remove(drive.Substring(0, 1).ToLower())
        Next

        If alphabet.Count > 0 Then
            Return alphabet
        Else
            Throw New ApplicationException("No drives available.")
        End If
    End Function

    ''' <summary>
    ''' Vérifie si GUIDosbox est lancé avec des arguments.
    ''' Ex: GUIDosbox.exe /cmdc
    ''' </summary>
    ''' <returns>Avec arguments --> True, Sans arguments --> False</returns>
    Public Function OpenWithCmdArgs() As Boolean
        If My.Application.CommandLineArgs.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Permet de supprimer le texte contenue dans chacun des textbox du form.
    ''' </summary>
    ''' <param name="root">Form name généralement « Me »</param>
    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    ''' <summary>
    ''' Charge le Header (Flash Movie) à partir des ressources incorporées.
    ''' </summary>
    ''' <param name="header">Nom du composant AxShockwaveFlash</param>
    ''' <param name="tools">Nom de la ressource (Flash Movie)</param>
    Public Sub LoadHeader(ByVal header As AxShockwaveFlash, ByVal tools As String)
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & tools & ".swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, CType(My.Resources.ResourceManager.GetObject(tools), Byte()), False)
            header.LoadMovie(0, System.IO.Path.GetTempPath & "\" & tools & ".swf")
            header.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors du chargement de cette fenêtre, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try
    End Sub


#Region " Gestion des privilèges "

    ''' <summary>
    ''' Requis par la fonction CheckPrivilegeLevelNeeded() et par frmMsgBox
    ''' </summary>
    Public PrivilegesLevel As Integer
    ''' <summary>
    ''' Vérifie le niveau de privilèges requis par l'utilitaire et le lance dans le bon mode
    ''' </summary>
    ''' <param name="Tools">Utilitaire à lancé --> Voir ShowGUIDosboxForm() dans GUIDosboxFunction</param>
    ''' <param name="LevelNeeded">Niveau de privilèges requis, 1 --> Administrateur, 2 --> Utilisateur, 3 --> Nothing</param>
    Public Sub CheckPrivilegeLevelNeeded(ByVal Tools As String, ByVal LevelNeeded As Integer)

        'Initialisation et affectation de la variable PrivilegesLevel
        PrivilegesLevel = LevelNeeded

        Select Case LevelNeeded
            'Require Administrator
            Case 1
                If Not RunAsAdmin() Then
                    Try
                        My.Computer.FileSystem.WriteAllText(System.IO.Path.GetTempPath() & "\stf.guidb", Tools, False)
                    Catch ex As Exception
                        MsgBox("Une erreur est survenue avec la création d'un fichier temporaire, " & _
                               ex.Message, MsgBoxStyle.Critical, "GUIDbos - Erreur")
                    End Try
                    frmMsgBox.Show()
                Else
                    OpenCloseGUIDosboxForm(Tools, 1)
                End If
                'Require Users
            Case 2
                If RunAsAdmin() Then
                    Try
                        My.Computer.FileSystem.WriteAllText(System.IO.Path.GetTempPath() & "\stf.guidb", Tools, False)
                    Catch ex As Exception
                        MsgBox("Une erreur est survenue avec la création d'un fichier temporaire, " & _
                               ex.Message, MsgBoxStyle.Critical, "GUIDbos - Erreur")
                    End Try
                    frmMsgBox.Show()
                Else
                    OpenCloseGUIDosboxForm(Tools, 1)
                End If
                'Nothing Required
            Case -1
                OpenCloseGUIDosboxForm(Tools, 1)
        End Select
    End Sub

    ''' <summary>
    ''' Vérifie le niveau d'exécution de l'application (Administrateur - Normal)
    ''' </summary>
    ''' <returns>True --> Administrateur (admin), False --> Normal (User) </returns>
    Public Function RunAsAdmin() As Boolean
        Dim user As New WindowsPrincipal(WindowsIdentity.GetCurrent())
        Dim HaveAdminRight As Boolean = user.IsInRole(WindowsBuiltInRole.Administrator)
        If HaveAdminRight Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Lance l'application en mode administrateur.
    ''' </summary>
    Public Sub RunAsAdminNow()
        Dim processInfo As New ProcessStartInfo()
        processInfo.Verb = "runas"
        processInfo.FileName = Application.ExecutablePath
        Try
            Process.Start(processInfo)
        Catch ex As Exception
            'Do nothing. Probably the user canceled the UAC window
        End Try
    End Sub

    ''' <summary>
    ''' Lance l'application en mode Utilisateur
    ''' </summary>
    Public Sub RunAsUserNow()
        Dim p As Process = New Process
        p.StartInfo.FileName = "runas.exe"
        p.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        p.StartInfo.Arguments = "/trustlevel:0x20000 " & """" & Application.ExecutablePath & """"
        p.Start()
        'Shell("cmd.exe /k runas /truslevel:0x20000 " & """" & Application.ExecutablePath & """", AppWinStyle.Hide)

        'Dim processInfo As New ProcessStartInfo()
        'processInfo.FileName = Application.ExecutablePath
        'Try
        '    Process.Start(processInfo)
        'Catch ex As Exception
        '    'Do nothing. Probably the user canceled the UAC window
        'End Try
    End Sub

    ''' <summary>
    ''' Mode 1 --> Lance le bon Form après avoir été lancé par un changement de mode (Administrateur, User). 
    ''' Mode 2 --> Retourne le nom du Form à fermer.
    ''' </summary>
    ''' <param name="FormName">Nom de l'utilitaire ex: assoc</param>
    ''' <param name="Mode">1 --> Ouvrir, 2 --> Fermer</param>
    ''' <returns>Mode 2 --> Le nom du Form à fermer., Mode 1 --> Rien</returns>
    Public Function OpenCloseGUIDosboxForm(ByVal FormName As String, Mode As Integer) As Windows.Forms.Form

        'Variable pour le Form choisi
        Dim Form As Windows.Forms.Form

        'Sélection du Form
        Select Case FormName
            Case "assoc"
                Form = AssocApp
            Case "attrib"
                Form = AttribApp
            Case "cacls"
                Form = CaclsApp
            Case "chkdsk"
                Form = CHKDSkApp
            Case "cmd"
                Form = CMDConsole
            Case "compact"
                Form = CompactApp
            Case "comp"
                Form = CompApp
            Case "help"
                Form = HelpApp
            Case "rd"
                Form = RDApp
            Case "subst"
                Form = SUBSTApp
            Case "systeminfo"
                Form = SystemInfoApp
            Case "tracert"
                Form = TracertApp
            Case "type"
                Form = TypeApp
            Case "where"
                Form = WhereApp
            Case "whoami"
                Form = WhoamiApp
            Case "xcopy"
                Form = XCopyApp
            Case Else
                Form = CP
        End Select

        'Action selon le mode --> 1 Ouvrir, 2 Fermer
        Select Case Mode
            Case 1 '--> Open Form
                CP.Hide()
                Form.Show()
            Case 2 '--> Close Form
                Return Form
        End Select

        Return Nothing

    End Function
#End Region


    

End Module
