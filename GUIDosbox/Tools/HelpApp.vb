' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

Option Strict On
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

End Class