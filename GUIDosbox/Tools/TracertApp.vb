' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

Option Strict On
Option Explicit On

Public Class TracertApp

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

    Private Sub btnSend_Click(sender As Object, e As EventArgs)Handles btnSend.Click
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

    Private Sub TracertApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démmarage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        LoadHeader(flashHeader, "tracert")

        'Mode avancé caché.
        btnSend.Hide()

        'Définition du niveau de privilèges requis par l'utililitaire
        footer.PrivilegeLevelNeeded(-1)

    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variables et constantes.
        Const Apps As String = "tracert "
        Dim Arguments As String = Nothing

        'Arguments
        Dim Args(8) As String
        For Each Arg In Args
            Arg = Nothing
        Next

        'Argument 0 --> /d
        If optD.Checked Then
            Args(0) = "-d "
        End If

        'Argument 1 --> /h
        If optH.Checked = True Then
            Args(1) = "-h " + CStr(numSautsMax.Value) + " "
        End If

        'Argument 2 --> /j
        If optJ.Checked Then
            Args(2) = "-j " & """" & txtListeHotes.Text & """" & " "
        End If

        'Argument 3 --> /w
        If optW.Checked Then
            Args(3) = "-w " + CStr(numDelaiMS.Value) + " "
        End If

        'Argument 4 --> /R
        If optR.Checked Then
            Args(4) = "-R "
        End If

        'Argument 5 --> /S
        If optS.Checked Then
            Args(5) = "-S " & """" & txtSourceIPv6.Text & """" & " "
        End If

        'Argument 6 --> /4
        If opt4.Checked Then
            Args(6) = "-4 "
        End If

        'Argument 7 --> /6
        If opt6.Checked Then
            Args(7) = "-6 "
        End If

        'Argument 8 --> IP Adress
        Args(8) = txtAdresse.Text

        'Création de la chaine d'argument
        For Each arg In Args
            Arguments += arg
        Next

        'Envoi de la commande­.
        txtCmdExec.Text = myConsole.SendCommand(Apps + Arguments)


    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        txtCmdExec.Text = myConsole.SendCommand("tracert /?")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("tracert")
        CP.Show()
        Me.Close()
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

End Class