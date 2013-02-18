Option Explicit On
Option Strict On

Imports System.CodeDom.Compiler

Public Class frmBatToExe

    ''' <summary>
    ''' Variable contenant le code source du nouveau .exe que nous allons créé lors de la compillation avec la méthode --> GenerateExecutable()
    ''' La partie {BATCH} serat remplacé par le contenue du .bat créé par l'utilisateur.
    ''' </summary>
    Dim Source As String = _
        "Module BtE" & vbNewLine & _
        "Sub Main()" & vbNewLine & _
        "If System.IO.File.Exists(System.Environment.GetEnvironmentVariable(" & Chr(34) & "TMP" & Chr(34) & ") & " & Chr(34) & "\cmd.bat" & Chr(34) & ") Then" & vbNewLine & _
        "System.IO.File.Delete(System.Environment.GetEnvironmentVariable(" & Chr(34) & "TMP" & Chr(34) & ") & " & Chr(34) & "\cmd.bat" & Chr(34) & ")" & vbNewLine & _
        "End If" & vbNewLine & _
        "System.IO.File.WriteAllText(System.Environment.GetEnvironmentVariable(" & Chr(34) & "TMP" & Chr(34) & ") & " & Chr(34) & "\cmd.bat" & Chr(34) & ", {BATCH})" & vbNewLine & _
        "System.Diagnostics.Process.Start(System.Environment.GetEnvironmentVariable(" & Chr(34) & "TMP" & Chr(34) & ") & " & Chr(34) & "\cmd.bat" & Chr(34) & ")" & vbNewLine & _
        "End Sub" & vbNewLine & _
        "End Module"

    ''' <summary>
    ''' Ce sub est à l'origine de la conversion du .bat en .exe 
    ''' Il appelle toutes les méthodes requise à la compillation et à l'affichage du progress
    ''' </summary>
    ''' <param name="Output">Le chemin du fichier de sortie final .exe</param>
    Sub ConvertBtE(ByVal Output As Object)
        UpdateStatus("Reading from batch file...", 50)
        Dim batch As String = IO.File.ReadAllText(txtSource.Text)  'input
        UpdateStatus("Preparing executable code...", 0)
        Dim code As String = Source
        UpdateStatus("", 50)
        code = code.Replace("{BATCH}", TobString(batch))
        UpdateStatus("Compiling...", 50)
        GenerateExecutable(CStr(Output), code)
        UpdateStatus("Done.", 100)
    End Sub

    ''' <summary>
    ''' Ce sub permet la mise à jour de l'interface sur le thread appelant.
    ''' </summary>
    ''' <param name="lbl">Text à afficher dans le Label</param>
    ''' <param name="prgs">Pourcentage actuelle ProgressBar</param>
    Delegate Sub delUpdateStatus(ByVal lbl As String, ByVal prgs As Integer)
    Sub UpdateStatus(ByVal lbl As String, ByVal prgs As Integer)
        If InvokeRequired Then
            Invoke(New delUpdateStatus(AddressOf UpdateStatus), New Object() {lbl, prgs})
        Else
            If lbl <> "" Then lblStatus.Text = lbl
            ProgressBar1.Value = prgs
        End If
    End Sub

    ''' <summary>
    ''' Convertie le contenue du batch file dans un format pouvant être compiller dans un projet vb.net
    ''' </summary>
    ''' <param name="b">Contenue du batch File</param>
    ''' <returns>Le code source qui remplace la partie {BATCH} dans la variable source ci-haut</returns>
    Function TobString(ByVal b As String) As String
        Dim ret As String = ""
        For i As Integer = 0 To Split(b, vbNewLine).Count - 1
            Dim line As String = Split(b, vbNewLine)(i).Replace(Chr(34), Chr(34) & " & System.Text.Encoding.ASCII.GetString(New Byte() {34}) & " & Chr(34))
            ret &= Chr(34) & line & Chr(34) & " & System.Environment.NewLine & _" & vbNewLine
        Next
        Return ret.Remove(ret.Length - 6)
    End Function

    ''' <summary>
    ''' Compille notre nouveau .exe 
    ''' </summary>
    ''' <param name="Output">Le chemin de sortie du fichier final .exe</param>
    ''' <param name="Source">Code source du nouveau .exe</param>
    Public Sub GenerateExecutable(ByVal Output As String, ByVal Source As String)
        Try
            Dim Param As New CompilerParameters()
            Dim Res As CompilerResults
            Param.GenerateExecutable = True
            Param.IncludeDebugInformation = False
            Param.CompilerOptions = "/target:winexe /optimize+ /filealign:512" '/win32icon:" & icone
            Param.OutputAssembly = Output
            Res = New VBCodeProvider(New Dictionary(Of String, String)() From {{"Version", "v2"}}).CompileAssemblyFromSource(Param, Source)
            If Res.Errors.Count <> 0 Then
                For Each erreur As CompilerError In Res.Errors
                    MessageBox.Show("Erreur de compillation: " & erreur.ToString, "GUIDosbox - Erreur de compillation", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Next
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuild.Click

        If Not IO.File.Exists(txtSource.Text) Then
            MsgBox("Please select a valid batch file!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim sfd As New SaveFileDialog
        sfd.Filter = "Executables|*.exe"
        If sfd.ShowDialog <> vbOK Then
            Exit Sub
        End If

        Dim tConvert As New Threading.Thread(AddressOf ConvertBtE)
        tConvert.Start(sfd.FileName) 'ouput

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        txtSource.Text = ofd()
    End Sub

End Class
