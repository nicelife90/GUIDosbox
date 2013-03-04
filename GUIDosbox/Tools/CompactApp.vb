' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

Option Strict On
Option Explicit On

Public Class CompactApp

#Region "Mode avancé"

    'Variable pour le mode avancé.
    Private AdvanceMode As Boolean = False

    Private Sub optAdvanceMode_CheckedChanged(sender As Object, e As EventArgs) Handles optAdvanceMode.CheckedChanged
        If optAdvanceMode.Checked = True Then
            AdvanceMode = True
            btnApply.Visible = False
            btnHelp.Visible = False
            btnSend.Visible = True
            txtCmdExec.Enabled = True
            footer.AdvanceMode(AdvanceMode)
        Else
            AdvanceMode = False
            btnApply.Visible = True
            btnHelp.Visible = True
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

    Private Sub CompactApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démmarage de la console.
        myConsole.StartConsole()

        'Mode avancé caché.
        btnSend.Visible = False

        'Loading du header flash.
        LoadHeader(flashHeader, "compact")

        'Valeur par défaut.
        optI.Checked = True
        optC.Checked = True

        'Définition des privilèges requis par l'utilitaire
        footer.PrivilegeLevelNeeded(-1)
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variable et constantes.
        Const Apps As String = "compact "
        Dim Arguments As String = Nothing

        'Argument
        Dim args(9) As String
        For Each arg In args
            arg = Nothing
        Next

        'args(0) --> /C vs /U
        If optC.Checked Then
            args(0) = "/C "
        ElseIf optU.Checked Then
            args(0) = "/U "
        End If

        'args(1) --> /S
        If optS.Checked Then
            args(1) = "/S:" + """" & txtAllPath.Text & """" & " "
        End If

        'args(2) --> /A 
        If optA.Checked Then
            args(2) = "/A "
        End If

        'args(3) --> /I
        If optI.Checked Then
            args(3) = "/I "
        End If

        'args(4) --> /F
        If optF.Checked Then
            args(4) = "/F "
        End If

        'args(5) --> /Q
        If optQ.Checked Then
            args(5) = "/Q "
        End If

        'args(6) --> Path ! /S
        If Not optS.Checked Then
            args(6) = """" & txtRealPath.Text & """" & " "
        End If

        'Création de la chaine d'arguments
        For Each arg In args
            Arguments += arg
        Next

        'Exécution de la commande.
        txtCmdExec.Text = myConsole.SendCommand(Apps + Arguments)

    End Sub

    Private Sub btnDossier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDossier.Click
        'Sélection d'un dossier.
        txtAllPath.Text = fbd()
    End Sub

    Private Sub btnFichier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFichier.Click
        'Sélection d'un fichier
        txtRealPath.Text = ofd()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("compact")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        txtCmdExec.Text = myConsole.SendCommand("compact /?")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des textbox et de la console.
        ClearTextBox(Me)
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

#Region " Gestion de l'affichage "
    Private Sub optS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optS.CheckedChanged
        If optS.Checked Then
            txtRealPath.Hide()
            btnFichier.Hide()
        Else
            txtRealPath.Show()
            btnFichier.Show()
        End If
    End Sub
#End Region

End Class