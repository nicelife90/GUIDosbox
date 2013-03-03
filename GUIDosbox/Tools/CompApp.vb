' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

Option Strict On
Option Explicit On

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

    Private Sub CompApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Démarrage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        LoadHeader(flashHeader, "comp")

        'Mode avancé caché.
        btnSend.Hide()

        'Définition des prévilèges requis par l'utilitaire.
        footer.PrivilegeLevelNeeded(-1)
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        'Déclaration des variables et des constantes.
        Const Apps As String = "comp "
        Dim Arguments As String = Nothing

        'Arguments
        Dim args(7) As String
        For Each arg In args
            arg = Nothing
        Next
        
        'args(0) --> Fichier 1
        args(0) = """" & txtFile1.Text & """" & " "

        'args(1) --> Fichier 2
        args(1) = """" & txtFile2.Text & """" & " "

        'args(2) --> /D
        If optD.Checked Then
            args(2) = "/D "
        End If

        'args(3) --> /A
        If optA.Checked Then
            args(3) = "/A "
        End If

        'args(4) --> /L
        If optL.Checked Then
            args(4) = "/L "
        End If

        'args(5) --> /N:Nombre de ligne
        If optN.Checked Then
            args(5) = "/N=" & CStr(optNArgs.Value) & " "
        End If

        'args(6) --> /C
        If optC.Checked Then
            args(6) = "/C "
        End If

        'args(7) --> /OFF[LINE]
        If optOff.Checked Then
            args(7) = "/OFF "
        End If

        'Céation de la chaine d'arguments
        For Each arg In args
            Arguments += arg
        Next

        'Envoi de la commande
        txtCmdExec.Text = myConsole.SendCommand(Apps + Arguments)

        'Répond non à la question de comp
        myConsole.SendReponseNo()

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
        'Reset des texbox et de la console.
        ClearTextBox(Me)
    End Sub

    Private Sub btnFile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile1.Click
        'Sélection du fichier.
        txtFile1.Text = ofd()
    End Sub

    Private Sub btnFile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile2.Click
        'Sélection du fichier.
        txtFile2.Text = ofd()
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