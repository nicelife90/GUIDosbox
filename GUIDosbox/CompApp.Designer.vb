<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompApp))
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.OptADV = New System.Windows.Forms.CheckBox()
        Me.TextReturns = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.CommandReturn = New System.Windows.Forms.TextBox()
        Me.ADVCommand = New System.Windows.Forms.TextBox()
        Me.btnEnvoi = New System.Windows.Forms.Button()
        Me.lblLigneCommande = New System.Windows.Forms.Label()
        Me.lblCommandeExec = New System.Windows.Forms.Label()
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.OptFile1 = New System.Windows.Forms.TextBox()
        Me.OptFile2 = New System.Windows.Forms.TextBox()
        Me.OptD = New System.Windows.Forms.CheckBox()
        Me.OptA = New System.Windows.Forms.CheckBox()
        Me.OptL = New System.Windows.Forms.CheckBox()
        Me.OptC = New System.Windows.Forms.CheckBox()
        Me.OptN = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFile2 = New System.Windows.Forms.Button()
        Me.btnFile1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OptNArgs = New System.Windows.Forms.NumericUpDown()
        Me.lblNbLigne = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.OptNArgs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(13, 553)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(449, 553)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 7
        Me.btnApply.Text = "Appliquer"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(530, 553)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(530, 524)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'OptADV
        '
        Me.OptADV.AutoSize = True
        Me.OptADV.Location = New System.Drawing.Point(513, 501)
        Me.OptADV.Name = "OptADV"
        Me.OptADV.Size = New System.Drawing.Size(92, 17)
        Me.OptADV.TabIndex = 10
        Me.OptADV.Text = "Mode avancé"
        Me.OptADV.UseVisualStyleBackColor = True
        '
        'TextReturns
        '
        Me.TextReturns.BackColor = System.Drawing.SystemColors.WindowText
        Me.TextReturns.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextReturns.ForeColor = System.Drawing.SystemColors.Window
        Me.TextReturns.Location = New System.Drawing.Point(129, 120)
        Me.TextReturns.Multiline = True
        Me.TextReturns.Name = "TextReturns"
        Me.TextReturns.ReadOnly = True
        Me.TextReturns.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextReturns.Size = New System.Drawing.Size(476, 333)
        Me.TextReturns.TabIndex = 11
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(94, 553)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(350, 23)
        Me.ProgressBar1.TabIndex = 12
        '
        'CommandReturn
        '
        Me.CommandReturn.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommandReturn.Location = New System.Drawing.Point(129, 475)
        Me.CommandReturn.Name = "CommandReturn"
        Me.CommandReturn.ReadOnly = True
        Me.CommandReturn.Size = New System.Drawing.Size(476, 21)
        Me.CommandReturn.TabIndex = 13
        '
        'ADVCommand
        '
        Me.ADVCommand.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADVCommand.Location = New System.Drawing.Point(129, 454)
        Me.ADVCommand.Name = "ADVCommand"
        Me.ADVCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ADVCommand.Size = New System.Drawing.Size(476, 21)
        Me.ADVCommand.TabIndex = 14
        '
        'btnEnvoi
        '
        Me.btnEnvoi.Location = New System.Drawing.Point(315, 501)
        Me.btnEnvoi.Name = "btnEnvoi"
        Me.btnEnvoi.Size = New System.Drawing.Size(75, 23)
        Me.btnEnvoi.TabIndex = 0
        Me.btnEnvoi.Text = "Envoi"
        Me.btnEnvoi.UseVisualStyleBackColor = True
        '
        'lblLigneCommande
        '
        Me.lblLigneCommande.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLigneCommande.Location = New System.Drawing.Point(5, 460)
        Me.lblLigneCommande.Name = "lblLigneCommande"
        Me.lblLigneCommande.Size = New System.Drawing.Size(118, 15)
        Me.lblLigneCommande.TabIndex = 16
        Me.lblLigneCommande.Text = "Ligne de commande :"
        Me.lblLigneCommande.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCommandeExec
        '
        Me.lblCommandeExec.AutoSize = True
        Me.lblCommandeExec.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommandeExec.Location = New System.Drawing.Point(3, 481)
        Me.lblCommandeExec.Name = "lblCommandeExec"
        Me.lblCommandeExec.Size = New System.Drawing.Size(120, 15)
        Me.lblCommandeExec.TabIndex = 17
        Me.lblCommandeExec.Text = "Commande exécutée:"
        Me.lblCommandeExec.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(13, 58)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 19
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'OptFile1
        '
        Me.OptFile1.Location = New System.Drawing.Point(75, 18)
        Me.OptFile1.Name = "OptFile1"
        Me.OptFile1.Size = New System.Drawing.Size(395, 21)
        Me.OptFile1.TabIndex = 20
        '
        'OptFile2
        '
        Me.OptFile2.Location = New System.Drawing.Point(75, 45)
        Me.OptFile2.Name = "OptFile2"
        Me.OptFile2.Size = New System.Drawing.Size(395, 21)
        Me.OptFile2.TabIndex = 21
        '
        'OptD
        '
        Me.OptD.AutoSize = True
        Me.OptD.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.OptD.Location = New System.Drawing.Point(12, 153)
        Me.OptD.Name = "OptD"
        Me.OptD.Size = New System.Drawing.Size(38, 19)
        Me.OptD.TabIndex = 24
        Me.OptD.Text = "/D"
        Me.OptD.UseVisualStyleBackColor = True
        '
        'OptA
        '
        Me.OptA.AutoSize = True
        Me.OptA.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.OptA.Location = New System.Drawing.Point(66, 153)
        Me.OptA.Name = "OptA"
        Me.OptA.Size = New System.Drawing.Size(37, 19)
        Me.OptA.TabIndex = 25
        Me.OptA.Text = "/A"
        Me.OptA.UseVisualStyleBackColor = True
        '
        'OptL
        '
        Me.OptL.AutoSize = True
        Me.OptL.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.OptL.Location = New System.Drawing.Point(13, 178)
        Me.OptL.Name = "OptL"
        Me.OptL.Size = New System.Drawing.Size(36, 19)
        Me.OptL.TabIndex = 26
        Me.OptL.Text = "/L"
        Me.OptL.UseVisualStyleBackColor = True
        '
        'OptC
        '
        Me.OptC.AutoSize = True
        Me.OptC.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.OptC.Location = New System.Drawing.Point(65, 178)
        Me.OptC.Name = "OptC"
        Me.OptC.Size = New System.Drawing.Size(38, 19)
        Me.OptC.TabIndex = 27
        Me.OptC.Text = "/C"
        Me.OptC.UseVisualStyleBackColor = True
        '
        'OptN
        '
        Me.OptN.AutoSize = True
        Me.OptN.Location = New System.Drawing.Point(7, 19)
        Me.OptN.Name = "OptN"
        Me.OptN.Size = New System.Drawing.Size(38, 19)
        Me.OptN.TabIndex = 28
        Me.OptN.Text = "/N"
        Me.OptN.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFile2)
        Me.GroupBox1.Controls.Add(Me.btnFile1)
        Me.GroupBox1.Controls.Add(Me.OptFile1)
        Me.GroupBox1.Controls.Add(Me.OptFile2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(129, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 74)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fichier à comparer"
        '
        'btnFile2
        '
        Me.btnFile2.Location = New System.Drawing.Point(7, 44)
        Me.btnFile2.Name = "btnFile2"
        Me.btnFile2.Size = New System.Drawing.Size(62, 23)
        Me.btnFile2.TabIndex = 23
        Me.btnFile2.Text = "Fichier 2"
        Me.btnFile2.UseVisualStyleBackColor = True
        '
        'btnFile1
        '
        Me.btnFile1.Location = New System.Drawing.Point(7, 17)
        Me.btnFile1.Name = "btnFile1"
        Me.btnFile1.Size = New System.Drawing.Size(62, 23)
        Me.btnFile1.TabIndex = 22
        Me.btnFile1.Text = "Fichier 1"
        Me.btnFile1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OptNArgs)
        Me.GroupBox2.Controls.Add(Me.lblNbLigne)
        Me.GroupBox2.Controls.Add(Me.OptN)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(108, 91)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option /N"
        '
        'OptNArgs
        '
        Me.OptNArgs.Location = New System.Drawing.Point(7, 59)
        Me.OptNArgs.Name = "OptNArgs"
        Me.OptNArgs.Size = New System.Drawing.Size(97, 21)
        Me.OptNArgs.TabIndex = 32
        '
        'lblNbLigne
        '
        Me.lblNbLigne.AutoSize = True
        Me.lblNbLigne.Location = New System.Drawing.Point(6, 41)
        Me.lblNbLigne.Name = "lblNbLigne"
        Me.lblNbLigne.Size = New System.Drawing.Size(98, 15)
        Me.lblNbLigne.TabIndex = 29
        Me.lblNbLigne.Text = "Nombre de ligne:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(-5, -4)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(623, 44)
        Me.AxShockwaveFlash1.TabIndex = 31
        '
        'CompApp
        '
        Me.AcceptButton = Me.btnEnvoi
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(617, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OptC)
        Me.Controls.Add(Me.OptL)
        Me.Controls.Add(Me.OptA)
        Me.Controls.Add(Me.OptD)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Controls.Add(Me.lblCommandeExec)
        Me.Controls.Add(Me.lblLigneCommande)
        Me.Controls.Add(Me.btnEnvoi)
        Me.Controls.Add(Me.ADVCommand)
        Me.Controls.Add(Me.CommandReturn)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextReturns)
        Me.Controls.Add(Me.OptADV)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnHelp)
        Me.Name = "CompApp"
        Me.Text = "GUI DosBox - CHKDSK"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.OptNArgs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents OptADV As System.Windows.Forms.CheckBox
    Friend WithEvents TextReturns As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents CommandReturn As System.Windows.Forms.TextBox
    Friend WithEvents ADVCommand As System.Windows.Forms.TextBox
    Friend WithEvents btnEnvoi As System.Windows.Forms.Button
    Friend WithEvents lblLigneCommande As System.Windows.Forms.Label
    Friend WithEvents lblCommandeExec As System.Windows.Forms.Label
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents OptFile1 As System.Windows.Forms.TextBox
    Friend WithEvents OptFile2 As System.Windows.Forms.TextBox
    Friend WithEvents OptD As System.Windows.Forms.CheckBox
    Friend WithEvents OptA As System.Windows.Forms.CheckBox
    Friend WithEvents OptL As System.Windows.Forms.CheckBox
    Friend WithEvents OptC As System.Windows.Forms.CheckBox
    Friend WithEvents OptN As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OptNArgs As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNbLigne As System.Windows.Forms.Label
    Friend WithEvents btnFile1 As System.Windows.Forms.Button
    Friend WithEvents btnFile2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
