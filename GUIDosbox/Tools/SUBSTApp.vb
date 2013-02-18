Option Strict On
Option Explicit On

Public Class SUBSTApp

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
            footer.AdvanceMode(AdvanceMode)
        Else
            AdvanceMode = False
            btnApply.Visible = True
            btnHelp.Visible = True
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

    Private Sub SUBSTApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démmarage de la console.
        myConsole.StartConsole()

        'Ajout des élément au combobox.
        FillComboBox()

        'Loading du header flash.
        LoadHeader(flashHeader, "subst")

        'Mode avancé caché.
        btnSend.Hide()

        'Définition des privilèges requis
        footer.PrivilegeLevelNeeded(2)

    End Sub

    Private Sub FillComboBox()
        'Pause
        System.Threading.Thread.Sleep(100)

        'On ajoute les élément (lecteur disponible) au combobox --> GUIDosboxCustomFunction
        cbLecteur.Items.Clear()
        For Each lecteur In AvailableDrive()
            cbLecteur.Items.Add(lecteur.ToUpper & ":")
        Next

        'Ajout des éléments (lecteur utiliser) au comboBox.
        cbDelete.Items.Clear()
        For Each drive In UsedDrive()
            cbDelete.Items.Add(drive)
        Next

    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variable et constante
        Const Apps As String = "subst "
        Dim Arguments As String = Nothing

        'Arguments.
        Dim Args(2) As String
        For Each arg In Args
            arg = Nothing
        Next

        'Argument 0 --> Drive
        If Not cbLecteur.Text = Nothing Then
            Args(0) = cbLecteur.Text & " "
        End If

        'Argument 1 --> Drive
        If Not txtDossier.Text = Nothing Then
            Args(1) = """" & txtDossier.Text & """" & " "
        End If

        'Argument 2 --> /D
        If optD.Checked Then
            If Not cbDelete.Text = Nothing Then
                For i As Integer = 0 To 2
                    Args(i) = Nothing
                Next
                Args(2) = cbDelete.Text & " /D"
            End If
        End If

        'Argument --> Lister Seulement
        If optLister.Checked Then
            For i As Integer = 0 To 2
                Args(i) = Nothing
            Next
        End If

        'Création de la chaine d'argument
        For Each arg In Args
            Arguments += arg
        Next

        'Envoi de la commande.
        txtCmdExec.Text = myConsole.SendCommand(Apps + Arguments)
        'Mise à jour des ComboBox.
        FillComboBox()

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        txtCmdExec.Text = myConsole.SendCommand("subst /?")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Fermeture de la console et retour au cp.
        myConsole.CloseConsole("SUBST")
        CP.Show()
        Me.Close()
        'Vérifie si l'utilitaire est lancé en mode user et ce ferme si c'est la cas
        CheckPrivilegeLevelNeeded("SUBST", 3)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des texboxs et de la console
        ClearTextBox(Me)
    End Sub

    Private Sub btnDossier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDossier.Click
        'Sélectionner de dossier.
        txtDossier.Text = fbd()
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

#Region " Gestion de l'affichage "
    Private Sub optLister_CheckedChanged(sender As Object, e As EventArgs) Handles optLister.CheckedChanged
        'Groupbox caché si option lister est coché.
        If optLister.Checked Then
            gbLecteur.Visible = False
            gbDossier.Visible = False
            gbDelete.Visible = False
        Else
            gbLecteur.Visible = True
            gbDossier.Visible = True
            gbDelete.Visible = True
        End If
    End Sub

    Private Sub optD_CheckedChanged(sender As Object, e As EventArgs) Handles optD.CheckedChanged
        'Groupbox caché si option /D est coché.
        If optD.Checked Then
            gbLecteur.Visible = False
            gbDossier.Visible = False
            gbOption.Visible = False
        Else
            gbLecteur.Visible = True
            gbDossier.Visible = True
            gbOption.Visible = True
        End If
    End Sub
#End Region
   
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
            gbDossier.Text = "Créer"
            gbDelete.Text = "Supprimer"
            btnDossier.Text = "Dossier"
            optLister.Text = "Lister Seulement"

        Else                              ' boite PAS cochée=EN
            chkbxLangue.Text = "English"
            lblCmdExec.Text = "Just Executed:"
            optAdvanceMode.Text = "Advanced Mode"
            btnApply.Text = "Applyr"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnSend.Text = "Send"
            btnHelp.Text = "Help"
            gbDossier.Text = "Create"
            gbDelete.Text = "Delete"
            btnDossier.Text = "Folder"
            optLister.Text = "Lister Only"

        End If
    End Sub
#End Region

End Class

