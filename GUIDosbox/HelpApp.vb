Option Strict On

Public Class HelpApp

    Private Sub HelpApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Démarrage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "help.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.help, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "help.swf")
            flashHeader.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

        'Mode avancé caché
        btnSend.Visible = False
        lblAdvanceMode.Visible = False
        txtAdvanceCommand.Visible = False

    End Sub

    Private Sub btnAide_Click(sender As Object, e As EventArgs) Handles btnAide.Click
        'Affichage de l'aide
        myConsole.Cls()
        myConsole.SendCommand("help")
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        'Envoi de la commande
        myConsole.SendCommand(txtAdvanceCommand.Text)
        txtAdvanceCommand.Text = Nothing
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Arrêt de la console et retour au cp.
        myConsole.CloseConsole()
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnClaer_Click(sender As Object, e As EventArgs) Handles btnClaer.Click
        'Reset de la console
        myConsole.Cls()
    End Sub

    ''' <summary>
    ''' Ce sub empêche la console d'être sélectionné.
    ''' </summary>
    Private Sub myConsole_Enter(sender As Object, e As EventArgs) Handles myConsole.Enter
        ActiveControl = txtAdvanceCommand
    End Sub

    Private Sub optAdvanceMode_CheckedChanged(sender As Object, e As EventArgs) Handles optAdvanceMode.CheckedChanged
        'Gestion pour le mode avancé.
        If optAdvanceMode.Checked = True Then
            btnSend.Visible = True
            lblAdvanceMode.Visible = True
            txtAdvanceCommand.Visible = True
            txtAdvanceCommand.Focus()

        Else
            btnSend.Visible = False
            lblAdvanceMode.Visible = False
            txtAdvanceCommand.Visible = False
        End If
    End Sub

#Region "Language"
    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then ' boite cochée=FR donc, default pour la checkbox est checked
            btnAide.Text = "Aide"
            btnBack.Text = "Retour"
            btnSend.Text = "Envoyer"
            optAdvanceMode.Text = "Mode avancé"
            btnClaer.Text = "Effacer"
        Else                                ' boite PAS cochée=EN 
            btnAide.Text = "Help"
            btnBack.Text = "Back"
            btnSend.Text = "Send"
            optAdvanceMode.Text = "Advance mode"
            btnClaer.Text = "Clear"
        End If
    End Sub
#End Region

    
End Class