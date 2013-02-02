﻿Option Strict On

Public Class WhoamiApp

    Private Sub WhoamiApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Démmarage de la console.
        myConsole.StartConsole()

        'Loading du header flash.
        Try
            Dim MoviePath As String = System.IO.Path.GetTempPath & "\" & "whoami.swf"
            My.Computer.FileSystem.WriteAllBytes(MoviePath, My.Resources.whoami, False)
            flashHeader.LoadMovie(0, System.IO.Path.GetTempPath & "\" & "whoami.swf")
            flashHeader.Play()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de l'ouverture de cette application, " & ex.Message & vbCrLf & vbCrLf & _
                   "Cette erreur n'empèche pas le bon fonctionnement de l'application.", _
                   MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'Affichage de l'aide.
        myConsole.SendCommand("whoami /?")
        
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Arrêt de la console et retour au cp.
        myConsole.CloseConsole("whoami")
        Me.Close()
        CP.Show()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'Envoi de la commande.
        myConsole.SendCommand("whoami")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset des texbox.
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = Nothing
            End If
        Next
    End Sub

    ''' <summary>
    ''' Ce sub empêche la console d'être sélectionné.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TextReturns_Enter(sender As Object, e As EventArgs)
        ActiveControl = btnGo
    End Sub

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