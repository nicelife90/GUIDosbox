Imports System.Text

Public Class AssocApp
    Public Function ProcessAssoc(ByVal arg As String) 'fonction process start 2 work whit
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
        XCopyStartInfo.Arguments = "/D /c ASSOC " + XCopyArguments

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
        TextReturn.Text = ProcessAssoc(" /?")
    End Sub

    Private Sub Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        Dim Args1 As String = "" 'déclaraiton des variable
        Dim Args2 As String = ""

        'Argument 1 .ext Extension
        Args1 = Args1 + "" & ExtentionSet.Text & ""
        'Argument 2 Type de fichier
        Args2 = Args2 + "" & ExtentionFile.Text & ""


        TextReturn.Text = ProcessAssoc(Args1 + "=" + Args2)  'démmarage du process

        CommandReturn.Text = "ASSOC" & Args1 + "=" + Args2 'Renvoi de la commande exécuter au form Command return

        'progress bar 1
        Dim i As Integer = 0
        ProgressBar1.Maximum = 100000
        ProgressBar1.Minimum = 0
        ProgressBar1.Value = 0

        For i = ProgressBar1.Minimum To ProgressBar1.Maximum
            ProgressBar1.Value = i
        Next

    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        CP.Show()
        Me.Close()
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
    End Sub

    Private Sub ExtShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtShow.Click
        TextReturn.Text = ProcessAssoc("")
    End Sub

    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then ' boite cochée=FR donc, default pour la checkbox est checked
            chkbxLangue.Text = "Français"
            lblTypeFichier.Text = "Type de Fichier"
            lblCommande.Text = "Commande"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnExtShow.Text = "Voir les .ext"
            btnHelp.Text = "Aide"
        Else
            chkbxLangue.Text = "English" ' boite PAS cochée=EN 
            lblTypeFichier.Text = "File Type"
            lblCommande.Text = "Command"
            btnApply.Text = "Apply"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnExtShow.Text = "View .ext's"
            btnHelp.Text = "Help"
        End If
    End Sub
End Class