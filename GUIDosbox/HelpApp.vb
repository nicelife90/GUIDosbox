Imports System.Text

Public Class HelpApp

    Public Function StartProcess(ByVal filename As String) As String
        TextBox1.Text = ""
        Dim info As ProcessStartInfo = New ProcessStartInfo() 'processinfo
        info.FileName = filename 'nom du prog DOS "console" a executer .exe ou .com
        info.UseShellExecute = False ' si le shell du système d'exploitation doit être utilisé pour démarrer le processus
        info.RedirectStandardOutput = True 'valeur qui indique si la sortie d'une application est écrite dans le flux 
        info.CreateNoWindow = True 'sans fenetre visible
        Dim output As String = String.Empty
        Try
            Dim p As Process = Process.Start(info) 'execution
            p.StartInfo.StandardOutputEncoding = Encoding.GetEncoding("cp437") 'Pour convertir les caracterre de la fenetre dos
            p.Start()
            output = p.StandardOutput.ReadToEnd() 'lecture du resultat complet
            p.WaitForExit()
            p.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return output 'retour du text visible sur la console
    End Function

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        CP.Show()
        Me.Close()
    End Sub

   
    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        TextBox1.Text = StartProcess("help")
    End Sub

    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then ' boite cochée=FR donc, default pour la checkbox est checked
            chkbxLangue.Text = "Français"
            btnHelp.Text = "AIDE"
            btnBack.Text = "Retour"

        Else                                ' boite PAS cochée=EN 
            chkbxLangue.Text = "English"
            btnHelp.Text = "HELP"
            btnBack.Text = "Back"

        End If
    End Sub
End Class