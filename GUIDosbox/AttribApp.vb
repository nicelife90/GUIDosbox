Imports System.Text

Public Class AttribApp

    Public Function StartProcess(ByVal filename As String, ByVal arguments As String) As String
        TextResults.Text = ""
        Dim info As ProcessStartInfo = New ProcessStartInfo() 'processinfo
        info.FileName = filename 'nom du prog DOS "console" a executer .exe ou .com
        info.Arguments = arguments 'liste des arguments necessaire a l'execution
        info.UseShellExecute = False ' si le shell du système d'exploitation doit être utilisé pour démarrer le processus
        info.RedirectStandardOutput = True 'valeur qui indique si la sortie d'une application est écrite dans le flux 
        info.CreateNoWindow = True 'sans fenetre visible
        Dim output As String = String.Empty
        Try
            Dim p As Process = Process.Start(info) 'execution
            p.StartInfo.StandardOutputEncoding = Encoding.GetEncoding("cp437") 'Pour convertir les caracterre de la fenetre dos
            p.Start()
            output = p.StandardOutput.ReadToEnd() 'lecture du resultat complet
            p.WaitForExit()
            p.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return output 'retour du text visible sur la console
    End Function

    Private Sub Files_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiles.Click

        OpenFileDialog1.Title = "Rechercher un fichier"  'attribut du openfiledialoge ex. titre, directory, start
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.FileName() = ""
        OpenFileDialog1.ShowDialog()
        PathReturn.Text = OpenFileDialog1.FileName()

     

    End Sub

    Private Sub Folders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFolders.Click

        Dim folderDlg As New FolderBrowserDialog    'attribut de la fonction FolderBrowserDialoge
        folderDlg.ShowNewFolderButton = True
        If (folderDlg.ShowDialog() = DialogResult.OK) Then
            PathReturn.Text = folderDlg.SelectedPath
            Dim root As Environment.SpecialFolder = folderDlg.RootFolder
        End If

    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()    'retour
        CP.Show()
    End Sub

    Private Sub Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        Dim Args1 As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""            'Déclaration des variables
        Dim Args4 As String = ""
        Dim Args5 As String = ""
        Dim Args6 As String = ""
        Dim Args7 As String = ""
        Dim Args8 As String = ""
        Dim Args9 As String = ""

        'Argument 1 +/- R
        If RPlus.Checked = True Then
            Args1 = Args1 + " +R"
        ElseIf RMoin.Checked = True Then
            Args1 = Args1 + " -R"
        End If
        'Argument 2 +/- A
        If Aplus.Checked = True Then
            Args2 = Args2 + " +A "
        ElseIf AMoin.Checked = True Then
            Args2 = Args2 + " -A "
        End If
        'Argument 3 +/- S
        If SPlus.Checked = True Then
            Args3 = Args3 + " +S "
        ElseIf SMoin.Checked = True Then
            Args3 = Args3 + " -S "
        End If
        'Argument 4 +/- H
        If HPlus.Checked = True Then
            Args4 = Args4 + " +H "
        ElseIf HMoin.Checked = True Then
            Args4 = Args4 + " -H "
        End If
        'Argument 5 +/- I
        If IPlus.Checked = True Then
            Args5 = Args5 + " +I "
        ElseIf IMoin.Checked = True Then
            Args5 = Args5 + " -I "
        End If
        'Argument 7 /S
        If OptS.Checked = True Then
            Args7 = Args7 + " /S "
        ElseIf OptS.Checked = False Then
            Args7 = ""
        End If
        'Argument 8 /D
        If OptD.Checked = True Then
            Args8 = Args8 + " /D "
        ElseIf OptD.Checked = False Then
            Args8 = ""
        End If
        'Argument 9 /L
        If OptL.Checked = True Then
            Args9 = Args9 + " /L "
        ElseIf OptL.Checked = False Then
            Args9 = ""
        End If

        'Argument 6
        Args6 = """" & PathReturn.Text & """" 'affectation du path à la variable Args6

        StartProcess("attrib.exe ", Args1 + Args2 + Args3 + Args4 _
    + Args5 + Args6 + Args7 + Args8 + Args9) 'Lancement de la commande

        TextResults.Text = "attrib.exe" + Args1 + Args2 _
            + Args3 + Args4 + Args5 + Args6 _
           + Args7 + Args8 + Args9 ' affichage de la commande éxécuter

        'progress bar
        Dim l As Integer = 0
        ProgressBar1.Maximum = 100000
        ProgressBar1.Minimum = 0
        ProgressBar1.Value = 0

        For l = ProgressBar1.Minimum To ProgressBar1.Maximum
            ProgressBar1.Value = l
        Next

    End Sub

    Private Sub Aide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAide.Click

        Dim args As String = ""
        args = args + " attrib"    'Bouton de la fonction aide
        TextResults.Text = StartProcess("help", args)
    End Sub

    Private Sub AttribApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Null.Checked = True
        Null1.Checked = True
        Null2.Checked = True    'Application de la valeur par défault du programme
        Null3.Checked = True    'Défault = Null pour toute les option
        Null4.Checked = True
    End Sub

    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then ' boite cochée=FR donc, default pour la checkbox est checked
            chkbxLangue.Text = "Français"
            lblDescription2.Text = "Vous devez choisir les attributs içi. Pour en connaitre la description vous pouvez cliquer sur le bouton aide plus bas."
            lblDescription1.Text = "Ces options peuvent prendres plus de temps sur certains ordinateur. Soyez patient, même si la fenêtre ne semble plus bouger. (J'usqua 30 sec)."
            lblPath.Text = "Pour quel fichier ou dossier souhaitez-vous modiffier les attributs : "
            TextResults.Text = "Bienvenue!" + Environment.NewLine + "Vous pouvez en tous temp appuyer sur la touche aide plus bas pour connaitre l'effet des options" + Environment.NewLine + "disponible plus haut."
            btnAide.Text = "Aide"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnFiles.Text = "Fichier"
            btnFolders.Text = "Dossier"

        Else                               ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
            lblDescription2.Text = "You ay select attributes here. To get a description for each you may click on the help button below."
            lblDescription1.Text = "Theese option can take more time on certain computers. Please be patient, even if the window seem to not be moving. (Up to 30 sec)."
            lblPath.Text = "For which file or folder did you wish to modify attributes :"
            TextResults.Text = "Welcome !" + Environment.NewLine + "You may at all times press the help button to obtain a list of the options" + Environment.NewLine + "And all of their effects."
            btnAide.Text = "Help"
            btnApply.Text = "Apply"
            btnBack.Text = "Back"
            btnFiles.Text = "File"
            btnFolders.Text = "Folder"

        End If
    End Sub
End Class