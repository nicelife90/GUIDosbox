﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TracertApp
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
        Me.GBForce = New System.Windows.Forms.GroupBox()
        Me.GBIpv6 = New System.Windows.Forms.GroupBox()
        Me.OptD = New System.Windows.Forms.CheckBox()
        Me.DelaiMS = New System.Windows.Forms.NumericUpDown()
        Me.GBTimeout = New System.Windows.Forms.GroupBox()
        Me.OptW = New System.Windows.Forms.CheckBox()
        Me.OptJ = New System.Windows.Forms.CheckBox()
        Me.OptS = New System.Windows.Forms.CheckBox()
        Me.OptR = New System.Windows.Forms.CheckBox()
        Me.txtSourceIPv6 = New System.Windows.Forms.TextBox()
        Me.txtAddresse = New System.Windows.Forms.TextBox()
        Me.GBHops = New System.Windows.Forms.GroupBox()
        Me.OptH = New System.Windows.Forms.CheckBox()
        Me.SautsMax = New System.Windows.Forms.NumericUpDown()
        Me.Opt4 = New System.Windows.Forms.CheckBox()
        Me.Opt6 = New System.Windows.Forms.CheckBox()
        Me.lblAddresse = New System.Windows.Forms.Label()
        Me.GBHotes = New System.Windows.Forms.GroupBox()
        Me.txtListeHotes = New System.Windows.Forms.TextBox()
        Me.GBForce.SuspendLayout()
        Me.GBIpv6.SuspendLayout()
        CType(Me.DelaiMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBTimeout.SuspendLayout()
        Me.GBHops.SuspendLayout()
        CType(Me.SautsMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBHotes.SuspendLayout()
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
        Me.btnApply.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnApply.Location = New System.Drawing.Point(449, 553)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 7
        Me.btnApply.Text = "Appliquer"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
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
        Me.TextReturns.Location = New System.Drawing.Point(152, 54)
        Me.TextReturns.Multiline = True
        Me.TextReturns.Name = "TextReturns"
        Me.TextReturns.ReadOnly = True
        Me.TextReturns.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextReturns.Size = New System.Drawing.Size(453, 399)
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
        Me.lblCommandeExec.Size = New System.Drawing.Size(123, 15)
        Me.lblCommandeExec.TabIndex = 17
        Me.lblCommandeExec.Text = "Commande executée :"
        Me.lblCommandeExec.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(604, 45)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 19
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'GBForce
        '
        Me.GBForce.Controls.Add(Me.Opt6)
        Me.GBForce.Controls.Add(Me.Opt4)
        Me.GBForce.Location = New System.Drawing.Point(74, 229)
        Me.GBForce.Name = "GBForce"
        Me.GBForce.Size = New System.Drawing.Size(59, 66)
        Me.GBForce.TabIndex = 20
        Me.GBForce.TabStop = False
        Me.GBForce.Text = "Forcer"
        '
        'GBIpv6
        '
        Me.GBIpv6.Controls.Add(Me.txtSourceIPv6)
        Me.GBIpv6.Controls.Add(Me.OptR)
        Me.GBIpv6.Controls.Add(Me.OptS)
        Me.GBIpv6.Location = New System.Drawing.Point(2, 377)
        Me.GBIpv6.Name = "GBIpv6"
        Me.GBIpv6.Size = New System.Drawing.Size(145, 71)
        Me.GBIpv6.TabIndex = 21
        Me.GBIpv6.TabStop = False
        Me.GBIpv6.Text = "IPv6"
        '
        'OptD
        '
        Me.OptD.AutoSize = True
        Me.OptD.Location = New System.Drawing.Point(6, 249)
        Me.OptD.Name = "OptD"
        Me.OptD.Size = New System.Drawing.Size(39, 17)
        Me.OptD.TabIndex = 22
        Me.OptD.Text = "/D"
        Me.OptD.UseVisualStyleBackColor = True
        '
        'DelaiMS
        '
        Me.DelaiMS.Location = New System.Drawing.Point(11, 42)
        Me.DelaiMS.Name = "DelaiMS"
        Me.DelaiMS.Size = New System.Drawing.Size(54, 20)
        Me.DelaiMS.TabIndex = 23
        '
        'GBTimeout
        '
        Me.GBTimeout.Controls.Add(Me.OptW)
        Me.GBTimeout.Controls.Add(Me.DelaiMS)
        Me.GBTimeout.Location = New System.Drawing.Point(74, 154)
        Me.GBTimeout.Name = "GBTimeout"
        Me.GBTimeout.Size = New System.Drawing.Size(73, 69)
        Me.GBTimeout.TabIndex = 24
        Me.GBTimeout.TabStop = False
        Me.GBTimeout.Text = "Délai"
        '
        'OptW
        '
        Me.OptW.AutoSize = True
        Me.OptW.Location = New System.Drawing.Point(6, 19)
        Me.OptW.Name = "OptW"
        Me.OptW.Size = New System.Drawing.Size(42, 17)
        Me.OptW.TabIndex = 24
        Me.OptW.Text = "/W"
        Me.OptW.UseVisualStyleBackColor = True
        '
        'OptJ
        '
        Me.OptJ.AutoSize = True
        Me.OptJ.Location = New System.Drawing.Point(12, 19)
        Me.OptJ.Name = "OptJ"
        Me.OptJ.Size = New System.Drawing.Size(100, 17)
        Me.OptJ.TabIndex = 25
        Me.OptJ.Text = "/J           Hôtes:"
        Me.OptJ.UseVisualStyleBackColor = True
        '
        'OptS
        '
        Me.OptS.AutoSize = True
        Me.OptS.Location = New System.Drawing.Point(46, 19)
        Me.OptS.Name = "OptS"
        Me.OptS.Size = New System.Drawing.Size(91, 17)
        Me.OptS.TabIndex = 0
        Me.OptS.Text = "/S  Addresse:"
        Me.OptS.UseVisualStyleBackColor = True
        '
        'OptR
        '
        Me.OptR.AutoSize = True
        Me.OptR.Location = New System.Drawing.Point(5, 19)
        Me.OptR.Name = "OptR"
        Me.OptR.Size = New System.Drawing.Size(39, 17)
        Me.OptR.TabIndex = 1
        Me.OptR.Text = "/R"
        Me.OptR.UseVisualStyleBackColor = True
        '
        'txtSourceIPv6
        '
        Me.txtSourceIPv6.Location = New System.Drawing.Point(5, 42)
        Me.txtSourceIPv6.Name = "txtSourceIPv6"
        Me.txtSourceIPv6.Size = New System.Drawing.Size(132, 20)
        Me.txtSourceIPv6.TabIndex = 2
        '
        'txtAddresse
        '
        Me.txtAddresse.Location = New System.Drawing.Point(6, 112)
        Me.txtAddresse.Name = "txtAddresse"
        Me.txtAddresse.Size = New System.Drawing.Size(145, 20)
        Me.txtAddresse.TabIndex = 26
        '
        'GBHops
        '
        Me.GBHops.Controls.Add(Me.SautsMax)
        Me.GBHops.Controls.Add(Me.OptH)
        Me.GBHops.Location = New System.Drawing.Point(1, 154)
        Me.GBHops.Name = "GBHops"
        Me.GBHops.Size = New System.Drawing.Size(67, 85)
        Me.GBHops.TabIndex = 27
        Me.GBHops.TabStop = False
        Me.GBHops.Text = "Sauts Maximum"
        '
        'OptH
        '
        Me.OptH.AutoSize = True
        Me.OptH.Location = New System.Drawing.Point(7, 34)
        Me.OptH.Name = "OptH"
        Me.OptH.Size = New System.Drawing.Size(39, 17)
        Me.OptH.TabIndex = 0
        Me.OptH.Text = "/H"
        Me.OptH.UseVisualStyleBackColor = True
        '
        'SautsMax
        '
        Me.SautsMax.Location = New System.Drawing.Point(5, 57)
        Me.SautsMax.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.SautsMax.Name = "SautsMax"
        Me.SautsMax.Size = New System.Drawing.Size(46, 20)
        Me.SautsMax.TabIndex = 1
        '
        'Opt4
        '
        Me.Opt4.AutoSize = True
        Me.Opt4.Location = New System.Drawing.Point(5, 20)
        Me.Opt4.Name = "Opt4"
        Me.Opt4.Size = New System.Drawing.Size(48, 17)
        Me.Opt4.TabIndex = 0
        Me.Opt4.Text = "IPv4"
        Me.Opt4.UseVisualStyleBackColor = True
        '
        'Opt6
        '
        Me.Opt6.AutoSize = True
        Me.Opt6.Location = New System.Drawing.Point(5, 44)
        Me.Opt6.Name = "Opt6"
        Me.Opt6.Size = New System.Drawing.Size(48, 17)
        Me.Opt6.TabIndex = 1
        Me.Opt6.Text = "IPv6"
        Me.Opt6.UseVisualStyleBackColor = True
        '
        'lblAddresse
        '
        Me.lblAddresse.AutoSize = True
        Me.lblAddresse.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddresse.Location = New System.Drawing.Point(10, 83)
        Me.lblAddresse.Name = "lblAddresse"
        Me.lblAddresse.Size = New System.Drawing.Size(97, 15)
        Me.lblAddresse.TabIndex = 28
        Me.lblAddresse.Text = "Addresse à tracer"
        '
        'GBHotes
        '
        Me.GBHotes.Controls.Add(Me.txtListeHotes)
        Me.GBHotes.Controls.Add(Me.OptJ)
        Me.GBHotes.Location = New System.Drawing.Point(0, 296)
        Me.GBHotes.Name = "GBHotes"
        Me.GBHotes.Size = New System.Drawing.Size(146, 80)
        Me.GBHotes.TabIndex = 29
        Me.GBHotes.TabStop = False
        Me.GBHotes.Text = "Liste Hôtes"
        '
        'txtListeHotes
        '
        Me.txtListeHotes.Location = New System.Drawing.Point(12, 42)
        Me.txtListeHotes.Name = "txtListeHotes"
        Me.txtListeHotes.Size = New System.Drawing.Size(125, 20)
        Me.txtListeHotes.TabIndex = 26
        '
        'TracertApp
        '
        Me.AcceptButton = Me.btnEnvoi
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(617, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.GBHotes)
        Me.Controls.Add(Me.lblAddresse)
        Me.Controls.Add(Me.GBHops)
        Me.Controls.Add(Me.txtAddresse)
        Me.Controls.Add(Me.GBTimeout)
        Me.Controls.Add(Me.OptD)
        Me.Controls.Add(Me.GBIpv6)
        Me.Controls.Add(Me.GBForce)
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
        Me.Name = "TracertApp"
        Me.Text = "GUI DosBox - TRACERT"
        Me.GBForce.ResumeLayout(False)
        Me.GBForce.PerformLayout()
        Me.GBIpv6.ResumeLayout(False)
        Me.GBIpv6.PerformLayout()
        CType(Me.DelaiMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBTimeout.ResumeLayout(False)
        Me.GBTimeout.PerformLayout()
        Me.GBHops.ResumeLayout(False)
        Me.GBHops.PerformLayout()
        CType(Me.SautsMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBHotes.ResumeLayout(False)
        Me.GBHotes.PerformLayout()
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
    Friend WithEvents GBForce As System.Windows.Forms.GroupBox
    Friend WithEvents GBIpv6 As System.Windows.Forms.GroupBox
    Friend WithEvents OptD As System.Windows.Forms.CheckBox
    Friend WithEvents DelaiMS As System.Windows.Forms.NumericUpDown
    Friend WithEvents GBTimeout As System.Windows.Forms.GroupBox
    Friend WithEvents OptW As System.Windows.Forms.CheckBox
    Friend WithEvents OptJ As System.Windows.Forms.CheckBox
    Friend WithEvents Opt6 As System.Windows.Forms.CheckBox
    Friend WithEvents Opt4 As System.Windows.Forms.CheckBox
    Friend WithEvents txtSourceIPv6 As System.Windows.Forms.TextBox
    Friend WithEvents OptR As System.Windows.Forms.CheckBox
    Friend WithEvents OptS As System.Windows.Forms.CheckBox
    Friend WithEvents txtAddresse As System.Windows.Forms.TextBox
    Friend WithEvents GBHops As System.Windows.Forms.GroupBox
    Friend WithEvents SautsMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents OptH As System.Windows.Forms.CheckBox
    Friend WithEvents lblAddresse As System.Windows.Forms.Label
    Friend WithEvents GBHotes As System.Windows.Forms.GroupBox
    Friend WithEvents txtListeHotes As System.Windows.Forms.TextBox
End Class
