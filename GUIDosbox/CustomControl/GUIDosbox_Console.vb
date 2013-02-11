Option Strict On
Imports System.Text

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
        myConsole.StandardInput.WriteLine(myCommand)
        myConsole.StandardInput.Flush()
        Return myCommand
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

        myConsole.CancelErrorRead()
        myConsole.CancelOutputRead()
        myConsole.Close()

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

  
End Class
