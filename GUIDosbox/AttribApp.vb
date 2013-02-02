Option Strict On

Public Class AttribApp

    Private Sub AttribApp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Démarrage de la console
        myConsole.StartConsole()

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
        Null.Checked = True
        Null1.Checked = True
        Null2.Checked = True
        Null3.Checked = True
        Null4.Checked = True

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
        Args6 = """" & PathReturn.Text & """"


        'Exécution de la commande.
        myConsole.sendCommand("attrib " + Args1 + Args2 + Args3 + Args4 + Args5 + Args6 + Args7 + Args8 + Args9)
        'Affichage de la commande exécuté.
        txtCmdExec.Text = "attrib " + Args1 + Args2 + Args3 + Args4 + Args5 + Args6 + Args7 + Args8 + Args9

    End Sub

    Private Sub btnAide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAide.Click
        'Affichage de l'aide
        myConsole.sendCommand("attrib /?")
        txtCmdExec.Text = "attrib /?"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset de la console
        myConsole.cls()
        txtCmdExec.Text = "cls"
    End Sub

    Private Sub btnFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiles.Click
        'Sélection d'un fichier
        OpenFileDialog1.ShowDialog()
        PathReturn.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnFolders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFolders.Click
        'Sélection d'un dossier
        FolderBrowserDialog1.ShowDialog()
        PathReturn.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Arrêt de la console.
        myConsole.CloseConsole("attrib")
        CP.Show()
        Me.Close()
    End Sub

#Region "Language"
    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then ' boite cochée=FR donc, default pour la checkbox est checked
            chkbxLangue.Text = "Français"
            lblDescription2.Text = "Vous devez choisir les attributs içi. Pour en connaitre la description vous pouvez cliquer sur le bouton aide plus bas."
            lblDescription1.Text = "Ces options peuvent prendres plus de temps sur certains ordinateur. Soyez patient, même si la fenêtre ne semble plus bouger. (J'usqua 30 sec)."
            lblPath.Text = "Pour quel fichier ou dossier souhaitez-vous modiffier les attributs : "
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
            btnAide.Text = "Help"
            btnApply.Text = "Apply"
            btnBack.Text = "Back"
            btnFiles.Text = "File"
            btnFolders.Text = "Folder"

        End If
    End Sub
#End Region




End Class