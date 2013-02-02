Imports System.Text


Public Class CaclsApp

    Private WithEvents MyProcess As Process 'déclaration de myprocess     ''''
    Private Delegate Sub AppendOutputTextDelegate(ByVal text As String)   ''''


    Private Sub MyProcess_ErrorDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.ErrorDataReceived '''' Sub
        AppendOutputText(vbCrLf & e.Data)
    End Sub

    Private Sub MyProcess_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.OutputDataReceived '''' Sub
        AppendOutputText(vbCrLf & e.Data)
    End Sub

    Private Sub ExecuteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvoi.Click
        'action qui ce produise lors du click 
        MyProcess.StandardInput.WriteLine(ADVCommand.Text) 'on n'envoie au commande prompt la commande du textbox ADVCommand.Text
        MyProcess.StandardInput.Flush()
        ADVCommand.Text = "" 'on efface le textbox

    End Sub

    Private Sub AppendOutputText(ByVal text As String)  '''' Sub

        If TextReturns.InvokeRequired Then  'on appelle la methode invoke puisque lappelant se trouve sur un thread different du control
            Dim myDelegate As New AppendOutputTextDelegate(AddressOf AppendOutputText)
            Me.Invoke(myDelegate, text)
        Else
            TextReturns.AppendText(text)
        End If

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

    Private Sub CHKDSkApp_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed   '''' Contenue du sub

        MyProcess.CancelErrorRead() 'on arrête la lecture asynchrone sur le flux standard error
        MyProcess.CancelOutputRead() 'on arrête la lecture asynchrone sur le flux standard output
        MyProcess.Close() 'on arrête le processus

        For Each RunningProcess In Process.GetProcessesByName("cmd")   'on kill toute les process cdm.exe
            RunningProcess.Kill()
        Next
        For Each RunningProcess In Process.GetProcessesByName("cacls")   'on kill toute les process cdm.exe
            RunningProcess.Kill()
        Next

    End Sub

    Private Sub CHKDSkApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load '''' contenu du sub
        btnEnvoi.Hide()
        ADVCommand.Hide()  'on cache les element du mode avancer au demarrage
        lblLigneCommande.Hide()

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

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click

        MyProcess.StandardInput.WriteLine("cacls /?") 'on envoie au commande prompt les la ligne suivante
        MyProcess.StandardInput.Flush()
        ADVCommand.Text = "" ' on efface le textbox ADVCommand.text

    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        CP.Show() 'on affiche le control panel
        Me.Close() 'on cache ferme le form chkdsk
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'on efface les textbox du form
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next ctl

        'on efface les textbox dans les gorupe box
        txtFile.Text = ""
        txtUserD.Text = ""
        txtUserG.Text = ""
        txtUserP.Text = ""
        txtUserR.Text = ""

    End Sub

    Private Sub Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        Const Apps As String = "CACLS "
        Dim File As String = ""
        Dim Args1 As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""            'Déclaration des variables
        Dim Args4 As String = ""
        Dim Args5 As String = ""
        Dim Args6 As String = ""
        Dim Args7 As String = ""
        Dim Args8 As String = ""
        Dim Args9 As String = ""
        Dim Permission As String = ""
        Dim Permission2 As String = ""

        'Vérification des permission
        If optGLecture.Checked = True Then
            Permission = Permission + "R"
        End If
        If optGEcrire.Checked = True Then
            Permission = Permission + "W"
        End If
        If optGModif.Checked = True Then
            Permission = Permission + "C"
        End If
        If optGControlT.Checked = True Then
            Permission = Permission + "T"
        End If


        'Vérification des permission2
        If optPLecture.Checked = True Then
            Permission2 = Permission2 + "R"
        End If
        If optPEcrire.Checked = True Then
            Permission2 = Permission2 + "W"
        End If
        If optPModif.Checked = True Then
            Permission2 = Permission2 + "C"
        End If
        If optPControlT.Checked = True Then
            Permission2 = Permission2 + "T"
        End If
        If optPAucun.Checked = True Then
            Permission2 = "N"
        End If

        'début des élément if
        'args1 = option /t
        If optT.Checked = True Then
            Args1 = Args1 + " /T "
        Else
            Args1 = ""
        End If
        'args2 = option /m
        If optM.Checked = True Then
            Args2 = Args2 + " M "
        Else
            Args2 = ""
        End If
        'args3 = option /L
        If optL.Checked = True Then
            Args3 = Args3 + " /L "
        Else
            Args3 = ""
        End If
        'args4 = option /E
        If optE.Checked = True Then
            Args4 = Args4 + " /E "
        Else
            Args4 = ""
        End If
        'args5 = option /C
        If optC.Checked = True Then
            Args5 = Args5 + " /C "
        Else
            Args5 = ""
        End If
        'args6 = option /G util:perm
        If optG.Checked = True Then
            Args6 = Args6 + " /G " + _
            txtUserG.Text + ":" + Permission
        Else
            Args6 = ""
        End If
        'args7 = option /R 
        If optR.Checked = True Then
            Args7 = Args7 + " /R " + _
            txtUserR.Text + " "
        Else
            Args7 = ""
        End If

        'args8 = option /P util:author
        If optP.Checked = True Then
            Args8 = Args8 + " /G " + _
            txtUserP.Text + ":" + Permission2
        Else
            Args8 = ""
        End If
        'args9 = option /D utililistaeur
        If optD.Checked = True Then
            Args9 = Args9 + " /D " + txtUserD.Text
        Else
            Args9 = ""
        End If

        'on affecte sa valeur a File
        File = """" & txtFile.Text & """"

        'on envoi ca commande au process
        MyProcess.StandardInput.WriteLine(Apps + File + Args1 + Args2 + Args3 + Args4 _
        + Args5 + Args6 + Args7 + Args8 + Args9) 'on n'envoie au commande prompt la commande du textbox
        MyProcess.StandardInput.Flush()

        CommandReturn.Text = Apps + File + Args1 + Args2 + Args3 + Args4 _
        + Args5 + Args6 + Args7 + Args8 + Args9  'renvoie de la commande effectuer au textbox commandReturn


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

    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        'on ouvre et on capture le chemin dun fichier vaec open file dialog1
        OpenFileDialog1.Title = "Sélectionner le fichier"
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        txtFile.Text = OpenFileDialog1.FileName
    End Sub
End Class