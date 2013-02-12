'Pour une liste de toute les commandes cmd disponble et une description complette.
'http://technet.microsoft.com/en-us/library/bb490928.aspx

Option Strict On
Imports System.IO

Public Class CP

#Region "Barre de menu"

    Private Sub AttribToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttribToolStripMenuItem.Click
        Me.Hide()
        AttribApp.Show()
    End Sub

    Private Sub ChkdskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkdskToolStripMenuItem.Click
        Me.Hide()
        CHKDSkApp.Show()
    End Sub

    Private Sub CmdConsoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdConsoleToolStripMenuItem.Click
        Me.Hide()
        CMDConsole.Show()
    End Sub

    Private Sub CompactToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompactToolStripMenuItem.Click
        Me.Hide()
        CompactApp.Show()
    End Sub

    Private Sub XcopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XcopyToolStripMenuItem.Click
        'Vérification des droits
        If Not RunAsAdmin() Then
            My.Computer.FileSystem.WriteAllText(System.IO.Path.GetTempPath() & "\stf.guidb", "XCopyApp", False)
            frmMsgBox.Show()
        Else
            Me.Hide()
            XCopyApp.Show()
        End If
    End Sub

    Private Sub COmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssocToolStripMenuItem.Click
        Me.Hide()
        AssocApp.Show()
    End Sub

    Private Sub AideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        HelpApp.Show()
        Me.Hide()
    End Sub

    Private Sub QuiterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuiterToolStripMenuItem.Click
        End
    End Sub

    Private Sub WhoamiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhoamiToolStripMenuItem.Click
        Me.Hide()
        WhoamiApp.Show()
    End Sub

    Private Sub COMPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPToolStripMenuItem.Click
        Me.Hide()
        CompApp.Show()
    End Sub

    Private Sub TRACERTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRACERTToolStripMenuItem.Click
        Me.Hide()
        TracertApp.Show()
    End Sub

    Private Sub TYPEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TYPEToolStripMenuItem.Click
        Me.Hide()
        TypeApp.Show()
    End Sub

    Private Sub RToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RToolStripMenuItem.Click
        Me.Hide()
        CaclsApp.Show()
    End Sub

    Private Sub RDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDToolStripMenuItem.Click
        Me.Hide()
        RDApp.Show()
    End Sub

    Private Sub SUBSTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUBSTToolStripMenuItem.Click
        Me.Hide()
        SUBSTApp.Show()
    End Sub

    Private Sub SYSTEMINFOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYSTEMINFOToolStripMenuItem.Click
        Me.Hide()
        SystemInfoApp.Show()
    End Sub

    Private Sub RToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RToolStripMenuItem1.Click
        Me.Hide()
        WhereApp.Show()
    End Sub
    Private Sub ToolStripAide_Click(sender As Object, e As EventArgs) Handles ToolStripAide.Click
        Me.Hide()
        HelpApp.Show()
    End Sub
#End Region

#Region "Changement de langue"

    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged

        'Changement de langue des mot du menus
        If chkbxLangue.Checked = True Then ' boite cochée=FR donc, default pour la checkbox est checked

            chkbxLangue.Text = "Français"
            FichierToolStripMenuItem.Text = "Fichier"
            ToolStripAide.Text = "Aide"
            QuiterToolStripMenuItem.Text = "Quitter"
            EnglishToolStripMenuItem.Text = "Anglais"
            FrançaisToolStripMenuItem.Text = "Français"
            LangueToolStripMenuItem.Text = "Langue"


        Else
            chkbxLangue.Text = "English" ' boite PAS cochée=EN 
            FichierToolStripMenuItem.Text = "File"
            ToolStripAide.Text = "Help"
            QuiterToolStripMenuItem.Text = "Quit"
            FrançaisToolStripMenuItem.Text = "French"
            EnglishToolStripMenuItem.Text = "English"
            LangueToolStripMenuItem.Text = "Language"


        End If
    End Sub

    Private Sub FrançaisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrançaisToolStripMenuItem.Click

        'langue selectionner Francais
        Me.chkbxLangue.Checked = True
        AssocApp.chkbxLangue.Checked = True
        AttribApp.chkbxLangue.Checked = True
        CHKDSkApp.chkbxLangue.Checked = True             'changement de la langue
        CMDConsole.chkbxLangue.Checked = True
        CompactApp.chkbxLangue.Checked = True
        HelpApp.chkbxLangue.Checked = True
        WhoamiApp.chkbxLangue.Checked = True
        XCopyApp.chkbxLangue.Checked = True
        WhoamiApp.chkbxLangue.Checked = True
        TracertApp.chkbxLangue.Checked = True
        TypeApp.chkbxLangue.Checked = True

        'changemement du menu flash selon la langue
        FlashCPFR.Show()
        FlashCPEN.Hide()


    End Sub

    Private Sub EnglishToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnglishToolStripMenuItem.Click

        'langue selectionner anglais
        Me.chkbxLangue.Checked = False
        AssocApp.chkbxLangue.Checked = False
        AttribApp.chkbxLangue.Checked = False
        CHKDSkApp.chkbxLangue.Checked = False                'changement de langue
        CMDConsole.chkbxLangue.Checked = False
        CompactApp.chkbxLangue.Checked = False
        HelpApp.chkbxLangue.Checked = False
        WhoamiApp.chkbxLangue.Checked = False
        XCopyApp.chkbxLangue.Checked = False
        WhoamiApp.chkbxLangue.Checked = False
        TracertApp.chkbxLangue.Checked = False
        TypeApp.chkbxLangue.Checked = False

        'changement du menu selon la langue
        FlashCPFR.Hide()
        FlashCPEN.Show()

    End Sub

