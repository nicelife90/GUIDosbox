' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

Option Strict On
Option Explicit On

Imports System.IO
Imports Microsoft.Win32

Public Class frmGUIDBLoader

#Region " GUI MOVE "

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub frmMain_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) _
        Handles MyBase.MouseDown, lblText.MouseDown, lblTitle.MouseDown, imgFlash.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub frmMain_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) _
        Handles MyBase.MouseUp, lblText.MouseUp, lblTitle.MouseUp, imgFlash.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub frmMain_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) _
        Handles MyBase.MouseMove, lblText.MouseMove, lblTitle.MouseMove, imgFlash.MouseMove
        If IsFormBeingDragged Then
            Dim newLocation As Point = New Point()
            newLocation.X = Me.Location.X + (e.X - MouseDownX)
            newLocation.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = newLocation
            newLocation = Nothing
        End If
    End Sub
#End Region

#Region " Control Button "
    Private Sub imgBtnClose_MouseEnter(sender As Object, e As EventArgs) Handles imgBtnClose.MouseEnter
        imgBtnClose.Image = My.Resources.btnClose_Over
    End Sub

    Private Sub imgBtnClose_MouseHover(sender As Object, e As EventArgs) Handles imgBtnClose.MouseHover
        imgBtnClose.Image = My.Resources.btnClose_Over
    End Sub

    Private Sub imgBtnClose_MouseLeave(sender As Object, e As EventArgs) Handles imgBtnClose.MouseLeave
        imgBtnClose.Image = My.Resources.btnClose
    End Sub

    Private Sub imgBtnClose_Click(sender As Object, e As EventArgs) Handles imgBtnClose.Click
        Me.Close()
    End Sub

    Private Sub imgBtnMinimize_MouseEnter(sender As Object, e As EventArgs) Handles imgBtnMinimize.MouseEnter
        imgBtnMinimize.Image = My.Resources.btnMinimize_Over
    End Sub

    Private Sub imgBtnMinimize_MouseHover(sender As Object, e As EventArgs) Handles imgBtnMinimize.MouseHover
        imgBtnMinimize.Image = My.Resources.btnMinimize_Over
    End Sub

    Private Sub imgBtnMinimize_MouseLeave(sender As Object, e As EventArgs) Handles imgBtnMinimize.MouseLeave
        imgBtnMinimize.Image = My.Resources.btnMinimize
    End Sub

    Private Sub imgBtnMinimize_Click(sender As Object, e As EventArgs) Handles imgBtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

    ''' <summary>
    ''' Chemin des fichiers temp
    ''' </summary>
    Private InstallTempPath As String = System.IO.Path.GetTempPath

    Private Sub frmGUIDBLoader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Vérification de la présence de flahs player
        Try
            Dim Rk As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Macromedia\FlashPlayer")
            If Not Rk Is Nothing Then
                CP.Show()
                Me.Close()
            End If
        Catch ex As Exception
            'Impossible de trouver la clé de registre
        End Try
    End Sub

    Private Sub btnInstall_Click(sender As Object, e As EventArgs) Handles btnInstall.Click
        'Installation de flash player
        btnInstall.Hide()
        btnCancel.Enabled = False
        imgBtnClose.Enabled = False

        Try
            'Copie du fichier 1
            If Not File.Exists(InstallTempPath & "fpp.exe") Then
                My.Computer.FileSystem.WriteAllBytes(InstallTempPath & "fpp.exe", My.Resources.fpp, False)
            Else
                File.Delete(InstallTempPath & "fpp.exe")
                My.Computer.FileSystem.WriteAllBytes(InstallTempPath & "fpp.exe", My.Resources.fpp, False)
            End If

            'Copie du fichier 2
            If Not File.Exists(InstallTempPath & "fpax.exe") Then
                My.Computer.FileSystem.WriteAllBytes(InstallTempPath & "fpax.exe", My.Resources.fpax, False)
            Else
                File.Delete(InstallTempPath & "fpax.exe")
                My.Computer.FileSystem.WriteAllBytes(InstallTempPath & "fpax.exe", My.Resources.fpax, False)
            End If

            'Création de l'installer
            Dim batch As String() = {
                "@echo off",
                "title GUI Dosbox - Installation Flash Player",
                "color 17",
                "taskkill /IM firefox.exe /F >nul",
                "taskkill /IM chrome.exe /F >nul",
                "taskkill /IM iexplore.exe /F >nul",
                "taskkill /IM opera.exe /F >nul",
                "echo.",
                "echo Installing Adobe flash player...",
                "echo.",
                "echo Install Flash Player ActiveX for Internet Explorer ...",
                "start ""Install Flash Player ActiveX"" /wait """ & InstallTempPath & "fpax.exe"" -install",
                "echo Install Flash Player Plugin for other browser...",
                "start ""Install Flash Player Plugin"" /wait """ & InstallTempPath & "fpp.exe"" -install",
                "echo.",
                "echo Deleting Temporary Files...",
                "del /f /s /q """ & InstallTempPath & "fpax.exe""",
                "del /f /s /q """ & InstallTempPath & "fpp.exe""",
                "echo.",
                "echo Installation Completed!",
                "ping 127.0.0.1 -n 3 >nul",
                "exit"
                }
            File.WriteAllLines(InstallTempPath & "fpInstaller.cmd", batch)

            'Lancement de l'installation
            Dim p As Process = New Process
            With p.StartInfo
                .UseShellExecute = True
                .CreateNoWindow = True
                .WindowStyle = ProcessWindowStyle.Normal
                .FileName = InstallTempPath & "fpInstaller.cmd"
            End With
            p.Start()
            p.WaitForExit()

            'Supression des fichier temp
            If File.Exists(InstallTempPath & "fpInstaller.cmd") Then
                File.Delete(InstallTempPath & "fpInstaller.cmd")
            End If

            'Lancement de guidosbox
            CP.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Une erreur c'est produite lors de la tentavite d'installation de Flash Player." & vbCrLf & vbCrLf & _
                   ex.Message, MsgBoxStyle.Critical, "GUI Dosbox - Erreur d'installation")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class