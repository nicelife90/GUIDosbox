Option Strict On

Public Class CHKDSkApp

    Private Sub CHKDSkApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démarrage de la console
        myConsole.StartConsole()

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
        btnEnvoi.Hide()
        ADVCommand.Hide()
        lblLigneCommande.Hide()
    End Sub

    Private Sub Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

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
        DLetter.Text & "" & " "

        'Argument 2 /F
        If OptF.Checked = True Then
            Args2 = Args2 + " /F "
        Else
            Args2 = ""
        End If

        'Argument 3 /V
        If OptV.Checked = True Then
            Args3 = Args3 + " /V "
        Else
            Args3 = ""
        End If

        'Argument 4 /R
        If OptR.Checked = True Then
            Args4 = Args4 + " /R "
        Else
            Args4 = ""
        End If

        'Argument 5 /L:taille
        If OptL.Checked = True Then
            Args5 = Args5 + " /L:" & "" & _
            OptLArg.Text & "" & " "
        Else
            Args5 = ""
        End If

        'Argument 6 /X
        If OptX.Checked = True Then
            Args6 = Args6 + " /X "
        Else
            Args6 = ""
        End If

        'Argument 7 /I
        If OptI.Checked = True Then
            Args7 = Args7 + " /I "
        Else
            Args7 = ""
        End If

        'Argument 8 /C
        If OptC.Checked = True Then
            Args8 = Args8 + " /C "
        Else
            Args8 = ""
        End If

        'Argument 9 /B
        If OptB.Checked = True Then
            Args9 = Args9 + " /B "
        Else
            Args9 = ""
        End If

        'Exécution de la commande
        myConsole.sendCommand(Apps + Args1 + Args2 + Args3 + Args4 _
        + Args5 + Args6 + Args7 + Args8 + Args9)

        'Affichage de la commande exécuté.
        CommandReturn.Text = Apps + Args1 + Args2 + Args3 + Args4 _
        + Args5 + Args6 + Args7 + Args8 + Args9

    End Sub

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide
        myConsole.sendCommand("chkdsk /?")
        ADVCommand.Text = ""
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
                ctl.Text = ""
            End If
        Next
        'Reset de la console
        myConsole.cls()
    End Sub

#Region "Mode avancé"

    Private Sub ExecuteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvoi.Click
        'Envoi de la commande
        myConsole.sendCommand(ADVCommand.Text)
        ADVCommand.Text = ""
    End Sub

    Private Sub OptADV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptADV.CheckedChanged
        If OptADV.Checked = False Then
            btnEnvoi.Hide()       'on affiche les élément du mode normal et on cache les élément du mode avancé
            ADVCommand.Hide()
            lblLigneCommande.Hide()
            btnApply.Show()
            lblCommandeExec.Show()
            CommandReturn.Show()
        Else
            btnEnvoi.Show()
            ADVCommand.Show()   'on chache les élément du mode normal et on affiche les élément du mode avancer
            lblLigneCommande.Show()
            btnApply.Hide()
            lblCommandeExec.Hide()
            CommandReturn.Hide()
        End If
    End Sub

#End Region

#Region "Language"
    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then
            chkbxLangue.Text = "Français" ' boite cochée=FR donc, default pour la checkbox est checked
            GBLetter.Text = "Lecteur/Disque"
            GBOptL.Text = "Option /L"
            OptL.Text = "/L:taille"
            lblLigneCommande.Text = "Ligne de commande:"
            lblCommandeExec.Text = "Commande exécutée:"
            OptADV.Text = "Mode Avancé"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnEnvoi.Text = "Envoi"
            btnHelp.Text = "Aide"

        Else                              ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
            GBLetter.Text = "Drive letter"
            GBOptL.Text = "/L Option"
            OptL.Text = "/L:size"
            lblLigneCommande.Text = "Command line:"
            lblCommandeExec.Text = "Just Executed:"
            OptADV.Text = "Advanced Mode"
            btnApply.Text = "Applyr"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnEnvoi.Text = "Send"
            btnHelp.Text = "Help"

        End If
    End Sub
#End Region

End Class