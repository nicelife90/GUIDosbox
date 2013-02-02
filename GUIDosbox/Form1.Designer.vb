<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompactApp
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompactApp))
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TextReturn = New System.Windows.Forms.TextBox()
        Me.CommandReturn = New System.Windows.Forms.TextBox()
        Me.GBMode = New System.Windows.Forms.GroupBox()
        Me.OptU = New System.Windows.Forms.RadioButton()
        Me.OptC = New System.Windows.Forms.RadioButton()
        Me.GBDossier = New System.Windows.Forms.GroupBox()
        Me.btnPathDossier = New System.Windows.Forms.Button()
        Me.AllPath = New System.Windows.Forms.TextBox()
        Me.OptS = New System.Windows.Forms.CheckBox()
        Me.GBOptions = New System.Windows.Forms.GroupBox()
        Me.OptQ = New System.Windows.Forms.CheckBox()
        Me.OptF = New System.Windows.Forms.CheckBox()
        Me.OptI = New System.Windows.Forms.CheckBox()
        Me.OptA = New System.Windows.Forms.CheckBox()
        Me.lblResultat = New System.Windows.Forms.Label()
        Me.RealPath = New System.Windows.Forms.TextBox()
        Me.btnPathFichier = New System.Windows.Forms.Button()
        Me.lblCommande = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.GBMode.SuspendLayout()
        Me.GBDossier.SuspendLayout()
        Me.GBOptions.SuspendLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(9, 471)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 0
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(315, 471)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 1
        Me.btnApply.Text = "Appliquer"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(396, 471)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'TextReturn
        '
        Me.TextReturn.BackColor = System.Drawing.SystemColors.WindowText
        Me.TextReturn.ForeColor = System.Drawing.SystemColors.Window
        Me.TextReturn.Location = New System.Drawing.Point(12, 172)
        Me.TextReturn.Multiline = True
        Me.TextReturn.Name = "TextReturn"
        Me.TextReturn.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextReturn.Size = New System.Drawing.Size(459, 238)
        Me.TextReturn.TabIndex = 4
        '
        'CommandReturn
        '
        Me.CommandReturn.Location = New System.Drawing.Point(117, 416)
        Me.CommandReturn.Name = "CommandReturn"
        Me.CommandReturn.Size = New System.Drawing.Size(354, 20)
        Me.CommandReturn.TabIndex = 5
        '
        'GBMode
        '
        Me.GBMode.Controls.Add(Me.OptU)
        Me.GBMode.Controls.Add(Me.OptC)
        Me.GBMode.Location = New System.Drawing.Point(37, 52)
        Me.GBMode.Name = "GBMode"
        Me.GBMode.Size = New System.Drawing.Size(117, 71)
        Me.GBMode.TabIndex = 6
        Me.GBMode.TabStop = False
        Me.GBMode.Text = "Mode"
        '
        'OptU
        '
        Me.OptU.AutoSize = True
        Me.OptU.Location = New System.Drawing.Point(6, 42)
        Me.OptU.Name = "OptU"
        Me.OptU.Size = New System.Drawing.Size(109, 17)
        Me.OptU.TabIndex = 1
        Me.OptU.TabStop = True
        Me.OptU.Text = "Décompresser /U"
        Me.OptU.UseVisualStyleBackColor = True
        '
        'OptC
        '
        Me.OptC.AutoSize = True
        Me.OptC.Location = New System.Drawing.Point(6, 21)
        Me.OptC.Name = "OptC"
        Me.OptC.Size = New System.Drawing.Size(95, 17)
        Me.OptC.TabIndex = 0
        Me.OptC.TabStop = True
        Me.OptC.Text = "Compresser /C"
        Me.OptC.UseVisualStyleBackColor = True
        '
        'GBDossier
        '
        Me.GBDossier.Controls.Add(Me.btnPathDossier)
        Me.GBDossier.Controls.Add(Me.AllPath)
        Me.GBDossier.Controls.Add(Me.OptS)
        Me.GBDossier.Location = New System.Drawing.Point(160, 52)
        Me.GBDossier.Name = "GBDossier"
        Me.GBDossier.Size = New System.Drawing.Size(198, 71)
        Me.GBDossier.TabIndex = 7
        Me.GBDossier.TabStop = False
        Me.GBDossier.Text = "Dossier"
        '
        'btnPathDossier
        '
        Me.btnPathDossier.Location = New System.Drawing.Point(119, 16)
        Me.btnPathDossier.Name = "btnPathDossier"
        Me.btnPathDossier.Size = New System.Drawing.Size(75, 23)
        Me.btnPathDossier.TabIndex = 2
        Me.btnPathDossier.Text = "Dossier"
        Me.btnPathDossier.UseVisualStyleBackColor = True
        '
        'AllPath
        '
        Me.AllPath.Location = New System.Drawing.Point(6, 43)
        Me.AllPath.Name = "AllPath"
        Me.AllPath.Size = New System.Drawing.Size(186, 20)
        Me.AllPath.TabIndex = 1
        '
        'OptS
        '
        Me.OptS.AutoSize = True
        Me.OptS.Location = New System.Drawing.Point(7, 20)
        Me.OptS.Name = "OptS"
        Me.OptS.Size = New System.Drawing.Size(117, 17)
        Me.OptS.TabIndex = 0
        Me.OptS.Text = "/S Sous-Répertoire"
        Me.OptS.UseVisualStyleBackColor = True
        '
        'GBOptions
        '
        Me.GBOptions.Controls.Add(Me.OptQ)
        Me.GBOptions.Controls.Add(Me.OptF)
        Me.GBOptions.Controls.Add(Me.OptI)
        Me.GBOptions.Controls.Add(Me.OptA)
        Me.GBOptions.Location = New System.Drawing.Point(364, 52)
        Me.GBOptions.Name = "GBOptions"
        Me.GBOptions.Size = New System.Drawing.Size(85, 71)
        Me.GBOptions.TabIndex = 8
        Me.GBOptions.TabStop = False
        Me.GBOptions.Text = "Options"
        '
        'OptQ
        '
        Me.OptQ.AutoSize = True
        Me.OptQ.Location = New System.Drawing.Point(43, 39)
        Me.OptQ.Name = "OptQ"
        Me.OptQ.Size = New System.Drawing.Size(39, 17)
        Me.OptQ.TabIndex = 3
        Me.OptQ.Text = "/Q"
        Me.OptQ.UseVisualStyleBackColor = True
        '
        'OptF
        '
        Me.OptF.AutoSize = True
        Me.OptF.Location = New System.Drawing.Point(43, 16)
        Me.OptF.Name = "OptF"
        Me.OptF.Size = New System.Drawing.Size(37, 17)
        Me.OptF.TabIndex = 2
        Me.OptF.Text = "/F"
        Me.OptF.UseVisualStyleBackColor = True
        '
        'OptI
        '
        Me.OptI.AutoSize = True
        Me.OptI.Location = New System.Drawing.Point(7, 39)
        Me.OptI.Name = "OptI"
        Me.OptI.Size = New System.Drawing.Size(34, 17)
        Me.OptI.TabIndex = 1
        Me.OptI.Text = "/I"
        Me.OptI.UseVisualStyleBackColor = True
        '
        'OptA
        '
        Me.OptA.AutoSize = True
        Me.OptA.Location = New System.Drawing.Point(7, 16)
        Me.OptA.Name = "OptA"
        Me.OptA.Size = New System.Drawing.Size(38, 17)
        Me.OptA.TabIndex = 0
        Me.OptA.Text = "/A"
        Me.OptA.UseVisualStyleBackColor = True
        '
        'lblResultat
        '
        Me.lblResultat.AutoSize = True
        Me.lblResultat.Location = New System.Drawing.Point(9, 156)
        Me.lblResultat.Name = "lblResultat"
        Me.lblResultat.Size = New System.Drawing.Size(136, 13)
        Me.lblResultat.TabIndex = 9
        Me.lblResultat.Text = "Résultat de la commande : "
        '
        'RealPath
        '
        Me.RealPath.Location = New System.Drawing.Point(117, 130)
        Me.RealPath.Name = "RealPath"
        Me.RealPath.Size = New System.Drawing.Size(332, 20)
        Me.RealPath.TabIndex = 10
        '
        'btnPathFichier
        '
        Me.btnPathFichier.Location = New System.Drawing.Point(37, 128)
        Me.btnPathFichier.Name = "btnPathFichier"
        Me.btnPathFichier.Size = New System.Drawing.Size(75, 23)
        Me.btnPathFichier.TabIndex = 11
        Me.btnPathFichier.Text = "Fichier"
        Me.btnPathFichier.UseVisualStyleBackColor = True
        '
        'lblCommande
        '
        Me.lblCommande.Location = New System.Drawing.Point(6, 419)
        Me.lblCommande.Name = "lblCommande"
        Me.lblCommande.Size = New System.Drawing.Size(110, 13)
        Me.lblCommande.TabIndex = 12
        Me.lblCommande.Text = "Commande exécutée :"
        Me.lblCommande.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(396, 442)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(90, 471)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(219, 23)
        Me.ProgressBar1.TabIndex = 14
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, -1)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(487, 47)
        Me.AxShockwaveFlash1.TabIndex = 15
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(9, 52)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 16
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'CompactApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(484, 499)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkbxLangue)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblCommande)
        Me.Controls.Add(Me.btnPathFichier)
        Me.Controls.Add(Me.RealPath)
        Me.Controls.Add(Me.lblResultat)
        Me.Controls.Add(Me.GBOptions)
        Me.Controls.Add(Me.GBDossier)
        Me.Controls.Add(Me.GBMode)
        Me.Controls.Add(Me.CommandReturn)
        Me.Controls.Add(Me.TextReturn)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnHelp)
        Me.MaximumSize = New System.Drawing.Size(500, 537)
        Me.MinimumSize = New System.Drawing.Size(500, 537)
        Me.Name = "CompactApp"
        Me.Text = "Compact"
        Me.GBMode.ResumeLayout(False)
        Me.GBMode.PerformLayout()
        Me.GBDossier.ResumeLayout(False)
        Me.GBDossier.PerformLayout()
        Me.GBOptions.ResumeLayout(False)
        Me.GBOptions.PerformLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents TextReturn As System.Windows.Forms.TextBox
    Friend WithEvents CommandReturn As System.Windows.Forms.TextBox
    Friend WithEvents GBMode As System.Windows.Forms.GroupBox
    Friend WithEvents OptU As System.Windows.Forms.RadioButton
    Friend WithEvents OptC As System.Windows.Forms.RadioButton
    Friend WithEvents GBDossier As System.Windows.Forms.GroupBox
    Friend WithEvents GBOptions As System.Windows.Forms.GroupBox
    Friend WithEvents OptS As System.Windows.Forms.CheckBox
    Friend WithEvents btnPathDossier As System.Windows.Forms.Button
    Friend WithEvents AllPath As System.Windows.Forms.TextBox
    Friend WithEvents OptQ As System.Windows.Forms.CheckBox
    Friend WithEvents OptF As System.Windows.Forms.CheckBox
    Friend WithEvents OptI As System.Windows.Forms.CheckBox
    Friend WithEvents OptA As System.Windows.Forms.CheckBox
    Friend WithEvents lblResultat As System.Windows.Forms.Label
    Friend WithEvents RealPath As System.Windows.Forms.TextBox
    Friend WithEvents btnPathFichier As System.Windows.Forms.Button
    Friend WithEvents lblCommande As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
End Class
