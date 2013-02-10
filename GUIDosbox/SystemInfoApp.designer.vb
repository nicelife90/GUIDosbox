<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SystemInfoApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SystemInfoApp))
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.GuiDosbox_Groupbox1 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.GuiDosbox_Groupbox2 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.GuiDosbox_Groupbox3 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.GuiDosbox_Groupbox4 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optNH = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optP = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optU = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optS = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optFO = New GUIDosbox.GUIDosbox_Checkbox()
        Me.cbOptFO = New GUIDosbox.GUIDosbox_Combobox()
        Me.txtOptS = New GUIDosbox.GUIDosbox_Textbox()
        Me.txtOptU = New GUIDosbox.GUIDosbox_Textbox()
        Me.txtOptP = New GUIDosbox.GUIDosbox_Textbox()
        Me.btnHelp = New GUIDosbox.GUIDosbox_Button()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
        Me.btnApply = New GUIDosbox.GUIDosbox_Button()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnClear = New GUIDosbox.GUIDosbox_Button()
        Me.lblCmdExec = New GUIDosbox.GUIDosbox_Label()
        Me.txtCmdExec = New GUIDosbox.GUIDosbox_Textbox()
        Me.optAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GuiDosbox_Groupbox1.SuspendLayout()
        Me.GuiDosbox_Groupbox2.SuspendLayout()
        Me.GuiDosbox_Groupbox3.SuspendLayout()
        Me.GuiDosbox_Groupbox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(12, 573)
        Me.chkbxLangue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 19
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(5, 122)
        Me.myConsole.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(639, 412)
        Me.myConsole.TabIndex = 31
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(0, 0)
        Me.flashHeader.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(654, 40)
        Me.flashHeader.TabIndex = 32
        '
        'GuiDosbox_Groupbox1
        '
        Me.GuiDosbox_Groupbox1.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox1.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.cbOptFO)
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.optNH)
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.optFO)
        Me.GuiDosbox_Groupbox1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox1.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox1.Location = New System.Drawing.Point(5, 46)
        Me.GuiDosbox_Groupbox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GuiDosbox_Groupbox1.Name = "GuiDosbox_Groupbox1"
        Me.GuiDosbox_Groupbox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GuiDosbox_Groupbox1.Size = New System.Drawing.Size(159, 70)
        Me.GuiDosbox_Groupbox1.TabIndex = 33
        Me.GuiDosbox_Groupbox1.TabStop = False
        '
        'GuiDosbox_Groupbox2
        '
        Me.GuiDosbox_Groupbox2.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox2.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox2.Controls.Add(Me.txtOptP)
        Me.GuiDosbox_Groupbox2.Controls.Add(Me.optP)
        Me.GuiDosbox_Groupbox2.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox2.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox2.Location = New System.Drawing.Point(485, 46)
        Me.GuiDosbox_Groupbox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GuiDosbox_Groupbox2.Name = "GuiDosbox_Groupbox2"
        Me.GuiDosbox_Groupbox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GuiDosbox_Groupbox2.Size = New System.Drawing.Size(159, 70)
        Me.GuiDosbox_Groupbox2.TabIndex = 34
        Me.GuiDosbox_Groupbox2.TabStop = False
        '
        'GuiDosbox_Groupbox3
        '
        Me.GuiDosbox_Groupbox3.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox3.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox3.Controls.Add(Me.txtOptU)
        Me.GuiDosbox_Groupbox3.Controls.Add(Me.optU)
        Me.GuiDosbox_Groupbox3.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox3.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox3.Location = New System.Drawing.Point(325, 46)
        Me.GuiDosbox_Groupbox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GuiDosbox_Groupbox3.Name = "GuiDosbox_Groupbox3"
        Me.GuiDosbox_Groupbox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GuiDosbox_Groupbox3.Size = New System.Drawing.Size(159, 70)
        Me.GuiDosbox_Groupbox3.TabIndex = 0
        Me.GuiDosbox_Groupbox3.TabStop = False
        '
        'GuiDosbox_Groupbox4
        '
        Me.GuiDosbox_Groupbox4.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox4.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox4.Controls.Add(Me.txtOptS)
        Me.GuiDosbox_Groupbox4.Controls.Add(Me.optS)
        Me.GuiDosbox_Groupbox4.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox4.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox4.Location = New System.Drawing.Point(165, 46)
        Me.GuiDosbox_Groupbox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GuiDosbox_Groupbox4.Name = "GuiDosbox_Groupbox4"
        Me.GuiDosbox_Groupbox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GuiDosbox_Groupbox4.Size = New System.Drawing.Size(159, 70)
        Me.GuiDosbox_Groupbox4.TabIndex = 0
        Me.GuiDosbox_Groupbox4.TabStop = False
        '
        'optNH
        '
        Me.optNH.AutoSize = True
        Me.optNH.BackColor = System.Drawing.Color.Black
        Me.optNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optNH.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optNH.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optNH.Location = New System.Drawing.Point(82, 7)
        Me.optNH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optNH.Name = "optNH"
        Me.optNH.Size = New System.Drawing.Size(42, 15)
        Me.optNH.TabIndex = 24
        Me.optNH.Text = "/NH"
        Me.optNH.UseVisualStyleBackColor = False
        '
        'optP
        '
        Me.optP.AutoSize = True
        Me.optP.BackColor = System.Drawing.Color.Black
        Me.optP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optP.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optP.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optP.Location = New System.Drawing.Point(62, 7)
        Me.optP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optP.Name = "optP"
        Me.optP.Size = New System.Drawing.Size(35, 15)
        Me.optP.TabIndex = 25
        Me.optP.Text = "/P"
        Me.optP.UseVisualStyleBackColor = False
        '
        'optU
        '
        Me.optU.AutoSize = True
        Me.optU.BackColor = System.Drawing.Color.Black
        Me.optU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optU.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optU.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optU.Location = New System.Drawing.Point(62, 7)
        Me.optU.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optU.Name = "optU"
        Me.optU.Size = New System.Drawing.Size(35, 15)
        Me.optU.TabIndex = 26
        Me.optU.Text = "/U"
        Me.optU.UseVisualStyleBackColor = False
        '
        'optS
        '
        Me.optS.AutoSize = True
        Me.optS.BackColor = System.Drawing.Color.Black
        Me.optS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optS.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optS.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optS.Location = New System.Drawing.Point(62, 7)
        Me.optS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optS.Name = "optS"
        Me.optS.Size = New System.Drawing.Size(35, 15)
        Me.optS.TabIndex = 27
        Me.optS.Text = "/S"
        Me.optS.UseVisualStyleBackColor = False
        '
        'optFO
        '
        Me.optFO.AutoSize = True
        Me.optFO.BackColor = System.Drawing.Color.Black
        Me.optFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optFO.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optFO.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optFO.Location = New System.Drawing.Point(34, 7)
        Me.optFO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optFO.Name = "optFO"
        Me.optFO.Size = New System.Drawing.Size(42, 15)
        Me.optFO.TabIndex = 35
        Me.optFO.Text = "/FO"
        Me.optFO.UseVisualStyleBackColor = False
        '
        'cbOptFO
        '
        Me.cbOptFO.BackColor = System.Drawing.Color.Black
        Me.cbOptFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbOptFO.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.cbOptFO.ForeColor = System.Drawing.Color.LightBlue
        Me.cbOptFO.FormattingEnabled = True
        Me.cbOptFO.Location = New System.Drawing.Point(13, 35)
        Me.cbOptFO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbOptFO.Name = "cbOptFO"
        Me.cbOptFO.Size = New System.Drawing.Size(132, 19)
        Me.cbOptFO.TabIndex = 36
        '
        'txtOptS
        '
        Me.txtOptS.BackColor = System.Drawing.Color.Black
        Me.txtOptS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOptS.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtOptS.ForeColor = System.Drawing.Color.LightBlue
        Me.txtOptS.Location = New System.Drawing.Point(13, 35)
        Me.txtOptS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOptS.Name = "txtOptS"
        Me.txtOptS.Size = New System.Drawing.Size(132, 18)
        Me.txtOptS.TabIndex = 28
        '
        'txtOptU
        '
        Me.txtOptU.BackColor = System.Drawing.Color.Black
        Me.txtOptU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOptU.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtOptU.ForeColor = System.Drawing.Color.LightBlue
        Me.txtOptU.Location = New System.Drawing.Point(13, 35)
        Me.txtOptU.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOptU.Name = "txtOptU"
        Me.txtOptU.Size = New System.Drawing.Size(132, 18)
        Me.txtOptU.TabIndex = 27
        '
        'txtOptP
        '
        Me.txtOptP.BackColor = System.Drawing.Color.Black
        Me.txtOptP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOptP.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtOptP.ForeColor = System.Drawing.Color.LightBlue
        Me.txtOptP.Location = New System.Drawing.Point(13, 35)
        Me.txtOptP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOptP.Name = "txtOptP"
        Me.txtOptP.Size = New System.Drawing.Size(132, 18)
        Me.txtOptP.TabIndex = 26
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Black
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnHelp.ForeColor = System.Drawing.Color.LightBlue
        Me.btnHelp.Location = New System.Drawing.Point(5, 593)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHelp.MinimumSize = New System.Drawing.Size(0, 22)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(82, 22)
        Me.btnHelp.TabIndex = 35
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Black
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnSend.ForeColor = System.Drawing.Color.LightBlue
        Me.btnSend.Location = New System.Drawing.Point(325, 564)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSend.MinimumSize = New System.Drawing.Size(0, 22)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(82, 22)
        Me.btnSend.TabIndex = 36
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
        Me.btnApply.Location = New System.Drawing.Point(477, 593)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnApply.MinimumSize = New System.Drawing.Size(0, 22)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(82, 22)
        Me.btnApply.TabIndex = 37
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
        Me.btnBack.Location = New System.Drawing.Point(562, 593)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 22)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 22)
        Me.btnBack.TabIndex = 38
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
        Me.btnClear.Location = New System.Drawing.Point(562, 564)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.MinimumSize = New System.Drawing.Size(0, 22)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 22)
        Me.btnClear.TabIndex = 39
        Me.btnClear.Text = "Effacer"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblCmdExec
        '
        Me.lblCmdExec.AutoSize = True
        Me.lblCmdExec.BackColor = System.Drawing.Color.Transparent
        Me.lblCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.lblCmdExec.Location = New System.Drawing.Point(3, 543)
        Me.lblCmdExec.Name = "lblCmdExec"
        Me.lblCmdExec.Size = New System.Drawing.Size(124, 11)
        Me.lblCmdExec.TabIndex = 40
        Me.lblCmdExec.Text = "Commande exécuté:"
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(133, 540)
        Me.txtCmdExec.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(511, 18)
        Me.txtCmdExec.TabIndex = 41
        '
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.BackColor = System.Drawing.Color.Black
        Me.optAdvanceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAdvanceMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAdvanceMode.Location = New System.Drawing.Point(93, 602)
        Me.optAdvanceMode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(98, 15)
        Me.optAdvanceMode.TabIndex = 42
        Me.optAdvanceMode.Text = "Mode avancé"
        Me.optAdvanceMode.UseVisualStyleBackColor = False
        '
        'SystemInfoApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(650, 623)
        Me.ControlBox = False
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.lblCmdExec)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.GuiDosbox_Groupbox3)
        Me.Controls.Add(Me.GuiDosbox_Groupbox4)
        Me.Controls.Add(Me.GuiDosbox_Groupbox2)
        Me.Controls.Add(Me.GuiDosbox_Groupbox1)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.chkbxLangue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SystemInfoApp"
        Me.Text = "GUI Dosbox - SYSTEMINFO"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GuiDosbox_Groupbox1.ResumeLayout(False)
        Me.GuiDosbox_Groupbox1.PerformLayout()
        Me.GuiDosbox_Groupbox2.ResumeLayout(False)
        Me.GuiDosbox_Groupbox2.PerformLayout()
        Me.GuiDosbox_Groupbox3.ResumeLayout(False)
        Me.GuiDosbox_Groupbox3.PerformLayout()
        Me.GuiDosbox_Groupbox4.ResumeLayout(False)
        Me.GuiDosbox_Groupbox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents GuiDosbox_Groupbox1 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optNH As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optFO As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents GuiDosbox_Groupbox2 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optP As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents GuiDosbox_Groupbox3 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optU As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents GuiDosbox_Groupbox4 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optS As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents cbOptFO As GUIDosbox.GUIDosbox_Combobox
    Friend WithEvents txtOptP As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents txtOptU As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents txtOptS As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents btnHelp As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnApply As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnClear As GUIDosbox.GUIDosbox_Button
    Friend WithEvents lblCmdExec As GUIDosbox.GUIDosbox_Label
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
End Class
