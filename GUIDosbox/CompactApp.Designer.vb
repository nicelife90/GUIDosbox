<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompactApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompactApp))
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.gbMode = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optC = New GUIDosbox.GUIDosbox_RadioButton()
        Me.optU = New GUIDosbox.GUIDosbox_RadioButton()
        Me.gbDossier = New GUIDosbox.GUIDosbox_Groupbox()
        Me.btnDossier = New GUIDosbox.GUIDosbox_Button()
        Me.optS = New GUIDosbox.GUIDosbox_Checkbox()
        Me.txtAllPath = New GUIDosbox.GUIDosbox_Textbox()
        Me.gbOptions = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optA = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optQ = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optF = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optI = New GUIDosbox.GUIDosbox_Checkbox()
        Me.txtRealPath = New GUIDosbox.GUIDosbox_Textbox()
        Me.btnFichier = New GUIDosbox.GUIDosbox_Button()
        Me.txtCmdExec = New GUIDosbox.GUIDosbox_Textbox()
        Me.lblCmdExec = New GUIDosbox.GUIDosbox_Label()
        Me.optAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
        Me.btnApply = New GUIDosbox.GUIDosbox_Button()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnClear = New GUIDosbox.GUIDosbox_Button()
        Me.btnHelp = New GUIDosbox.GUIDosbox_Button()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        Me.footer = New GUIDosbox.GUIDosbox_StatusStrip()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMode.SuspendLayout()
        Me.gbDossier.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(5, 427)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 16
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(-1, 0)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(526, 40)
        Me.flashHeader.TabIndex = 18
        '
        'gbMode
        '
        Me.gbMode.BackColor = System.Drawing.Color.Black
        Me.gbMode.BorderColor = System.Drawing.Color.LightBlue
        Me.gbMode.Controls.Add(Me.optC)
        Me.gbMode.Controls.Add(Me.optU)
        Me.gbMode.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbMode.ForeColor = System.Drawing.Color.LightBlue
        Me.gbMode.Location = New System.Drawing.Point(47, 44)
        Me.gbMode.Name = "gbMode"
        Me.gbMode.Size = New System.Drawing.Size(139, 64)
        Me.gbMode.TabIndex = 39
        Me.gbMode.TabStop = False
        Me.gbMode.Text = " Mode"
        '
        'optC
        '
        Me.optC.AutoSize = True
        Me.optC.BackColor = System.Drawing.Color.Black
        Me.optC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optC.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optC.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optC.Location = New System.Drawing.Point(8, 21)
        Me.optC.Name = "optC"
        Me.optC.Size = New System.Drawing.Size(113, 15)
        Me.optC.TabIndex = 37
        Me.optC.TabStop = True
        Me.optC.Text = "Compresser /C"
        Me.optC.UseVisualStyleBackColor = False
        '
        'optU
        '
        Me.optU.AutoSize = True
        Me.optU.BackColor = System.Drawing.Color.Black
        Me.optU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optU.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optU.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optU.Location = New System.Drawing.Point(8, 37)
        Me.optU.Name = "optU"
        Me.optU.Size = New System.Drawing.Size(127, 15)
        Me.optU.TabIndex = 38
        Me.optU.TabStop = True
        Me.optU.Text = "Décompresser /U"
        Me.optU.UseVisualStyleBackColor = False
        '
        'gbDossier
        '
        Me.gbDossier.BackColor = System.Drawing.Color.Black
        Me.gbDossier.BorderColor = System.Drawing.Color.LightBlue
        Me.gbDossier.Controls.Add(Me.btnDossier)
        Me.gbDossier.Controls.Add(Me.optS)
        Me.gbDossier.Controls.Add(Me.txtAllPath)
        Me.gbDossier.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbDossier.ForeColor = System.Drawing.Color.LightBlue
        Me.gbDossier.Location = New System.Drawing.Point(192, 44)
        Me.gbDossier.Name = "gbDossier"
        Me.gbDossier.Size = New System.Drawing.Size(257, 64)
        Me.gbDossier.TabIndex = 36
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
        Me.btnDossier.Location = New System.Drawing.Point(176, 11)
        Me.btnDossier.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnDossier.Name = "btnDossier"
        Me.btnDossier.Size = New System.Drawing.Size(75, 23)
        Me.btnDossier.TabIndex = 2
        Me.btnDossier.Text = "Dossier"
        Me.btnDossier.UseVisualStyleBackColor = False
        '
        'optS
        '
        Me.optS.AutoSize = True
        Me.optS.BackColor = System.Drawing.Color.Black
        Me.optS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optS.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optS.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optS.Location = New System.Drawing.Point(6, 16)
        Me.optS.Name = "optS"
        Me.optS.Size = New System.Drawing.Size(147, 15)
        Me.optS.TabIndex = 35
        Me.optS.Text = "/S Sous-Répertoire"
        Me.optS.UseVisualStyleBackColor = False
        '
        'txtAllPath
        '
        Me.txtAllPath.BackColor = System.Drawing.Color.Black
        Me.txtAllPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAllPath.Enabled = False
        Me.txtAllPath.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtAllPath.ForeColor = System.Drawing.Color.LightBlue
        Me.txtAllPath.Location = New System.Drawing.Point(6, 38)
        Me.txtAllPath.Name = "txtAllPath"
        Me.txtAllPath.Size = New System.Drawing.Size(245, 18)
        Me.txtAllPath.TabIndex = 3
        '
        'gbOptions
        '
        Me.gbOptions.BackColor = System.Drawing.Color.Black
        Me.gbOptions.BorderColor = System.Drawing.Color.LightBlue
        Me.gbOptions.Controls.Add(Me.optA)
        Me.gbOptions.Controls.Add(Me.optQ)
        Me.gbOptions.Controls.Add(Me.optF)
        Me.gbOptions.Controls.Add(Me.optI)
        Me.gbOptions.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbOptions.ForeColor = System.Drawing.Color.LightBlue
        Me.gbOptions.Location = New System.Drawing.Point(455, 44)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(103, 64)
        Me.gbOptions.TabIndex = 34
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = " Options"
        '
        'optA
        '
        Me.optA.AutoSize = True
        Me.optA.BackColor = System.Drawing.Color.Black
        Me.optA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optA.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optA.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optA.Location = New System.Drawing.Point(15, 16)
        Me.optA.Name = "optA"
        Me.optA.Size = New System.Drawing.Size(35, 15)
        Me.optA.TabIndex = 30
        Me.optA.Text = "/A"
        Me.optA.UseVisualStyleBackColor = False
        '
        'optQ
        '
        Me.optQ.AutoSize = True
        Me.optQ.BackColor = System.Drawing.Color.Black
        Me.optQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optQ.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optQ.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optQ.Location = New System.Drawing.Point(53, 37)
        Me.optQ.Name = "optQ"
        Me.optQ.Size = New System.Drawing.Size(35, 15)
        Me.optQ.TabIndex = 33
        Me.optQ.Text = "/Q"
        Me.optQ.UseVisualStyleBackColor = False
        '
        'optF
        '
        Me.optF.AutoSize = True
        Me.optF.BackColor = System.Drawing.Color.Black
        Me.optF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optF.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optF.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optF.Location = New System.Drawing.Point(53, 16)
        Me.optF.Name = "optF"
        Me.optF.Size = New System.Drawing.Size(35, 15)
        Me.optF.TabIndex = 31
        Me.optF.Text = "/F"
        Me.optF.UseVisualStyleBackColor = False
        '
        'optI
        '
        Me.optI.AutoSize = True
        Me.optI.BackColor = System.Drawing.Color.Black
        Me.optI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optI.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optI.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optI.Location = New System.Drawing.Point(15, 37)
        Me.optI.Name = "optI"
        Me.optI.Size = New System.Drawing.Size(35, 15)
        Me.optI.TabIndex = 32
        Me.optI.Text = "/I"
        Me.optI.UseVisualStyleBackColor = False
        '
        'txtRealPath
        '
        Me.txtRealPath.BackColor = System.Drawing.Color.Black
        Me.txtRealPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRealPath.Enabled = False
        Me.txtRealPath.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtRealPath.ForeColor = System.Drawing.Color.LightBlue
        Me.txtRealPath.Location = New System.Drawing.Point(128, 116)
        Me.txtRealPath.Name = "txtRealPath"
        Me.txtRealPath.Size = New System.Drawing.Size(430, 18)
        Me.txtRealPath.TabIndex = 29
        '
        'btnFichier
        '
        Me.btnFichier.BackColor = System.Drawing.Color.Black
        Me.btnFichier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFichier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnFichier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFichier.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnFichier.ForeColor = System.Drawing.Color.LightBlue
        Me.btnFichier.Location = New System.Drawing.Point(47, 113)
        Me.btnFichier.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnFichier.Name = "btnFichier"
        Me.btnFichier.Size = New System.Drawing.Size(75, 23)
        Me.btnFichier.TabIndex = 28
        Me.btnFichier.Text = "Fichier"
        Me.btnFichier.UseVisualStyleBackColor = False
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(140, 411)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(460, 18)
        Me.txtCmdExec.TabIndex = 27
        '
        'lblCmdExec
        '
        Me.lblCmdExec.AutoSize = True
        Me.lblCmdExec.BackColor = System.Drawing.Color.Transparent
        Me.lblCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.lblCmdExec.Location = New System.Drawing.Point(3, 414)
        Me.lblCmdExec.Name = "lblCmdExec"
        Me.lblCmdExec.Size = New System.Drawing.Size(131, 11)
        Me.lblCmdExec.TabIndex = 26
        Me.lblCmdExec.Text = "Commande exécuté :"
        '
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.BackColor = System.Drawing.Color.Black
        Me.optAdvanceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAdvanceMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAdvanceMode.Location = New System.Drawing.Point(93, 472)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(98, 15)
        Me.optAdvanceMode.TabIndex = 25
        Me.optAdvanceMode.Text = "Mode avancé"
        Me.optAdvanceMode.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Black
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnSend.ForeColor = System.Drawing.Color.LightBlue
        Me.btnSend.Location = New System.Drawing.Point(261, 435)
        Me.btnSend.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(82, 23)
        Me.btnSend.TabIndex = 24
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
        Me.btnApply.Location = New System.Drawing.Point(430, 464)
        Me.btnApply.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(82, 23)
        Me.btnApply.TabIndex = 23
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
        Me.btnBack.Location = New System.Drawing.Point(518, 464)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 23)
        Me.btnBack.TabIndex = 22
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
        Me.btnClear.Location = New System.Drawing.Point(518, 435)
        Me.btnClear.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 23)
        Me.btnClear.TabIndex = 21
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
        Me.btnHelp.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(82, 23)
        Me.btnHelp.TabIndex = 20
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(5, 140)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(595, 265)
        Me.myConsole.TabIndex = 17
        '
        'footer
        '
        Me.footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footer.Location = New System.Drawing.Point(0, 493)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(605, 22)
        Me.footer.TabIndex = 40
        '
        'CompactApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(605, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.gbMode)
        Me.Controls.Add(Me.gbDossier)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.txtRealPath)
        Me.Controls.Add(Me.btnFichier)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.lblCmdExec)
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.LightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CompactApp"
        Me.Text = "GUI Dosbox - COMPACT"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMode.ResumeLayout(False)
        Me.gbMode.PerformLayout()
        Me.gbDossier.ResumeLayout(False)
        Me.gbDossier.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents btnHelp As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnClear As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnApply As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents lblCmdExec As GUIDosbox.GUIDosbox_Label
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents txtAllPath As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents btnDossier As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnFichier As GUIDosbox.GUIDosbox_Button
    Friend WithEvents txtRealPath As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents gbOptions As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optA As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optQ As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optF As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optI As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optS As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents gbDossier As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optC As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents optU As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents gbMode As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents footer As GUIDosbox.GUIDosbox_StatusStrip
End Class
