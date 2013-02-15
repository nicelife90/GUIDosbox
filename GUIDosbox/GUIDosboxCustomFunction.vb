Option Strict On
Option Explicit On

Imports System.IO
Imports AxShockwaveFlashObjects
Imports System.Security.Principal
Imports System.Collections.Specialized
Imports System.Collections.ObjectModel

Module GUIDosboxCustomFunction

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
    ''' Lance le bon form (tools) après avoir été lancé en mode administrateur.
    ''' </summary>
    Public Sub ShowGUIDosboxForm(ByVal FormName As String)

        Dim ShowedForm As Windows.Forms.Form

        Select Case FormName
            Case "assoc"
                ShowedForm = AssocApp
            Case "attrib"
                ShowedForm = AttribApp
            Case "cacls"
                ShowedForm = CaclsApp
            Case "chkdsk"
                ShowedForm = CHKDSkApp
            Case "cmd"
                ShowedForm = CMDConsole
            Case "compact"
                ShowedForm = CompactApp
            Case "comp"
                ShowedForm = CompApp
            Case "help"
                ShowedForm = HelpApp
            Case "rd"
                ShowedForm = RDApp
            Case "subst"
                ShowedForm = SUBSTApp
            Case "systeminfo"
                ShowedForm = SystemInfoApp
            Case "tracert"
                ShowedForm = TracertApp
            Case "type"
                ShowedForm = TypeApp
            Case "where"
                ShowedForm = WhereApp
            Case "whoami"
                ShowedForm = WhoamiApp
            Case "xcopy"
                ShowedForm = XCopyApp

            Case Else
                ShowedForm = CP
        End Select

        CP.Hide()
        ShowedForm.Show()
    End Sub

#End Region


End Module
