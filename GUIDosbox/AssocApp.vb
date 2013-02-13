Option Strict On

Public Class AssocApp

#Region "Mode avancé"

    'Variable pour le mode avancé.
    Private AdvanceMode As Boolean = False

    Private Sub optAdvanceMode_CheckedChanged(sender As Object, e As EventArgs) Handles optAdvanceMode.CheckedChanged
        If optAdvanceMode.Checked = True Then
            AdvanceMode = True
            btnExtShow.Visible = False
            btnApply.Visible = False
            btnHelp.Visible = False
            btnSend.Visible = True
            txtCmdExec.Enabled = True
            footer.AdvanceMode(True)
        Else
            AdvanceMode = False
            btnExtShow.Visible = True
            btnApply.Visible = True
            btnHelp.Visible = True
            btnSend.Visible = False
            txtCmdExec.Enabled = False
            footer.AdvanceMode(False)
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        'Envoi de la commande
        myConsole.SendCommand(txtCmdExec.Text)
        txtCmdExec.Text = Nothing
    End Sub

#End Region
   
    Private Sub AssocApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Démarrage de la console
        myConsole.StartConsole()

        'Mode avancé caché.
        btnSend.Visible = False

        'Loading du header flash.
        LoadHeader(flashHeader, "assoc")

    End Sub


    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaraiton des variables et constantes
        Const App As String = "assoc "
        Dim Arguments As String = Nothing

        'Arguments
        Dim args(1) As String
        For Each arg In args
            arg = Nothing
        Next

        'args(0) --> .ext (Extension)
        args(0) = txtExtSet.Text & "="
        'args(1) --> Type de fichier
        args(1) = txtExtFile.Text

        'Création de la chiane d'arguments
        For Each arg In args
            Arguments += arg
        Next

        'Envoi de la commande
        txtCmdExec.Text = myConsole.SendCommand(App + Arguments)


    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Arrêt de la console
        myConsole.CloseConsole("assoc")
        CP.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Reset des textbox et de la console
        ClearTextBox(Me)
        txtCmdExec.Text = "cls"
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        txtCmdExec.Text = myConsole.SendCommand("assoc /?")
    End Sub

    Private Sub btnExtShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtShow.Click
        'Affichage des extentioms.
        txtCmdExec.Text = myConsole.SendCommand("assoc")
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
        If chkbxLangue.Checked = True Then ' boite cochée=FR donc, default pour la checkbox est checked
            chkbxLangue.Text = "Français"
            lblTypeFichier.Text = "Type de Fichier"
            lblCommande.Text = "Commande"
            btnApply.Text = "Appliquer"
            btnBack.Text = "Retour"
            btnClear.Text = "Effacer"
            btnExtShow.Text = "Voir les .ext"
            btnHelp.Text = "Aide"
        Else
            chkbxLangue.Text = "English" ' boite PAS cochée=EN 
            lblTypeFichier.Text = "File Type"
            lblCommande.Text = "Command"
            btnApply.Text = "Apply"
            btnBack.Text = "Back"
            btnClear.Text = "Clear"
            btnExtShow.Text = "View .ext's"
            btnHelp.Text = "Help"
        End If
    End Sub
#End Region

End Class