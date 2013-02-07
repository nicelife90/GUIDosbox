Option Strict On

Public Class RDApp

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

    Private Sub RDApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démarrage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "rd.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.rd, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "rd.swf")
            flashHeader.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

        'Mode avancé caché.
        btnSend.Hide()

        'Option par défaut.
        optQ.Checked = True

    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des constantes et variables.
        Const Apps As String = "RD "
        Dim Args1 As String = Nothing
        Dim Args2 As String = Nothing
        Dim Args3 As String = Nothing

        'Argument 1 /S 
        If optS.Checked = True Then
            Args1 = "/S "
        End If

        'Argument 2 /Q
        If optQ.Checked = True Then
            Args2 = "/Q "
        End If

        'Argument 3 Path
        Args3 = """" & txtPath.Text & """"

        'Exécution de la commande.
        txtCmdExec.Text = myConsole.SendCommand(Apps + Args1 + Args2 + Args3)

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        txtCmdExec.Text = myConsole.SendCommand("rd /?")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("rd")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset de la console
        myConsole.Cls()

        'Reset des textbox.
        txtPath.Text = Nothing
    End Sub

    Private Sub btnDossier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDossier.Click
        'Sélection du dossier.
        FolderBrowserDialog1.ShowDialog()
        txtPath.Text = FolderBrowserDialog1.SelectedPath
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
            btnDossier.Text = "Dossier"


        Else                              ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
            lblCmdExec.Text = "Just Executed:"
            optAdvanceMode.Text = "Advanced Mode"
            btnApply.Text = "Applyr"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnSend.Text = "Send"
            btnHelp.Text = "Help"
            btnDossier.Text = "Folder"

        End If
    End Sub
#End Region

End Class