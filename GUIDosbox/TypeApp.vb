Imports System.Text


Public Class TypeApp

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

    Private Sub CHKDSkApp_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed   '''' Contenue du sub

        MyProcess.CancelErrorRead() 'on arrête la lecture asynchrone sur le flux standard error
        MyProcess.CancelOutputRead() 'on arrête la lecture asynchrone sur le flux standard output
        MyProcess.Close() 'on arrête le processus

        For Each RunningProcess In Process.GetProcessesByName("cmd")   'on kill toute les process cdm.exe
            RunningProcess.Kill()
        Next
        For Each RunningProcess In Process.GetProcessesByName("type")   'on kill toute les process cdm.exe
            RunningProcess.Kill()
        Next

    End Sub

    Private Sub TypeApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load '''' contenu du sub

        'début de notre shell dans notre form and wait for command
        MyProcess = New Process  'déclaration de myprocess as process
        With MyProcess.StartInfo 'début des argument pour start.info du process myprocess
            .FileName = "cmd.EXE" 'process à exécuter cmd.exe
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

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click

        MyProcess.StandardInput.WriteLine("type /?") 'on envoie au commande prompt les la ligne suivante
        MyProcess.StandardInput.Flush()

    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        CP.Show() 'on affiche le control panel
        Me.Close() 'on cache ferme le form chkdsk
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
    End Sub

    Private Sub Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        Const Apps As String = "TYPE "  'changer le programme a executer

        Dim Args3 As String = ""            'Déclaration des variables
        Args3 = " " & """" & txtPathFichier.Text & """" & " "  'DOUBLAGE GUILMETS


            MyProcess.StandardInput.WriteLine(Apps + Args3) 'on n'envoie au commande prompt la commande du textbox
            MyProcess.StandardInput.Flush()

            CommandReturn.Text = Apps + Args3   'renvoie de la commande effectuer au textbox commandReturn


            'Progress bar 1 qui ce déclenche en meme temp que le process
            Dim i As Integer = 0
            ProgressBar1.Maximum = 100000
            ProgressBar1.Minimum = 0
            ProgressBar1.Value = 0
            For i = ProgressBar1.Minimum To ProgressBar1.Maximum
                ProgressBar1.Value = i
            Next



    End Sub

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFichier.Click
        OpenFileDialog1.Title = "Rechercher un fichier"  'attribut du openfiledialoge ex. titre, directory, start
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        Dim strm As System.IO.Stream                            'fonction openfiledialoge
        strm = OpenFileDialog1.OpenFile()                       'qui permet de voir les fichier et de sélectionner une source
        txtPathFichier.Text = OpenFileDialog1.FileName.ToString()   '**'
        If Not (strm Is Nothing) Then                           '**'
            'insert code to read the file data
            strm.Close()
        End If
    End Sub
End Class