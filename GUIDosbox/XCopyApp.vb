Option Strict On
Option Explicit On

Public Class XcopyApp

#Region "Mode avancé"
    'Variable pour le mode avancé.
    Private AdvanceMode As Boolean = False

    Private Sub optAdvanceMode_CheckedChanged(sender As Object, e As EventArgs) Handles optAdvanceMode.CheckedChanged
        If optAdvanceMode.Checked = True Then
            AdvanceMode = True
            btnSend.Visible = False
            btnHelp.Visible = False
            btnApply.Visible = False
            btnSend.Visible = True
            txtCmdExec.Enabled = True
            footer.AdvanceMode(AdvanceMode)
        Else
            AdvanceMode = False
            btnSend.Visible = True
            btnHelp.Visible = True
            btnApply.Visible = True
            btnSend.Visible = False
            txtCmdExec.Enabled = False
            footer.AdvanceMode(AdvanceMode)
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        'Envoi de la commande
        myConsole.SendCommand(txtCmdExec.Text)
        txtCmdExec.Text = Nothing
    End Sub
#End Region

    Private Sub xcopyApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démmarage de la console
        myConsole.StartConsole()

        'Loading du header flash.
        LoadHeader(flashHeader, "xcopy")

        'Mode avancé caché
        btnSend.Visible = False

        'Option par défaut
        OptC.Checked = True
        OptE.Checked = True
        OptY.Checked = True

        'Niveau de privilèges requis par l'utilitaire.
        footer.PrivilegeLevelNeeded(1)
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        'Déclaration des variables et constantes.
        Const App As String = "xcopy "
        Dim Arguments As String = Nothing

        'Arguments
        Dim args(19) As String
        For Each arg In args
            arg = Nothing
        Next

        'args(0) --> Source
        args(0) = """" & txtSource.Text & """" & " "

        'args(1) --> Destination
        args(1) = """" & txtDestination.Text & """" & " "

        'args(2) --> /A & /M
        If OptA.Checked Then
            args(2) = "/A "
        ElseIf OptM.Checked Then
            args(2) = "/M "
        End If

        'args(3) --> /D:date
        If OptD.Checked = True Then
            args(3) = "/D:" & txtDate.Text & " "
        End If

        'args(4) --> /Y & /-Y
        If OptY.Checked Then
            args(4) = "/Y "
        ElseIf invOptY.Checked Then
            args(4) = "/-Y "
        End If

        'args(5) --> /S & /E
        If OptS.Checked Then
            args(5) = "/S "
        ElseIf OptE.Checked Then
            args(5) = "/E "
        End If

        'args(6) --> /G
        If OptG.Checked Then
            args(6) = "/G "
        End If

        'args(7) --> /H
        If OptH.Checked Then
            args(7) = "/H "
        End If

        'args(8) --> /I
        If OptI.Checked Then
            args(8) = "/I "
        End If

        'args(9) --> /J
        If OptJ.Checked Then
            args(9) = "/J "
        End If

        'args(10) --> /K
        If OptK.Checked Then
            args(10) = "/K "
        End If

        'args(11) --> /N
        If OptN.Checked Then
            args(11) = "/N "
        End If

        'args(12) --> /O
        If OptO.Checked Then
            args(12) = "/O "
        End If

        'args(13) --> /R
        If OptR.Checked Then
            args(13) = "/R "
        End If

        'args(14) --> /T
        If OptT.Checked Then
            args(14) = "/T "
        End If

        'args(15) --> /U
        If OptU.Checked Then
            args(15) = "/U "
        End If

        'args(16) --> /V
        If OptV.Checked Then
            args(16) = "/V "
        End If

        'args(17) --> /X
        If OptX.Checked Then
            args(17) = "/X "
        End If

        'args(18) --> /C
        If OptC.Checked Then
            args(18) = "/C "
        End If

        'args(19) --> /EXCLUDE:file+file...
        If optExclude.Checked Then
            args(19) = "/EXCLUDE:" & "" & txtExclude.Text & "" & " "
        End If

        'Création de la chaine d'arguments
        For Each arg In args
            Arguments += arg
        Next

        'Envoi de la commande.
        txtCmdExec.Text = myConsole.SendCommand(App + Arguments)
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide
        txtCmdExec.Text = myConsole.SendCommand("xcopy /?")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("xcopy")
        Me.Close()
        CP.Show()
    End Sub

    Private Sub btnFichier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFichier.Click
        'Sélection d'un fichier.
        txtSource.Text = ofd()
    End Sub

    Private Sub btnDossier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDossier.Click
        'Sélection d'un fichier
        txtSource.Text = fbd()
    End Sub

    Private Sub btnDestination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDestination.Click
        'Sélection d'un fichier.
        txtDestination.Text = fbd()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des textbox.
        ClearTextBox(Me)
    End Sub

    ''' <summary>
    ''' Empêche la console d'être sélectionné.
    ''' </summary>
    Private Sub myConsole_Enter() Handles myConsole.Enter
        If AdvanceMode = True Then
            ActiveControl = txtCmdExec
        Else
            ActiveControl = btnSend
        End If
    End Sub

#Region " Gestion de l'interface "
    Private Sub OptM_CheckedChanged(sender As Object, e As EventArgs) Handles OptM.CheckedChanged
        If OptM.Checked Then
            OptA.Checked = False
            OptA.Visible = False
            MyBase.Refresh()
        Else
            OptA.Visible = True
            MyBase.Refresh()
        End If
    End Sub

    Private Sub OptA_CheckedChanged(sender As Object, e As EventArgs) Handles OptA.CheckedChanged
        If OptA.Checked Then
            OptM.Checked = False
            OptM.Visible = False
            MyBase.Refresh()
        Else
            OptM.Visible = True
            MyBase.Refresh()
        End If
    End Sub

    Private Sub invOptY_CheckedChanged(sender As Object, e As EventArgs) Handles invOptY.CheckedChanged
        If invOptY.Checked Then
            OptY.Checked = False
            OptY.Visible = False
            MyBase.Refresh()
        Else
            OptY.Visible = True
            MyBase.Refresh()
        End If
    End Sub

    Private Sub OptY_CheckedChanged(sender As Object, e As EventArgs) Handles OptY.CheckedChanged
        If OptY.Checked Then
            invOptY.Checked = False
            invOptY.Visible = False
            MyBase.Refresh()
        Else
            invOptY.Visible = True
            MyBase.Refresh()
        End If
    End Sub

    Private Sub OptS_CheckedChanged(sender As Object, e As EventArgs) Handles OptS.CheckedChanged
        If OptS.Checked Then
            OptE.Checked = False
            OptE.Visible = False
            MyBase.Refresh()
        Else
            OptE.Visible = True
            MyBase.Refresh()
        End If
    End Sub

    Private Sub OptE_CheckedChanged(sender As Object, e As EventArgs) Handles OptE.CheckedChanged
        If OptE.Checked Then
            OptS.Checked = False
            OptS.Visible = False
            MyBase.Refresh()
        Else
            OptS.Visible = True
            MyBase.Refresh()
        End If
    End Sub
#End Region

#Region "Language"
    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then ' boite cochée=FR donc, default pour la checkbox est checked
            chkbxLangue.Text = "Français"
            lblCmdExec.Text = "Commande éxecutée:"
            gbRecomander.Text = "Recommandés"
            btnSend.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnDestination.Text = "Dossier"
            btnDossier.Text = "Dossier"
            btnFichier.Text = "Fichier"
            btnHelp.Text = "Aide"
        Else                                ' boite PAS cochée=EN 
            chkbxLangue.Text = "English"
            lblCmdExec.Text = "Just executed:"
            gbRecomander.Text = "Recommended"
            btnSend.Text = "Apply"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnDestination.Text = "Folder"
            btnDossier.Text = "Folder"
            btnFichier.Text = "File"
            btnHelp.Text = "Help"
        End If
    End Sub
#End Region

End Class