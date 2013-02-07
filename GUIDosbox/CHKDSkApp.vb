Option Strict On

Imports System.IO
Imports System.Collections.ObjectModel

Public Class CHKDSkApp

#Region "Mode avancé"

    'Variable pour le mode avancé.
    Private AdvanceMode As Boolean = False

    Private Sub optAdvanceMode_CheckedChanged(sender As Object, e As EventArgs) Handles optAdvanceMode.CheckedChanged
        If optAdvanceMode.Checked = True Then
            AdvanceMode = True
            btnApply.Visible = False
            btnHelp.Visible = False
            btnSend.Visible = True
            txtCmdExec.Enabled = True
        Else
            AdvanceMode = False
            btnApply.Visible = True
            btnHelp.Visible = True
            btnSend.Visible = False
            txtCmdExec.Enabled = False
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        'Envoi de la commande
        myConsole.SendCommand(txtCmdExec.Text)
        txtCmdExec.Text = Nothing
    End Sub

#End Region

    Private Sub CHKDSkApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démarrage de la console
        myConsole.StartConsole()

        'Ajout des éléments (lecteur) au comboBox.
        Dim drives As ReadOnlyCollection(Of DriveInfo) = My.Computer.FileSystem.Drives
        For Each drive As DriveInfo In drives
            Dim lecteur As String = drive.ToString.Substring(0, drive.ToString.Length - 1)
            cbLetter.Items.Add(lecteur)
        Next

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "chkdsk.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.chkdsk, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "chkdsk.swf")
            flashHeader.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

        'Mode avancé caché.
        btnSend.Hide()


    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variables et constante
        Const Apps As String = "CHKDSK "
        Dim Args1 As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""
        Dim Args4 As String = ""
        Dim Args5 As String = ""
        Dim Args6 As String = ""
        Dim Args7 As String = ""
        Dim Args8 As String = ""
        Dim Args9 As String = ""

        'Argument 1 Lecteur
        Args1 = Args1 & " " & "" & _
        cbLetter.Text & "" & " "

        'Argument 2 /F
        If optF.Checked = True Then
            Args2 = Args2 + " /F "
        Else
            Args2 = ""
        End If

        'Argument 3 /V
        If optV.Checked = True Then
            Args3 = Args3 + " /V "
        Else
            Args3 = ""
        End If

        'Argument 4 /R
        If optR.Checked = True Then
            Args4 = Args4 + " /R "
        Else
            Args4 = ""
        End If

        'Argument 5 /L:taille
        If optL.Checked = True Then
            Args5 = Args5 + " /L:" & "" & _
            optLArg.Text & "" & " "
        Else
            Args5 = ""
        End If

        'Argument 6 /X
        If optX.Checked = True Then
            Args6 = Args6 + " /X "
        Else
            Args6 = ""
        End If

        'Argument 7 /I
        If optI.Checked = True Then
            Args7 = Args7 + " /I "
        Else
            Args7 = ""
        End If

        'Argument 8 /C
        If optC.Checked = True Then
            Args8 = Args8 + " /C "
        Else
            Args8 = ""
        End If

        'Argument 9 /B
        If optB.Checked = True Then
            Args9 = Args9 + " /B "
        Else
            Args9 = ""
        End If

        'Exécution de la commande
        txtCmdExec.Text = myConsole.SendCommand(Apps + Args1 + Args2 + Args3 + Args4 + Args5 + Args6 + Args7 + Args8 + Args9)

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide
        txtCmdExec.Text = myConsole.SendCommand("chkdsk /?")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("chkdsk")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des textbox
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = Nothing
            End If
        Next
        'Reset de la console
        myConsole.Cls()
    End Sub

    ''' <summary>
    ''' Empêche la console d'être sélectionné.
    ''' </summary>
    Private Sub myConsole_Enter() Handles myConsole.Enter
        If AdvanceMode = True Then
            ActiveControl = txtCmdExec
        Else
            ActiveControl = btnApply
        End If
    End Sub

#Region "Language"
    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then
            chkbxLangue.Text = "Français" ' boite cochée=FR donc, default pour la checkbox est checked
            gbLetter.Text = "Lecteur/Disque"
            gbOptL.Text = "Option /L"
            optL.Text = "/L:taille"

            lblCmdExec.Text = "Commande exécutée:"
            optAdvanceMode.Text = "Mode Avancé"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnSend.Text = "Envoi"
            btnHelp.Text = "Aide"

        Else                              ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
            gbLetter.Text = "Drive letter"
            gbOptL.Text = "/L Option"
            optL.Text = "/L:size"

            lblCmdExec.Text = "Just Executed:"
            optAdvanceMode.Text = "Advanced Mode"
            btnApply.Text = "Applyr"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnSend.Text = "Send"
            btnHelp.Text = "Help"

        End If
    End Sub
#End Region

End Class