Option Explicit On
Option Strict On

Imports System.IO
Imports System.CodeDom.Compiler

Public Class frmBatToExe

    Private DefaultIcone As String = Path.GetTempPath() & "\DefaultIcone.ico"

    Private Sub frmBatToExe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loading du flash Movie
        LoadHeader(flashHeader, "batchtoexe")

        'Status
        lblStatus.Text = "Statut : En attente"

        'Extration de l'icone par défaut
        Try
            SaveToDisk("cmd.ico", Path.GetTempPath() & "\DefaultIcone.ico")
        Catch ex As Exception
            MsgBox("Impossible de créé l'icone par défaut", MsgBoxStyle.Exclamation, "GUI Dosbox - Erreur")
        End Try
    End Sub

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

    Dim manifest As String = _
        "<?xml version=" & Chr(34) & "1.0" & Chr(34) & " encoding=" & Chr(34) & "utf-8" & Chr(34) & " standalone=" & Chr(34) & "yes" & Chr(34) & "?>" & vbNewLine & _
        "<assembly xmlns=" & Chr(34) & "urn:schemas-microsoft-com:asm.v1" & Chr(34) & " manifestVersion=" & Chr(34) & "1.0" & Chr(34) & ">" & vbNewLine & _
            "<assemblyIdentity version=" & Chr(34) & "1.0.0.0" & Chr(34) & " name=" & Chr(34) & "MyApplication.app" & Chr(34) & "/>" & vbNewLine & _
            "<trustInfo xmlns=" & Chr(34) & "urn:schemas-microsoft-com:asm.v2" & Chr(34) & ">" & vbNewLine & _
                "<security>" & vbNewLine & _
                    "<requestedPrivileges xmlns=" & Chr(34) & "urn:schemas-microsoft-com:asm.v3" & Chr(34) & ">" & vbNewLine & _
                        "<requestedExecutionLevel level=" & Chr(34) & "highestAvailable" & Chr(34) & "/>" & vbNewLine & _
                    "</requestedPrivileges>" & vbNewLine & _
                "</security>" & vbNewLine & _
            "</trustInfo>" & vbNewLine & _
        "</assembly>"

    ''' <summary>
    ''' Ce sub est à l'origine de la conversion du .bat en .exe 
    ''' Il appelle toutes les méthodes requise à la compillation et à l'affichage du progress
    ''' </summary>
    ''' <param name="Output">Le chemin du fichier de sortie final .exe</param>
    Private Sub ConvertBtE(ByVal Output As Object)
        UpdateStatus("Statut : Lecture du fichier", 50)
        Dim batch As String = IO.File.ReadAllText(txtSource.Text)  'input
        UpdateStatus("Statut : Préparation du code", 0)
        Dim code As String = Source
        UpdateStatus("", 50)
        code = code.Replace("{BATCH}", TobString(batch))
        UpdateStatus("Statut : Compillation", 50)
        If optAsAdmin.Checked Then
            GenerateExecutableAsAdmin(CStr(Output), code)
        Else
            GenerateExecutable(CStr(Output), code)
        End If
        UpdateStatus("Statut : Terminé", 100)
    End Sub

    ''' <summary>
    ''' Ce sub permet la mise à jour de l'interface sur le thread appelant.
    ''' </summary>
    ''' <param name="lbl">Text à afficher dans le Label</param>
    ''' <param name="prgs">Pourcentage actuelle ProgressBar</param>
    Delegate Sub delUpdateStatus(ByVal lbl As String, ByVal prgs As Integer)
    Private Sub UpdateStatus(ByVal lbl As String, ByVal prgs As Integer)
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
    Private Function TobString(ByVal b As String) As String
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
    Private Sub GenerateExecutable(ByVal Output As String, ByVal Source As String)
        Try
            Dim Param As New CompilerParameters()
            Dim Res As CompilerResults
            Param.GenerateExecutable = True
            Param.IncludeDebugInformation = False
            If txtIcone.Text <> Nothing Then
                Param.CompilerOptions = "/target:winexe /optimize+ /filealign:512 /win32icon:" & Chr(34) & txtIcone.Text & Chr(34)
            Else
                Param.CompilerOptions = "/target:winexe /optimize+ /filealign:512 /win32icon:" & Chr(34) & DefaultIcone & Chr(34)
            End If
            Param.OutputAssembly = Output
            Res = New VBCodeProvider(New Dictionary(Of String, String)() From {{"Version", "v2"}}).CompileAssemblyFromSource(Param, Source)
            If Res.Errors.Count <> 0 Then
                Dim message As String = Nothing
                For Each erreur As CompilerError In Res.Errors
                    message += vbCrLf & vbCrLf & erreur.ToString
                Next
                MessageBox.Show("Erreur de compillation, " & message, "GUIDosbox - Erreur de compillation", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox("Erreur de compillation, " & ex.ToString, MsgBoxStyle.Critical, "GUIDosbox - Erreur de compillation")
        End Try
    End Sub

    ''' <summary>
    ''' Compille notre nouveau .exe et ajoute la demande de droit d'administrateur
    ''' </summary>
    ''' <param name="Output">Le chemin de sortie du fichier final .exe</param>
    ''' <param name="Source">Code source du nouveau .exe</param>
    Private Sub GenerateExecutableAsAdmin(ByVal Output As String, ByVal Source As String)
        Try
            Dim Param As New CompilerParameters()
            Dim Res As CompilerResults
            Param.GenerateExecutable = True
            Param.IncludeDebugInformation = False
            If txtIcone.Text <> Nothing Then
                Param.CompilerOptions = "/target:winexe /optimize+ /filealign:512 /win32manifest:" & Path.GetTempPath & "\app.manifest /win32icon:" & Chr(34) & txtIcone.Text & Chr(34)
            Else
                Param.CompilerOptions = "/target:winexe /optimize+ /filealign:512 /win32manifest:" & Path.GetTempPath & "\app.manifest /win32icon:" & Chr(34) & DefaultIcone & Chr(34)
            End If
            Param.OutputAssembly = Output
            Res = New VBCodeProvider(New Dictionary(Of String, String)() From {{"Version", "v2"}}).CompileAssemblyFromSource(Param, Source)
            If Res.Errors.Count <> 0 Then
                Dim message As String = Nothing
                For Each erreur As CompilerError In Res.Errors
                    message += vbCrLf & vbCrLf & erreur.ToString
                Next
                MessageBox.Show("Erreur de compillation, " & message, "GUIDosbox - Erreur de compillation", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox("Erreur de compillation, " & ex.ToString, MsgBoxStyle.Critical, "GUIDosbox - Erreur de compillation")
        End Try
    End Sub

    Private Sub btnBuild_Click(sender As Object, e As EventArgs) Handles btnBuild.Click
        'Vérification du fichier batch
        If Path.GetExtension(txtSource.Text) <> ".bat" Then
            MsgBox("Veuillez sélectionner un fichier batch valide s.v.p!" & vbCrLf & "Le fichier doit porter l'extension .bat", _
                  MsgBoxStyle.Exclamation, "GUIDosbox - Fichier non valide")
            Exit Sub
        End If

        'Vérification de l'icone
        If txtIcone.Text <> Nothing And Path.GetExtension(txtIcone.Text) <> ".ico" Then
            MsgBox("Veuillez sélectionner une icône valide s.v.p!" & vbCrLf & "L'icone doit avoir l'extension .ico", _
                  MsgBoxStyle.Exclamation, "GUIDosbox - Fichier non valide")
            Exit Sub
        End If

        'Affichage de la voite enregistrer sous 
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Executables|*.exe"
        sfd.FileName = Path.GetFileNameWithoutExtension(txtSource.Text)
        If sfd.ShowDialog <> vbOK Then
            Exit Sub
        End If

        'Option Add Administrator manifest
        If optAsAdmin.Checked Then
            'Création d'un fichier manifest 
            My.Computer.FileSystem.WriteAllText(Path.GetTempPath & "\app.manifest", manifest, False)
        End If

        'Compillation du batch
        Dim tConvert As New Threading.Thread(AddressOf ConvertBtE)
        tConvert.Start(sfd.FileName)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'Sélection d'un fichier
        txtSource.Text = ofd()
    End Sub

    Private Sub btnBrowseIcone_Click(sender As Object, e As EventArgs) Handles btnBrowseIcone.Click
        'Sélection d'un icone.
        txtIcone.Text = ofd()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Retour au cp.
        CP.Show()
        Me.Close()
    End Sub

End Class
