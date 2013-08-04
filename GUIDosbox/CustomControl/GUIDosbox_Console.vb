' [--> GUIDosbox <--]
' Créé par : Nice-Life90
' http://www.guidosbox.com
' Copyright (C) 2010 - 2013 GUIDosbox - Montréal 
' Tous droits réservés

' [--> Contenue du fichhier <-] 
' Ce code est le controle principal de cette application
' Il s'agit de la console intégré dans GUIDosbox.

Option Strict On
Option Explicit On

Imports System.Text
Imports System.ComponentModel

''' <summary>
''' Console personnalisé GUIDosbox.
''' </summary>
Public Class GUIDosbox_Console

    ''' <summary>
    ''' Console personnalisé GUIDosbox.
    ''' </summary>
    ''' <remarks>Déclaration d'un process avec évenement</remarks>
    Public WithEvents myConsole As Process

    Public Delegate Sub AppendOutputTextDelegate(ByVal text As String)

    ''' <summary>
    ''' Démmare une nouvelle instance de la console personnalisé GUIDosbox.
    ''' </summary>
    Public Sub StartConsole()
        'Création de la console
        myConsole = New Process
        With myConsole.StartInfo
            .FileName = "CMD.EXE"
            .UseShellExecute = False
            .CreateNoWindow = True
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            '437	IBM437	OEM United States
            '850	ibm850	OEM Multilingual Latin 1; Western European (DOS)
            .StandardOutputEncoding = Encoding.GetEncoding(850)
            .StandardErrorEncoding = Encoding.GetEncoding(850)
        End With

        'Démarage de la console
        myConsole.Start()
        myConsole.BeginErrorReadLine()
        myConsole.BeginOutputReadLine()
    End Sub

    Private Sub Console_ErrorDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles myConsole.ErrorDataReceived
        AppendOutputText(vbCrLf & e.Data)
    End Sub

    Private Sub Console_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles myConsole.OutputDataReceived
        AppendOutputText(vbCrLf & e.Data)
    End Sub

    ''' <summary>
    ''' Affiche le text dans le textbox après l'avoir mit sur le même thread que celui du contrôle.
    ''' </summary>
    ''' <param name="text">le text provenant du flux</param>
    Private Sub AppendOutputText(ByVal text As String)
        If txtOutput.InvokeRequired Then
            Dim myDelegate As New AppendOutputTextDelegate(AddressOf AppendOutputText)
            Me.Invoke(myDelegate, text)
        Else
            txtOutput.AppendText(text)
        End If
    End Sub

    ''' <summary>
    ''' Envoi la commande à l'instance actuelle de la console personnalisé GUIDosbox et retourne la commande exécuté.
    ''' </summary>
    ''' <param name="myCommand">Commande à exécuter.</param>
    Public Function SendCommand(ByVal myCommand As String) As String
        If myCommand = "cls" Or myCommand = "CLS" Then
            'Si commande = cls
            Cls()
            Return myCommand
        Else
            'Conversion de la chaine de caractères --> Support des accents
            Dim buffer As Byte() = Encoding.GetEncoding(850).GetBytes(myCommand)

            'Envoi de la commande à la console
            myConsole.StandardInput.BaseStream.Write(buffer, 0, buffer.Length)
            myConsole.StandardInput.WriteLine()
            myConsole.StandardInput.Flush()

            'Écriture de la commande dans le batch file.
            'Si la commande n'est pas vide.
            If myCommand <> Nothing Then
                WriteBatch(myCommand)
            End If

            'Retour de la commande
            Return myCommand
        End If
    End Function

    ''' <summary>
    ''' Répond n à la question afficher dans l'instance actuelle de la console personnalisé GUIDosbox.
    ''' </summary>
    Public Sub SendReponseNo()
        myConsole.StandardInput.WriteLine("n")
    End Sub

    ''' <summary>
    ''' Efface la console et envoi un message personnalisé dans la console.
    ''' </summary>
    ''' <param name="message"></param>
    ''' <remarks></remarks>
    Public Sub Message(ByVal message As String)
        Cls()
        txtOutput.Text = message
    End Sub

    ''' <summary>
    ''' Éfface le text de l'instance actuelle de la console personnalisé GUIDosbox.
    ''' </summary>
    Public Sub Cls()
        txtOutput.Text = Nothing
    End Sub

    ''' <summary>
    ''' Arrête l'instance actuelle de la console personnalisé GUIDosbox.
    ''' </summary>
    ''' <param name="tool">Utilitaire utilisé par CMD dans le formulaire d'utilisateur qui a instancié la console.
    ''' Ex: chkdsk
    ''' </param>
    Public Sub CloseConsole(Optional ByVal tool As String = "cmd")
        'Arrêt et fermeture de la console
        myConsole.CancelErrorRead()
        myConsole.CancelOutputRead()
        myConsole.Close()
        'Process Killing cmd.exe & tool.exe
        Try
            For Each RunningProcess In Process.GetProcessesByName("cmd")
                RunningProcess.Kill()
            Next

            If Not tool = "cmd" Then
                For Each RunningProcess In Process.GetProcessesByName(tool)
                    RunningProcess.Kill()
                Next
            End If
        Catch ex As Exception
            MsgBox("L'erreur suivante c'est produite, " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#Region " Console Custom Property "

    ''' <summary>
    ''' Couleur de fond de la console GUI Dosbox.
    ''' </summary>
    <Category("GUI Dosbox Console Property")>
    <Description("Couleur de fond de la console GUI Dosbox.")>
    Public Property ConsoleBackColor As Color
        Get
            Return txtOutput.BackColor
        End Get
        Set(value As Color)
            txtOutput.BackColor = value
        End Set
    End Property

    ''' <summary>
    ''' Couleur du texte de la console GUI Dosbox.
    ''' </summary>
    <Category("GUI Dosbox Console Property")>
    <Description("Couleur du texte de la console GUI Dosbox.")>
    Public Property ConsoleForeColor As Color
        Get
            Return txtOutput.ForeColor
        End Get
        Set(ByVal value As Color)
            txtOutput.ForeColor = value
        End Set
    End Property

    ''' <summary>
    ''' Police de caractère de la console GUI Dosbox.
    ''' </summary>
    <Category("GUI Dosbox Console Property")>
    <Description("Police de caractère de la console GUI Dosbox.")>
    Public Property ConsoleFont As Font
        Get
            Return txtOutput.Font
        End Get
        Set(ByVal value As Font)
            txtOutput.Font = value
        End Set
    End Property
#End Region
End Class
