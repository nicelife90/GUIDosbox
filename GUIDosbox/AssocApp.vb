Option Strict On

Public Class AssocApp

#Region "Mode avancé"
    'Variable pour le mode avancé.
    Private AdvanceMode As Boolean = False
    Private Sub OptAdvanceMode_CheckedChanged(sender As Object, e As EventArgs) Handles OptAdvanceMode.CheckedChanged
        If OptAdvanceMode.Checked = True Then
            AdvanceMode = True
            btnExtShow.Visible = False
            btnApply.Visible = False
            btnHelp.Visible = False
            btnSend.Visible = True
            txtCmdExec.Enabled = True
        Else
            AdvanceMode = False
            btnExtShow.Visible = True
            btnApply.Visible = True
            btnHelp.Visible = True
            btnSend.Visible = False
            txtCmdExec.Enabled = False
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        'Envoi de la commande
        myConsole.SendCommand(txtCmdExec.Text)
    End Sub

#End Region
   
    Private Sub AssocApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Démarrage de la console
        myConsole.StartConsole()

        'Mode avancé caché.
        btnSend.Visible = False

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "assoc.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.assoc, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "assoc.swf")
            flashHeader.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

    End Sub


    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        Dim Args1 As String = "" 'déclaraiton des variable
        Dim Args2 As String = ""

        'Argument 1 .ext Extension
        Args1 = "" & txtExtSet.Text & ""
        'Argument 2 Type de fichier
        Args2 = "" & txtExtFile.Text & ""


        myConsole.SendCommand("assoc " + Args1 + "=" + Args2)  'démmarage du process
        txtCmdExec.Text = "assoc " & Args1 + "=" + Args2 'Renvoi de la commande exécuter au form Command return

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Arrêt de la console
        myConsole.CloseConsole("assoc")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des textbox
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = Nothing
            End If
        Next
        'Reset de la console.
        myConsole.Cls()
        txtCmdExec.Text = "cls"
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        myConsole.SendCommand("assoc /?")
        txtCmdExec.Text = "assoc /?"
    End Sub

    Private Sub btnExtShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtShow.Click
        'Affichage des extentioms.
        myConsole.SendCommand("assoc")
        txtCmdExec.Text = "assoc"
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
        If chkbxLangue.Checked = True Then ' boite cochée=FR donc, default pour la checkbox est checked
            chkbxLangue.Text = "Français"
            lblTypeFichier.Text = "Type de Fichier"
            lblCommande.Text = "Commande"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnExtShow.Text = "Voir les .ext"
            btnHelp.Text = "Aide"
        Else
            chkbxLangue.Text = "English" ' boite PAS cochée=EN 
            lblTypeFichier.Text = "File Type"
            lblCommande.Text = "Command"
            btnApply.Text = "Apply"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnExtShow.Text = "View .ext's"
            btnHelp.Text = "Help"
        End If
    End Sub
#End Region

   
   
End Class