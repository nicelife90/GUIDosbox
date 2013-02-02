Option Strict On

Public Class SUBSTApp

    Private Sub SUBSTApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démmarage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "subst.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.subst, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "subst.swf")
            flashHeader.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

        'Mode avancé caché.
        btnEnvoi.Hide()
        ADVCommand.Hide()
        lblLigneCommande.Hide()
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variables et constantes.
        Const Apps As String = "subst "
        Dim Args1 As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""
        Dim Args4 As String = ""
        Dim Args5 As String = ""

        'Argument 1 Lecteur
        If Not txtLecteur.Text = "" Then
            Args1 = Args1 & " " & "" & txtLecteur.Text & "" & ":\" & "" & txtDossier.Text & "" & " "
        Else
            Args1 = ""
        End If

        'Argument 2 /F
        If OptSUBST.Checked = True Then
            Args1 = ""
            Args2 = Args2 + ""
            Args3 = ""
            Args4 = ""
            Args5 = ""
        End If

        'Argument 3 /V
        If Not txtDelete.Text = "" Then
            Args3 = Args3 & " " & "/d " & "" & txtDelete.Text & "" & ":\"
        Else
            Args3 = ""
        End If

        'Envoi de la commande.
        myConsole.SendCommand(Apps + Args1 + Args2 + Args3)
        'Affichage de la commande exécuté.
        CommandReturn.Text = Apps + Args1 + Args2 + Args3

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        myConsole.SendCommand("subst /?")
        ADVCommand.Text = ""
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("SUBST")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des texbox
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
    End Sub

    Private Sub btnDossier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDossier.Click
        'Sélectionner de dossier.
        FolderBrowserDialog1.ShowDialog()
        txtDossier.Text = FolderBrowserDialog1.SelectedPath
    End Sub

#Region "Mode avancé"
    Private Sub btnEnvoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvoi.Click
        'Envoi de la commande  
        myConsole.SendCommand(ADVCommand.Text)
        ADVCommand.Text = ""
    End Sub

    Private Sub OptADV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptADV.CheckedChanged
        If OptADV.Checked = False Then
            btnEnvoi.Hide()       'on affiche les élément du mode normal et on cache les élément du mode avancé
            ADVCommand.Hide()
            lblLigneCommande.Hide()
            btnApply.Show()
            lblCommandeExec.Show()
            CommandReturn.Show()
        Else
            btnEnvoi.Show()
            ADVCommand.Show()   'on chache les élément du mode normal et on affiche les élément du mode avancer
            lblLigneCommande.Show()
            btnApply.Hide()
            lblCommandeExec.Hide()
            CommandReturn.Hide()
        End If
    End Sub
#End Region

#Region "Language"
    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then
            chkbxLangue.Text = "Français" ' boite cochée=FR donc, default pour la checkbox est checked
            lblLigneCommande.Text = "Ligne de commande:"
            lblCommandeExec.Text = "Commande exécutée:"
            OptADV.Text = "Mode Avancé"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnEnvoi.Text = "Envoi"
            btnHelp.Text = "Aide"
            GBCreer.Text = "Créer"
            GBSupprimmer.Text = "Supprimer"
            BtnDossier.Text = "Dossier"
            OptSUBST.Text = "Lister Seulement"

        Else                              ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
            lblLigneCommande.Text = "Command line:"
            lblCommandeExec.Text = "Just Executed:"
            OptADV.Text = "Advanced Mode"
            btnApply.Text = "Applyr"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnEnvoi.Text = "Send"
            btnHelp.Text = "Help"
            GBCreer.Text = "Create"
            GBSupprimmer.Text = "Delete"
            BtnDossier.Text = "Folder"
            OptSUBST.Text = "Lister Only"

        End If
    End Sub
#End Region
    
End Class

