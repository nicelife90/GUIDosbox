Option Strict On
Option Explicit On

Public Class WhoamiApp

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

    Private Sub WhoamiApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Démmarage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        LoadHeader(flashHeader, "whoami")

        'Mode abvancé caché
        btnSend.Visible = False

        'Options par défaut
        optNull.Checked = True

        'Ajout des élément au comboBox.
        cbFormat.Items.Add("TABLE")
        cbFormat.Items.Add("LIST")
        cbFormat.Items.Add("CSV")

        'Définition du niveau de privilèges requis par l'utilitaire
        footer.PrivilegeLevelNeeded(-1)
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click

        'Déclaration des variables et constantes.
        Const Apps As String = "whoami "
        Dim Arguments As String = Nothing

        'Arguments
        Dim args(9) As String
        For Each arg In args
            arg = Nothing
        Next

        'args(0) --> /USER
        If optUser.Checked Then
            args(0) = "/USER "
        End If

        'args(1) --> /GROUPS
        If optGroups.Checked Then
            args(1) = "/GROUPS "
        End If

        'args(2) --> /PRIV
        If optPriv.Checked Then
            args(2) = "/PRIV "
        End If

        'args(3) --> /ALL
        If optAll.Checked Then
            For i As Integer = 0 To 2
                args(i) = Nothing
            Next
            args(3) = "/ALL "
        End If

        'args(4) --> /UPN
        If optUpn.Checked Then
            For i As Integer = 0 To 3 
                args(i) = Nothing
            Next
            args(4) = "/UPN "
        End If

        'args(5) --> /FQDN
        If optFqdn.Checked Then
            For i As Integer = 0 To 4
                args(i) = Nothing
            Next
            args(5) = "/FQDN "
        End If

        'args(6) --> /LOGONID
        If optLogonid.Checked Then
            For i As Integer = 0 To 5
                args(i) = Nothing
            Next
            args(6) = "/LOGONID "
        End If

        'args(7) --> /FO
        If optFO.Checked And cbFormat.Text <> Nothing Then
            args(7) = "/FO " & cbFormat.Text & " "
        End If

        'args(8) --> /NH
        If optNH.Checked And cbFormat.Text <> "LIST" Then
            args(8) = "/NH"     
        End If

        'Création de la chaine d'arguments
        For Each arg In args
            Arguments += arg
        Next

        'Envoi de la commande.
        txtCmdExec.Text = myConsole.SendCommand(Apps + Arguments)

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        txtCmdExec.Text = myConsole.SendCommand("whoami /?")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Arrêt de la console et retour au cp.
        myConsole.CloseConsole("whoami")
        Me.Close()
        CP.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset des texbox.
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

#Region "Gestion de l'interface"
    Private Sub optUpn_CheckedChanged(sender As Object, e As EventArgs) Handles optUpn.CheckedChanged
        If optUpn.Checked Then
            optUser.Checked = False
            optGroups.Checked = False
            optPriv.Checked = False
            optAll.Checked = False
            optNH.Checked = False
            optFO.Checked = False
        End If

    End Sub

    Private Sub optFqdn_CheckedChanged(sender As Object, e As EventArgs) Handles optFqdn.CheckedChanged
        If optFqdn.Checked Then
            optUser.Checked = False
            optGroups.Checked = False
            optPriv.Checked = False
            optAll.Checked = False
            optNH.Checked = False
            optFO.Checked = False
        End If
    End Sub

    Private Sub optLogonid_CheckedChanged(sender As Object, e As EventArgs) Handles optLogonid.CheckedChanged
        If optLogonid.Checked Then
            optUser.Checked = False
            optGroups.Checked = False
            optPriv.Checked = False
            optAll.Checked = False
            optNH.Checked = False
            optFO.Checked = False
        End If
    End Sub

    Private Sub optUser_CheckedChanged(sender As Object, e As EventArgs) Handles optUser.CheckedChanged
        optNull.Checked = True
    End Sub

    Private Sub optPriv_CheckedChanged(sender As Object, e As EventArgs) Handles optPriv.CheckedChanged
        optNull.Checked = True
    End Sub

    Private Sub optGroups_CheckedChanged(sender As Object, e As EventArgs) Handles optGroups.CheckedChanged
        optNull.Checked = True
    End Sub

    Private Sub optAll_CheckedChanged(sender As Object, e As EventArgs) Handles optAll.CheckedChanged
        optNull.Checked = True
    End Sub

    Private Sub optNH_CheckedChanged(sender As Object, e As EventArgs) Handles optNH.CheckedChanged
        optNull.Checked = True
    End Sub

    Private Sub optFO_CheckedChanged(sender As Object, e As EventArgs) Handles optFO.CheckedChanged
        optNull.Checked = True
    End Sub
#End Region

#Region "Language"
    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then ' boite cochée=FR donc, default pour la checkbox est checked
            chkbxLangue.Text = "Français"
            btnBack.Text = "Retour"

        Else                                ' boite PAS cochée=EN 
            chkbxLangue.Text = "English"
            btnBack.Text = "Back"

        End If
    End Sub
#End Region

End Class