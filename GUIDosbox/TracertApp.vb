Option Strict On

Public Class TracertApp

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

    Private Sub TracertApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démmarage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "tracert.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.tracert, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "tracert.swf")
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

        'Déclaration des variables et constantes.
        Const Apps As String = "tracert "
        Dim Arguments As String = Nothing

        'Arguments
        Dim Args(8) As String
        Args(0) = Nothing
        Args(1) = Nothing
        Args(2) = Nothing
        Args(3) = Nothing
        Args(4) = Nothing
        Args(5) = Nothing
        Args(6) = Nothing
        Args(7) = Nothing
        Args(8) = Nothing

        'Argument 0 --> /d
        If optD.Checked Then
            Args(0) = "-d "
        End If

        'Argument 1 --> /h
        If optH.Checked = True Then
            Args(1) = "-h " + CStr(numSautsMax.Value) + " "
        End If

        'Argument 2 --> /j
        If optJ.Checked Then
            Args(2) = "-j " & """" & txtListeHotes.Text & """" & " "
        End If

        'Argument 3 --> /w
        If optW.Checked Then
            Args(3) = "-w " + CStr(numDelaiMS.Value) + " "
        End If

        'Argument 4 --> /R
        If optR.Checked Then
            Args(4) = "-R "
        End If

        'Argument 5 --> /S
        If optS.Checked Then
            Args(5) = "-S " & """" & txtSourceIPv6.Text & """" & " "
        End If

        'Argument 6 --> /4
        If opt4.Checked Then
            Args(6) = "-4 "
        End If

        'Argument 7 --> /6
        If opt6.Checked Then
            Args(7) = "-6 "
        End If

        'Argument 8 --> IP Adress
        Args(8) = txtAdresse.Text

        'Création de la chaine d'argument
        For Each arg In Args
            Arguments += arg
        Next

        'Envoi de la commande­.
        txtCmdExec.Text = myConsole.SendCommand(Apps + Arguments)


    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        txtCmdExec.Text = myConsole.SendCommand("tracert /?")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("tracert")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset de la console
        myConsole.Cls()
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
            ActiveControl = btnApply
        End If
    End Sub

#Region "Language"
    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then
            chkbxLangue.Text = "Français" ' boite cochée=FR donc, default pour la checkbox est checked
            lblCmdExec.Text = "Commande exécutée:"
            optAdvanceMode.Text = "Mode Avancé"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnSend.Text = "Envoi"
            btnHelp.Text = "Aide"
            gbHops.Text = "Sauts Maximum"
            gbTimeout.Text = "Délai"
            gbForce.Text = "Forcer"
            gbHotes.Text = "Liste Hotes"
            optJ.Text = "/J           Hôtes:"
            optS.Text = "/S  Addresse:"
        Else                              ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
            lblCmdExec.Text = "Just Executed:"
            optAdvanceMode.Text = "Advanced Mode"
            btnApply.Text = "Apply"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnSend.Text = "Send"
            btnHelp.Text = "Help"
            gbHops.Text = "Maximum Hops"
            gbForce.Text = "Force"
            gbHotes.Text = "Host List"
            optJ.Text = "/J           Hosts:"
            optS.Text = "/S   Address:"
        End If
    End Sub
#End Region

    
    Private Sub myConsole_Enter(sender As Object, e As EventArgs) Handles myConsole.Enter

    End Sub
End Class