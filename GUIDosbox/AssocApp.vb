Option Strict On

Public Class AssocApp


    Private Sub AssocApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Démarrage de la console
        myConsole.StartConsole()

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
        Args1 = "" & ExtentionSet.Text & ""
        'Argument 2 Type de fichier
        Args2 = "" & ExtentionFile.Text & ""


        myConsole.SendCommand("ASSOC " + Args1 + "=" + Args2)  'démmarage du process
        CommandReturn.Text = "ASSOC " & Args1 + "=" + Args2 'Renvoi de la commande exécuter au form Command return



    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Arrêt de la console
        myConsole.CloseConsole("assoc")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        myConsole.Cls()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        myConsole.SendCommand("ASSOC /?")
        CommandReturn.Text = "ASSOC /?"
    End Sub

    Private Sub btnExtShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtShow.Click
        myConsole.SendCommand("ASSOC")
        CommandReturn.Text = "ASSOC"
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