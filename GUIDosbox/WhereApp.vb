Option Strict On

Public Class WhereApp

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

    Private Sub WhereApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démmarage de la console.
        myConsole.StartConsole()

        'Chargement du Flash Movie (Header)
        LoadHeader(flashHeader, "where")

        'Options par défaut
        OptR.Checked = True

        'Mode avancé caché.
        btnSend.Hide()
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        If txtModele.Text = Nothing Then
            myConsole.Message("Vous devez entrer un modèle valable." & vbCrLf & "Exemple : *.jpg, *.mp3," _
                   & "*.dll, *.exe, *.avi, *.mp4 ou nom de fichier")
        Else

            'Déclaration des variables et constantes.
            Const apps As String = "where "
            Dim Arguments As String = Nothing

            'Arguments
            Dim Args(4) As String
            Args(0) = Nothing
            Args(1) = Nothing
            Args(2) = Nothing
            Args(3) = Nothing
            Args(4) = Nothing

            'Argument 1 --> /Q
            If OptQ.Checked Then
                Args(1) = "/Q "
            End If

            'Argument 2 --> /F
            If optF.Checked Then
                Args(2) = "/F "
            End If

            'Argument 3 --> /T
            If OptT.Checked Then
                Args(3) = "/T "
            End If

            'Argument 4 --> Modèles
            Args(4) = txtModele.Text

            'Argument 0 --> /R (Args(0) dois être affecter en dernier mais dois tous de meme être args(0))
            If OptR.Checked And txtSource.Text <> Nothing Then
                Args(0) = "/R " & """" & txtSource.Text & """" & " "
            ElseIf OptR.Checked Then
                Args(0) = "/R "
            Else
                If txtSource.Text <> Nothing Then
                    Args(0) = """" & txtSource.Text & """" & ":" & txtModele.Text
                    Args(4) = Nothing
                Else
                    Args(0) = Nothing
                End If
            End If

            'Création de la chaine d'arguments
            For Each arg In Args
                Arguments += arg
            Next

            'Envoi de la commande.
            txtCmdExec.Text = myConsole.SendCommand(apps + Arguments)
            
        End If

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Envoi de la commande
        txtCmdExec.Text = myConsole.SendCommand("where /?")
    End Sub

    Private Sub btnDossier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDossier.Click
        'Sélection d'un dossier.
        FolderBrowserDialog1.ShowDialog()
        txtSource.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("where")
        Me.Close()
        CP.Show()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des textbox.
        ClearTextBox(Me)
    End Sub

    Private Sub OptT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptT.CheckedChanged
        'on bloque l'option /q quand une autre option est choisi
        If OptT.Checked Or optF.Checked = True Then
            OptQ.Enabled = False
        Else
            OptQ.Enabled = True
        End If
    End Sub

    Private Sub OptF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optF.CheckedChanged
        'on bloque l'option /q quand une autre option est chois
        If optF.Checked Or OptT.Checked = True Then
            OptQ.Enabled = False
        Else
            OptQ.Enabled = True
        End If
    End Sub

    Private Sub OptQ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptQ.CheckedChanged
        'on affiche ou on masque les message d'avertissement concernat loption /Q
        If OptQ.Checked = True Then
            OptT.Enabled = False
            optF.Enabled = False
        Else
            OptT.Enabled = True
            optF.Enabled = True
        End If
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

End Class