Imports System.Text
Public Class WhoamiApp
    Public Function StartProcess(ByVal filename As String) As String
        TextReturns.Text = ""
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

    Private Sub BtnCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGo.Click
        TextReturns.Text = StartProcess("whoami.exe") 'lance l'application
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()    'retour
        CP.Show()
    End Sub

    Private Sub chkbxLangue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxLangue.CheckedChanged
        If chkbxLangue.Checked = True Then ' boite cochée=FR donc, default pour la checkbox est checked
            chkbxLangue.Text = "Français"
            btnBack.Text = "Retour"

        Else                                ' boite PAS cochée=EN 
            chkbxLangue.Text = "English"
            btnBack.Text = "Back"

        End If
    End Sub


    Private Sub WhoamiApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Tooltip Ballon 1
        ToolTip1.ToolTipTitle = "Informations / UNP"
        ToolTip1.UseFading = True
        ToolTip1.UseAnimation = True
        ToolTip1.ShowAlways = True
        ToolTip1.AutoPopDelay = 5000
        ToolTip1.InitialDelay = 1000
        ToolTip1.ReshowDelay = 500
        ToolTip1.IsBalloon = True
        ToolTip1.SetToolTip(Opt1, "Affiche le nom d'utilisateur au format UNP" & vbCrLf & "(nom d'utilisateur principal).")

        'Tooltip Ballon 2
        ToolTip2.ToolTipTitle = "Informations / FQDN"
        ToolTip2.UseFading = True
        ToolTip2.UseAnimation = True
        ToolTip2.ShowAlways = True
        ToolTip2.AutoPopDelay = 5000
        ToolTip2.InitialDelay = 1000
        ToolTip2.ReshowDelay = 500
        ToolTip2.IsBalloon = True
        ToolTip2.SetToolTip(Opt2, "Affiche le nom d'utilisateur au format FQDN" & vbCrLf & "(nom de domaine pleinement qualifié).")

        'Tooltip Ballon 3
        ToolTip3.ToolTipTitle = "Informations / USER"
        ToolTip3.UseFading = True
        ToolTip3.UseAnimation = True
        ToolTip3.ShowAlways = True
        ToolTip3.AutoPopDelay = 5000
        ToolTip3.InitialDelay = 1000
        ToolTip3.ReshowDelay = 500
        ToolTip3.IsBalloon = True
        ToolTip3.SetToolTip(Opt3, "Affiche les informations de l'utilisateur actuel" & vbCrLf & "ainsi que l'identificateur de sécurité (SID).")

        'Tooltip Ballon 4
        ToolTip4.ToolTipTitle = "Informations / GROUPS"
        ToolTip4.UseFading = True
        ToolTip4.UseAnimation = True
        ToolTip4.ShowAlways = True
        ToolTip4.AutoPopDelay = 10000
        ToolTip4.InitialDelay = 1000
        ToolTip4.ReshowDelay = 500
        ToolTip4.IsBalloon = True
        ToolTip4.SetToolTip(Opt4, "Affiche l'appartenence de groupe de l'utilisateur" & vbCrLf & "actuel, le type de compte, les identificateurs de" & vbCrLf & "sécurité (SID) et les attributs.")

        'Tooltip Ballon 5
        ToolTip5.ToolTipTitle = "Informations / PRIV"
        ToolTip5.UseFading = True
        ToolTip5.UseAnimation = True
        ToolTip5.ShowAlways = True
        ToolTip5.AutoPopDelay = 5000
        ToolTip5.InitialDelay = 1000
        ToolTip5.ReshowDelay = 500
        ToolTip5.IsBalloon = True
        ToolTip5.SetToolTip(Opt5, "Affiche les privilèges de sécurité de" & vbCrLf & "l'utilisateur actuel.")

        'Tooltip Ballon 6
        ToolTip6.ToolTipTitle = "Informations / LOGONID"
        ToolTip6.UseFading = True
        ToolTip6.UseAnimation = True
        ToolTip6.ShowAlways = True
        ToolTip6.AutoPopDelay = 5000
        ToolTip6.InitialDelay = 1000
        ToolTip6.ReshowDelay = 500
        ToolTip6.IsBalloon = True
        ToolTip6.SetToolTip(Opt6, "Affiche l'ID de connexion de l'utilisateur actuel.")

        'Tooltip Ballon 7
        ToolTip7.ToolTipTitle = "Informations / ALL"
        ToolTip7.UseFading = True
        ToolTip7.UseAnimation = True
        ToolTip7.ShowAlways = True
        ToolTip7.AutoPopDelay = 10000
        ToolTip7.InitialDelay = 1000
        ToolTip7.ReshowDelay = 500
        ToolTip7.IsBalloon = True
        ToolTip7.SetToolTip(Opt7, "Affiche le nom de l'utilisateur actuel, les" & vbCrLf & "groupes auxquels il apartient ainsi que les" & vbCrLf & _
                            "identificateurs de sécurité (SID) et" & vbCrLf & "les privilèges du jeton d'accès de l'utilisateur" & vbCrLf & "actuel.")

        'Tooltip Ballon 8
        ToolTip8.ToolTipTitle = "Informations / NH"
        ToolTip8.UseFading = True
        ToolTip8.UseAnimation = True
        ToolTip8.ShowAlways = True
        ToolTip8.AutoPopDelay = 5000
        ToolTip8.InitialDelay = 1000
        ToolTip8.ReshowDelay = 500
        ToolTip8.IsBalloon = True
        ToolTip8.SetToolTip(Opt8, "Spécifie que les en-têtes de colonnes de doivent" & vbCrLf & "pas être affichés dans la sortie." & vbCrLf & "Valide uniquement pour les formats TABLE et CSV.")

        'Tooltip Ballon 9
        ToolTip9.ToolTipTitle = "Informations / FO"
        ToolTip9.UseFading = True
        ToolTip9.UseAnimation = True
        ToolTip9.ShowAlways = True
        ToolTip9.AutoPopDelay = 10000
        ToolTip9.InitialDelay = 1000
        ToolTip9.ReshowDelay = 500
        ToolTip9.IsBalloon = True
        ToolTip9.SetToolTip(Opt9, "Spécifie le format de sortie à afficher." & vbCrLf & "Les valeurs valides sont TABLE, LIST, CSV." & vbCrLf & _
                            "Les en-tête de colones ne sont pas affichées" & vbCrLf & "avec le format CSV. Le format par défaut" & vbCrLf & "est TABLE.")

        'Tooltip Ballon 10
        ToolTip10.ToolTipTitle = "Informations CSV"
        ToolTip10.UseFading = True
        ToolTip10.UseAnimation = True
        ToolTip10.ShowAlways = True
        ToolTip10.AutoPopDelay = 5000
        ToolTip10.InitialDelay = 1000
        ToolTip10.ReshowDelay = 500
        ToolTip10.IsBalloon = True
        ToolTip10.SetToolTip(rbCSV, "Les en-tête de colones ne sont pas affichées")

    End Sub

    Private Sub TextReturns_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextReturns.TextChanged

    End Sub
End Class