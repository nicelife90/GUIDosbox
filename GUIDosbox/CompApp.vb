Option Strict On

Public Class CompApp

    Private Sub CHKDSkApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load '''' contenu du sub
        'Démarrage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "comp.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.comp, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "comp.swf")
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

    Private Sub Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variables et des constantes.
        Const Apps As String = "comp "
        Dim Args1 As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""
        Dim Args4 As String = ""
        Dim Args5 As String = ""
        Dim Args6 As String = ""
        Dim Args7 As String = ""
        Dim Args8 As String = ""

        'Argument 1 Fichier 1
        Args1 = """" & OptFile1.Text & """" & " "

        'Argument 2 Fichier 2
        Args2 = """" & OptFile2.Text & """" & " "

        'Argument 3 /D
        If OptD.Checked = True Then
            Args3 = Args3 + " /D "
        Else
            Args3 = ""
        End If

        'Argument 4 /A
        If OptA.Checked = True Then
            Args4 = Args4 + " /A "
        Else
            Args4 = ""
        End If

        'Argument 5 /L
        If OptL.Checked = True Then
            Args5 = Args5 + " /L "
        Else
            Args5 = ""
        End If

        'Argument 6 /N
        If OptN.Checked = True Then
            Args6 = Args6 + " /N="
        Else
            Args6 = ""
        End If

        'Argument 7 /N:Nombre de ligne
        If OptN.Checked = True Then
            Args7 = Args7 & "" & _
            CStr(OptNArgs.Value) & "" & " "
        Else
            Args7 = ""
        End If

        'Argument 8 /C
        If OptC.Checked = True Then
            Args8 = Args8 + " /C "
        Else
            Args8 = ""
        End If

        'Vérification des champs obligatoire.
        If OptFile1.Text = "" Or OptFile2.Text = "" Then
            myConsole.Message("Vous devez entrer les noms de fichiers à comparer dans les cases du haut.")
        Else
            'Envoi de la commande.
            myConsole.SendCommand(Apps + Args1 + Args2 + Args3 + Args4 _
            + Args5 + Args6 + Args7 + Args8)

            'Répond non à la question de comp
            myConsole.SendReponseNo()

            'Affichage de la commande exécuté.
            txtCmdExec.Text = Apps + Args1 + Args2 + Args3 + Args4 _
            + Args5 + Args6 + Args7 + Args8

        End If

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        myConsole.SendCommand("comp /?")
        txtCmdExec.Text = "comp /?"
        ADVCommand.Text = ""
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("comp")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset de texbox.
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
        'Reset de la console
        myConsole.Cls()
    End Sub

    Private Sub btnFile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile1.Click
        'Sélection du fichier.
        OpenFileDialog1.ShowDialog()
        OptFile1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnFile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile2.Click
        'Sélection du fichier.
        OpenFileDialog2.ShowDialog()
        OptFile2.Text = OpenFileDialog2.FileName
    End Sub

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

        End If
    End Sub
#End Region

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
            txtCmdExec.Show()
        Else
            btnEnvoi.Show()
            ADVCommand.Show()   'on chache les élément du mode normal et on affiche les élément du mode avancer
            lblLigneCommande.Show()
            btnApply.Hide()
            lblCommandeExec.Hide()
            txtCmdExec.Hide()
        End If
    End Sub
#End Region

End Class