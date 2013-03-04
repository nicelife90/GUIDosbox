' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

Option Strict On
Option Explicit On

Public Class SystemInfoApp

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

    Private Sub SystemInfoApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démmarage de la console
        myConsole.StartConsole()

        'Ajout des éléments au ComboBox.
        cbOptFO.Items.Add("TABLE")
        cbOptFO.Items.Add("LIST")
        cbOptFO.Items.Add("CSV")

        'Loading du header flash.
        LoadHeader(flashHeader, "system_info")

        'Mode avancé caché.
        btnSend.Hide()

        'Définition du niveau de privilèges requis par l'utilitaire
        footer.PrivilegeLevelNeeded(-1)

    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variables et constantes.
        Const Apps As String = "systeminfo "
        Dim Arguments As String = Nothing

        'Arguments
        Dim Args(4) As String
        For Each arg In Args
            arg = Nothing
        Next

        'Argument 0 --> /S
        If optS.Checked Then
            Args(0) = "/S " & txtOptS.Text & " "
        End If

        'Argument 1 --> /U
        If optU.Checked Then
            Args(1) = "/U " & txtOptU.Text & " "
        End If

        'Argument 2 --> /P
        If optP.Checked Then
            Args(2) = "/P " & txtOptP.Text & " "
        End If

        'Argument 3 --> /FO
        If optFO.Checked Then
            Args(3) = "/FO " & cbOptFO.Text & " "
        End If

        'Argument 4 --> /NH
        If optNH.Checked And cbOptFO.Text <> "LIST" Then
            Args(4) = "/NH "
        End If

        'Création de la chaine d'argument
        For Each arg In Args
            Arguments += arg
        Next

        'lancemant du process avec ses arguments
        txtCmdExec.Text = myConsole.SendCommand(Apps + Arguments)

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        txtCmdExec.Text = myConsole.SendCommand("systeminfo /?")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("systeminfo")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset de la console et des textbox
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

End Class