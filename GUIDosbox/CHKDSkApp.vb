﻿Imports System.Text


Public Class CHKDSkApp

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
        For Each RunningProcess In Process.GetProcessesByName("chkdsk")   'on kill toute les process cdm.exe
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

        MyProcess.StandardInput.WriteLine("chkdsk /?") 'on envoie au commande prompt les la ligne suivante
        MyProcess.StandardInput.Flush()
        ADVCommand.Text = "" ' on efface le textbox ADVCommand.text

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
        Const Apps As String = "CHKDSK "
        Dim Args1 As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""            'Déclaration des variables
        Dim Args4 As String = ""
        Dim Args5 As String = ""
        Dim Args6 As String = ""
        Dim Args7 As String = ""
        Dim Args8 As String = ""
        Dim Args9 As String = ""

        'Argument 1 Lecteur

        Args1 = Args1 & " " & "" & _
        DLetter.Text & "" & " "

        'Argument 2 /F
        If OptF.Checked = True Then
            Args2 = Args2 + " /F "
        Else
            Args2 = ""
        End If

        'Argument 3 /V
        If OptV.Checked = True Then
            Args3 = Args3 + " /V "
        Else
            Args3 = ""
        End If

        'Argument 4 /R
        If OptR.Checked = True Then
            Args4 = Args4 + " /R "
        Else
            Args4 = ""
        End If

        'Argument 5 /L:taille
        If OptL.Checked = True Then
            Args5 = Args5 + " /L:" & "" & _
            OptLArg.Text & "" & " "
        Else
            Args5 = ""
        End If

        'Argument 6 /X
        If OptX.Checked = True Then
            Args6 = Args6 + " /X "
        Else
            Args6 = ""
        End If

        'Argument 7 /I
        If OptI.Checked = True Then
            Args7 = Args7 + " /I "
        Else
            Args7 = ""
        End If

        'Argument 8 /C
        If OptC.Checked = True Then
            Args8 = Args8 + " /C "
        Else
            Args8 = ""
        End If

        'Argument 9 /B
        If OptB.Checked = True Then
            Args9 = Args9 + " /B "
        Else
            Args9 = ""
        End If

        MyProcess.StandardInput.WriteLine(Apps + Args1 + Args2 + Args3 + Args4 _
        + Args5 + Args6 + Args7 + Args8 + Args9) 'on n'envoie au commande prompt la commande du textbox
        MyProcess.StandardInput.Flush()

        CommandReturn.Text = Apps + Args1 + Args2 + Args3 + Args4 _
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
            GBLetter.Text = "Lecteur/Disque"
            GBOptL.Text = "Option /L"
            OptL.Text = "/L:taille"
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
            GBLetter.Text = "Drive letter"
            GBOptL.Text = "/L Option"
            OptL.Text = "/L:size"
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
End Class