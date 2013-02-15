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

   
    Private Sub myConsole_Enter(sender As Object, e As EventArgs) Handles myConsole.Enter

    End Sub
End Class