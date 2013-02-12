Imports System.Runtime.InteropServices
Imports System.IO
Public Class frmMsgBox

    Dim test As Boolean = False

    'Import the function from user32.dll and define the shield constant 
    <DllImport("user32")> _
    Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As UInt32, ByVal wParam As UInt32, ByVal lParam As UInt32) As UInt32
    End Function
    Private Const BCM_SETSHIELD As UInteger = &H160C

    Private Sub btnOui_Click(sender As Object, e As EventArgs) Handles btnOui.Click
        RunAsAdminNow()
        CP.Close()
        Me.Close()
    End Sub

    Private Sub btnNon_Click(sender As Object, e As EventArgs) Handles btnNon.Click
        'Supression des fichiers temporaires
        Try
            If File.Exists(Path.GetTempPath & "\stf.guidb") Then
                File.Delete(Path.GetTempPath & "\stf.guidb")
            End If
        Catch ex As Exception
            MsgBox("Impossible de supprimer les fichiers temporaires, " & ex.Message, _
                 MsgBoxStyle.Information, My.Application.GetType.Name)
        End Try
        'Fermeture.
        Me.Close()
    End Sub


    Private Sub frmMsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(btnOui.Handle, BCM_SETSHIELD, 0, 1)
    End Sub
End Class