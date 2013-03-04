' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

Option Strict On
Option Explicit On

Public Class CaclsApp

#Region "Mode avancé"

    'Variable pour le mode avancé.
    Private AdvanceMode As Boolean = False

    Private Sub optAdvanceMode_CheckedChanged(sender As Object, e As EventArgs) Handles optAdvanceMode.CheckedChanged
        If optAdvanceMode.Checked = True Then
            AdvanceMode = True
            btnApply.Visible = False
            btnHelp.Visible = False
            btnNo.Visible = False
            btnYes.Visible = False
            btnSend.Visible = True
            txtCmdExec.Enabled = True
            footer.AdvanceMode(AdvanceMode)
        Else
            AdvanceMode = False
            btnApply.Visible = True
            btnHelp.Visible = True
            btnNo.Visible = True
            btnYes.Visible = True
            btnSend.Visible = False
            txtCmdExec.Enabled = False
            footer.AdvanceMode(AdvanceMode)
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        'Envoi de la commande
        myConsole.SendCommand(txtCmdExec.Text)
        txtCmdExec.Text = Nothing
    End Sub

    ''' <summary>
    ''' Permet d'afficher les commande précédente à l'aide des flèches.
    ''' </summary>
    ''' <param name="e">Retourne un Keycode</param>
    ''' <remarks>La procédure de ce sub est dans GUIDosboxBatchFile </remarks>
    Private Sub txtCmdExec_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCmdExec.KeyUp
        'Affichage des commande exécuter à l'aide des flèches.
        Dim Key As Keys = e.KeyCode
        If Key = Keys.Up Or Key = Keys.Down Or Key = Keys.Enter Then
            ShowLastCommand(txtCmdExec, Key)
        End If
    End Sub
#End Region

    Private Sub CaclsApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        'Démmarage de la console.
        myConsole.StartConsole()

        'Mode avancé caché
        btnSend.Hide()

        'Loading du header flash.
        LoadHeader(flashHeader, "cacls")

        'Ajout des éléments (utilisateurs) aux ComboBox. --> GUIDosboxCustomFunction
        Dim Users As List(Of String) = GetLocalUsers("localhost")
        For Each User As String In Users
            cbUserD.Items.Add(User)
            cbUserP.Items.Add(User)
            cbUserR.Items.Add(User)
            cbUserG.Items.Add(User)
        Next
        'Ajout des éléments (Groups) aux ComboBox. --> GUIDosboxCustomFunction
        Dim Groups As List(Of String) = GetLocalGroup("localhost")
        For Each Group In Groups
            cbUserD.Items.Add(Group)
            cbUserP.Items.Add(Group)
            cbUserR.Items.Add(Group)
            cbUserG.Items.Add(Group)
        Next

        'Options par défaut
        optE.Checked = True

        'Niveau de privilèges requis par l'utilitaire.
        footer.PrivilegeLevelNeeded(-1)
        
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variables
        Const App As String = "cacls "
        Dim Arguments As String = Nothing
        Dim GPerm As String = Nothing
        Dim PPerm As String = Nothing

        'Argument
        Dim args(9) As String
        For Each arg In args
            arg = Nothing
        Next

        'args(0) --> Fichier/Dossier
        args(0) = """" & txtFile.Text & """" & " "

        'args(1) --> /T
        If optT.Checked Then
            args(1) = "/T "
        End If

        'args(2) --> /M
        If optM.Checked Then
            args(2) = "/M "
        End If

        'args(3) --> /L
        If optL.Checked Then
            args(3) = "/L "
        End If

        'args(4) --> /E
        If optE.Checked Then
            args(4) = "/E "
        End If

        'args(5) = --> /C
        If optC.Checked Then
            args(5) = "/C "
        End If

        'GPerm --> Permission /G
        If optGLecture.Checked Then
            GPerm = "R"
        ElseIf optGEcrire.Checked Then
            GPerm = "W"
        ElseIf optGModif.Checked Then
            GPerm = "C"
        ElseIf optGControlT.Checked Then
            GPerm = "F"
        End If

        'PPerm --> Permission /P
        If optPLecture.Checked Then
            PPerm = "R"
        ElseIf optPEcrire.Checked Then
            PPerm = "W"
        ElseIf optPModif.Checked Then
            PPerm = "C"
        ElseIf optPControlT.Checked Then
            PPerm = "F"
        ElseIf optPAucun.Checked Then
            PPerm = "N"
        End If

        'args(6) --> /G util:perm
        If optG.Checked Then
            args(6) = "/G " + """" + cbUserG.Text + """" + ":" + GPerm + " "
        End If

        'args(7) --> /R utilisateur
        If optR.Checked Then
            args(7) = "/R " + """" + cbUserR.Text + """" + " "
        End If

        'args(8) --> /P util:perm
        If optP.Checked Then
            args(8) = "/P " + """" + cbUserP.Text + """" + ":" + PPerm + " "
        End If

        'args(9) --> /D utilisateur
        If optD.Checked Then
            args(9) = "/D " + """" + cbUserD.Text + """" + " "
        End If

        'Création de la chaine d'arguments
        For Each arg In args
            Arguments += arg
        Next

        'Envoi et afichage de la commande
        txtCmdExec.Text = myConsole.SendCommand(App + Arguments)

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide
        txtCmdExec.Text = myConsole.SendCommand("cacls /?")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Arrêt de la console et retour au cp
        myConsole.CloseConsole("cacls")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        'Envoi de la commande
        myConsole.SendCommand("o")
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        'Envoi de la commande
        myConsole.SendCommand("n")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des textbox et de la console
        ClearTextBox(Me)
        txtCmdExec.Text = "cls"
    End Sub

    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        'Sélection d'un fichier
        txtFile.Text = ofd()
    End Sub

    ''' <summary>
    ''' Empêche la console d'être sélectionné.
    ''' </summary>
    Private Sub myConsole_Enter() Handles myConsole.Enter
        If AdvanceMode Then
            ActiveControl = txtCmdExec
        Else
            ActiveControl = btnApply
        End If
    End Sub

End Class