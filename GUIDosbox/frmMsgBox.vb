Option Strict On
Option Explicit On

Imports System.Runtime.InteropServices
Imports System.IO

Public Class frmMsgBox

    'Import pour le bouclier sur le bouton 
    <DllImport("user32")> _
    Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As UInt32, ByVal wParam As UInt32, ByVal lParam As UInt32) As UInt32
    End Function
    Private Const BCM_SETSHIELD As UInteger = &H160C

    Private Sub frmMsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ajout du bouclier au bouton
        SendMessage(btnOui.Handle, BCM_SETSHIELD, 0, 1)
    End Sub

    Private Sub btnOui_Click(sender As Object, e As EventArgs) Handles btnOui.Click
        'Démarrage de l'application en tant qu'administrateur
        RunAsAdminNow()
        CP.Close()
        Me.Close()
    End Sub

    Private Sub btnNon_Click(sender As Object, e As EventArgs) Handles btnNon.Click
        'Supression des fichiers temporaires et lancement du tools en mode limité
        Try
            If File.Exists(Path.GetTempPath & "\stf.guidb") Then
                Dim FormToShow As String
                FormToShow = System.IO.File.ReadAllText(Path.GetTempPath & "\stf.guidb")
                File.Delete(Path.GetTempPath & "\stf.guidb")
                ShowGUIDosboxForm(FormToShow)
            End If
        Catch ex As Exception
            MsgBox("Impossible de supprimer les fichiers temporaires, " & ex.Message, _
                 MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try
        'Fermeture.
        Me.Close()
    End Sub

End Class