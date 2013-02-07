<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RDApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RDApp))
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
        Me.optAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        Me.btnApply = New GUIDosbox.GUIDosbox_Button()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnClear = New GUIDosbox.GUIDosbox_Button()
        Me.btnHelp = New GUIDosbox.GUIDosbox_Button()
        Me.txtCmdExec = New GUIDosbox.GUIDosbox_Textbox()
        Me.lblCmdExec = New GUIDosbox.GUIDosbox_Label()
        Me.gbDossier = New GUIDosbox.GUIDosbox_Groupbox()
        Me.txtPath = New GUIDosbox.GUIDosbox_Textbox()
        Me.btnDossier = New GUIDosbox.GUIDosbox_Button()
        Me.GuiDosbox_Groupbox1 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optQ = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optS = New GUIDosbox.GUIDosbox_Checkbox()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDossier.SuspendLayout()
        Me.GuiDosbox_Groupbox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(43, 443)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 19
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(0, -1)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(643, 40)
        Me.flashHeader.TabIndex = 27
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Black
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnSend.ForeColor = System.Drawing.Color.LightBlue
        Me.btnSend.Location = New System.Drawing.Point(319, 438)
        Me.btnSend.MinimumSize = New System.Drawing.Size(0, 19)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(96, 23)
        Me.btnSend.TabIndex = 37
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.BackColor = System.Drawing.Color.Black
        Me.optAdvanceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAdvanceMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAdvanceMode.Location = New System.Drawing.Point(107, 471)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(98, 15)
        Me.optAdvanceMode.TabIndex = 36
        Me.optAdvanceMode.Text = "Mode avancé"
        Me.optAdvanceMode.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.Black
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnApply.ForeColor = System.Drawing.Color.LightBlue
        Me.btnApply.Location = New System.Drawing.Point(437, 464)
        Me.btnApply.MinimumSize = New System.Drawing.Size(0, 19)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(96, 23)
        Me.btnApply.TabIndex = 35
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
        Me.btnBack.Location = New System.Drawing.Point(536, 464)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 19)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(96, 23)
        Me.btnBack.TabIndex = 34
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
        Me.btnClear.Location = New System.Drawing.Point(536, 438)
        Me.btnClear.MinimumSize = New System.Drawing.Size(0, 19)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 23)
        Me.btnClear.TabIndex = 33
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
        Me.btnHelp.Location = New System.Drawing.Point(5, 464)
        Me.btnHelp.MinimumSize = New System.Drawing.Size(0, 19)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(96, 23)
        Me.btnHelp.TabIndex = 32
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(140, 417)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(492, 18)
        Me.txtCmdExec.TabIndex = 31
        '
        'lblCmdExec
        '
        Me.lblCmdExec.AutoSize = True
        Me.lblCmdExec.BackColor = System.Drawing.Color.Transparent
        Me.lblCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.lblCmdExec.Location = New System.Drawing.Point(3, 420)
        Me.lblCmdExec.Name = "lblCmdExec"
        Me.lblCmdExec.Size = New System.Drawing.Size(131, 11)
        Me.lblCmdExec.TabIndex = 30
        Me.lblCmdExec.Text = "Commande exécuté :"
        '
        'gbDossier
        '
        Me.gbDossier.BackColor = System.Drawing.Color.Black
        Me.gbDossier.BorderColor = System.Drawing.Color.LightBlue
        Me.gbDossier.Controls.Add(Me.txtPath)
        Me.gbDossier.Controls.Add(Me.btnDossier)
        Me.gbDossier.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbDossier.ForeColor = System.Drawing.Color.LightBlue
        Me.gbDossier.Location = New System.Drawing.Point(5, 45)
        Me.gbDossier.Name = "gbDossier"
        Me.gbDossier.Size = New System.Drawing.Size(514, 56)
        Me.gbDossier.TabIndex = 29
        Me.gbDossier.TabStop = False
        Me.gbDossier.Text = " Dossier"
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.Color.Black
        Me.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPath.Enabled = False
        Me.txtPath.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtPath.ForeColor = System.Drawing.Color.LightBlue
        Me.txtPath.Location = New System.Drawing.Point(110, 22)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(398, 18)
        Me.txtPath.TabIndex = 1
        '
        'btnDossier
        '
        Me.btnDossier.BackColor = System.Drawing.Color.Black
        Me.btnDossier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDossier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDossier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDossier.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnDossier.ForeColor = System.Drawing.Color.LightBlue
        Me.btnDossier.Location = New System.Drawing.Point(7, 20)
        Me.btnDossier.MinimumSize = New System.Drawing.Size(0, 19)
        Me.btnDossier.Name = "btnDossier"
        Me.btnDossier.Size = New System.Drawing.Size(96, 23)
        Me.btnDossier.TabIndex = 0
        Me.btnDossier.Text = "Parcourir"
        Me.btnDossier.UseVisualStyleBackColor = False
        '
        'GuiDosbox_Groupbox1
        '
        Me.GuiDosbox_Groupbox1.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox1.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.optQ)
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.optS)
        Me.GuiDosbox_Groupbox1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox1.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox1.Location = New System.Drawing.Point(525, 45)
        Me.GuiDosbox_Groupbox1.Name = "GuiDosbox_Groupbox1"
        Me.GuiDosbox_Groupbox1.Size = New System.Drawing.Size(107, 56)
        Me.GuiDosbox_Groupbox1.TabIndex = 28
        Me.GuiDosbox_Groupbox1.TabStop = False
        Me.GuiDosbox_Groupbox1.Text = " Options"
        '
        'optQ
        '
        Me.optQ.AutoSize = True
        Me.optQ.BackColor = System.Drawing.Color.Black
        Me.optQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optQ.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optQ.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optQ.Location = New System.Drawing.Point(60, 22)
        Me.optQ.Name = "optQ"
        Me.optQ.Size = New System.Drawing.Size(35, 15)
        Me.optQ.TabIndex = 31
        Me.optQ.Text = "/Q"
        Me.optQ.UseVisualStyleBackColor = False
        '
        'optS
        '
        Me.optS.AutoSize = True
        Me.optS.BackColor = System.Drawing.Color.Black
        Me.optS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optS.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optS.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optS.Location = New System.Drawing.Point(12, 22)
        Me.optS.Name = "optS"
        Me.optS.Size = New System.Drawing.Size(35, 15)
        Me.optS.TabIndex = 30
        Me.optS.Text = "/S"
        Me.optS.UseVisualStyleBackColor = False
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(5, 107)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(627, 304)
        Me.myConsole.TabIndex = 26
        '
        'RDApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(638, 493)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.lblCmdExec)
        Me.Controls.Add(Me.gbDossier)
        Me.Controls.Add(Me.GuiDosbox_Groupbox1)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.LightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RDApp"
        Me.Text = "GUI DosBox - RD"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDossier.ResumeLayout(False)
        Me.gbDossier.PerformLayout()
        Me.GuiDosbox_Groupbox1.ResumeLayout(False)
        Me.GuiDosbox_Groupbox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents GuiDosbox_Groupbox1 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optS As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents gbDossier As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents txtPath As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents btnDossier As GUIDosbox.GUIDosbox_Button
    Friend WithEvents optQ As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents lblCmdExec As GUIDosbox.GUIDosbox_Label
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents btnHelp As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnClear As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnApply As GUIDosbox.GUIDosbox_Button
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
End Class
