Option Strict On

Public Class TracertApp

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
        btnEnvoi.Hide()
        ADVCommand.Hide()
        lblLigneCommande.Hide()
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variables et constantes.
        Const Apps As String = "tracert "
        Dim Args1 As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""
        Dim Args4 As String = ""
        Dim Args5 As String = ""
        Dim Args6 As String = ""
        Dim Args7 As String = ""
        Dim Args8 As String = ""
        Dim Args9 As String = ""

        'Argument 1 /D
        If OptD.Checked = True Then
            Args1 = Args1 + " /D "
        Else
            Args1 = ""
        End If
        'Argument 2 /J
        If OptJ.Checked = True Then
            Args2 = Args2 + " /j " + " " & """" & txtListeHotes.Text & """" & " "
        Else
            Args2 = ""
        End If
        'Argument 3
        If OptH.Checked = True Then
            Args3 = Args3 + " /h " + CStr(SautsMax.Value) + " "
        Else
            Args3 = ""
        End If
        'Argument 4
        If OptW.Checked = True Then
            Args4 = Args4 + " /w " + CStr(DelaiMS.Value) + " "
        Else
            Args4 = ""
        End If
        'Argument 5
        If Opt4.Checked = True Then
            Args5 = Args5 + " /4 "
        Else
            Args5 = ""
        End If
        'Argument 6
        If Opt6.Checked = True Then
            Args6 = Args6 + " /6 "
        End If
        'Argument 7
        If OptR.Checked = True Then
            Args7 = Args7 + " /r "
        End If
        'Argument 8
        If OptS.Checked = True Then
            Args8 = Args8 + " " & """" & txtSourceIPv6.Text & """" & " "
        End If
        'Argument 9 
        Args9 = txtAddresse.Text

        'Envoi de la commande­.
        myConsole.SendCommand(Apps + Args1 + Args2 + Args3 + Args4 + Args5 + Args6 + Args7 + Args8 + Args9)
        'Affichage de la commande exécué.
        CommandReturn.Text = Apps + Args1 + Args2 + Args3 + Args4 + Args5 + Args6 + Args7 + Args8 + Args9

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        myConsole.SendCommand("tracert /?")
        ADVCommand.Text = ""
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("tracert")
        CP.Show()
        Me.Close()
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


#Region "Mode avancé"
    Private Sub btnEnvoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvoi.Click
        'Envoi de la commande. 
        myConsole.SendCommand(ADVCommand.Text)
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
            lblLigneCommande.Text = "Ligne de commande:"
            lblCommandeExec.Text = "Commande exécutée:"
            OptADV.Text = "Mode Avancé"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnEnvoi.Text = "Envoi"
            btnHelp.Text = "Aide"
            lblAddresse.Text = "Addresse à tracer"
            GBHops.Text = "Sauts Maximum"
            GBTimeout.Text = "Délai"
            GBForce.Text = "Forcer"
            GBHotes.Text = "Liste Hotes"
            OptJ.Text = "/J           Hôtes:"
            OptS.Text = "/S  Addresse:"
        Else                              ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
            lblLigneCommande.Text = "Command line:"
            lblCommandeExec.Text = "Just Executed:"
            OptADV.Text = "Advanced Mode"
            btnApply.Text = "Apply"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnEnvoi.Text = "Send"
            btnHelp.Text = "Help"
            lblAddresse.Text = "Address to be Traced"
            GBHops.Text = "Maximum Hops"
            GBForce.Text = "Force"
            GBHotes.Text = "Host List"
            OptJ.Text = "/J           Hosts:"
            OptS.Text = "/S   Address:"
        End If
    End Sub
#End Region

End Class