<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhereApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhereApp))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.optAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        Me.btnClear = New GUIDosbox.GUIDosbox_Button()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnApply = New GUIDosbox.GUIDosbox_Button()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
        Me.btnHelp = New GUIDosbox.GUIDosbox_Button()
        Me.GuiDosbox_Label1 = New GUIDosbox.GUIDosbox_Label()
        Me.txtCmdExec = New GUIDosbox.GUIDosbox_Textbox()
        Me.GuiDosbox_Groupbox2 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.OptQ = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optF = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptT = New GUIDosbox.GUIDosbox_Checkbox()
        Me.GuiDosbox_Groupbox1 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.txtSource = New GUIDosbox.GUIDosbox_Textbox()
        Me.btnDossier = New GUIDosbox.GUIDosbox_Button()
        Me.txtModele = New GUIDosbox.GUIDosbox_Textbox()
        Me.OptR = New GUIDosbox.GUIDosbox_Checkbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        Me.footer = New GUIDosbox.GUIDosbox_StatusStrip()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GuiDosbox_Groupbox2.SuspendLayout()
        Me.GuiDosbox_Groupbox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(-1, 0)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(610, 40)
        Me.flashHeader.TabIndex = 25
        '
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.BackColor = System.Drawing.Color.Black
        Me.optAdvanceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAdvanceMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAdvanceMode.Location = New System.Drawing.Point(93, 502)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(98, 15)
        Me.optAdvanceMode.TabIndex = 35
        Me.optAdvanceMode.Text = "Mode Avancé"
        Me.optAdvanceMode.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.LightBlue
        Me.btnClear.Location = New System.Drawing.Point(519, 469)
        Me.btnClear.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 23)
        Me.btnClear.TabIndex = 34
        Me.btnClear.Text = "Effacer"
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
        Me.btnBack.Location = New System.Drawing.Point(519, 494)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 23)
        Me.btnBack.TabIndex = 33
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
        Me.btnApply.Location = New System.Drawing.Point(435, 494)
        Me.btnApply.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(82, 23)
        Me.btnApply.TabIndex = 32
        Me.btnApply.Text = "Appliquer"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Black
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnSend.ForeColor = System.Drawing.Color.LightBlue
        Me.btnSend.Location = New System.Drawing.Point(245, 469)
        Me.btnSend.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(82, 23)
        Me.btnSend.TabIndex = 31
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Black
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnHelp.ForeColor = System.Drawing.Color.LightBlue
        Me.btnHelp.Location = New System.Drawing.Point(5, 494)
        Me.btnHelp.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(82, 23)
        Me.btnHelp.TabIndex = 30
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'GuiDosbox_Label1
        '
        Me.GuiDosbox_Label1.AutoSize = True
        Me.GuiDosbox_Label1.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label1.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Label1.Location = New System.Drawing.Point(3, 449)
        Me.GuiDosbox_Label1.Name = "GuiDosbox_Label1"
        Me.GuiDosbox_Label1.Size = New System.Drawing.Size(131, 11)
        Me.GuiDosbox_Label1.TabIndex = 29
        Me.GuiDosbox_Label1.Text = "Commande exécuté :"
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(140, 445)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(461, 18)
        Me.txtCmdExec.TabIndex = 28
        '
        'GuiDosbox_Groupbox2
        '
        Me.GuiDosbox_Groupbox2.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox2.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox2.Controls.Add(Me.OptQ)
        Me.GuiDosbox_Groupbox2.Controls.Add(Me.optF)
        Me.GuiDosbox_Groupbox2.Controls.Add(Me.OptT)
        Me.GuiDosbox_Groupbox2.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox2.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox2.Location = New System.Drawing.Point(466, 43)
        Me.GuiDosbox_Groupbox2.Name = "GuiDosbox_Groupbox2"
        Me.GuiDosbox_Groupbox2.Size = New System.Drawing.Size(135, 78)
        Me.GuiDosbox_Groupbox2.TabIndex = 27
        Me.GuiDosbox_Groupbox2.TabStop = False
        Me.GuiDosbox_Groupbox2.Text = " Options"
        '
        'OptQ
        '
        Me.OptQ.AutoSize = True
        Me.OptQ.BackColor = System.Drawing.Color.Black
        Me.OptQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptQ.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptQ.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptQ.Location = New System.Drawing.Point(70, 41)
        Me.OptQ.Name = "OptQ"
        Me.OptQ.Size = New System.Drawing.Size(35, 15)
        Me.OptQ.TabIndex = 8
        Me.OptQ.Text = "/Q"
        Me.OptQ.UseVisualStyleBackColor = False
        '
        'optF
        '
        Me.optF.AutoSize = True
        Me.optF.BackColor = System.Drawing.Color.Black
        Me.optF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optF.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optF.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optF.Location = New System.Drawing.Point(29, 41)
        Me.optF.Name = "optF"
        Me.optF.Size = New System.Drawing.Size(35, 15)
        Me.optF.TabIndex = 9
        Me.optF.Text = "/F"
        Me.optF.UseVisualStyleBackColor = False
        '
        'OptT
        '
        Me.OptT.AutoSize = True
        Me.OptT.BackColor = System.Drawing.Color.Black
        Me.OptT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptT.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptT.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptT.Location = New System.Drawing.Point(29, 21)
        Me.OptT.Name = "OptT"
        Me.OptT.Size = New System.Drawing.Size(35, 15)
        Me.OptT.TabIndex = 10
        Me.OptT.Text = "/T"
        Me.OptT.UseVisualStyleBackColor = False
        '
        'GuiDosbox_Groupbox1
        '
        Me.GuiDosbox_Groupbox1.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox1.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.txtSource)
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.btnDossier)
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.txtModele)
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.OptR)
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.Label1)
        Me.GuiDosbox_Groupbox1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox1.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox1.Location = New System.Drawing.Point(5, 43)
        Me.GuiDosbox_Groupbox1.Name = "GuiDosbox_Groupbox1"
        Me.GuiDosbox_Groupbox1.Size = New System.Drawing.Size(457, 78)
        Me.GuiDosbox_Groupbox1.TabIndex = 26
        Me.GuiDosbox_Groupbox1.TabStop = False
        Me.GuiDosbox_Groupbox1.Text = " Rechercher dans :"
        '
        'txtSource
        '
        Me.txtSource.BackColor = System.Drawing.Color.Black
        Me.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSource.Enabled = False
        Me.txtSource.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtSource.ForeColor = System.Drawing.Color.LightBlue
        Me.txtSource.Location = New System.Drawing.Point(94, 19)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(355, 18)
        Me.txtSource.TabIndex = 30
        '
        'btnDossier
        '
        Me.btnDossier.BackColor = System.Drawing.Color.Black
        Me.btnDossier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDossier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDossier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDossier.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnDossier.ForeColor = System.Drawing.Color.LightBlue
        Me.btnDossier.Location = New System.Drawing.Point(6, 17)
        Me.btnDossier.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnDossier.Name = "btnDossier"
        Me.btnDossier.Size = New System.Drawing.Size(82, 23)
        Me.btnDossier.TabIndex = 28
        Me.btnDossier.Text = "Parcourir"
        Me.btnDossier.UseVisualStyleBackColor = False
        '
        'txtModele
        '
        Me.txtModele.BackColor = System.Drawing.Color.Black
        Me.txtModele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModele.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtModele.ForeColor = System.Drawing.Color.LightBlue
        Me.txtModele.Location = New System.Drawing.Point(94, 41)
        Me.txtModele.Name = "txtModele"
        Me.txtModele.Size = New System.Drawing.Size(100, 18)
        Me.txtModele.TabIndex = 29
        '
        'OptR
        '
        Me.OptR.AutoSize = True
        Me.OptR.BackColor = System.Drawing.Color.Black
        Me.OptR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptR.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptR.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptR.Location = New System.Drawing.Point(200, 42)
        Me.OptR.Name = "OptR"
        Me.OptR.Size = New System.Drawing.Size(35, 15)
        Me.OptR.TabIndex = 28
        Me.OptR.Text = "/R"
        Me.OptR.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 11)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modèle :"
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(5, 127)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(596, 312)
        Me.myConsole.TabIndex = 24
        '
        'footer
        '
        Me.footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footer.Location = New System.Drawing.Point(0, 519)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(605, 22)
        Me.footer.TabIndex = 36
        '
        'WhereApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(605, 541)
        Me.ControlBox = False
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.GuiDosbox_Label1)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.GuiDosbox_Groupbox2)
        Me.Controls.Add(Me.GuiDosbox_Groupbox1)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.ForeColor = System.Drawing.Color.LightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WhereApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI Dosbox - WHERE"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GuiDosbox_Groupbox2.ResumeLayout(False)
        Me.GuiDosbox_Groupbox2.PerformLayout()
        Me.GuiDosbox_Groupbox1.ResumeLayout(False)
        Me.GuiDosbox_Groupbox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents GuiDosbox_Groupbox1 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents txtSource As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents btnDossier As GUIDosbox.GUIDosbox_Button
    Friend WithEvents txtModele As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents OptR As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GuiDosbox_Groupbox2 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents OptQ As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optF As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptT As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents GuiDosbox_Label1 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents btnHelp As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnApply As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnClear As GUIDosbox.GUIDosbox_Button
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents footer As GUIDosbox.GUIDosbox_StatusStrip
End Class
