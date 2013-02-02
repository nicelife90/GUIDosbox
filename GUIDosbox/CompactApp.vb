Imports System.Text

Public Class CompactApp

    Public Function ProcessCompact(ByVal arg As String) 'fonction process start 2 work whit
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
        XCopyStartInfo.Arguments = "/D /c COMPACT " + XCopyArguments

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

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        TextReturn.Text = ProcessCompact(" /?")
    End Sub

    Private Sub CompactApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OptI.Checked = True 'application des valeur par défaut
        OptC.Checked = True
    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        CP.Show() 'ouverture du control panel 
        Me.Close() 'fermeture du form
    End Sub

    Private Sub BClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'effacement des champ textbox (Bouton Clear)
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
    End Sub


    Private Sub Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        Dim Args1 As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""              'Déclaration des variable
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


        TextReturn.Text = ProcessCompact(Args1 + Args2 + Args3 + Args4 + Args5 + Args6 + Source) 'début du process

        CommandReturn.Text = "Compact " + Args1 + Args2 + Args3 + Args4 + Args5 + Args6 + Source 'Retour de la command exécuter vers le textbox

        AllPath.Text = "" 'effacement des chamd de chemin
        RealPath.Text = ""

        'Progressbar1
        Dim i As Integer = 0
        ProgressBar1.Maximum = 100000
        ProgressBar1.Minimum = 0
        ProgressBar1.Value = 0

        For i = ProgressBar1.Minimum To ProgressBar1.Maximum
            ProgressBar1.Value = i
        Next

    End Sub

    Private Sub DPathButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPathDossier.Click
        Dim folderDlg2 As New FolderBrowserDialog    'attribut de la fonction FolderBrowserDialoge
        folderDlg2.ShowNewFolderButton = True
        If (folderDlg2.ShowDialog() = DialogResult.OK) Then
            AllPath.Text = folderDlg2.SelectedPath
            Dim root As Environment.SpecialFolder = folderDlg2.RootFolder
        End If
    End Sub

    Private Sub Bfichier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPathFichier.Click
        OpenFileDialog1.Title = "Rechercher un fichier"  'attribut du openfiledialoge ex. titre, directory, start
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream                            'fonction openfiledialoge
        strm = OpenFileDialog1.OpenFile()                       'qui permet de voir les fichier et de sélectionner une source
        RealPath.Text = OpenFileDialog1.FileName.ToString()   '**'
        If Not (strm Is Nothing) Then                           '**'
            'insert code to read the file data
            strm.Close()
        End If
    End Sub

    Private Sub OptS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptS.CheckedChanged
        If OptS.Checked = True Then
            RealPath.Hide()
        ElseIf OptS.Checked = False Then   'on masque le champ fichier si la case /s est cocher
            RealPath.Show()
        End If

        If OptS.Checked = True Then
            btnPathFichier.Hide()
        ElseIf OptS.Checked = False Then  'on masque le bouton fichier si la case /s est cocher
            btnPathFichier.Show()
        End If

        If OptS.Checked = True Then

        End If
    End Sub

    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then
            chkbxLangue.Text = "Français" ' boite cochée=FR donc, default pour la checkbox est checked
            GBDossier.Text = "Dossier"
            OptC.Text = "Compresser /C"
            OptU.Text = "Décompresser /U"
            OptS.Text = "/S Sous-Répertoire"
            lblResultat.Text = "Résultat de la commande:"
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
            lblResultat.Text = "Command result:"
            lblCommande.Text = "Just executed:"
            btnApply.Text = "Apply"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnHelp.Text = "Help"
            btnPathDossier.Text = "Folder"
            btnPathFichier.Text = "File"

        End If
    End Sub
End Class