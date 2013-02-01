Imports System.Text

Public Class XCopyApp

    Public Function ProcessXCopy(ByVal arg As String) 'fonction process start 2 work whit
        Dim XCopyArguments As String = arg
        Dim XCopyProcess As New Process()    'déclaration des variable
        Dim XCopyStartInfo As New ProcessStartInfo()

        XCopyStartInfo.FileName = "CMD.exe "   'fichier à démarrer

        'écrit la sortie des erreur dans le flux (stream)
        XCopyStartInfo.RedirectStandardError = True
        'écrit la sortie standard dans le flux
        XCopyStartInfo.RedirectStandardOutput = True
        'écrit les entrer dans le flux
        XCopyStartInfo.RedirectStandardInput = True
        'ne pas utiliser le shell de windows
        XCopyStartInfo.UseShellExecute = False
        'ne pas faire voir de fenêtre
        XCopyStartInfo.CreateNoWindow = True
        'argument à insérer
        XCopyStartInfo.Arguments = "/D /c XCOPY " + XCopyArguments

        XCopyProcess.EnableRaisingEvents = True
        XCopyProcess.StartInfo = XCopyStartInfo

        'convertie le texte pour un affichage compatible sur windows
        XCopyProcess.StartInfo.StandardOutputEncoding = Encoding.GetEncoding("cp437")
        'début du process cmd.exe & xcope.exe
        XCopyProcess.Start()
        'déclaration de la variable pour le flux de sortie
        Dim XcopySuccessful As String = ""
        'lecture du résultat
        XcopySuccessful = XCopyProcess.StandardOutput.ReadToEnd

        'période de délais avant la fin du processus
        XCopyProcess.WaitForExit(15000)

        'affichage du flux 
        Return XcopySuccessful
    End Function

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        CP.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFichier.Click
        OpenFileDialog1.Title = "Rechercher un fichier"  'attribut du openfiledialoge ex. titre, directory, start
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream                            'fonction openfiledialoge
        strm = OpenFileDialog1.OpenFile()                       'qui permet de voir les fichier et de sélectionner une source
        PathSource.Text = OpenFileDialog1.FileName.ToString()   '**'
        If Not (strm Is Nothing) Then                           '**'
            'insert code to read the file data
            strm.Close()
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDossierSource.Click
        Dim folderDlg As New FolderBrowserDialog    'attribut de la fonction FolderBrowserDialoge
        folderDlg.ShowNewFolderButton = True
        If (folderDlg.ShowDialog() = DialogResult.OK) Then
            PathSource.Text = folderDlg.SelectedPath
            Dim root As Environment.SpecialFolder = folderDlg.RootFolder
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDossierDest.Click
        Dim folderDlg2 As New FolderBrowserDialog    'attribut de la fonction FolderBrowserDialoge
        folderDlg2.ShowNewFolderButton = True
        If (folderDlg2.ShowDialog() = DialogResult.OK) Then
            PathDestination.Text = folderDlg2.SelectedPath
            Dim root As Environment.SpecialFolder = folderDlg2.RootFolder
        End If
    End Sub

    Private Sub Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        Dim Args1 As String = ""
        Dim ArgsD As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""            'Déclaration des variables
        Dim Args4 As String = ""
        Dim Args5 As String = ""
        Dim Args6 As String = ""
        Dim Args7 As String = ""
        Dim Args8 As String = ""
        Dim Args9 As String = ""
        Dim Args10 As String = ""
        Dim Args11 As String = ""
        Dim Args12 As String = ""
        Dim Args13 As String = ""
        Dim Args14 As String = ""
        Dim Args15 As String = ""
        Dim Args16 As String = ""
        Dim source As String = ""
        Dim destination As String = ""

        'Argument 1 /A  Vs /M
        If OptA.Checked = True Then
            Args1 = Args1 + " /a "
        ElseIf OptM.Checked = True Then
            Args1 = Args1 + " /m "
        End If

        'Argument D 
        If OptD.Checked = True Then
            ArgsD = ArgsD + " /D:" + "" _
            & DateSelected.Text & "" & " "
        Else
            ArgsD = " "
        End If

        'Argument 2 /y vs /-y
        If OptY.Checked = True Then
            Args2 = Args2 + " /y "
        ElseIf invOptY.Checked = True Then
            Args2 = Args2 + " /-y "
        End If

        'Argument 3 /s /e
        If OptS.Checked = True Then
            Args3 = Args3 + " /s "
        ElseIf OptE.Checked = True Then
            Args3 = Args3 + " /e "
        End If

        'Argument 4 G
        If OptG.Checked = True Then
            Args4 = Args4 + " /g "
        ElseIf OptG.Checked = False Then
            Args4 = ""
        End If

        'Argument 5 H
        If OptH.Checked = True Then
            Args5 = Args5 + " /h "
        ElseIf OptH.Checked = False Then
            Args5 = ""
        End If

        'Argument 6 I
        If OptI.Checked = True Then
            Args6 = Args6 + " /i "
        ElseIf OptI.Checked = False Then
            Args6 = ""
        End If

        'Argument 7 J
        If OptJ.Checked = True Then
            Args7 = Args7 + " /j "
        ElseIf OptJ.Checked = False Then
            Args7 = ""
        End If

        'Argument 8 K
        If OptK.Checked = True Then
            Args8 = Args8 + " /k "
        ElseIf OptK.Checked = False Then
            Args8 = ""
        End If

        'Argument 9 N
        If OptN.Checked = True Then
            Args9 = Args9 + " /n "
        ElseIf OptN.Checked = False Then
            Args9 = ""
        End If
        'Argument 10 O
        If OptO.Checked = True Then
            Args10 = Args10 + " /o "
        ElseIf OptO.Checked = False Then
            Args10 = ""
        End If

        'Argument 11 R
        If OptR.Checked = True Then
            Args11 = Args11 + " /r "
        ElseIf OptR.Checked = False Then
            Args11 = ""
        End If
        'Argument 12 T
        If OptT.Checked = True Then
            Args12 = Args12 + " /t "
        ElseIf OptT.Checked = False Then
            Args12 = ""
        End If
        'Argument 13 U
        If OptU.Checked = True Then
            Args13 = Args13 + " /u "
        ElseIf OptU.Checked = False Then
            Args13 = ""
        End If
        'Argument 14 V
        If OptV.Checked = True Then
            Args14 = Args14 + " /v "
        ElseIf OptV.Checked = False Then
            Args14 = ""
        End If
        'Argument 15 X
        If OptX.Checked = True Then
            Args15 = Args15 + " /x "
        ElseIf OptX.Checked = False Then
            Args15 = ""
        End If

        'Argument 16 C
        If OptC.Checked = True Then
            Args16 = Args16 + " /c "
        ElseIf OptC.Checked = False Then
            Args16 = ""
        End If


        'source
        source = " " & """" & PathSource.Text & """" 'affectation du path à la variable source
        'destination
        destination = """" & PathDestination.Text & """" ' affectation du path à la variable destination

        TextReturns.Text = ProcessXCopy(source & " " & destination _
                + Args1 + Args2 + Args3 + Args4 + Args5 + Args6 + Args7 + Args8 + Args9 + Args10 _
                + Args11 + Args12 + Args13 + Args14 + Args15 + Args16) 'Lancement de la commande

        CommandReturn.Text = ("xcopy.exe " & source & " " & destination _
                + Args1 + ArgsD + Args2 + Args3 + Args4 + Args5 + Args6 + Args7 + Args8 + Args9 + Args10 _
                + Args11 + Args12 + Args13 + Args14 + Args15 + Args16) 'affichage de la commande éxécuter

        PathDestination.Text = " " 'effacement du champ destination
        PathSource.Text = " "     'effacement du champ source

        Dim l As Integer = 0 'progressbar1
        ProgressBar1.Maximum = 100000
        ProgressBar1.Minimum = 0
        ProgressBar1.Value = 0

        For l = ProgressBar1.Minimum To ProgressBar1.Maximum
            ProgressBar1.Value = l
        Next

    End Sub

    Private Sub xcopyApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OptC.Checked = True
        OptE.Checked = True   'établissement des valeurs recommander
        OptY.Checked = True

    End Sub

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        TextReturns.Text = ProcessXCopy(" /?") 'lancement de la commande pour l'aide
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        'déclaration de la variable ctl
        Dim ctl As Control
        'boucle dans textbox pour effacer les champ
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
    End Sub


    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then ' boite cochée=FR donc, default pour la checkbox est checked
            chkbxLangue.Text = "Français"
            lblResultatCmd.Text = "Résultat de la commande:"
            lblCommande.Text = "Commande éxecutée:"
            GBRecomande.Text = "Recommandés"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnDossierDest.Text = "Dossier"
            btnDossierSource.Text = "Dossier"
            btnFichier.Text = "Fichier"
            btnHelp.Text = "Aide"

        Else                                ' boite PAS cochée=EN 
            chkbxLangue.Text = "English"
            lblResultatCmd.Text = "Command result:"
            lblCommande.Text = "Just executed:"
            GBRecomande.Text = "Recommended"
            btnApply.Text = "Apply"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnDossierDest.Text = "Folder"
            btnDossierSource.Text = "Folder"
            btnFichier.Text = "File"
            btnHelp.Text = "Help"

        End If
    End Sub
End Class