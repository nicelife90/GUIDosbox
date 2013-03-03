﻿' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

Option Strict On
Option Explicit On

Public Class CMDConsole

    Private Sub CMDConsole_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démmarage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        LoadHeader(flashHeader, "cmd1")

        'Définition des privilèges requis par l'utilitaire.
        footer.PrivilegeLevelNeeded(1)
        footer.AdvanceMode(True)
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        txtInput.Text = myConsole.SendCommand("cmd /?")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des textbox et de la console.
        ClearTextBox(Me) 
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        'Envoi de la commande.
        myConsole.SendCommand(txtInput.Text)
        txtInput.Text = Nothing
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If OpenWithCmdArgs() Then
            'Arrêt de la console et fermeture
            myConsole.CloseConsole()
            Me.Close()
        Else
            'Arrêt de la console et retour au cp.
            myConsole.CloseConsole()
            CP.Show()
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Empêche la console d'être sélectionné.
    ''' </summary>
    Private Sub myConsole_Enter() Handles myConsole.Enter
        ActiveControl = txtInput
    End Sub

End Class