#End Region

#Region "Parramètres de démarrage"
    Private Sub CP_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'Permet d'accepter les arguments de démarrage
        If OpenWithCmdArgs() Then

            Dim CmdArg As String = My.Application.CommandLineArgs(0)
            Select Case CmdArg
                Case "/cmdc"
                    CMDConsole.Show()
                    Me.Close()

                Case "/test"
                    MsgBox("salut")

            End Select
        End If


        'Ouverture du form (tools) après avoir été lancé en mode administrateur.
        Try
            If File.Exists(Path.GetTempPath & "\stf.guidb") Then
                Dim FormToShow As String
                FormToShow = System.IO.File.ReadAllText(Path.GetTempPath & "\stf.guidb")
                File.Delete(Path.GetTempPath & "\stf.guidb")
                ShowGUIDosboxForm(FormToShow)
            End If
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors du démmarage de l'application en mode administrateur, " & ex.Message, _
                 MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

    End Sub
#End Region

    Private Sub CP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Préparation de l'interface d'utilisateur
        Try

            'Status Strip
            lblUser.Text = "Bienvenue, " & Environment.UserName & " : "
            lblMode.ForeColor = If(RunAsAdmin, Color.DarkOrange, Color.RoyalBlue)
            lblMode.Text = If(RunAsAdmin(), "Mode Administrateur", "Mode Utilisateur")

            'Déclaration des chemins pour les nouveaux fichiers 
            Dim MovieENPath As String = System.IO.Path.GetTempPath & "\" & "Menu_EN_GuiDosBox.swf"
            Dim MovieFRPath As String = System.IO.Path.GetTempPath & "\" & "Menu_GuiDosBox.swf"
            Dim Xml1Path As String = System.IO.Path.GetTempPath & "\" & "page_1.xml"
            Dim Xml2Path As String = System.IO.Path.GetTempPath & "\" & "page_2.xml"
            Dim Xml3Path As String = System.IO.Path.GetTempPath & "\" & "page_3.xml"
            Dim Xml10Path As String = System.IO.Path.GetTempPath & "\" & "page_10.xml"
            Dim Xml20Path As String = System.IO.Path.GetTempPath & "\" & "page_20.xml"
            Dim Xml30Path As String = System.IO.Path.GetTempPath & "\" & "page_30.xml"
            Dim StylePath As String = System.IO.Path.GetTempPath & "\" & "style.css"
            Dim Style2Path As String = System.IO.Path.GetTempPath & "\" & "style2.css"
            Dim HeaderPath As String = System.IO.Path.GetTempPath & "\" & "headerGUIDOSBOX.swf"

            'Création des nouveaux fichiers à partir des resources
            My.Computer.FileSystem.WriteAllBytes(MovieENPath, My.Resources.Menu_EN_GuiDosBox, False)
            My.Computer.FileSystem.WriteAllBytes(MovieFRPath, My.Resources.Menu_GuiDosBox, False)
            My.Computer.FileSystem.WriteAllText(Xml1Path, My.Resources.page_1, False)
            My.Computer.FileSystem.WriteAllText(Xml2Path, My.Resources.page_2, False)
            My.Computer.FileSystem.WriteAllText(Xml3Path, My.Resources.page_3, False)
            My.Computer.FileSystem.WriteAllText(Xml10Path, My.Resources.page_10, False)
            My.Computer.FileSystem.WriteAllText(Xml20Path, My.Resources.page_20, False)
            My.Computer.FileSystem.WriteAllText(Xml30Path, My.Resources.page_30, False)
            My.Computer.FileSystem.WriteAllText(StylePath, My.Resources.style, False)
            My.Computer.FileSystem.WriteAllText(Style2Path, My.Resources.style2, False)
            My.Computer.FileSystem.WriteAllBytes(HeaderPath, My.Resources.headerGUIDOSBOX, False)

            'Affichage du menu en francais
            FlashCPFR.LoadMovie(0, MovieFRPath)
            FlashCPFR.Menu = False
            FlashCPFR.Play()

            'Affichage du menu en anglais
            FlashCPEN.LoadMovie(0, MovieENPath)
            FlashCPEN.Play()

            'Affichage du header
            FlashHeader.LoadMovie(0, HeaderPath)
            FlashHeader.Play()

        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message, _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

    End Sub

End Class
