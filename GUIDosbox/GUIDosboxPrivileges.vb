'Créé par : Nice-Life90
'http://www.kobixxe.com
'Copyright (C) 2010 - 2013 Kobixxe - Montréal 
'Tous droits réservés

' Ce Module contient toutes les fonctions et méthodes pour la gestion des privilèges.
' Certain Tools de ce projet doivent être exécuter avec des privilèges différent sur le système.

Option Strict On
Option Explicit On

Imports System.Security.Principal

Module GUIDosboxPrivileges

    ''' <summary>
    ''' Vérifie le niveau de privilèges requis par l'utilitaire et le lance dans le bon mode
    ''' </summary>
    ''' <param name="Tools">Utilitaire à lancé --> Voir ShowGUIDosboxForm() dans GUIDosboxFunction</param>
    ''' <param name="LevelNeeded">Niveau de privilèges requis, 1 --> Administrateur, 2 --> Utilisateur, 3 --> Requis Admin sinon Close, -1 --> Nothing</param>
    Public Sub CheckPrivilegeLevelNeeded(ByVal Tools As String, ByVal LevelNeeded As Integer)
        Select Case LevelNeeded
            Case 1 '<-- Require Administrator
                If Not RunAsAdmin() Then
                    'Avertissement
                    frmNeedAdminPrivilege.Show()
                Else
                    OpenCloseGUIDosboxForm(Tools)
                End If

            Case 2 '<-- Require Users
                If RunAsAdmin() Then
                    Try
                        My.Computer.FileSystem.WriteAllText(System.IO.Path.GetTempPath() & "\stf.guidb", Tools, False)
                    Catch ex As Exception
                        MsgBox("Une erreur est survenue avec la création d'un fichier temporaire, " & _
                               ex.Message, MsgBoxStyle.Critical, "GUIDbos - Erreur")
                    End Try
                    frmNeedUserPrivilege.Show()
                Else
                    OpenCloseGUIDosboxForm(Tools)
                End If

            Case 3 '<-- Ferme GUIDosbox après qu'un utilitaire est été lancé en mode utilisateur
                If Not RunAsAdmin() Then
                    Application.Exit()
                End If

            Case -1 '<-- Nothing Required
                OpenCloseGUIDosboxForm(Tools)
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
    ''' Lance l'application en mode Utilisateur
    ''' </summary>
    Public Sub RunAsUserNow()
        Dim p As Process = New Process
        p.StartInfo.FileName = "runas.exe"
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p.StartInfo.Arguments = "/trustlevel:0x20000 " & """" & Application.ExecutablePath & """"
        p.Start()
    End Sub

    ''' <summary>
    ''' Lance le bon Form après avoir été lancé en mode utilisateur. 
    ''' </summary>
    ''' <param name="FormName">Nom de l'utilitaire ex: assoc</param>
    Public Sub OpenCloseGUIDosboxForm(ByVal FormName As String)

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
                Form = XcopyApp
            Case Else
                Form = CP
        End Select

        CP.Hide()
        Form.Show()
    End Sub

End Module
