<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhoamiApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhoamiApp))
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip6 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip7 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip8 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip9 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip10 = New System.Windows.Forms.ToolTip(Me.components)
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.gbOptionsDomain = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optNull = New GUIDosbox.GUIDosbox_RadioButton()
        Me.optFqdn = New GUIDosbox.GUIDosbox_RadioButton()
        Me.optLogonid = New GUIDosbox.GUIDosbox_RadioButton()
        Me.optUpn = New GUIDosbox.GUIDosbox_RadioButton()
        Me.gbFormat = New GUIDosbox.GUIDosbox_Groupbox()
        Me.cbFormat = New GUIDosbox.GUIDosbox_Combobox()
        Me.optFO = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optNH = New GUIDosbox.GUIDosbox_Checkbox()
        Me.gbOptions = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optUser = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optGroups = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optPriv = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optAll = New GUIDosbox.GUIDosbox_Checkbox()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
        Me.txtCmdExec = New GUIDosbox.GUIDosbox_Textbox()
        Me.lblCmdExec = New GUIDosbox.GUIDosbox_Label()
        Me.optAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        Me.btnClear = New GUIDosbox.GUIDosbox_Button()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnApply = New GUIDosbox.GUIDosbox_Button()
        Me.btnHelp = New GUIDosbox.GUIDosbox_Button()
        Me.footer = New GUIDosbox.GUIDosbox_StatusStrip()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOptionsDomain.SuspendLayout()
        Me.gbFormat.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkbxLangue.Location = New System.Drawing.Point(419, 486)
        Me.chkbxLangue.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 4
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(0, 0)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(753, 40)
        Me.flashHeader.TabIndex = 14
        '
        'gbOptionsDomain
        '
        Me.gbOptionsDomain.BackColor = System.Drawing.Color.Black
        Me.gbOptionsDomain.BorderColor = System.Drawing.Color.LightBlue
        Me.gbOptionsDomain.Controls.Add(Me.optNull)
        Me.gbOptionsDomain.Controls.Add(Me.optFqdn)
        Me.gbOptionsDomain.Controls.Add(Me.optLogonid)
        Me.gbOptionsDomain.Controls.Add(Me.optUpn)
        Me.gbOptionsDomain.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbOptionsDomain.ForeColor = System.Drawing.Color.LightBlue
        Me.gbOptionsDomain.Location = New System.Drawing.Point(244, 46)
        Me.gbOptionsDomain.Name = "gbOptionsDomain"
        Me.gbOptionsDomain.Size = New System.Drawing.Size(200, 100)
        Me.gbOptionsDomain.TabIndex = 0
        Me.gbOptionsDomain.TabStop = False
        Me.gbOptionsDomain.Text = " Options (Domaine)"
        '
        'optNull
        '
        Me.optNull.AutoSize = True
        Me.optNull.BackColor = System.Drawing.Color.Black
        Me.optNull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optNull.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optNull.ForeColor = System.Drawing.Color.Maroon
        Me.optNull.Location = New System.Drawing.Point(112, 64)
        Me.optNull.Name = "optNull"
        Me.optNull.Size = New System.Drawing.Size(50, 15)
        Me.optNull.TabIndex = 23
        Me.optNull.TabStop = True
        Me.optNull.Text = "NULL"
        Me.optNull.UseVisualStyleBackColor = False
        '
        'optFqdn
        '
        Me.optFqdn.AutoSize = True
        Me.optFqdn.BackColor = System.Drawing.Color.Black
        Me.optFqdn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optFqdn.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optFqdn.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optFqdn.Location = New System.Drawing.Point(24, 61)
        Me.optFqdn.Name = "optFqdn"
        Me.optFqdn.Size = New System.Drawing.Size(57, 15)
        Me.optFqdn.TabIndex = 22
        Me.optFqdn.TabStop = True
        Me.optFqdn.Text = "/FQDN"
        Me.optFqdn.UseVisualStyleBackColor = False
        '
        'optLogonid
        '
        Me.optLogonid.AutoSize = True
        Me.optLogonid.BackColor = System.Drawing.Color.Black
        Me.optLogonid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optLogonid.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optLogonid.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optLogonid.Location = New System.Drawing.Point(112, 32)
        Me.optLogonid.Name = "optLogonid"
        Me.optLogonid.Size = New System.Drawing.Size(78, 15)
        Me.optLogonid.TabIndex = 21
        Me.optLogonid.TabStop = True
        Me.optLogonid.Text = "/LOGONID"
        Me.optLogonid.UseVisualStyleBackColor = False
        '
        'optUpn
        '
        Me.optUpn.AutoSize = True
        Me.optUpn.BackColor = System.Drawing.Color.Black
        Me.optUpn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optUpn.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optUpn.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optUpn.Location = New System.Drawing.Point(24, 32)
        Me.optUpn.Name = "optUpn"
        Me.optUpn.Size = New System.Drawing.Size(50, 15)
        Me.optUpn.TabIndex = 20
        Me.optUpn.TabStop = True
        Me.optUpn.Text = "/UPN"
        Me.optUpn.UseVisualStyleBackColor = False
        '
        'gbFormat
        '
        Me.gbFormat.BackColor = System.Drawing.Color.Black
        Me.gbFormat.BorderColor = System.Drawing.Color.LightBlue
        Me.gbFormat.Controls.Add(Me.cbFormat)
        Me.gbFormat.Controls.Add(Me.optFO)
        Me.gbFormat.Controls.Add(Me.optNH)
        Me.gbFormat.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbFormat.ForeColor = System.Drawing.Color.LightBlue
        Me.gbFormat.Location = New System.Drawing.Point(478, 46)
        Me.gbFormat.Name = "gbFormat"
        Me.gbFormat.Size = New System.Drawing.Size(200, 100)
        Me.gbFormat.TabIndex = 0
        Me.gbFormat.TabStop = False
        Me.gbFormat.Text = " Format"
        '
        'cbFormat
        '
        Me.cbFormat.BackColor = System.Drawing.Color.Black
        Me.cbFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFormat.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.cbFormat.ForeColor = System.Drawing.Color.LightBlue
        Me.cbFormat.FormattingEnabled = True
        Me.cbFormat.Location = New System.Drawing.Point(115, 42)
        Me.cbFormat.Name = "cbFormat"
        Me.cbFormat.Size = New System.Drawing.Size(79, 19)
        Me.cbFormat.TabIndex = 5
        '
        'optFO
        '
        Me.optFO.AutoSize = True
        Me.optFO.BackColor = System.Drawing.Color.Black
        Me.optFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optFO.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optFO.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optFO.Location = New System.Drawing.Point(67, 43)
        Me.optFO.Name = "optFO"
        Me.optFO.Size = New System.Drawing.Size(42, 15)
        Me.optFO.TabIndex = 4
        Me.optFO.Text = "/FO"
        Me.optFO.UseVisualStyleBackColor = False
        '
        'optNH
        '
        Me.optNH.AutoSize = True
        Me.optNH.BackColor = System.Drawing.Color.Black
        Me.optNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optNH.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optNH.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optNH.Location = New System.Drawing.Point(19, 43)
        Me.optNH.Name = "optNH"
        Me.optNH.Size = New System.Drawing.Size(42, 15)
        Me.optNH.TabIndex = 3
        Me.optNH.Text = "/NH"
        Me.optNH.UseVisualStyleBackColor = False
        '
        'gbOptions
        '
        Me.gbOptions.BackColor = System.Drawing.Color.Black
        Me.gbOptions.BorderColor = System.Drawing.Color.LightBlue
        Me.gbOptions.Controls.Add(Me.optUser)
        Me.gbOptions.Controls.Add(Me.optGroups)
        Me.gbOptions.Controls.Add(Me.optPriv)
        Me.gbOptions.Controls.Add(Me.optAll)
        Me.gbOptions.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbOptions.ForeColor = System.Drawing.Color.LightBlue
        Me.gbOptions.Location = New System.Drawing.Point(10, 46)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(200, 100)
        Me.gbOptions.TabIndex = 19
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = " Options"
        '
        'optUser
        '
        Me.optUser.AutoSize = True
        Me.optUser.BackColor = System.Drawing.Color.Black
        Me.optUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optUser.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optUser.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optUser.Location = New System.Drawing.Point(18, 32)
        Me.optUser.Name = "optUser"
        Me.optUser.Size = New System.Drawing.Size(56, 15)
        Me.optUser.TabIndex = 3
        Me.optUser.Text = "/USER"
        Me.optUser.UseVisualStyleBackColor = False
        '
        'optGroups
        '
        Me.optGroups.AutoSize = True
        Me.optGroups.BackColor = System.Drawing.Color.Black
        Me.optGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optGroups.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optGroups.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optGroups.Location = New System.Drawing.Point(112, 32)
        Me.optGroups.Name = "optGroups"
        Me.optGroups.Size = New System.Drawing.Size(70, 15)
        Me.optGroups.TabIndex = 2
        Me.optGroups.Text = "/GROUPS"
        Me.optGroups.UseVisualStyleBackColor = False
        '
        'optPriv
        '
        Me.optPriv.AutoSize = True
        Me.optPriv.BackColor = System.Drawing.Color.Black
        Me.optPriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optPriv.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optPriv.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optPriv.Location = New System.Drawing.Point(18, 61)
        Me.optPriv.Name = "optPriv"
        Me.optPriv.Size = New System.Drawing.Size(56, 15)
        Me.optPriv.TabIndex = 1
        Me.optPriv.Text = "/PRIV"
        Me.optPriv.UseVisualStyleBackColor = False
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.BackColor = System.Drawing.Color.Black
        Me.optAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAll.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAll.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAll.Location = New System.Drawing.Point(112, 61)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(49, 15)
        Me.optAll.TabIndex = 0
        Me.optAll.Text = "/ALL"
        Me.optAll.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Black
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnSend.ForeColor = System.Drawing.Color.LightBlue
        Me.btnSend.Location = New System.Drawing.Point(262, 477)
        Me.btnSend.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 18
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(145, 453)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(534, 18)
        Me.txtCmdExec.TabIndex = 17
        '
        'lblCmdExec
        '
        Me.lblCmdExec.AutoSize = True
        Me.lblCmdExec.BackColor = System.Drawing.Color.Transparent
        Me.lblCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.lblCmdExec.Location = New System.Drawing.Point(8, 455)
        Me.lblCmdExec.Name = "lblCmdExec"
        Me.lblCmdExec.Size = New System.Drawing.Size(131, 11)
        Me.lblCmdExec.TabIndex = 16
        Me.lblCmdExec.Text = "Commande exécuté :"
        '
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.BackColor = System.Drawing.Color.Black
        Me.optAdvanceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAdvanceMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAdvanceMode.Location = New System.Drawing.Point(91, 485)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(98, 15)
        Me.optAdvanceMode.TabIndex = 15
        Me.optAdvanceMode.Text = "Mode avancé"
        Me.optAdvanceMode.UseVisualStyleBackColor = False
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(8, 152)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(671, 296)
        Me.myConsole.TabIndex = 13
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.LightBlue
        Me.btnClear.Location = New System.Drawing.Point(524, 477)
        Me.btnClear.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.LightBlue
        Me.btnBack.Location = New System.Drawing.Point(604, 477)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.Black
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnApply.ForeColor = System.Drawing.Color.LightBlue
        Me.btnApply.Location = New System.Drawing.Point(443, 477)
        Me.btnApply.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 10
        Me.btnApply.Text = "Go"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Black
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnHelp.ForeColor = System.Drawing.Color.LightBlue
        Me.btnHelp.Location = New System.Drawing.Point(10, 477)
        Me.btnHelp.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 9
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'footer
        '
        Me.footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footer.Location = New System.Drawing.Point(0, 502)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(685, 22)
        Me.footer.TabIndex = 20
        '
        'WhoamiApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(685, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.gbOptionsDomain)
        Me.Controls.Add(Me.gbFormat)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.lblCmdExec)
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WhoamiApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI DosBox - Whoami"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOptionsDomain.ResumeLayout(False)
        Me.gbOptionsDomain.PerformLayout()
        Me.gbFormat.ResumeLayout(False)
        Me.gbFormat.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip4 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip5 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip6 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip7 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip8 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip9 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip10 As System.Windows.Forms.ToolTip
    Friend WithEvents btnHelp As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnApply As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnClear As GUIDosbox.GUIDosbox_Button
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents lblCmdExec As GUIDosbox.GUIDosbox_Label
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
    Friend WithEvents gbOptions As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optUser As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optGroups As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optPriv As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optAll As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents gbOptionsDomain As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents gbFormat As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optFO As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optNH As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optFqdn As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents optLogonid As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents optUpn As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents optNull As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents cbFormat As GUIDosbox.GUIDosbox_Combobox
    Friend WithEvents footer As GUIDosbox.GUIDosbox_StatusStrip
End Class
