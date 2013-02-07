Option Strict On

Public Class TypeApp

#Region "Mode avancé"

    'Variable pour le mode avancé.
    Private AdvanceMode As Boolean = False

    Private Sub optAdvanceMode_CheckedChanged(sender As Object, e As EventArgs) Handles OptAdvanceMode.CheckedChanged
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

    Private Sub TypeApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démarrage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "type.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.type, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "type.swf")
            flashHeader.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variables et constantes.
        Const Apps As String = "TYPE "
        Dim Args3 As String = ""

        Args3 = " " & """" & txtPathFichier.Text & """" & " "

        'Envoi de la commande.
        myConsole.SendCommand(Apps + Args3)
        'Affichage de la commande exécuté.
        txtCmdExec.Text = Apps + Args3

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide
        myConsole.SendCommand("type /?")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("type")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des textbox.
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
    End Sub

    Private Sub btnFichier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFichier.Click
        'Sélection d'un fichier.
        OpenFileDialog1.ShowDialog()
        txtPathFichier.Text = OpenFileDialog1.FileName.ToString()
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
            btnApply.Text = "Lire"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnHelp.Text = "Aide"

        Else                              ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
            lblCommandeExec.Text = "Just Executed:"
            btnApply.Text = "Read"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnHelp.Text = "Help"

        End If
    End Sub
#End Region

End Class