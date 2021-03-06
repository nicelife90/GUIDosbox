﻿' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

Option Strict On
Option Explicit On

Public Class CHKDSkApp

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

    Private Sub CHKDSkApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démarrage de la console
        myConsole.StartConsole()

        'Ajout des éléments (lecteurs) au comboBox.
        For Each drive In UsedDrive()
            cbLetter.Items.Add(drive)
        Next

        'Loading du header flash.
        LoadHeader(flashHeader, "chkdsk")

        'Mode avancé caché.
        btnSend.Hide()

        'Définition du niveau de privilèges de l'utilitaire.
        footer.PrivilegeLevelNeeded(1)
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variables et constante
        Const App As String = "chkdsk "
        Dim Arguments As String = Nothing

        'Arguments
        Dim args(8) As String
        For Each arg In args
            arg = Nothing
        Next

        'args(0) --> Lecteur
        args(0) = cbLetter.Text & " "

        'args(1) --> /F
        If optF.Checked Then
            args(1) = "/F "
        End If

        'args(2) --> /V
        If optV.Checked Then
            args(2) = "/V "
        End If

        'args(3) --> /R
        If optR.Checked Then
            args(3) = "/R "
        End If

        'args(4) --> /X
        If optX.Checked Then
            args(4) = "/X "
        End If

        'args(5) --> /I
        If optI.Checked Then
            args(5) = "/I "
        End If

        'args(6) --> /C
        If optC.Checked Then
            args(6) = "/C "
        End If

        'args(7) --> /L:taille
        If optL.Checked Then
            args(7) = "/L:" & optLArg.Text & " "
        End If

        'args(8) --> /B
        If optB.Checked Then
            args(8) = "/B "
        End If

        'Création de la chaine d'arguments
        For Each arg In args
            Arguments += arg
        Next

        'Exécution de la commande
        txtCmdExec.Text = myConsole.SendCommand(App + Arguments)

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide
        txtCmdExec.Text = myConsole.SendCommand("chkdsk /?")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("chkdsk")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des textbox et de la console
        ClearTextBox(Me)
        txtCmdExec.Text = "cls"
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