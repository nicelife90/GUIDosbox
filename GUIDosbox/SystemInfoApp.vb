Option Strict On

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
        Dim Args1 As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""
        Dim Args4 As String = ""
        Dim Args5 As String = ""
        Dim Args6 As String = ""
        Dim Args7 As String = ""
        Dim Args8 As String = ""
        Dim Args9 As String = ""

        'Argument 1 /S
        If OptS.Checked = True Then
            Args1 = Args1 + "  " & "" & txtOptS.Text & "" & " "
        Else
            Args1 = ""
        End If

        'Argument 2 /U
        If OptU.Checked = True Then
            Args2 = Args2 + "  " & "" & txtOptU.Text & "" & " "
        Else
            Args2 = ""
        End If

        'Argument 3 /P
        If OptP.Checked = True Then
            Args3 = Args3 + "  " & "" & txtOptP.Text & "" & " "
        Else
            Args3 = ""
        End If

        'Argument 4 /FO
        If OptFO.Checked = True Then
            Args4 = Args4 + "  " & "" & txtOptFO.Text & "" & " "
        Else
            Args4 = ""
        End If

        'Argument 5 /NH
        If OptNH.Checked = True Then
            Args5 = Args5 + "  " & "/NH "
        ElseIf txtOptFO.Text = "LIST" Then
            Args5 = ""
        Else
            Args5 = ""
        End If

        'lancemant du process avec ses args
        myConsole.SendCommand(Apps + Args1 + Args2 + Args3 + Args4 + Args5)

        'Affichage de la commande exécuté.
        txtCmdExec.Text = Apps + Args1 + Args2 + Args3 + Args4 + Args5

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        myConsole.SendCommand("systeminfo /?")
        txtCmdExec.Text = ""
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("systeminfo")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des texbox.
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
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
            lblCommandeExec.Text = "Commande exécutée:"
            optAdvanceMode.Text = "Mode Avancé"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnSend.Text = "Envoi"
            btnHelp.Text = "Aide"

        Else                              ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
            lblCommandeExec.Text = "Just Executed:"
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