Imports System.Text
Public Class WhereApp

    Private WithEvents MyProcess As Process 'déclaration de myprocess     ''''
    Private Delegate Sub AppendOutputTextDelegate(ByVal text As String)   ''''

    Private Sub MyProcess_ErrorDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.ErrorDataReceived '''' Sub
        AppendOutputText(vbCrLf & e.Data)
    End Sub

    Private Sub MyProcess_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.OutputDataReceived '''' Sub
        AppendOutputText(vbCrLf & e.Data)
    End Sub

    Private Sub AppendOutputText(ByVal text As String)  '''' Sub

        If TextReturns.InvokeRequired Then  'on appelle la methode invoke puisque lappelant se trouve sur un thread different du control
            Dim myDelegate As New AppendOutputTextDelegate(AddressOf AppendOutputText)
            Me.Invoke(myDelegate, text)
        Else
            TextReturns.AppendText(text)
        End If

    End Sub

    Private Sub BtnOuvrirdossier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOuvrirdossier.Click
        Dim folderDlg As New FolderBrowserDialog    'attribut de la fonction FolderBrowserDialoge
        folderDlg.ShowNewFolderButton = True
        If (folderDlg.ShowDialog() = DialogResult.OK) Then
            txtSource.Text = folderDlg.SelectedPath
            Dim root As Environment.SpecialFolder = folderDlg.RootFolder
        End If
    End Sub

    Private Sub BtnRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRetour.Click
        Me.Close()    'retour
        CP.Show()
    End Sub

    Private Sub BtnRecherche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRecherche.Click
        If txtModele.Text = "" Then
            MsgBox("Vous devez entrer un modèle valable." & vbCrLf & "Exemple : *.jpg, *.mp3," _
                   & "*.dll, *.exe, *.avi, *.mp4 ou nom de fichier", _
                   MsgBoxStyle.Exclamation, Title:="Important! Modèle manquant.")
        Else

            Dim apps As String = "where "
            Dim Args1 As String = ""
            Dim Args2 As String = ""
            Dim Args3 As String = ""            'Déclaration des variables
            Dim Args4 As String = ""
            Dim Args5 As String = ""


            'Argument 1 +/- R
            If OptR.Checked = True Then
                Args1 = Args1 + "/R" & " " _
                & """" & txtSource.Text _
                & """" & " "
            Else
                Args1 = ""
            End If

            'Argument 2 +/- T
            If OptT.Checked = True Then
                Args2 = Args2 + "/T "
            Else
                Args2 = ""
            End If

            'Argument 3 +/- F
            If OptF.Checked = True Then
                Args3 = Args3 + "/F "
            Else
                Args3 = ""
            End If

            'Argument 4 +/- Q
            If OptQ.Checked = True Then
                Args4 = Args4 + "/Q "
            Else
                Args4 = ""
            End If

            'Argument 5 Modèles
            Args5 = Args5 + """" _
            & txtModele.Text & """"


            MyProcess.StandardInput.WriteLine(apps + Args1 + Args2 + Args3 + Args4 + Args5) 'Lancement de la commande

            txtComandExecuter.Text = apps + Args1 + Args2 + Args3 + Args4 + Args5 ' affichage de la commande éxécuter


            'Progress bar 1 qui ce déclenche en meme temp que le process
            Dim i As Integer = 0
            ProgressBar1.Maximum = 100000
            ProgressBar1.Minimum = 0
            ProgressBar1.Value = 0
            For i = ProgressBar1.Minimum To ProgressBar1.Maximum
                ProgressBar1.Value = i
            Next
        End If
    End Sub

    Private Sub BtnAide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAide.Click

        MyProcess.StandardInput.WriteLine("where /?") 'on envoie au commande prompt les la ligne suivante
        MyProcess.StandardInput.Flush()
        txtComandExecuter.Text = "where /?"

    End Sub

    Private Sub WhereApp_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        MyProcess.CancelErrorRead() 'on arrête la lecture asynchrone sur le flux standard error
        MyProcess.CancelOutputRead() 'on arrête la lecture asynchrone sur le flux standard output
        MyProcess.Close() 'on arrête le processus

        For Each RunningProcess In Process.GetProcessesByName("cmd")   'on kill toute les process cdm.exe
            RunningProcess.Kill()
        Next
        For Each RunningProcess In Process.GetProcessesByName("where")   'on kill toute les process cdm.exe
            RunningProcess.Kill()
        Next

    End Sub

    Private Sub WhereApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'on masque le message concernant /Q
        lblExplication.Hide()
        'on coche l'option / R par défault au démarage
        OptR.Checked = True
        'on chahce les élément du mode avancé
        lblComandLine.Hide()
        txtComandLine.Hide()
        btnSend.Hide()

        'début de notre shell dans notre form and wait for command
        MyProcess = New Process  'déclaration de myprocess as process
        With MyProcess.StartInfo 'début des argument pour start.info du process myprocess
            .FileName = "CMD.EXE" 'process à exécuter cmd.exe
            .UseShellExecute = False 'on n'utilise pas le shell de windows
            .CreateNoWindow = True 'on ne cré pas de fenêtre pour notre command prompt
            .RedirectStandardInput = True 'on redirige le texte d'entrer
            .RedirectStandardOutput = True 'on redirige le texte de sortie
            .RedirectStandardError = True 'on redirige les erreur
            .StandardOutputEncoding = Encoding.GetEncoding("cp437") 'on convertie le texte dans un mode ocmpatible windows 7
        End With 'fin des argument du démarage

        MyProcess.Start() 'on start le process et on attend

        MyProcess.BeginErrorReadLine() 'on start la lecture asynchrone sur le flux system standard error
        MyProcess.BeginOutputReadLine() ' on start la lecture asynchrone sur le flux systeme standard output

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        ' on efface toute les textbox du form avec cette petite boucle
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next

    End Sub

    Private Sub OptAdvance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptAdvance.CheckedChanged

        'on affiche et on masque les élément selon le mode d'utilisation choisi par l'utilisateur (Avancer / Normal)
        If OptAdvance.Checked = True Then
            BtnRecherche.Hide()
            lblComandExecuter.Hide()
            txtComandExecuter.Hide()
            btnSend.Show()
            lblComandLine.Show()
            txtComandLine.Show()
        Else
            BtnRecherche.Show()
            lblComandExecuter.Show()
            txtComandExecuter.Show()
            btnSend.Hide()
            lblComandLine.Hide()
            txtComandLine.Hide()
        End If

    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        'on envoi la commande taper par l'utilisateur dans la boite txtComandLine au Process
        MyProcess.StandardInput.WriteLine(txtComandLine.Text) 'on envoie au commande prompt les la ligne suivante
        MyProcess.StandardInput.Flush()
        txtComandLine.Text = "" 'on efface le textbox

    End Sub

    Private Sub OptR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptR.CheckedChanged

        'on cache les élément d'emplacement si l'utilisateur décoche l'option R
        If OptR.Checked = True Then
            BtnOuvrirdossier.Show()
            txtSource.Show()
        Else
            BtnOuvrirdossier.Hide()
            txtSource.Hide()
        End If

    End Sub

    Private Sub OptT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptT.CheckedChanged
        'on bloque l'option /q quand une autre option est choisi
        If OptT.Checked Or OptF.Checked = True Then
            OptQ.Enabled = False
        Else
            OptQ.Enabled = True
        End If
    End Sub

    Private Sub OptF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptF.CheckedChanged
        'on bloque l'option /q quand une autre option est chois
        If OptF.Checked Or OptT.Checked = True Then
            OptQ.Enabled = False
        Else
            OptQ.Enabled = True
        End If
    End Sub

    Private Sub OptQ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptQ.CheckedChanged
        'on affiche ou on masque les message d'avertissement concernat loption /Q
        If OptQ.Checked = True Then
            lblExplication.Show()
            OptT.Enabled = False
            OptF.Enabled = False
        Else
            lblExplication.Hide()
            OptT.Enabled = True
            OptF.Enabled = True
        End If
    End Sub
End Class