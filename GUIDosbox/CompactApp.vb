Option Strict On

Public Class CompactApp

    Private Sub CompactApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démmarage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "compact.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.compact, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "compact.swf")
            flashHeader.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

        'Valeur par défaut.
        OptI.Checked = True
        OptC.Checked = True
    End Sub

    Private Sub Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variable
        Const Apps As String = "COMPACT "
        Dim Args1 As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""
        Dim Args4 As String = ""
        Dim Args5 As String = ""
        Dim Args6 As String = ""
        Dim Args7 As String = ""
        Dim Args8 As String = ""
        Dim Args9 As String = ""
        Dim Source As String = ""


        'Argument 1 /C  Vs /U
        If OptC.Checked = True Then
            Args1 = Args1 + " /C "
        ElseIf OptU.Checked = True Then
            Args1 = Args1 + " /U "
        End If

        'Argument 2 /S
        If OptS.Checked = True Then
            Args2 = Args2 + " /S:" + """" & AllPath.Text & """"
        Else
            Args2 = ""
        End If

        'Argument 3 /A 
        If OptA.Checked = True Then
            Args3 = Args3 + " /A "
        ElseIf OptA.Checked = False Then
            Args3 = ""
        End If

        'Argument 4 /I
        If OptI.Checked = True Then
            Args4 = Args4 + " /I "
        ElseIf OptI.Checked = False Then
            Args4 = ""
        End If

        'Argument 5 /F
        If OptF.Checked = True Then
            Args5 = Args5 + " /F "
        ElseIf OptF.Checked = False Then
            Args5 = ""
        End If

        'Argument 6 /Q
        If OptQ.Checked = True Then
            Args6 = Args6 + " /Q "
        ElseIf OptQ.Checked = False Then
            Args6 = ""
        End If

        'vérification de la valeur de l'option s et application des modification au variable
        If OptS.Checked = True Then
            Source = Nothing
        Else
            Source = " " & """" & RealPath.Text & """" & " "  'affectation du chemin à la variable source
        End If

        'Exécution de la commande.
        myConsole.sendCommand(Apps + Args1 + Args2 + Args3 + Args4 + Args5 + Args6 + Source)
        'Affichage de la commande exécuté.
        txtCmdExec.Text = Apps + Args1 + Args2 + Args3 + Args4 + Args5 + Args6 + Source 'Retour de la command exécuter vers le textbox

        AllPath.Text = "" 'effacement des chamd de chemin
        RealPath.Text = ""

    End Sub

    Private Sub btnPathDossier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPathDossier.Click
        'Sélection d'un dossier.
        FolderBrowserDialog1.ShowDialog()
        AllPath.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub btnPathFichier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPathFichier.Click
        'Sélection d'un fichier
        OpenFileDialog1.ShowDialog()
        RealPath.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("compact")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        myConsole.sendCommand("compact /?")
        txtCmdExec.Text = "COMPACT /?"
    End Sub

    Private Sub BClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset de textbox.
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
        'Reset de la console
        myConsole.cls()

    End Sub

    Private Sub OptS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptS.CheckedChanged
        'Affichage ou masquage du champ et du bouton fichier si la case /s est cocher
        If OptS.Checked = True Then
            RealPath.Hide()
            btnPathFichier.Hide()
        ElseIf OptS.Checked = False Then
            RealPath.Show()
            btnPathFichier.Show()
        End If
    End Sub

#Region "Language"
    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then
            chkbxLangue.Text = "Français" ' boite cochée=FR donc, default pour la checkbox est checked
            GBDossier.Text = "Dossier"
            OptC.Text = "Compresser /C"
            OptU.Text = "Décompresser /U"
            OptS.Text = "/S Sous-Répertoire"
            lblCommande.Text = "Commande executée:"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnHelp.Text = "Aide"
            btnPathDossier.Text = "Dossier"
            btnPathFichier.Text = "Fichier"

        Else                              'boite PAS cochée=EN
            chkbxLangue.Text = "English"
            GBDossier.Text = "Folder"
            OptC.Text = "Compress /C"
            OptU.Text = "Uncompress /U"
            OptS.Text = "/S Subdirectories"
            lblCommande.Text = "Just executed:"
            btnApply.Text = "Apply"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnHelp.Text = "Help"
            btnPathDossier.Text = "Folder"
            btnPathFichier.Text = "File"

        End If
    End Sub
#End Region
   
End Class