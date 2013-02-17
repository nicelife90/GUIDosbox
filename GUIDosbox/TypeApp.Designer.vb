<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypeApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TypeApp))
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.txtCmdExec = New GUIDosbox.GUIDosbox_Textbox()
        Me.lblCmdExec = New GUIDosbox.GUIDosbox_Label()
        Me.optAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        Me.GuiDosbox_Groupbox1 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.txtPathFichier = New GUIDosbox.GUIDosbox_Textbox()
        Me.btnFichier = New GUIDosbox.GUIDosbox_Button()
        Me.btnClear = New GUIDosbox.GUIDosbox_Button()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnApply = New GUIDosbox.GUIDosbox_Button()
        Me.btnHelp = New GUIDosbox.GUIDosbox_Button()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        Me.footer = New GUIDosbox.GUIDosbox_StatusStrip()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GuiDosbox_Groupbox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(5, 518)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 19
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(0, -1)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(763, 40)
        Me.flashHeader.TabIndex = 24
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(140, 485)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(603, 18)
        Me.txtCmdExec.TabIndex = 34
        '
        'lblCmdExec
        '
        Me.lblCmdExec.AutoSize = True
        Me.lblCmdExec.BackColor = System.Drawing.Color.Transparent
        Me.lblCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.lblCmdExec.Location = New System.Drawing.Point(3, 489)
        Me.lblCmdExec.Name = "lblCmdExec"
        Me.lblCmdExec.Size = New System.Drawing.Size(131, 11)
        Me.lblCmdExec.TabIndex = 33
        Me.lblCmdExec.Text = "Commande exécuté :"
        '
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.BackColor = System.Drawing.Color.Black
        Me.optAdvanceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAdvanceMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAdvanceMode.Location = New System.Drawing.Point(93, 546)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(98, 15)
        Me.optAdvanceMode.TabIndex = 32
        Me.optAdvanceMode.Text = "Mode avancé"
        Me.optAdvanceMode.UseVisualStyleBackColor = False
        '
        'GuiDosbox_Groupbox1
        '
        Me.GuiDosbox_Groupbox1.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox1.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.txtPathFichier)
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.btnFichier)
        Me.GuiDosbox_Groupbox1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox1.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox1.Location = New System.Drawing.Point(5, 43)
        Me.GuiDosbox_Groupbox1.Name = "GuiDosbox_Groupbox1"
        Me.GuiDosbox_Groupbox1.Size = New System.Drawing.Size(738, 74)
        Me.GuiDosbox_Groupbox1.TabIndex = 31
        Me.GuiDosbox_Groupbox1.TabStop = False
        Me.GuiDosbox_Groupbox1.Text = " Fichier à lire"
        '
        'txtPathFichier
        '
        Me.txtPathFichier.BackColor = System.Drawing.Color.Black
        Me.txtPathFichier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPathFichier.Enabled = False
        Me.txtPathFichier.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtPathFichier.ForeColor = System.Drawing.Color.LightBlue
        Me.txtPathFichier.Location = New System.Drawing.Point(95, 28)
        Me.txtPathFichier.Name = "txtPathFichier"
        Me.txtPathFichier.Size = New System.Drawing.Size(637, 18)
        Me.txtPathFichier.TabIndex = 33
        '
        'btnFichier
        '
        Me.btnFichier.BackColor = System.Drawing.Color.Black
        Me.btnFichier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFichier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnFichier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFichier.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnFichier.ForeColor = System.Drawing.Color.LightBlue
        Me.btnFichier.Location = New System.Drawing.Point(7, 26)
        Me.btnFichier.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnFichier.Name = "btnFichier"
        Me.btnFichier.Size = New System.Drawing.Size(82, 23)
        Me.btnFichier.TabIndex = 32
        Me.btnFichier.Text = "Parcourir"
        Me.btnFichier.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.LightBlue
        Me.btnClear.Location = New System.Drawing.Point(661, 509)
        Me.btnClear.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 23)
        Me.btnClear.TabIndex = 30
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
        Me.btnBack.Location = New System.Drawing.Point(661, 538)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 23)
        Me.btnBack.TabIndex = 29
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
        Me.btnApply.Location = New System.Drawing.Point(573, 538)
        Me.btnApply.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(82, 23)
        Me.btnApply.TabIndex = 28
        Me.btnApply.Text = "Appliquer"
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
        Me.btnHelp.Location = New System.Drawing.Point(5, 538)
        Me.btnHelp.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(82, 23)
        Me.btnHelp.TabIndex = 27
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
        Me.btnSend.Location = New System.Drawing.Point(333, 509)
        Me.btnSend.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(82, 23)
        Me.btnSend.TabIndex = 26
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(5, 123)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(738, 356)
        Me.myConsole.TabIndex = 23
        '
        'footer
        '
        Me.footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footer.Location = New System.Drawing.Point(0, 563)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(748, 22)
        Me.footer.TabIndex = 35
        '
        'TypeApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(748, 585)
        Me.ControlBox = False
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.lblCmdExec)
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.GuiDosbox_Groupbox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.ForeColor = System.Drawing.Color.LightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TypeApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI DosBox - TYPE"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GuiDosbox_Groupbox1.ResumeLayout(False)
        Me.GuiDosbox_Groupbox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnHelp As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnApply As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnClear As GUIDosbox.GUIDosbox_Button
    Friend WithEvents GuiDosbox_Groupbox1 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents txtPathFichier As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents btnFichier As GUIDosbox.GUIDosbox_Button
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents lblCmdExec As GUIDosbox.GUIDosbox_Label
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents footer As GUIDosbox.GUIDosbox_StatusStrip
End Class
