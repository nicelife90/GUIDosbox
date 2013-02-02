Option Strict On

Public Class WhereApp

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
        lblComandLine.Hide()
        txtComandLine.Hide()
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
            txtComandExecuter.Text = apps + Args1 + Args2 + Args3 + Args4 + Args5
        End If

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Envoi de la commande
        myConsole.SendCommand("where /?")
        txtComandExecuter.Text = "where /?"
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

#Region "Mode avancé"
    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        'Envoi de la commande.
        myConsole.SendCommand(txtComandLine.Text)
        txtComandLine.Text = ""
    End Sub

    Private Sub OptAdvance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptAdvance.CheckedChanged
        'on affiche et on masque les élément selon le mode d'utilisation choisi par l'utilisateur (Avancer / Normal)
        If OptAdvance.Checked = True Then
            btnApply.Hide()
            lblComandExecuter.Hide()
            txtComandExecuter.Hide()
            btnSend.Show()
            lblComandLine.Show()
            txtComandLine.Show()
        Else
            btnApply.Show()
            lblComandExecuter.Show()
            txtComandExecuter.Show()
            btnSend.Hide()
            lblComandLine.Hide()
            txtComandLine.Hide()
        End If
    End Sub
#End Region

End Class