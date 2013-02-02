Option Strict On

Public Class XCopyApp

    Private Sub xcopyApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démmarage de la console
        myConsole.StartConsole()

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "xcopy.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.xcopy, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "xcopy.swf")
            flashHeader.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

        'Option par défaut
        OptC.Checked = True
        OptE.Checked = True
        OptY.Checked = True
    End Sub
   
    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variables et constantes.
        Const App As String = "XCOPY "
        Dim Args1 As String = ""
        Dim ArgsD As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""
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
        source = " " & """" & PathSource.Text & """"
        'destination
        destination = """" & PathDestination.Text & """"

        'Envoi de la commande.
        myConsole.SendCommand(App + source & " " & destination + Args1 + Args2 + Args3 + Args4 + Args5 + Args6 + Args7 + Args8 + Args9 + Args10 _
                + Args11 + Args12 + Args13 + Args14 + Args15 + Args16)

        'Affichage de la commande exécuté.
        CommandReturn.Text = ("xcopy.exe " & source & " " & destination _
                + Args1 + ArgsD + Args2 + Args3 + Args4 + Args5 + Args6 + Args7 + Args8 + Args9 + Args10 _
                + Args11 + Args12 + Args13 + Args14 + Args15 + Args16) 'affichage de la commande éxécuter

        'Reset des champs textes.
        PathDestination.Text = Nothing
        PathSource.Text = Nothing



    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide
        myConsole.SendCommand("xcopy /?")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("xcopy")
        Me.Close()
        CP.Show()
    End Sub

    Private Sub btnFichier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFichier.Click
        'Sélection d'un fichier.
        OpenFileDialog1.ShowDialog()
        PathSource.Text = OpenFileDialog1.FileName.ToString()
    End Sub

    Private Sub btnDossierSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDossierSource.Click
        'Sélection d'un fichier
        FolderBrowserDialog1.ShowDialog()
        PathSource.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub btnDossierDest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDossierDest.Click
        'Sélection d'un fichier.
        FolderBrowserDialog2.ShowDialog()
        PathDestination.Text = FolderBrowserDialog2.SelectedPath
    End Sub

    Private Sub btnClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des textbox.
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
    End Sub

#Region "Language"
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
#End Region
    
End Class