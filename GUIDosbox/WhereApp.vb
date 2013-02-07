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

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "where.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.where, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "where.swf")
            flashHeader.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

        'Options par défaut
        OptR.Checked = True

        'Mode avancé caché.
        btnSend.Hide()
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        If txtModele.Text = "" Then
            MsgBox("Vous devez entrer un modèle valable." & vbCrLf & "Exemple : *.jpg, *.mp3," _
                   & "*.dll, *.exe, *.avi, *.mp4 ou nom de fichier", _
                   MsgBoxStyle.Exclamation, "Important! Modèle manquant.")
        Else

            'Déclaration des variables et constantes.
            Dim apps As String = "where "
            Dim Args1 As String = ""
            Dim Args2 As String = ""
            Dim Args3 As String = ""
            Dim Args4 As String = ""
            Dim Args5 As String = ""

            'Argument 1 +/- R
            If OptR.Checked = True Then
                Args1 = Args1 + "/R" & " " _
                & """" & txtSource.Text _
                & """" & " "
            Else
                Args1 = ""
            End If

            'Argument 2 +/- T
            If OptT.Checked = True Then
                Args2 = Args2 + "/T "
            Else
                Args2 = ""
            End If

            'Argument 3 +/- F
            If OptF.Checked = True Then
                Args3 = Args3 + "/F "
            Else
                Args3 = ""
            End If

            'Argument 4 +/- Q
            If OptQ.Checked = True Then
                Args4 = Args4 + "/Q "
            Else
                Args4 = ""
            End If

            'Argument 5 Modèles
            Args5 = Args5 + """" _
            & txtModele.Text & """"

            'Envoi de la commande.
            myConsole.SendCommand(apps + Args1 + Args2 + Args3 + Args4 + Args5)
            'Affichage de la commande exécuté.
            txtCmdExec.Text = apps + Args1 + Args2 + Args3 + Args4 + Args5
        End If

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Envoi de la commande
        myConsole.SendCommand("where /?")
        txtCmdExec.Text = "where /?"
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
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
    End Sub

    Private Sub OptR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptR.CheckedChanged
        'on cache les élément d'emplacement si l'utilisateur décoche l'option R
        If OptR.Checked = True Then
            btnDossier.Show()
            txtSource.Show()
        Else
            btnDossier.Hide()
            txtSource.Hide()
        End If
    End Sub

    Private Sub OptT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptT.CheckedChanged
        'on bloque l'option /q quand une autre option est choisi
        If OptT.Checked Or OptF.Checked = True Then
            OptQ.Enabled = False
        Else
            OptQ.Enabled = True
        End If
    End Sub

    Private Sub OptF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptF.CheckedChanged
        'on bloque l'option /q quand une autre option est chois
        If OptF.Checked Or OptT.Checked = True Then
            OptQ.Enabled = False
        Else
            OptQ.Enabled = True
        End If
    End Sub

    Private Sub OptQ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptQ.CheckedChanged
        'on affiche ou on masque les message d'avertissement concernat loption /Q
        If OptQ.Checked = True Then
            OptT.Enabled = False
            OptF.Enabled = False
        Else
            OptT.Enabled = True
            OptF.Enabled = True
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