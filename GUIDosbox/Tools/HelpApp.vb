﻿Option Strict On
Option Explicit On

Public Class HelpApp

#Region "Mode avancé"

    'Variable pour le mode avancé.
    Private AdvanceMode As Boolean = False

    Private Sub optAdvanceMode_CheckedChanged(sender As Object, e As EventArgs) Handles optAdvanceMode.CheckedChanged
        If optAdvanceMode.Checked = True Then
            AdvanceMode = True
            btnApply.Visible = False
            btnSend.Visible = True
            txtCmdExec.Visible = True
            lblAdvanceMode.Visible = True
            footer.AdvanceMode(AdvanceMode)
        Else
            AdvanceMode = False
            btnApply.Visible = True
            btnSend.Visible = False
            txtCmdExec.Visible = False
            lblAdvanceMode.Visible = False
            footer.AdvanceMode(AdvanceMode)
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        'Envoi de la commande
        myConsole.SendCommand(txtCmdExec.Text)
        txtCmdExec.Text = Nothing
    End Sub

#End Region

    Private Sub HelpApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Démarrage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        LoadHeader(flashHeader, "help")

        'Mode avancé caché
        btnSend.Visible = False
        lblAdvanceMode.Visible = False
        txtCmdExec.Visible = False

        'Définition du niveau de privilèges de l'utilitaires
        footer.PrivilegeLevelNeeded(-1)
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        'Affichage de l'aide
        myConsole.Cls()
        myConsole.SendCommand("help")
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Arrêt de la console et retour au cp.
        myConsole.CloseConsole("help")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset de la console
        myConsole.Cls()
    End Sub

    ''' <summary>
    ''' Ce sub empêche la console d'être sélectionné.
    ''' </summary>
    Private Sub myConsole_Enter(sender As Object, e As EventArgs) Handles myConsole.Enter
        ActiveControl = txtCmdExec
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

#Region "Language"
    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then ' boite cochée=FR donc, default pour la checkbox est checked
            btnApply.Text = "Aide"
            btnBack.Text = "Retour"
            btnSend.Text = "Envoyer"
            optAdvanceMode.Text = "Mode avancé"
            btnClear.Text = "Effacer"
        Else                                ' boite PAS cochée=EN 
            btnApply.Text = "Help"
            btnBack.Text = "Back"
            btnSend.Text = "Send"
            optAdvanceMode.Text = "Advance mode"
            btnClear.Text = "Clear"
        End If
    End Sub
#End Region
End Class