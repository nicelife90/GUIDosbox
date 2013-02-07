Option Strict On

Public Class AttribApp

#Region "Mode avancé"

    'Variable pour le mode avancé.
    Private AdvanceMode As Boolean = False

    Private Sub optAdvanceMode_CheckedChanged(sender As Object, e As EventArgs) Handles optAdvanceMode.CheckedChanged
        If optAdvanceMode.Checked = True Then
            AdvanceMode = True
            btnApply.Visible = False
            btnAide.Visible = False
            btnSend.Visible = True
            txtCmdExec.Enabled = True
        Else
            AdvanceMode = False
            btnApply.Visible = True
            btnAide.Visible = True
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

    Private Sub AttribApp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Démarrage de la console
        myConsole.StartConsole()

        'Mode avancé caché
        btnSend.Visible = False

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "attrib.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.attrib, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "attrib.swf")
            flashHeader.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

        'Valeur par défaut
        optRNull.Checked = True
        optANull.Checked = True
        optSNull.Checked = True
        optHNull.Checked = True
        optINull.Checked = True

    End Sub


    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variables
        Dim Args1 As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""
        Dim Args4 As String = ""
        Dim Args5 As String = ""
        Dim Args6 As String = ""
        Dim Args7 As String = ""
        Dim Args8 As String = ""
        Dim Args9 As String = ""

        'Argument 1 +/- R
        If optRPlus.Checked = True Then
            Args1 = Args1 + " +R"
        ElseIf optRMoin.Checked = True Then
            Args1 = Args1 + " -R"
        End If
        'Argument 2 +/- A
        If optAplus.Checked = True Then
            Args2 = Args2 + " +A "
        ElseIf optAMoin.Checked = True Then
            Args2 = Args2 + " -A "
        End If
        'Argument 3 +/- S
        If optSPlus.Checked = True Then
            Args3 = Args3 + " +S "
        ElseIf optSMoin.Checked = True Then
            Args3 = Args3 + " -S "
        End If
        'Argument 4 +/- H
        If optHPlus.Checked = True Then
            Args4 = Args4 + " +H "
        ElseIf optHMoin.Checked = True Then
            Args4 = Args4 + " -H "
        End If
        'Argument 5 +/- I
        If optIPlus.Checked = True Then
            Args5 = Args5 + " +I "
        ElseIf optIMoin.Checked = True Then
            Args5 = Args5 + " -I "
        End If
        'Argument 7 /S
        If optS.Checked = True Then
            Args7 = Args7 + " /S "
        ElseIf optS.Checked = False Then
            Args7 = ""
        End If
        'Argument 8 /D
        If optD.Checked = True Then
            Args8 = Args8 + " /D "
        ElseIf optD.Checked = False Then
            Args8 = ""
        End If
        'Argument 9 /L
        If optL.Checked = True Then
            Args9 = Args9 + " /L "
        ElseIf optL.Checked = False Then
            Args9 = ""
        End If

        'Argument 6
        Args6 = """" & txtFile.Text & """"


        'Exécution de la commande.
        txtCmdExec.Text = myConsole.SendCommand("attrib " + Args1 + Args2 + Args3 + Args4 + Args5 + Args6 + Args7 + Args8 + Args9)

    End Sub

    Private Sub btnAide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAide.Click
        'Affichage de l'aide
        txtCmdExec.Text = myConsole.SendCommand("attrib /?")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset des textbox
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = Nothing
            End If
        Next
        'Reset de la console
        myConsole.Cls()
        txtCmdExec.Text = "cls"
    End Sub

    Private Sub btnFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiles.Click
        'Sélection d'un fichier
        OpenFileDialog1.FileName = Nothing
        OpenFileDialog1.ShowDialog()
        txtFile.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnFolders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFolders.Click
        'Sélection d'un dossier
        FolderBrowserDialog1.ShowDialog()
        txtFile.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Arrêt de la console.
        myConsole.CloseConsole("attrib")
        CP.Show()
        Me.Close()
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
            btnAide.Text = "Aide"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnFiles.Text = "Fichier"
            btnFolders.Text = "Dossier"

        Else                               ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
            btnAide.Text = "Help"
            btnApply.Text = "Apply"
            btnBack.Text = "Back"
            btnFiles.Text = "File"
            btnFolders.Text = "Folder"

        End If
    End Sub
#End Region

End Class