Option Strict On

Public Class CompactApp

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

    Private Sub CompactApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démmarage de la console.
        myConsole.StartConsole()

        'Mode avancé caché.
        btnSend.Visible = False

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
        optI.Checked = True
        optC.Checked = True
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

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
        If optC.Checked = True Then
            Args1 = Args1 + " /C "
        ElseIf optU.Checked = True Then
            Args1 = Args1 + " /U "
        End If

        'Argument 2 /S
        If optS.Checked = True Then
            Args2 = Args2 + " /S:" + """" & txtAllPath.Text & """"
        Else
            Args2 = ""
        End If

        'Argument 3 /A 
        If optA.Checked = True Then
            Args3 = Args3 + " /A "
        ElseIf optA.Checked = False Then
            Args3 = ""
        End If

        'Argument 4 /I
        If optI.Checked = True Then
            Args4 = Args4 + " /I "
        ElseIf optI.Checked = False Then
            Args4 = ""
        End If

        'Argument 5 /F
        If optF.Checked = True Then
            Args5 = Args5 + " /F "
        ElseIf optF.Checked = False Then
            Args5 = ""
        End If

        'Argument 6 /Q
        If optQ.Checked = True Then
            Args6 = Args6 + " /Q "
        ElseIf optQ.Checked = False Then
            Args6 = ""
        End If

        'vérification de la valeur de l'option s et application des modification au variable
        If optS.Checked = True Then
            Source = Nothing
        Else
            Source = " " & """" & txtRealPath.Text & """" & " "  'affectation du chemin à la variable source
        End If

        'Exécution de la commande.
        txtCmdExec.Text = myConsole.SendCommand(Apps + Args1 + Args2 + Args3 + Args4 + Args5 + Args6 + Source)

        'Reset des chemins
        txtAllPath.Text = ""
        txtRealPath.Text = ""

    End Sub

    Private Sub btnDossier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDossier.Click
        'Sélection d'un dossier.
        FolderBrowserDialog1.ShowDialog()
        txtAllPath.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub btnFichier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFichier.Click
        'Sélection d'un fichier
        OpenFileDialog1.FileName = Nothing
        OpenFileDialog1.ShowDialog()
        txtRealPath.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("compact")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        txtCmdExec.Text = myConsole.SendCommand("compact /?")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset de textbox.
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = Nothing
            End If
        Next

        txtAllPath.Text = Nothing

        'Reset de la console
        myConsole.Cls()

    End Sub

    Private Sub optS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optS.CheckedChanged
        'Affichage ou masquage du champ et du bouton fichier si la case /s est cocher
        If optS.Checked = True Then
            txtRealPath.Hide()
            btnFichier.Hide()
        ElseIf optS.Checked = False Then
            txtRealPath.Show()
            btnFichier.Show()
        End If
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
            gbDossier.Text = "Dossier"
            optC.Text = "Compresser /C"
            optU.Text = "Décompresser /U"
            optS.Text = "/S Sous-Répertoire"
            lblCmdExec.Text = "Commande executée:"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnHelp.Text = "Aide"
            btnDossier.Text = "Dossier"
            btnFichier.Text = "Fichier"

        Else                              'boite PAS cochée=EN
            chkbxLangue.Text = "English"
            gbDossier.Text = "Folder"
            optC.Text = "Compress /C"
            optU.Text = "Uncompress /U"
            optS.Text = "/S Subdirectories"
            lblCmdExec.Text = "Just executed:"
            btnApply.Text = "Apply"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnHelp.Text = "Help"
            btnDossier.Text = "Folder"
            btnFichier.Text = "File"

        End If
    End Sub
#End Region

End Class