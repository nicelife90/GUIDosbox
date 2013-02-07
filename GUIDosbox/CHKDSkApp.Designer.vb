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
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.GuiDosbox_Groupbox3 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optC = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optB = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optX = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optV = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optI = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optR = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optF = New GUIDosbox.GUIDosbox_Checkbox()
        Me.gbOptL = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optLArg = New System.Windows.Forms.NumericUpDown()
        Me.optL = New GUIDosbox.GUIDosbox_Checkbox()
        Me.gbLetter = New GUIDosbox.GUIDosbox_Groupbox()
        Me.cbLetter = New GUIDosbox.GUIDosbox_Combobox()
        Me.lblCmdExec = New GUIDosbox.GUIDosbox_Label()
        Me.txtCmdExec = New GUIDosbox.GUIDosbox_Textbox()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
        Me.btnApply = New GUIDosbox.GUIDosbox_Button()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnClear = New GUIDosbox.GUIDosbox_Button()
        Me.btnHelp = New GUIDosbox.GUIDosbox_Button()
        Me.optAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GuiDosbox_Groupbox3.SuspendLayout()
        Me.gbOptL.SuspendLayout()
        CType(Me.optLArg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLetter.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(9, 443)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 19
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(0, 0)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(694, 40)
        Me.flashHeader.TabIndex = 21
        '
        'GuiDosbox_Groupbox3
        '
        Me.GuiDosbox_Groupbox3.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox3.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox3.Controls.Add(Me.optC)
        Me.GuiDosbox_Groupbox3.Controls.Add(Me.optB)
        Me.GuiDosbox_Groupbox3.Controls.Add(Me.optX)
        Me.GuiDosbox_Groupbox3.Controls.Add(Me.optV)
        Me.GuiDosbox_Groupbox3.Controls.Add(Me.optI)
        Me.GuiDosbox_Groupbox3.Controls.Add(Me.optR)
        Me.GuiDosbox_Groupbox3.Controls.Add(Me.optF)
        Me.GuiDosbox_Groupbox3.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox3.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox3.Location = New System.Drawing.Point(7, 208)
        Me.GuiDosbox_Groupbox3.Name = "GuiDosbox_Groupbox3"
        Me.GuiDosbox_Groupbox3.Size = New System.Drawing.Size(127, 100)
        Me.GuiDosbox_Groupbox3.TabIndex = 32
        Me.GuiDosbox_Groupbox3.TabStop = False
        Me.GuiDosbox_Groupbox3.Text = " Options"
        '
        'optC
        '
        Me.optC.AutoSize = True
        Me.optC.BackColor = System.Drawing.Color.Black
        Me.optC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optC.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optC.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optC.Location = New System.Drawing.Point(67, 56)
        Me.optC.Name = "optC"
        Me.optC.Size = New System.Drawing.Size(35, 15)
        Me.optC.TabIndex = 6
        Me.optC.Text = "/C"
        Me.optC.UseVisualStyleBackColor = False
        '
        'optB
        '
        Me.optB.AutoSize = True
        Me.optB.BackColor = System.Drawing.Color.Black
        Me.optB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optB.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optB.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optB.Location = New System.Drawing.Point(26, 75)
        Me.optB.Name = "optB"
        Me.optB.Size = New System.Drawing.Size(35, 15)
        Me.optB.TabIndex = 5
        Me.optB.Text = "/B"
        Me.optB.UseVisualStyleBackColor = False
        '
        'optX
        '
        Me.optX.AutoSize = True
        Me.optX.BackColor = System.Drawing.Color.Black
        Me.optX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optX.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optX.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optX.Location = New System.Drawing.Point(67, 37)
        Me.optX.Name = "optX"
        Me.optX.Size = New System.Drawing.Size(35, 15)
        Me.optX.TabIndex = 4
        Me.optX.Text = "/X"
        Me.optX.UseVisualStyleBackColor = False
        '
        'optV
        '
        Me.optV.AutoSize = True
        Me.optV.BackColor = System.Drawing.Color.Black
        Me.optV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optV.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optV.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optV.Location = New System.Drawing.Point(67, 18)
        Me.optV.Name = "optV"
        Me.optV.Size = New System.Drawing.Size(35, 15)
        Me.optV.TabIndex = 3
        Me.optV.Text = "/V"
        Me.optV.UseVisualStyleBackColor = False
        '
        'optI
        '
        Me.optI.AutoSize = True
        Me.optI.BackColor = System.Drawing.Color.Black
        Me.optI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optI.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optI.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optI.Location = New System.Drawing.Point(26, 56)
        Me.optI.Name = "optI"
        Me.optI.Size = New System.Drawing.Size(35, 15)
        Me.optI.TabIndex = 2
        Me.optI.Text = "/I"
        Me.optI.UseVisualStyleBackColor = False
        '
        'optR
        '
        Me.optR.AutoSize = True
        Me.optR.BackColor = System.Drawing.Color.Black
        Me.optR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optR.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optR.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optR.Location = New System.Drawing.Point(26, 37)
        Me.optR.Name = "optR"
        Me.optR.Size = New System.Drawing.Size(35, 15)
        Me.optR.TabIndex = 1
        Me.optR.Text = "/R"
        Me.optR.UseVisualStyleBackColor = False
        '
        'optF
        '
        Me.optF.AutoSize = True
        Me.optF.BackColor = System.Drawing.Color.Black
        Me.optF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optF.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optF.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optF.Location = New System.Drawing.Point(26, 18)
        Me.optF.Name = "optF"
        Me.optF.Size = New System.Drawing.Size(35, 15)
        Me.optF.TabIndex = 0
        Me.optF.Text = "/F"
        Me.optF.UseVisualStyleBackColor = False
        '
        'gbOptL
        '
        Me.gbOptL.BackColor = System.Drawing.Color.Black
        Me.gbOptL.BorderColor = System.Drawing.Color.LightBlue
        Me.gbOptL.Controls.Add(Me.optLArg)
        Me.gbOptL.Controls.Add(Me.optL)
        Me.gbOptL.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbOptL.ForeColor = System.Drawing.Color.LightBlue
        Me.gbOptL.Location = New System.Drawing.Point(7, 120)
        Me.gbOptL.Name = "gbOptL"
        Me.gbOptL.Size = New System.Drawing.Size(127, 78)
        Me.gbOptL.TabIndex = 31
        Me.gbOptL.TabStop = False
        Me.gbOptL.Text = " Option /L"
        '
        'optLArg
        '
        Me.optLArg.BackColor = System.Drawing.Color.Black
        Me.optLArg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.optLArg.ForeColor = System.Drawing.Color.LightBlue
        Me.optLArg.Location = New System.Drawing.Point(9, 41)
        Me.optLArg.Name = "optLArg"
        Me.optLArg.Size = New System.Drawing.Size(108, 18)
        Me.optLArg.TabIndex = 1
        '
        'optL
        '
        Me.optL.AutoSize = True
        Me.optL.BackColor = System.Drawing.Color.Black
        Me.optL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optL.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optL.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optL.Location = New System.Drawing.Point(9, 20)
        Me.optL.Name = "optL"
        Me.optL.Size = New System.Drawing.Size(105, 15)
        Me.optL.TabIndex = 0
        Me.optL.Text = "/L: taille ="
        Me.optL.UseVisualStyleBackColor = False
        '
        'gbLetter
        '
        Me.gbLetter.BackColor = System.Drawing.Color.Black
        Me.gbLetter.BorderColor = System.Drawing.Color.LightBlue
        Me.gbLetter.Controls.Add(Me.cbLetter)
        Me.gbLetter.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbLetter.ForeColor = System.Drawing.Color.LightBlue
        Me.gbLetter.Location = New System.Drawing.Point(7, 50)
        Me.gbLetter.Name = "gbLetter"
        Me.gbLetter.Size = New System.Drawing.Size(127, 60)
        Me.gbLetter.TabIndex = 30
        Me.gbLetter.TabStop = False
        Me.gbLetter.Text = " Lecteur/Disque"
        '
        'cbLetter
        '
        Me.cbLetter.BackColor = System.Drawing.Color.Black
        Me.cbLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLetter.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.cbLetter.ForeColor = System.Drawing.Color.LightBlue
        Me.cbLetter.FormattingEnabled = True
        Me.cbLetter.Location = New System.Drawing.Point(17, 21)
        Me.cbLetter.Name = "cbLetter"
        Me.cbLetter.Size = New System.Drawing.Size(92, 19)
        Me.cbLetter.TabIndex = 0
        '
        'lblCmdExec
        '
        Me.lblCmdExec.AutoSize = True
        Me.lblCmdExec.BackColor = System.Drawing.Color.Transparent
        Me.lblCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.lblCmdExec.Location = New System.Drawing.Point(7, 414)
        Me.lblCmdExec.Name = "lblCmdExec"
        Me.lblCmdExec.Size = New System.Drawing.Size(124, 11)
        Me.lblCmdExec.TabIndex = 29
        Me.lblCmdExec.Text = "Commande exécuté:"
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(142, 410)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(543, 18)
        Me.txtCmdExec.TabIndex = 28
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Black
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnSend.ForeColor = System.Drawing.Color.LightBlue
        Me.btnSend.Location = New System.Drawing.Point(367, 439)
        Me.btnSend.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(83, 23)
        Me.btnSend.TabIndex = 27
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.Black
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnApply.ForeColor = System.Drawing.Color.LightBlue
        Me.btnApply.Location = New System.Drawing.Point(513, 468)
        Me.btnApply.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(83, 23)
        Me.btnApply.TabIndex = 26
        Me.btnApply.Text = "Appliquer"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.LightBlue
        Me.btnBack.Location = New System.Drawing.Point(602, 468)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(83, 23)
        Me.btnBack.TabIndex = 25
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.LightBlue
        Me.btnClear.Location = New System.Drawing.Point(602, 439)
        Me.btnClear.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 23)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Effacer"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Black
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnHelp.ForeColor = System.Drawing.Color.LightBlue
        Me.btnHelp.Location = New System.Drawing.Point(7, 468)
        Me.btnHelp.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(83, 23)
        Me.btnHelp.TabIndex = 23
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.BackColor = System.Drawing.Color.Black
        Me.optAdvanceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAdvanceMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAdvanceMode.Location = New System.Drawing.Point(96, 476)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(98, 15)
        Me.optAdvanceMode.TabIndex = 22
        Me.optAdvanceMode.Text = "Mode Avancé"
        Me.optAdvanceMode.UseVisualStyleBackColor = False
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(142, 50)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(543, 354)
        Me.myConsole.TabIndex = 20
        '
        'CHKDSkApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(691, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.GuiDosbox_Groupbox3)
        Me.Controls.Add(Me.gbOptL)
        Me.Controls.Add(Me.gbLetter)
        Me.Controls.Add(Me.lblCmdExec)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CHKDSkApp"
        Me.Text = "GUI DosBox - CHKDSK"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GuiDosbox_Groupbox3.ResumeLayout(False)
        Me.GuiDosbox_Groupbox3.PerformLayout()
        Me.gbOptL.ResumeLayout(False)
        Me.gbOptL.PerformLayout()
        CType(Me.optLArg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLetter.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optLArg As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents btnHelp As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnClear As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnApply As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents lblCmdExec As GUIDosbox.GUIDosbox_Label
    Friend WithEvents gbLetter As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents cbLetter As GUIDosbox.GUIDosbox_Combobox
    Friend WithEvents gbOptL As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optL As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents GuiDosbox_Groupbox3 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optC As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optB As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optX As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optV As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optI As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optR As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optF As GUIDosbox.GUIDosbox_Checkbox
End Class
