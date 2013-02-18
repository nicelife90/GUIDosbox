<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUBSTApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SUBSTApp))
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.gbLecteur = New GUIDosbox.GUIDosbox_Groupbox()
        Me.cbLecteur = New GUIDosbox.GUIDosbox_Combobox()
        Me.gbDossier = New GUIDosbox.GUIDosbox_Groupbox()
        Me.btnDossier = New GUIDosbox.GUIDosbox_Button()
        Me.txtDossier = New GUIDosbox.GUIDosbox_Textbox()
        Me.gbOption = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optLister = New GUIDosbox.GUIDosbox_Checkbox()
        Me.gbDelete = New GUIDosbox.GUIDosbox_Groupbox()
        Me.cbDelete = New GUIDosbox.GUIDosbox_Combobox()
        Me.optD = New GUIDosbox.GUIDosbox_Checkbox()
        Me.txtCmdExec = New GUIDosbox.GUIDosbox_Textbox()
        Me.optAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        Me.lblCmdExec = New GUIDosbox.GUIDosbox_Label()
        Me.btnHelp = New GUIDosbox.GUIDosbox_Button()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnClear = New GUIDosbox.GUIDosbox_Button()
        Me.btnApply = New GUIDosbox.GUIDosbox_Button()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        Me.footer = New GUIDosbox.GUIDosbox_StatusStrip()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLecteur.SuspendLayout()
        Me.gbDossier.SuspendLayout()
        Me.gbOption.SuspendLayout()
        Me.gbDelete.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(22, 495)
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
        Me.flashHeader.Size = New System.Drawing.Size(666, 40)
        Me.flashHeader.TabIndex = 27
        '
        'gbLecteur
        '
        Me.gbLecteur.BackColor = System.Drawing.Color.Black
        Me.gbLecteur.BorderColor = System.Drawing.Color.LightBlue
        Me.gbLecteur.Controls.Add(Me.cbLecteur)
        Me.gbLecteur.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbLecteur.ForeColor = System.Drawing.Color.LightBlue
        Me.gbLecteur.Location = New System.Drawing.Point(137, 44)
        Me.gbLecteur.Name = "gbLecteur"
        Me.gbLecteur.Size = New System.Drawing.Size(106, 68)
        Me.gbLecteur.TabIndex = 3
        Me.gbLecteur.TabStop = False
        Me.gbLecteur.Text = " Lecteur"
        '
        'cbLecteur
        '
        Me.cbLecteur.BackColor = System.Drawing.Color.Black
        Me.cbLecteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLecteur.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.cbLecteur.ForeColor = System.Drawing.Color.LightBlue
        Me.cbLecteur.FormattingEnabled = True
        Me.cbLecteur.Location = New System.Drawing.Point(17, 25)
        Me.cbLecteur.Name = "cbLecteur"
        Me.cbLecteur.Size = New System.Drawing.Size(73, 19)
        Me.cbLecteur.TabIndex = 2
        '
        'gbDossier
        '
        Me.gbDossier.BackColor = System.Drawing.Color.Black
        Me.gbDossier.BorderColor = System.Drawing.Color.LightBlue
        Me.gbDossier.Controls.Add(Me.btnDossier)
        Me.gbDossier.Controls.Add(Me.txtDossier)
        Me.gbDossier.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbDossier.ForeColor = System.Drawing.Color.LightBlue
        Me.gbDossier.Location = New System.Drawing.Point(245, 44)
        Me.gbDossier.Name = "gbDossier"
        Me.gbDossier.Size = New System.Drawing.Size(280, 68)
        Me.gbDossier.TabIndex = 39
        Me.gbDossier.TabStop = False
        Me.gbDossier.Text = " Dossier"
        '
        'btnDossier
        '
        Me.btnDossier.BackColor = System.Drawing.Color.Black
        Me.btnDossier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDossier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDossier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDossier.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnDossier.ForeColor = System.Drawing.Color.LightBlue
        Me.btnDossier.Location = New System.Drawing.Point(8, 17)
        Me.btnDossier.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnDossier.Name = "btnDossier"
        Me.btnDossier.Size = New System.Drawing.Size(82, 23)
        Me.btnDossier.TabIndex = 1
        Me.btnDossier.Text = "Parcourir"
        Me.btnDossier.UseVisualStyleBackColor = False
        '
        'txtDossier
        '
        Me.txtDossier.BackColor = System.Drawing.Color.Black
        Me.txtDossier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDossier.Enabled = False
        Me.txtDossier.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtDossier.ForeColor = System.Drawing.Color.LightBlue
        Me.txtDossier.Location = New System.Drawing.Point(8, 44)
        Me.txtDossier.Name = "txtDossier"
        Me.txtDossier.Size = New System.Drawing.Size(265, 18)
        Me.txtDossier.TabIndex = 0
        '
        'gbOption
        '
        Me.gbOption.BackColor = System.Drawing.Color.Black
        Me.gbOption.BorderColor = System.Drawing.Color.LightBlue
        Me.gbOption.Controls.Add(Me.optLister)
        Me.gbOption.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbOption.ForeColor = System.Drawing.Color.LightBlue
        Me.gbOption.Location = New System.Drawing.Point(7, 44)
        Me.gbOption.Name = "gbOption"
        Me.gbOption.Size = New System.Drawing.Size(128, 68)
        Me.gbOption.TabIndex = 38
        Me.gbOption.TabStop = False
        Me.gbOption.Text = " Option"
        '
        'optLister
        '
        Me.optLister.AutoSize = True
        Me.optLister.BackColor = System.Drawing.Color.Black
        Me.optLister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optLister.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optLister.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optLister.Location = New System.Drawing.Point(5, 27)
        Me.optLister.Name = "optLister"
        Me.optLister.Size = New System.Drawing.Size(119, 15)
        Me.optLister.TabIndex = 0
        Me.optLister.Text = "Lister lecteur"
        Me.optLister.UseVisualStyleBackColor = False
        '
        'gbDelete
        '
        Me.gbDelete.BackColor = System.Drawing.Color.Black
        Me.gbDelete.BorderColor = System.Drawing.Color.LightBlue
        Me.gbDelete.Controls.Add(Me.cbDelete)
        Me.gbDelete.Controls.Add(Me.optD)
        Me.gbDelete.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbDelete.ForeColor = System.Drawing.Color.LightBlue
        Me.gbDelete.Location = New System.Drawing.Point(527, 44)
        Me.gbDelete.Name = "gbDelete"
        Me.gbDelete.Size = New System.Drawing.Size(128, 68)
        Me.gbDelete.TabIndex = 37
        Me.gbDelete.TabStop = False
        Me.gbDelete.Text = " Supprimer"
        '
        'cbDelete
        '
        Me.cbDelete.BackColor = System.Drawing.Color.Black
        Me.cbDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDelete.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.cbDelete.ForeColor = System.Drawing.Color.LightBlue
        Me.cbDelete.FormattingEnabled = True
        Me.cbDelete.Location = New System.Drawing.Point(51, 25)
        Me.cbDelete.Name = "cbDelete"
        Me.cbDelete.Size = New System.Drawing.Size(68, 19)
        Me.cbDelete.TabIndex = 29
        '
        'optD
        '
        Me.optD.AutoSize = True
        Me.optD.BackColor = System.Drawing.Color.Black
        Me.optD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optD.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optD.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optD.Location = New System.Drawing.Point(10, 27)
        Me.optD.Name = "optD"
        Me.optD.Size = New System.Drawing.Size(35, 15)
        Me.optD.TabIndex = 28
        Me.optD.Text = "/D"
        Me.optD.UseVisualStyleBackColor = False
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(137, 467)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(518, 18)
        Me.txtCmdExec.TabIndex = 36
        '
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.BackColor = System.Drawing.Color.Black
        Me.optAdvanceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAdvanceMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAdvanceMode.Location = New System.Drawing.Point(95, 527)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(98, 15)
        Me.optAdvanceMode.TabIndex = 35
        Me.optAdvanceMode.Text = "Mode avancé"
        Me.optAdvanceMode.UseVisualStyleBackColor = False
        '
        'lblCmdExec
        '
        Me.lblCmdExec.AutoSize = True
        Me.lblCmdExec.BackColor = System.Drawing.Color.Transparent
        Me.lblCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.lblCmdExec.Location = New System.Drawing.Point(5, 470)
        Me.lblCmdExec.Name = "lblCmdExec"
        Me.lblCmdExec.Size = New System.Drawing.Size(131, 11)
        Me.lblCmdExec.TabIndex = 34
        Me.lblCmdExec.Text = "Commande exécuté :"
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Black
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnHelp.ForeColor = System.Drawing.Color.LightBlue
        Me.btnHelp.Location = New System.Drawing.Point(7, 519)
        Me.btnHelp.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(82, 23)
        Me.btnHelp.TabIndex = 33
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.LightBlue
        Me.btnBack.Location = New System.Drawing.Point(573, 519)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 23)
        Me.btnBack.TabIndex = 32
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
        Me.btnClear.Location = New System.Drawing.Point(573, 490)
        Me.btnClear.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 23)
        Me.btnClear.TabIndex = 31
        Me.btnClear.Text = "Effacer"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.Black
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnApply.ForeColor = System.Drawing.Color.LightBlue
        Me.btnApply.Location = New System.Drawing.Point(485, 519)
        Me.btnApply.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(82, 23)
        Me.btnApply.TabIndex = 30
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
        Me.btnSend.Location = New System.Drawing.Point(290, 491)
        Me.btnSend.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(82, 23)
        Me.btnSend.TabIndex = 29
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(7, 117)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(648, 346)
        Me.myConsole.TabIndex = 26
        '
        'footer
        '
        Me.footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footer.Location = New System.Drawing.Point(0, 543)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(663, 22)
        Me.footer.TabIndex = 40
        '
        'SUBSTApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(663, 565)
        Me.ControlBox = False
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.gbLecteur)
        Me.Controls.Add(Me.gbDossier)
        Me.Controls.Add(Me.gbOption)
        Me.Controls.Add(Me.gbDelete)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.lblCmdExec)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.ForeColor = System.Drawing.Color.LightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SUBSTApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI DosBox - SUBST"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLecteur.ResumeLayout(False)
        Me.gbDossier.ResumeLayout(False)
        Me.gbDossier.PerformLayout()
        Me.gbOption.ResumeLayout(False)
        Me.gbOption.PerformLayout()
        Me.gbDelete.ResumeLayout(False)
        Me.gbDelete.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents optD As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnApply As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnClear As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnHelp As GUIDosbox.GUIDosbox_Button
    Friend WithEvents lblCmdExec As GUIDosbox.GUIDosbox_Label
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents gbDelete As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents cbDelete As GUIDosbox.GUIDosbox_Combobox
    Friend WithEvents gbOption As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optLister As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents gbDossier As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents btnDossier As GUIDosbox.GUIDosbox_Button
    Friend WithEvents txtDossier As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents cbLecteur As GUIDosbox.GUIDosbox_Combobox
    Friend WithEvents gbLecteur As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents footer As GUIDosbox.GUIDosbox_StatusStrip
End Class
