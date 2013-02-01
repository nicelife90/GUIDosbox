<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CHKDSkApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CHKDSkApp))
        Me.DLetter = New System.Windows.Forms.ComboBox()
        Me.GBLetter = New System.Windows.Forms.GroupBox()
        Me.GBOptions = New System.Windows.Forms.GroupBox()
        Me.OptB = New System.Windows.Forms.CheckBox()
        Me.OptR = New System.Windows.Forms.CheckBox()
        Me.OptI = New System.Windows.Forms.CheckBox()
        Me.OptV = New System.Windows.Forms.CheckBox()
        Me.OptC = New System.Windows.Forms.CheckBox()
        Me.OptX = New System.Windows.Forms.CheckBox()
        Me.OptF = New System.Windows.Forms.CheckBox()
        Me.GBOptL = New System.Windows.Forms.GroupBox()
        Me.OptLArg = New System.Windows.Forms.NumericUpDown()
        Me.OptL = New System.Windows.Forms.CheckBox()
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
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.GBLetter.SuspendLayout()
        Me.GBOptions.SuspendLayout()
        Me.GBOptL.SuspendLayout()
        CType(Me.OptLArg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DLetter
        '
        Me.DLetter.FormattingEnabled = True
        Me.DLetter.Items.AddRange(New Object() {"C:", "D:", "E:", "F:", "G:", "H:", "I:", "J:", "K:", "L:", "M:", "O:", "P:", "Q:", "R:", "S:", "T:", "U:", "V:", "W:", "X:", "Y:", "Z:"})
        Me.DLetter.Location = New System.Drawing.Point(26, 18)
        Me.DLetter.Name = "DLetter"
        Me.DLetter.Size = New System.Drawing.Size(57, 23)
        Me.DLetter.TabIndex = 1
        '
        'GBLetter
        '
        Me.GBLetter.Controls.Add(Me.DLetter)
        Me.GBLetter.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBLetter.Location = New System.Drawing.Point(13, 92)
        Me.GBLetter.Name = "GBLetter"
        Me.GBLetter.Size = New System.Drawing.Size(110, 49)
        Me.GBLetter.TabIndex = 2
        Me.GBLetter.TabStop = False
        Me.GBLetter.Text = "Lecteur / Disque"
        '
        'GBOptions
        '
        Me.GBOptions.Controls.Add(Me.OptB)
        Me.GBOptions.Controls.Add(Me.OptR)
        Me.GBOptions.Controls.Add(Me.OptI)
        Me.GBOptions.Controls.Add(Me.OptV)
        Me.GBOptions.Controls.Add(Me.OptC)
        Me.GBOptions.Controls.Add(Me.OptX)
        Me.GBOptions.Controls.Add(Me.OptF)
        Me.GBOptions.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBOptions.Location = New System.Drawing.Point(13, 226)
        Me.GBOptions.Name = "GBOptions"
        Me.GBOptions.Size = New System.Drawing.Size(110, 119)
        Me.GBOptions.TabIndex = 3
        Me.GBOptions.TabStop = False
        Me.GBOptions.Text = "Options"
        '
        'OptB
        '
        Me.OptB.AutoSize = True
        Me.OptB.Location = New System.Drawing.Point(9, 94)
        Me.OptB.Name = "OptB"
        Me.OptB.Size = New System.Drawing.Size(37, 19)
        Me.OptB.TabIndex = 6
        Me.OptB.Text = "/B"
        Me.OptB.UseVisualStyleBackColor = True
        '
        'OptR
        '
        Me.OptR.AutoSize = True
        Me.OptR.Location = New System.Drawing.Point(9, 44)
        Me.OptR.Name = "OptR"
        Me.OptR.Size = New System.Drawing.Size(37, 19)
        Me.OptR.TabIndex = 5
        Me.OptR.Text = "/R"
        Me.OptR.UseVisualStyleBackColor = True
        '
        'OptI
        '
        Me.OptI.AutoSize = True
        Me.OptI.Location = New System.Drawing.Point(9, 69)
        Me.OptI.Name = "OptI"
        Me.OptI.Size = New System.Drawing.Size(33, 19)
        Me.OptI.TabIndex = 4
        Me.OptI.Text = "/I"
        Me.OptI.UseVisualStyleBackColor = True
        '
        'OptV
        '
        Me.OptV.AutoSize = True
        Me.OptV.Location = New System.Drawing.Point(55, 20)
        Me.OptV.Name = "OptV"
        Me.OptV.Size = New System.Drawing.Size(37, 19)
        Me.OptV.TabIndex = 3
        Me.OptV.Text = "/V"
        Me.OptV.UseVisualStyleBackColor = True
        '
        'OptC
        '
        Me.OptC.AutoSize = True
        Me.OptC.Location = New System.Drawing.Point(55, 69)
        Me.OptC.Name = "OptC"
        Me.OptC.Size = New System.Drawing.Size(38, 19)
        Me.OptC.TabIndex = 2
        Me.OptC.Text = "/C"
        Me.OptC.UseVisualStyleBackColor = True
        '
        'OptX
        '
        Me.OptX.AutoSize = True
        Me.OptX.Location = New System.Drawing.Point(55, 44)
        Me.OptX.Name = "OptX"
        Me.OptX.Size = New System.Drawing.Size(37, 19)
        Me.OptX.TabIndex = 1
        Me.OptX.Text = "/X"
        Me.OptX.UseVisualStyleBackColor = True
        '
        'OptF
        '
        Me.OptF.AutoSize = True
        Me.OptF.Location = New System.Drawing.Point(10, 20)
        Me.OptF.Name = "OptF"
        Me.OptF.Size = New System.Drawing.Size(36, 19)
        Me.OptF.TabIndex = 0
        Me.OptF.Text = "/F"
        Me.OptF.UseVisualStyleBackColor = True
        '
        'GBOptL
        '
        Me.GBOptL.Controls.Add(Me.OptLArg)
        Me.GBOptL.Controls.Add(Me.OptL)
        Me.GBOptL.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBOptL.Location = New System.Drawing.Point(13, 156)
        Me.GBOptL.Name = "GBOptL"
        Me.GBOptL.Size = New System.Drawing.Size(110, 64)
        Me.GBOptL.TabIndex = 4
        Me.GBOptL.TabStop = False
        Me.GBOptL.Text = "Option /L"
        '
        'OptLArg
        '
        Me.OptLArg.Location = New System.Drawing.Point(9, 36)
        Me.OptLArg.Name = "OptLArg"
        Me.OptLArg.Size = New System.Drawing.Size(93, 21)
        Me.OptLArg.TabIndex = 1
        '
        'OptL
        '
        Me.OptL.AutoSize = True
        Me.OptL.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptL.Location = New System.Drawing.Point(9, 18)
        Me.OptL.Name = "OptL"
        Me.OptL.Size = New System.Drawing.Size(83, 17)
        Me.OptL.TabIndex = 0
        Me.OptL.Text = "/L:taille   ="
        Me.OptL.UseVisualStyleBackColor = True
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
        Me.TextReturns.Location = New System.Drawing.Point(129, 54)
        Me.TextReturns.Multiline = True
        Me.TextReturns.Name = "TextReturns"
        Me.TextReturns.ReadOnly = True
        Me.TextReturns.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextReturns.Size = New System.Drawing.Size(476, 399)
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
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(-1, 0)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(620, 39)
        Me.AxShockwaveFlash1.TabIndex = 18
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(8, 54)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 19
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'CHKDSkApp
        '
        Me.AcceptButton = Me.btnEnvoi
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(617, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkbxLangue)
        Me.Controls.Add(Me.AxShockwaveFlash1)
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
        Me.Controls.Add(Me.GBOptL)
        Me.Controls.Add(Me.GBOptions)
        Me.Controls.Add(Me.GBLetter)
        Me.Name = "CHKDSkApp"
        Me.Text = "GUI DosBox - CHKDSK"
        Me.GBLetter.ResumeLayout(False)
        Me.GBOptions.ResumeLayout(False)
        Me.GBOptions.PerformLayout()
        Me.GBOptL.ResumeLayout(False)
        Me.GBOptL.PerformLayout()
        CType(Me.OptLArg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DLetter As System.Windows.Forms.ComboBox
    Friend WithEvents GBLetter As System.Windows.Forms.GroupBox
    Friend WithEvents GBOptions As System.Windows.Forms.GroupBox
    Friend WithEvents OptB As System.Windows.Forms.CheckBox
    Friend WithEvents OptR As System.Windows.Forms.CheckBox
    Friend WithEvents OptI As System.Windows.Forms.CheckBox
    Friend WithEvents OptV As System.Windows.Forms.CheckBox
    Friend WithEvents OptC As System.Windows.Forms.CheckBox
    Friend WithEvents OptX As System.Windows.Forms.CheckBox
    Friend WithEvents OptF As System.Windows.Forms.CheckBox
    Friend WithEvents GBOptL As System.Windows.Forms.GroupBox
    Friend WithEvents OptLArg As System.Windows.Forms.NumericUpDown
    Friend WithEvents OptL As System.Windows.Forms.CheckBox
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
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
End Class
