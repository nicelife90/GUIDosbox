Option Strict On

Public Class CaclsApp

    Private Sub CaclsApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Démmarage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "cacls.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.cacls, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "cacls.swf")
            flashHeader.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

        'Mode avancé caché
        btnEnvoi.Hide()
        ADVCommand.Hide()
        lblLigneCommande.Hide()

    End Sub

    Private Sub Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        Const Apps As String = "CACLS "
        Dim File As String = ""
        Dim Args1 As String = ""
        Dim Args2 As String = ""
        Dim Args3 As String = ""            'Déclaration des variables
        Dim Args4 As String = ""
        Dim Args5 As String = ""
        Dim Args6 As String = ""
        Dim Args7 As String = ""
        Dim Args8 As String = ""
        Dim Args9 As String = ""
        Dim Permission As String = ""
        Dim Permission2 As String = ""

        'Vérification des permission
        If optGLecture.Checked = True Then
            Permission = Permission + "R"
        End If
        If optGEcrire.Checked = True Then
            Permission = Permission + "W"
        End If
        If optGModif.Checked = True Then
            Permission = Permission + "C"
        End If
        If optGControlT.Checked = True Then
            Permission = Permission + "T"
        End If


        'Vérification des permission2
        If optPLecture.Checked = True Then
            Permission2 = Permission2 + "R"
        End If
        If optPEcrire.Checked = True Then
            Permission2 = Permission2 + "W"
        End If
        If optPModif.Checked = True Then
            Permission2 = Permission2 + "C"
        End If
        If optPControlT.Checked = True Then
            Permission2 = Permission2 + "T"
        End If
        If optPAucun.Checked = True Then
            Permission2 = "N"
        End If

        'début des élément if
        'args1 = option /t
        If optT.Checked = True Then
            Args1 = Args1 + " /T "
        Else
            Args1 = ""
        End If
        'args2 = option /m
        If optM.Checked = True Then
            Args2 = Args2 + " M "
        Else
            Args2 = ""
        End If
        'args3 = option /L
        If optL.Checked = True Then
            Args3 = Args3 + " /L "
        Else
            Args3 = ""
        End If
        'args4 = option /E
        If optE.Checked = True Then
            Args4 = Args4 + " /E "
        Else
            Args4 = ""
        End If
        'args5 = option /C
        If optC.Checked = True Then
            Args5 = Args5 + " /C "
        Else
            Args5 = ""
        End If
        'args6 = option /G util:perm
        If optG.Checked = True Then
            Args6 = Args6 + " /G " + _
            txtUserG.Text + ":" + Permission
        Else
            Args6 = ""
        End If
        'args7 = option /R 
        If optR.Checked = True Then
            Args7 = Args7 + " /R " + _
            txtUserR.Text + " "
        Else
            Args7 = ""
        End If

        'args8 = option /P util:author
        If optP.Checked = True Then
            Args8 = Args8 + " /G " + _
            txtUserP.Text + ":" + Permission2
        Else
            Args8 = ""
        End If
        'args9 = option /D utililistaeur
        If optD.Checked = True Then
            Args9 = Args9 + " /D " + txtUserD.Text
        Else
            Args9 = ""
        End If

        'on affecte sa valeur a File
        File = """" & txtFile.Text & """"

        'on envoi ca commande au process
        myConsole.sendCommand(Apps + File + Args1 + Args2 + Args3 + Args4 _
        + Args5 + Args6 + Args7 + Args8 + Args9) 'on n'envoie au commande prompt la commande du textbox


        CommandReturn.Text = Apps + File + Args1 + Args2 + Args3 + Args4 _
        + Args5 + Args6 + Args7 + Args8 + Args9  'renvoie de la commande effectuer au textbox commandReturn


    End Sub

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide
        myConsole.sendCommand("cacls /?")
        ADVCommand.Text = ""
    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Arrêt de la console et retour au cp
        myConsole.CloseConsole("cacls")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        'on efface les textbox du form
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next ctl

        'on efface les textbox dans les gorupe box
        txtFile.Text = ""
        txtUserD.Text = ""
        txtUserG.Text = ""
        txtUserP.Text = ""
        txtUserR.Text = ""

        'Reset de la console
        myConsole.cls()

    End Sub

    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        'Sélection d'un fichier
        OpenFileDialog1.ShowDialog()
        txtFile.Text = OpenFileDialog1.FileName
    End Sub

#Region "Mode avancé"

    Private Sub btnEnvoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvoi.Click
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