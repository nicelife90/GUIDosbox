Option Strict On

Public Class CMDConsole

    Private Sub CMDConsole_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démmarage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "cmd_console.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.cmd1, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "cmd_console.swf")
            flashHeader.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try



    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        myConsole.SendCommand("cmd /?")
        txtInput.Text = ""
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des textbox.
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
        'Reset de la console.
        myConsole.Cls()
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        'Envoi de la commande.
        myConsole.SendCommand(txtInput.Text)
        txtInput.Text = ""
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

#Region "Language"

    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged

        If chkbxLangue.Checked = True Then
            chkbxLangue.Text = "Français" ' boite cochée=FR donc, default pour la checkbox est checked
            lblCommande.Text = "Ligne de Commande:"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnHelp.Text = "Aide"
            btnSend.Text = "Envoyer"

        Else                              ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
            lblCommande.Text = "Command line:"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnHelp.Text = "Help"
            btnSend.Text = "Send"

        End If

    End Sub

#End Region

   
End Class