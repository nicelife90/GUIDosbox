﻿Option Strict On

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
        Else
            AdvanceMode = False
            btnApply.Visible = True
            btnHelp.Visible = True
            btnSend.Visible = False
            txtCmdExec.Enabled = False
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        'Envoi de la commande
        myConsole.SendCommand(txtCmdExec.Text)
        txtCmdExec.Text = Nothing
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
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "system_info.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.system_info, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "system_info")
            flashHeader.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

        'Mode avancé caché.
        btnSend.Hide()

    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variables et constantes.
        Const Apps As String = "systeminfo "
        Dim Arguments As String = Nothing

        'Arguments
        Dim Args(5) As String
        Args(0) = Nothing
        Args(1) = Nothing
        Args(2) = Nothing
        Args(3) = Nothing
        Args(4) = Nothing
        Args(5) = Nothing

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
        'Reset de la console
        myConsole.Cls()
        'Reset des textbox
        txtCmdExec.Text = Nothing
        txtOptP.Text = Nothing
        txtOptS.Text = Nothing
        txtOptU.Text = Nothing
        cbOptFO.Text = Nothing
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

#Region "Language"
    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then
            chkbxLangue.Text = "Français" ' boite cochée=FR donc, default pour la checkbox est checked
            lblCmdExec.Text = "Commande exécutée:"
            optAdvanceMode.Text = "Mode Avancé"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnSend.Text = "Envoi"
            btnHelp.Text = "Aide"

        Else                              ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
            lblCmdExec.Text = "Just Executed:"
            optAdvanceMode.Text = "Advanced Mode"
            btnApply.Text = "Applyr"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnSend.Text = "Send"
            btnHelp.Text = "Help"

        End If
    End Sub
#End Region

End Class