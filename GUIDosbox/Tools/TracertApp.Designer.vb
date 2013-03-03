<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TracertApp))
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.GuiDosbox_Groupbox7 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optD = New GUIDosbox.GUIDosbox_Checkbox()
        Me.GuiDosbox_Groupbox6 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.txtSourceIPv6 = New GUIDosbox.GUIDosbox_Textbox()
        Me.optS = New GUIDosbox.GUIDosbox_Checkbox()
        Me.optR = New GUIDosbox.GUIDosbox_Checkbox()
        Me.GuiDosbox_Groupbox2 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.txtAdresse = New GUIDosbox.GUIDosbox_Textbox()
        Me.gbHops = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optH = New GUIDosbox.GUIDosbox_Checkbox()
        Me.numSautsMax = New System.Windows.Forms.NumericUpDown()
        Me.gbTimeout = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optW = New GUIDosbox.GUIDosbox_Checkbox()
        Me.numDelaiMS = New System.Windows.Forms.NumericUpDown()
        Me.gbForce = New GUIDosbox.GUIDosbox_Groupbox()
        Me.opt6 = New GUIDosbox.GUIDosbox_Checkbox()
        Me.opt4 = New GUIDosbox.GUIDosbox_Checkbox()
        Me.gbHotes = New GUIDosbox.GUIDosbox_Groupbox()
        Me.txtListeHotes = New GUIDosbox.GUIDosbox_Textbox()
        Me.optJ = New GUIDosbox.GUIDosbox_Checkbox()
        Me.txtCmdExec = New GUIDosbox.GUIDosbox_Textbox()
        Me.lblCmdExec = New GUIDosbox.GUIDosbox_Label()
        Me.optAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        Me.btnHelp = New GUIDosbox.GUIDosbox_Button()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnClear = New GUIDosbox.GUIDosbox_Button()
        Me.btnApply = New GUIDosbox.GUIDosbox_Button()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        Me.footer = New GUIDosbox.GUIDosbox_StatusStrip()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GuiDosbox_Groupbox7.SuspendLayout()
        Me.GuiDosbox_Groupbox6.SuspendLayout()
        Me.GuiDosbox_Groupbox2.SuspendLayout()
        Me.gbHops.SuspendLayout()
        CType(Me.numSautsMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTimeout.SuspendLayout()
        CType(Me.numDelaiMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbForce.SuspendLayout()
        Me.gbHotes.SuspendLayout()
        Me.SuspendLayout()
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(0, 0)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(660, 40)
        Me.flashHeader.TabIndex = 31
        '
        'GuiDosbox_Groupbox7
        '
        Me.GuiDosbox_Groupbox7.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox7.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox7.Controls.Add(Me.optD)
        Me.GuiDosbox_Groupbox7.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox7.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox7.Location = New System.Drawing.Point(5, 105)
        Me.GuiDosbox_Groupbox7.Name = "GuiDosbox_Groupbox7"
        Me.GuiDosbox_Groupbox7.Size = New System.Drawing.Size(75, 54)
        Me.GuiDosbox_Groupbox7.TabIndex = 43
        Me.GuiDosbox_Groupbox7.TabStop = False
        Me.GuiDosbox_Groupbox7.Text = "Option"
        '
        'optD
        '
        Me.optD.AutoSize = True
        Me.optD.BackColor = System.Drawing.Color.Black
        Me.optD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optD.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optD.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optD.Location = New System.Drawing.Point(20, 20)
        Me.optD.Name = "optD"
        Me.optD.Size = New System.Drawing.Size(35, 15)
        Me.optD.TabIndex = 41
        Me.optD.Text = "/D"
        Me.optD.UseVisualStyleBackColor = False
        '
        'GuiDosbox_Groupbox6
        '
        Me.GuiDosbox_Groupbox6.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox6.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox6.Controls.Add(Me.txtSourceIPv6)
        Me.GuiDosbox_Groupbox6.Controls.Add(Me.optS)
        Me.GuiDosbox_Groupbox6.Controls.Add(Me.optR)
        Me.GuiDosbox_Groupbox6.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox6.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox6.Location = New System.Drawing.Point(292, 105)
        Me.GuiDosbox_Groupbox6.Name = "GuiDosbox_Groupbox6"
        Me.GuiDosbox_Groupbox6.Size = New System.Drawing.Size(251, 54)
        Me.GuiDosbox_Groupbox6.TabIndex = 42
        Me.GuiDosbox_Groupbox6.TabStop = False
        Me.GuiDosbox_Groupbox6.Text = " IPv6 Seulement"
        '
        'txtSourceIPv6
        '
        Me.txtSourceIPv6.BackColor = System.Drawing.Color.Black
        Me.txtSourceIPv6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSourceIPv6.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtSourceIPv6.ForeColor = System.Drawing.Color.LightBlue
        Me.txtSourceIPv6.Location = New System.Drawing.Point(89, 18)
        Me.txtSourceIPv6.Name = "txtSourceIPv6"
        Me.txtSourceIPv6.Size = New System.Drawing.Size(153, 18)
        Me.txtSourceIPv6.TabIndex = 2
        '
        'optS
        '
        Me.optS.AutoSize = True
        Me.optS.BackColor = System.Drawing.Color.Black
        Me.optS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optS.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optS.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optS.Location = New System.Drawing.Point(48, 19)
        Me.optS.Name = "optS"
        Me.optS.Size = New System.Drawing.Size(35, 15)
        Me.optS.TabIndex = 1
        Me.optS.Text = "/S"
        Me.optS.UseVisualStyleBackColor = False
        '
        'optR
        '
        Me.optR.AutoSize = True
        Me.optR.BackColor = System.Drawing.Color.Black
        Me.optR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optR.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optR.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optR.Location = New System.Drawing.Point(8, 19)
        Me.optR.Name = "optR"
        Me.optR.Size = New System.Drawing.Size(35, 15)
        Me.optR.TabIndex = 0
        Me.optR.Text = "/R"
        Me.optR.UseVisualStyleBackColor = False
        '
        'GuiDosbox_Groupbox2
        '
        Me.GuiDosbox_Groupbox2.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox2.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox2.Controls.Add(Me.txtAdresse)
        Me.GuiDosbox_Groupbox2.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox2.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox2.Location = New System.Drawing.Point(5, 45)
        Me.GuiDosbox_Groupbox2.Name = "GuiDosbox_Groupbox2"
        Me.GuiDosbox_Groupbox2.Size = New System.Drawing.Size(200, 54)
        Me.GuiDosbox_Groupbox2.TabIndex = 0
        Me.GuiDosbox_Groupbox2.TabStop = False
        Me.GuiDosbox_Groupbox2.Text = " Adresse IP / Hostname"
        '
        'txtAdresse
        '
        Me.txtAdresse.BackColor = System.Drawing.Color.Black
        Me.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdresse.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtAdresse.ForeColor = System.Drawing.Color.LightBlue
        Me.txtAdresse.Location = New System.Drawing.Point(6, 18)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(188, 18)
        Me.txtAdresse.TabIndex = 0
        '
        'gbHops
        '
        Me.gbHops.BackColor = System.Drawing.Color.Black
        Me.gbHops.BorderColor = System.Drawing.Color.LightBlue
        Me.gbHops.Controls.Add(Me.optH)
        Me.gbHops.Controls.Add(Me.numSautsMax)
        Me.gbHops.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbHops.ForeColor = System.Drawing.Color.LightBlue
        Me.gbHops.Location = New System.Drawing.Point(211, 45)
        Me.gbHops.Name = "gbHops"
        Me.gbHops.Size = New System.Drawing.Size(140, 54)
        Me.gbHops.TabIndex = 0
        Me.gbHops.TabStop = False
        Me.gbHops.Text = " Sauts maximum"
        '
        'optH
        '
        Me.optH.AutoSize = True
        Me.optH.BackColor = System.Drawing.Color.Black
        Me.optH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optH.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optH.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optH.Location = New System.Drawing.Point(9, 18)
        Me.optH.Name = "optH"
        Me.optH.Size = New System.Drawing.Size(35, 15)
        Me.optH.TabIndex = 1
        Me.optH.Text = "/H"
        Me.optH.UseVisualStyleBackColor = False
        '
        'numSautsMax
        '
        Me.numSautsMax.BackColor = System.Drawing.Color.Black
        Me.numSautsMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numSautsMax.ForeColor = System.Drawing.Color.LightBlue
        Me.numSautsMax.Location = New System.Drawing.Point(50, 18)
        Me.numSautsMax.Name = "numSautsMax"
        Me.numSautsMax.Size = New System.Drawing.Size(82, 18)
        Me.numSautsMax.TabIndex = 0
        '
        'gbTimeout
        '
        Me.gbTimeout.BackColor = System.Drawing.Color.Black
        Me.gbTimeout.BorderColor = System.Drawing.Color.LightBlue
        Me.gbTimeout.Controls.Add(Me.optW)
        Me.gbTimeout.Controls.Add(Me.numDelaiMS)
        Me.gbTimeout.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbTimeout.ForeColor = System.Drawing.Color.LightBlue
        Me.gbTimeout.Location = New System.Drawing.Point(357, 45)
        Me.gbTimeout.Name = "gbTimeout"
        Me.gbTimeout.Size = New System.Drawing.Size(171, 54)
        Me.gbTimeout.TabIndex = 0
        Me.gbTimeout.TabStop = False
        Me.gbTimeout.Text = " Délai (milliseconde)"
        '
        'optW
        '
        Me.optW.AutoSize = True
        Me.optW.BackColor = System.Drawing.Color.Black
        Me.optW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optW.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optW.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optW.Location = New System.Drawing.Point(24, 18)
        Me.optW.Name = "optW"
        Me.optW.Size = New System.Drawing.Size(35, 15)
        Me.optW.TabIndex = 1
        Me.optW.Text = "/W"
        Me.optW.UseVisualStyleBackColor = False
        '
        'numDelaiMS
        '
        Me.numDelaiMS.BackColor = System.Drawing.Color.Black
        Me.numDelaiMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numDelaiMS.ForeColor = System.Drawing.Color.LightBlue
        Me.numDelaiMS.Location = New System.Drawing.Point(65, 18)
        Me.numDelaiMS.Name = "numDelaiMS"
        Me.numDelaiMS.Size = New System.Drawing.Size(82, 18)
        Me.numDelaiMS.TabIndex = 0
        '
        'gbForce
        '
        Me.gbForce.BackColor = System.Drawing.Color.Black
        Me.gbForce.BorderColor = System.Drawing.Color.LightBlue
        Me.gbForce.Controls.Add(Me.opt6)
        Me.gbForce.Controls.Add(Me.opt4)
        Me.gbForce.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbForce.ForeColor = System.Drawing.Color.LightBlue
        Me.gbForce.Location = New System.Drawing.Point(534, 45)
        Me.gbForce.Name = "gbForce"
        Me.gbForce.Size = New System.Drawing.Size(118, 54)
        Me.gbForce.TabIndex = 0
        Me.gbForce.TabStop = False
        Me.gbForce.Text = "Forcer"
        '
        'opt6
        '
        Me.opt6.AutoSize = True
        Me.opt6.BackColor = System.Drawing.Color.Black
        Me.opt6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opt6.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.opt6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.opt6.Location = New System.Drawing.Point(62, 20)
        Me.opt6.Name = "opt6"
        Me.opt6.Size = New System.Drawing.Size(49, 15)
        Me.opt6.TabIndex = 1
        Me.opt6.Text = "IPv6"
        Me.opt6.UseVisualStyleBackColor = False
        '
        'opt4
        '
        Me.opt4.AutoSize = True
        Me.opt4.BackColor = System.Drawing.Color.Black
        Me.opt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opt4.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.opt4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.opt4.Location = New System.Drawing.Point(7, 20)
        Me.opt4.Name = "opt4"
        Me.opt4.Size = New System.Drawing.Size(49, 15)
        Me.opt4.TabIndex = 0
        Me.opt4.Text = "IPv4"
        Me.opt4.UseVisualStyleBackColor = False
        '
        'gbHotes
        '
        Me.gbHotes.BackColor = System.Drawing.Color.Black
        Me.gbHotes.BorderColor = System.Drawing.Color.LightBlue
        Me.gbHotes.Controls.Add(Me.txtListeHotes)
        Me.gbHotes.Controls.Add(Me.optJ)
        Me.gbHotes.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbHotes.ForeColor = System.Drawing.Color.LightBlue
        Me.gbHotes.Location = New System.Drawing.Point(86, 105)
        Me.gbHotes.Name = "gbHotes"
        Me.gbHotes.Size = New System.Drawing.Size(200, 54)
        Me.gbHotes.TabIndex = 40
        Me.gbHotes.TabStop = False
        Me.gbHotes.Text = " Liste d'hôtes"
        '
        'txtListeHotes
        '
        Me.txtListeHotes.BackColor = System.Drawing.Color.Black
        Me.txtListeHotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtListeHotes.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtListeHotes.ForeColor = System.Drawing.Color.LightBlue
        Me.txtListeHotes.Location = New System.Drawing.Point(48, 18)
        Me.txtListeHotes.Name = "txtListeHotes"
        Me.txtListeHotes.Size = New System.Drawing.Size(146, 18)
        Me.txtListeHotes.TabIndex = 1
        '
        'optJ
        '
        Me.optJ.AutoSize = True
        Me.optJ.BackColor = System.Drawing.Color.Black
        Me.optJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optJ.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optJ.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optJ.Location = New System.Drawing.Point(7, 18)
        Me.optJ.Name = "optJ"
        Me.optJ.Size = New System.Drawing.Size(35, 15)
        Me.optJ.TabIndex = 0
        Me.optJ.Text = "/J"
        Me.optJ.UseVisualStyleBackColor = False
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(139, 533)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(512, 18)
        Me.txtCmdExec.TabIndex = 39
        '
        'lblCmdExec
        '
        Me.lblCmdExec.AutoSize = True
        Me.lblCmdExec.BackColor = System.Drawing.Color.Transparent
        Me.lblCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.lblCmdExec.Location = New System.Drawing.Point(2, 535)
        Me.lblCmdExec.Name = "lblCmdExec"
        Me.lblCmdExec.Size = New System.Drawing.Size(131, 11)
        Me.lblCmdExec.TabIndex = 38
        Me.lblCmdExec.Text = "Commande exécuté :"
        '
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.BackColor = System.Drawing.Color.Black
        Me.optAdvanceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAdvanceMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAdvanceMode.Location = New System.Drawing.Point(99, 594)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(98, 15)
        Me.optAdvanceMode.TabIndex = 37
        Me.optAdvanceMode.Text = "Mode avancé"
        Me.optAdvanceMode.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Black
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnHelp.ForeColor = System.Drawing.Color.LightBlue
        Me.btnHelp.Location = New System.Drawing.Point(4, 586)
        Me.btnHelp.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(82, 23)
        Me.btnHelp.TabIndex = 36
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
        Me.btnBack.Location = New System.Drawing.Point(569, 586)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 23)
        Me.btnBack.TabIndex = 35
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
        Me.btnClear.Location = New System.Drawing.Point(569, 557)
        Me.btnClear.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 23)
        Me.btnClear.TabIndex = 34
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
        Me.btnApply.Location = New System.Drawing.Point(481, 586)
        Me.btnApply.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(82, 23)
        Me.btnApply.TabIndex = 33
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
        Me.btnSend.Location = New System.Drawing.Point(319, 557)
        Me.btnSend.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(82, 23)
        Me.btnSend.TabIndex = 32
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(5, 170)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(647, 357)
        Me.myConsole.TabIndex = 30
        '
        'footer
        '
        Me.footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footer.Location = New System.Drawing.Point(0, 613)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(657, 22)
        Me.footer.TabIndex = 44
        '
        'TracertApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(657, 635)
        Me.ControlBox = False
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.GuiDosbox_Groupbox7)
        Me.Controls.Add(Me.GuiDosbox_Groupbox6)
        Me.Controls.Add(Me.GuiDosbox_Groupbox2)
        Me.Controls.Add(Me.gbHops)
        Me.Controls.Add(Me.gbTimeout)
        Me.Controls.Add(Me.gbForce)
        Me.Controls.Add(Me.gbHotes)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.lblCmdExec)
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.ForeColor = System.Drawing.Color.LightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TracertApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI DosBox - TRACERT"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GuiDosbox_Groupbox7.ResumeLayout(False)
        Me.GuiDosbox_Groupbox7.PerformLayout()
        Me.GuiDosbox_Groupbox6.ResumeLayout(False)
        Me.GuiDosbox_Groupbox6.PerformLayout()
        Me.GuiDosbox_Groupbox2.ResumeLayout(False)
        Me.GuiDosbox_Groupbox2.PerformLayout()
        Me.gbHops.ResumeLayout(False)
        Me.gbHops.PerformLayout()
        CType(Me.numSautsMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTimeout.ResumeLayout(False)
        Me.gbTimeout.PerformLayout()
        CType(Me.numDelaiMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbForce.ResumeLayout(False)
        Me.gbForce.PerformLayout()
        Me.gbHotes.ResumeLayout(False)
        Me.gbHotes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnApply As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnClear As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnHelp As GUIDosbox.GUIDosbox_Button
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents lblCmdExec As GUIDosbox.GUIDosbox_Label
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents gbHotes As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents GuiDosbox_Groupbox2 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents txtAdresse As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents gbHops As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents gbTimeout As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents gbForce As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents numSautsMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents optH As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents txtListeHotes As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents optJ As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optW As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents numDelaiMS As System.Windows.Forms.NumericUpDown
    Friend WithEvents opt6 As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents opt4 As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optD As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents GuiDosbox_Groupbox6 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents txtSourceIPv6 As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents optS As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents optR As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents GuiDosbox_Groupbox7 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents footer As GUIDosbox.GUIDosbox_StatusStrip
End Class
