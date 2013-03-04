' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

Option Strict On
Option Explicit On

Public Class AttribApp

#Region "Mode avancé"

    'Variable pour le mode avancé.
    Private AdvanceMode As Boolean = False

    Private Sub optAdvanceMode_CheckedChanged(sender As Object, e As EventArgs) Handles optAdvanceMode.CheckedChanged
        If optAdvanceMode.Checked = True Then
            AdvanceMode = True
            btnApply.Visible = False
            btnAide.Visible = False
            btnSend.Visible = True
            txtCmdExec.Enabled = True
            footer.AdvanceMode(AdvanceMode)
        Else
            AdvanceMode = False
            btnApply.Visible = True
            btnAide.Visible = True
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

    Private Sub AttribApp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Démarrage de la console
        myConsole.StartConsole()

        'Mode avancé caché
        btnSend.Visible = False

        'Loading du header flash.
        LoadHeader(flashHeader, "attrib")

        'Valeur par défaut
        optRNull.Checked = True
        optANull.Checked = True
        optSNull.Checked = True
        optHNull.Checked = True
        optINull.Checked = True

        'Niveau de privilèges requis par l'utilitaire.
        footer.PrivilegeLevelNeeded(-1)

    End Sub


    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variables et constantes.
        Const App As String = "attrib "
        Dim Arguments As String = Nothing

        'Arguments
        Dim args(8) As String
        For Each arg In args
            arg = Nothing
        Next

        'args(0) --> +/- R
        If optRPlus.Checked Then
            args(0) = "+R "
        ElseIf optRMoin.Checked Then
            args(0) = "-R "
        End If

        'args(1) -->  +/- A
        If optAplus.Checked Then
            args(1) = "+A "
        ElseIf optAMoin.Checked Then
            args(1) = "-A "
        End If

        'args(2) --> +/- S
        If optSPlus.Checked Then
            args(2) = "+S "
        ElseIf optSMoin.Checked Then
            args(2) = "-S "
        End If

        'args(3) --> +/- H
        If optHPlus.Checked Then
            args(3) = "+H "
        ElseIf optHMoin.Checked Then
            args(3) = "-H "
        End If

        'args(4) --> +/- I
        If optIPlus.Checked Then
            args(4) = "+I "
        ElseIf optIMoin.Checked Then
            args(4) = "-I "
        End If

        'args(5) -->
        args(5) = """" & txtFile.Text & """" & " "

        'args(6) --> /S
        If optS.Checked Then
            args(6) = "/S "
        End If

        'args(7) --> /D
        If optD.Checked Then
            args(7) = "/D "
        End If

        'args(8) --> /L
        If optL.Checked Then
            args(8) = "/L "
        End If

        'Création de la chaine d'argument.
        For Each arg In args
            Arguments += arg
        Next
       
        'Exécution de la commande.
        txtCmdExec.Text = myConsole.SendCommand(App + Arguments)

    End Sub

    Private Sub btnAide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAide.Click
        'Affichage de l'aide
        txtCmdExec.Text = myConsole.SendCommand("attrib /?")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset des textbox et de la console
        ClearTextBox(Me)
        txtCmdExec.Text = "cls"
    End Sub

    Private Sub btnFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiles.Click
        'Sélection d'un fichier
        txtFile.Text = ofd()
    End Sub

    Private Sub btnFolders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFolders.Click
        'Sélection d'un dossier
        txtFile.Text = fbd()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Arrêt de la console.
        myConsole.CloseConsole("attrib")
        CP.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Empêche la console d'être sélectionné.
    ''' </summary>
    Private Sub myConsole_Enter() Handles myConsole.Enter
        If AdvanceMode = True Then
            ActiveControl = txtCmdExec
        Else
            ActiveControl = btnApply
        End If
    End Sub

End Class