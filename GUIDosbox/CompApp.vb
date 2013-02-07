Option Strict On

Public Class CompApp

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

    Private Sub CompApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démarrage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "comp.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.comp, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "comp.swf")
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

        'Déclaration des variables et des constantes.
        Const Apps As String = "comp "
        Dim Args1 As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""
        Dim Args4 As String = ""
        Dim Args5 As String = ""
        Dim Args6 As String = ""
        Dim Args7 As String = ""
        Dim Args8 As String = ""

        'Argument 1 Fichier 1
        Args1 = """" & txtFile1.Text & """" & " "

        'Argument 2 Fichier 2
        Args2 = """" & txtFile2.Text & """" & " "

        'Argument 3 /D
        If optD.Checked = True Then
            Args3 = Args3 + " /D "
        Else
            Args3 = ""
        End If

        'Argument 4 /A
        If optA.Checked = True Then
            Args4 = Args4 + " /A "
        Else
            Args4 = ""
        End If

        'Argument 5 /L
        If optL.Checked = True Then
            Args5 = Args5 + " /L "
        Else
            Args5 = ""
        End If

        'Argument 6 /N
        If optN.Checked = True Then
            Args6 = Args6 + " /N="
        Else
            Args6 = ""
        End If

        'Argument 7 /N:Nombre de ligne
        If optN.Checked = True Then
            Args7 = Args7 & "" & _
            CStr(optNArgs.Value) & "" & " "
        Else
            Args7 = ""
        End If

        'Argument 8 /C
        If optC.Checked = True Then
            Args8 = Args8 + " /C "
        Else
            Args8 = ""
        End If

        'Vérification des champs obligatoire.
        If txtFile1.Text = "" Or txtFile2.Text = "" Then
            myConsole.Message("Vous devez entrer les noms de fichiers à comparer dans les cases du haut.")
        Else
            'Envoi de la commande.
            txtCmdExec.Text = myConsole.SendCommand(Apps + Args1 + Args2 + Args3 + Args4 + Args5 + Args6 + Args7 + Args8)

            'Répond non à la question de comp
            myConsole.SendReponseNo()

        End If

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        txtCmdExec.Text = myConsole.SendCommand("comp /?")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("comp")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset de texbox.
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = Nothing
            End If
        Next

        txtFile1.Text = Nothing
        txtFile2.Text = Nothing

        'Reset de la console
        myConsole.Cls()
    End Sub

    Private Sub btnFile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile1.Click
        'Sélection du fichier.
        OpenFileDialog1.FileName = Nothing
        OpenFileDialog1.ShowDialog()
        txtFile1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnFile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile2.Click
        'Sélection du fichier.
        OpenFileDialog2.FileName = Nothing
        OpenFileDialog2.ShowDialog()
        txtFile2.Text = OpenFileDialog2.FileName
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

        Else                              ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
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

    Private Sub myConsole_Enter(sender As Object, e As EventArgs) Handles myConsole.Enter

    End Sub
End Class