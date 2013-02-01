Imports System.Text

Public Class CMDConsole

    Private WithEvents MyProcess As Process
    Private Delegate Sub AppendOutputTextDelegate(ByVal text As String)

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        MyProcess = New Process  'déclaration de myprocess
        With MyProcess.StartInfo  'argument du start info début
            .FileName = "CMD.EXE"  'on start cmd.exe
            .UseShellExecute = False 'on nutilisepas le shell de windows
            .CreateNoWindow = True 'on ne créé pas de nouvelle fenetre pour le process
            .RedirectStandardInput = True 'on redirige dans le flux le standard input
            .RedirectStandardOutput = True 'on redirige dans le flux le standard output
            .RedirectStandardError = True 'on redirige dans le flux le standard error
            .StandardOutputEncoding = Encoding.GetEncoding(437)  'on converti le texte du flux dans un forme correct pour windows 7
        End With

        MyProcess.Start()  'debut du processus

        MyProcess.BeginErrorReadLine() 'debut de la lecture asynchrone sur le flux standard error
        MyProcess.BeginOutputReadLine() 'debut de la lecture asynchrone sur le flux standard output

    End Sub

    Private Sub MyProcess_ErrorDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.ErrorDataReceived
        AppendOutputText(vbCrLf & e.Data)
    End Sub

    Private Sub MyProcess_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.OutputDataReceived
        AppendOutputText(vbCrLf & e.Data)
    End Sub

    Private Sub ExecuteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        MyProcess.CancelErrorRead()  ' on arrete la lecture asynchrone sur le flux standar error
        MyProcess.CancelOutputRead() ' on arrete la lecture asynchrone sur le flux standar output
        MyProcess.Close()     ' on arrete le process
        CP.Show() 'on affiche le control panel 
        Me.Close()  'on ferme cdmconsol
    End Sub

    Private Sub AppendOutputText(ByVal text As String)

        If OutputTextBox.InvokeRequired Then ' on appele la méthode invoke car lappelant ce trouve sur un thread différent du control
            Dim myDelegate As New AppendOutputTextDelegate(AddressOf AppendOutputText)
            Me.Invoke(myDelegate, text)
        Else
            OutputTextBox.AppendText(text)
        End If
    End Sub

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        MyProcess.StandardInput.WriteLine("cmd /?") 'on n'envoie au commande prompt la commande du textbox
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = "" 'on efface le textbox
    End Sub

   
    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then   'on efface l'écran avec le bouton effacer
                ctl.Text = ""
            End If
        Next

    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text) 'on n'envoie au commande prompt la commande du textbox
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = "" 'on efface le textbox
    End Sub

    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then
            chkbxLangue.Text = "Français" ' boite cochée=FR donc, default pour la checkbox est checked
            lblCommande.Text = "Ligne de Commande:"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnHelp.Text = "Aide"
            btnSend.Text = "Envoyer"

        Else                              ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
            lblCommande.Text = "Command line:"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnHelp.Text = "Help"
            btnSend.Text = "Send"

        End If
    End Sub
End Class