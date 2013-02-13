<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XCopyApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XCopyApp))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.lblSource = New GUIDosbox.GUIDosbox_Label()
        Me.btnFichier = New GUIDosbox.GUIDosbox_Button()
        Me.btnDestination = New GUIDosbox.GUIDosbox_Button()
        Me.btnDossier = New GUIDosbox.GUIDosbox_Button()
        Me.txtDestination = New GUIDosbox.GUIDosbox_Textbox()
        Me.txtSource = New GUIDosbox.GUIDosbox_Textbox()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        Me.btnApply = New GUIDosbox.GUIDosbox_Button()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
        Me.btnClear = New GUIDosbox.GUIDosbox_Button()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnHelp = New GUIDosbox.GUIDosbox_Button()
        Me.optAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        Me.lblCmdExec = New GUIDosbox.GUIDosbox_Label()
        Me.txtCmdExec = New GUIDosbox.GUIDosbox_Textbox()
        Me.gbOptions = New GUIDosbox.GUIDosbox_Groupbox()
        Me.OptR = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptJ = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptU = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptK = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptX = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptG = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptN = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptH = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptI = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptO = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptT = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptV = New GUIDosbox.GUIDosbox_Checkbox()
        Me.gbUniqueOptions = New GUIDosbox.GUIDosbox_Groupbox()
        Me.OptA = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptM = New GUIDosbox.GUIDosbox_Checkbox()
        Me.gbRecomander = New GUIDosbox.GUIDosbox_Groupbox()
        Me.OptC = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptE = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptS = New GUIDosbox.GUIDosbox_Checkbox()
        Me.OptY = New GUIDosbox.GUIDosbox_Checkbox()
        Me.invOptY = New GUIDosbox.GUIDosbox_Checkbox()
        Me.gbDate = New GUIDosbox.GUIDosbox_Groupbox()
        Me.OptD = New GUIDosbox.GUIDosbox_Checkbox()
        Me.txtDate = New GUIDosbox.GUIDosbox_Textbox()
        Me.GuiDosbox_Groupbox1 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.txtExclude = New GUIDosbox.GUIDosbox_Textbox()
        Me.optExclude = New GUIDosbox.GUIDosbox_Checkbox()
        Me.footer = New GUIDosbox.GUIDosbox_StatusStrip()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOptions.SuspendLayout()
        Me.gbUniqueOptions.SuspendLayout()
        Me.gbRecomander.SuspendLayout()
        Me.gbDate.SuspendLayout()
        Me.GuiDosbox_Groupbox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(17, 478)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 49
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(0, 0)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(706, 40)
        Me.flashHeader.TabIndex = 51
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.BackColor = System.Drawing.Color.Transparent
        Me.lblSource.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblSource.ForeColor = System.Drawing.Color.LightBlue
        Me.lblSource.Location = New System.Drawing.Point(23, 50)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(61, 11)
        Me.lblSource.TabIndex = 60
        Me.lblSource.Text = "Source :"
        '
        'btnFichier
        '
        Me.btnFichier.BackColor = System.Drawing.Color.Black
        Me.btnFichier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFichier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnFichier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFichier.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnFichier.ForeColor = System.Drawing.Color.LightBlue
        Me.btnFichier.Location = New System.Drawing.Point(90, 44)
        Me.btnFichier.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnFichier.Name = "btnFichier"
        Me.btnFichier.Size = New System.Drawing.Size(95, 23)
        Me.btnFichier.TabIndex = 58
        Me.btnFichier.Text = "Fichier"
        Me.btnFichier.UseVisualStyleBackColor = False
        '
        'btnDestination
        '
        Me.btnDestination.BackColor = System.Drawing.Color.Black
        Me.btnDestination.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDestination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDestination.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnDestination.ForeColor = System.Drawing.Color.LightBlue
        Me.btnDestination.Location = New System.Drawing.Point(188, 69)
        Me.btnDestination.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnDestination.Name = "btnDestination"
        Me.btnDestination.Size = New System.Drawing.Size(95, 23)
        Me.btnDestination.TabIndex = 57
        Me.btnDestination.Text = "Destination"
        Me.btnDestination.UseVisualStyleBackColor = False
        '
        'btnDossier
        '
        Me.btnDossier.BackColor = System.Drawing.Color.Black
        Me.btnDossier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDossier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDossier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDossier.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnDossier.ForeColor = System.Drawing.Color.LightBlue
        Me.btnDossier.Location = New System.Drawing.Point(188, 44)
        Me.btnDossier.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnDossier.Name = "btnDossier"
        Me.btnDossier.Size = New System.Drawing.Size(95, 23)
        Me.btnDossier.TabIndex = 56
        Me.btnDossier.Text = "Dossier"
        Me.btnDossier.UseVisualStyleBackColor = False
        '
        'txtDestination
        '
        Me.txtDestination.BackColor = System.Drawing.Color.Black
        Me.txtDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestination.Enabled = False
        Me.txtDestination.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtDestination.ForeColor = System.Drawing.Color.LightBlue
        Me.txtDestination.Location = New System.Drawing.Point(287, 71)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(429, 18)
        Me.txtDestination.TabIndex = 55
        '
        'txtSource
        '
        Me.txtSource.BackColor = System.Drawing.Color.Black
        Me.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSource.Enabled = False
        Me.txtSource.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtSource.ForeColor = System.Drawing.Color.LightBlue
        Me.txtSource.Location = New System.Drawing.Point(287, 46)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(429, 18)
        Me.txtSource.TabIndex = 54
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(188, 98)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(528, 352)
        Me.myConsole.TabIndex = 50
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.Black
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnApply.ForeColor = System.Drawing.Color.LightBlue
        Me.btnApply.Location = New System.Drawing.Point(546, 507)
        Me.btnApply.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(82, 23)
        Me.btnApply.TabIndex = 61
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
        Me.btnSend.Location = New System.Drawing.Point(319, 480)
        Me.btnSend.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(82, 23)
        Me.btnSend.TabIndex = 62
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.LightBlue
        Me.btnClear.Location = New System.Drawing.Point(634, 478)
        Me.btnClear.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 23)
        Me.btnClear.TabIndex = 63
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
        Me.btnBack.Location = New System.Drawing.Point(634, 507)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 23)
        Me.btnBack.TabIndex = 64
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Black
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnHelp.ForeColor = System.Drawing.Color.LightBlue
        Me.btnHelp.Location = New System.Drawing.Point(6, 507)
        Me.btnHelp.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(82, 23)
        Me.btnHelp.TabIndex = 65
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
        Me.optAdvanceMode.Location = New System.Drawing.Point(94, 515)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(98, 15)
        Me.optAdvanceMode.TabIndex = 66
        Me.optAdvanceMode.Text = "Mode avancé"
        Me.optAdvanceMode.UseVisualStyleBackColor = False
        '
        'lblCmdExec
        '
        Me.lblCmdExec.AutoSize = True
        Me.lblCmdExec.BackColor = System.Drawing.Color.Transparent
        Me.lblCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.lblCmdExec.Location = New System.Drawing.Point(54, 460)
        Me.lblCmdExec.Name = "lblCmdExec"
        Me.lblCmdExec.Size = New System.Drawing.Size(131, 11)
        Me.lblCmdExec.TabIndex = 67
        Me.lblCmdExec.Text = "Commande exécuté :"
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(188, 456)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(528, 18)
        Me.txtCmdExec.TabIndex = 68
        '
        'gbOptions
        '
        Me.gbOptions.BackColor = System.Drawing.Color.Black
        Me.gbOptions.BorderColor = System.Drawing.Color.LightBlue
        Me.gbOptions.Controls.Add(Me.OptR)
        Me.gbOptions.Controls.Add(Me.OptJ)
        Me.gbOptions.Controls.Add(Me.OptU)
        Me.gbOptions.Controls.Add(Me.OptK)
        Me.gbOptions.Controls.Add(Me.OptX)
        Me.gbOptions.Controls.Add(Me.OptG)
        Me.gbOptions.Controls.Add(Me.OptN)
        Me.gbOptions.Controls.Add(Me.OptH)
        Me.gbOptions.Controls.Add(Me.OptI)
        Me.gbOptions.Controls.Add(Me.OptO)
        Me.gbOptions.Controls.Add(Me.OptT)
        Me.gbOptions.Controls.Add(Me.OptV)
        Me.gbOptions.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbOptions.ForeColor = System.Drawing.Color.LightBlue
        Me.gbOptions.Location = New System.Drawing.Point(6, 98)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(176, 82)
        Me.gbOptions.TabIndex = 69
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = " Options"
        '
        'OptR
        '
        Me.OptR.AutoSize = True
        Me.OptR.BackColor = System.Drawing.Color.Black
        Me.OptR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptR.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptR.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptR.Location = New System.Drawing.Point(134, 35)
        Me.OptR.Name = "OptR"
        Me.OptR.Size = New System.Drawing.Size(35, 15)
        Me.OptR.TabIndex = 74
        Me.OptR.Text = "/R"
        Me.OptR.UseVisualStyleBackColor = False
        '
        'OptJ
        '
        Me.OptJ.AutoSize = True
        Me.OptJ.BackColor = System.Drawing.Color.Black
        Me.OptJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptJ.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptJ.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptJ.Location = New System.Drawing.Point(134, 14)
        Me.OptJ.Name = "OptJ"
        Me.OptJ.Size = New System.Drawing.Size(35, 15)
        Me.OptJ.TabIndex = 75
        Me.OptJ.Text = "/J"
        Me.OptJ.UseVisualStyleBackColor = False
        '
        'OptU
        '
        Me.OptU.AutoSize = True
        Me.OptU.BackColor = System.Drawing.Color.Black
        Me.OptU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptU.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptU.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptU.Location = New System.Drawing.Point(134, 56)
        Me.OptU.Name = "OptU"
        Me.OptU.Size = New System.Drawing.Size(35, 15)
        Me.OptU.TabIndex = 73
        Me.OptU.Text = "/U"
        Me.OptU.UseVisualStyleBackColor = False
        '
        'OptK
        '
        Me.OptK.AutoSize = True
        Me.OptK.BackColor = System.Drawing.Color.Black
        Me.OptK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptK.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptK.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptK.Location = New System.Drawing.Point(11, 35)
        Me.OptK.Name = "OptK"
        Me.OptK.Size = New System.Drawing.Size(35, 15)
        Me.OptK.TabIndex = 76
        Me.OptK.Text = "/K"
        Me.OptK.UseVisualStyleBackColor = False
        '
        'OptX
        '
        Me.OptX.AutoSize = True
        Me.OptX.BackColor = System.Drawing.Color.Black
        Me.OptX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptX.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptX.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptX.Location = New System.Drawing.Point(52, 56)
        Me.OptX.Name = "OptX"
        Me.OptX.Size = New System.Drawing.Size(35, 15)
        Me.OptX.TabIndex = 72
        Me.OptX.Text = "/X"
        Me.OptX.UseVisualStyleBackColor = False
        '
        'OptG
        '
        Me.OptG.AutoSize = True
        Me.OptG.BackColor = System.Drawing.Color.Black
        Me.OptG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptG.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptG.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptG.Location = New System.Drawing.Point(11, 14)
        Me.OptG.Name = "OptG"
        Me.OptG.Size = New System.Drawing.Size(35, 15)
        Me.OptG.TabIndex = 77
        Me.OptG.Text = "/G"
        Me.OptG.UseVisualStyleBackColor = False
        '
        'OptN
        '
        Me.OptN.AutoSize = True
        Me.OptN.BackColor = System.Drawing.Color.Black
        Me.OptN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptN.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptN.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptN.Location = New System.Drawing.Point(52, 35)
        Me.OptN.Name = "OptN"
        Me.OptN.Size = New System.Drawing.Size(35, 15)
        Me.OptN.TabIndex = 70
        Me.OptN.Text = "/N"
        Me.OptN.UseVisualStyleBackColor = False
        '
        'OptH
        '
        Me.OptH.AutoSize = True
        Me.OptH.BackColor = System.Drawing.Color.Black
        Me.OptH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptH.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptH.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptH.Location = New System.Drawing.Point(52, 14)
        Me.OptH.Name = "OptH"
        Me.OptH.Size = New System.Drawing.Size(35, 15)
        Me.OptH.TabIndex = 71
        Me.OptH.Text = "/H"
        Me.OptH.UseVisualStyleBackColor = False
        '
        'OptI
        '
        Me.OptI.AutoSize = True
        Me.OptI.BackColor = System.Drawing.Color.Black
        Me.OptI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptI.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptI.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptI.Location = New System.Drawing.Point(93, 14)
        Me.OptI.Name = "OptI"
        Me.OptI.Size = New System.Drawing.Size(35, 15)
        Me.OptI.TabIndex = 78
        Me.OptI.Text = "/I"
        Me.OptI.UseVisualStyleBackColor = False
        '
        'OptO
        '
        Me.OptO.AutoSize = True
        Me.OptO.BackColor = System.Drawing.Color.Black
        Me.OptO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptO.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptO.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptO.Location = New System.Drawing.Point(93, 35)
        Me.OptO.Name = "OptO"
        Me.OptO.Size = New System.Drawing.Size(35, 15)
        Me.OptO.TabIndex = 79
        Me.OptO.Text = "/O"
        Me.OptO.UseVisualStyleBackColor = False
        '
        'OptT
        '
        Me.OptT.AutoSize = True
        Me.OptT.BackColor = System.Drawing.Color.Black
        Me.OptT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptT.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptT.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptT.Location = New System.Drawing.Point(93, 56)
        Me.OptT.Name = "OptT"
        Me.OptT.Size = New System.Drawing.Size(35, 15)
        Me.OptT.TabIndex = 80
        Me.OptT.Text = "/T"
        Me.OptT.UseVisualStyleBackColor = False
        '
        'OptV
        '
        Me.OptV.AutoSize = True
        Me.OptV.BackColor = System.Drawing.Color.Black
        Me.OptV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptV.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptV.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptV.Location = New System.Drawing.Point(11, 56)
        Me.OptV.Name = "OptV"
        Me.OptV.Size = New System.Drawing.Size(35, 15)
        Me.OptV.TabIndex = 81
        Me.OptV.Text = "/V"
        Me.OptV.UseVisualStyleBackColor = False
        '
        'gbUniqueOptions
        '
        Me.gbUniqueOptions.BackColor = System.Drawing.Color.Black
        Me.gbUniqueOptions.BorderColor = System.Drawing.Color.LightBlue
        Me.gbUniqueOptions.Controls.Add(Me.OptA)
        Me.gbUniqueOptions.Controls.Add(Me.OptM)
        Me.gbUniqueOptions.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbUniqueOptions.ForeColor = System.Drawing.Color.LightBlue
        Me.gbUniqueOptions.Location = New System.Drawing.Point(6, 276)
        Me.gbUniqueOptions.Name = "gbUniqueOptions"
        Me.gbUniqueOptions.Size = New System.Drawing.Size(176, 42)
        Me.gbUniqueOptions.TabIndex = 0
        Me.gbUniqueOptions.TabStop = False
        Me.gbUniqueOptions.Text = " Options unique"
        '
        'OptA
        '
        Me.OptA.AutoSize = True
        Me.OptA.BackColor = System.Drawing.Color.Black
        Me.OptA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptA.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptA.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptA.Location = New System.Drawing.Point(99, 18)
        Me.OptA.Name = "OptA"
        Me.OptA.Size = New System.Drawing.Size(35, 15)
        Me.OptA.TabIndex = 70
        Me.OptA.Text = "/A"
        Me.OptA.UseVisualStyleBackColor = False
        '
        'OptM
        '
        Me.OptM.AutoSize = True
        Me.OptM.BackColor = System.Drawing.Color.Black
        Me.OptM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptM.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptM.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptM.Location = New System.Drawing.Point(42, 18)
        Me.OptM.Name = "OptM"
        Me.OptM.Size = New System.Drawing.Size(35, 15)
        Me.OptM.TabIndex = 0
        Me.OptM.Text = "/M"
        Me.OptM.UseVisualStyleBackColor = False
        '
        'gbRecomander
        '
        Me.gbRecomander.BackColor = System.Drawing.Color.Black
        Me.gbRecomander.BorderColor = System.Drawing.Color.LightBlue
        Me.gbRecomander.Controls.Add(Me.OptC)
        Me.gbRecomander.Controls.Add(Me.OptE)
        Me.gbRecomander.Controls.Add(Me.OptS)
        Me.gbRecomander.Controls.Add(Me.OptY)
        Me.gbRecomander.Controls.Add(Me.invOptY)
        Me.gbRecomander.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbRecomander.ForeColor = System.Drawing.Color.LightBlue
        Me.gbRecomander.Location = New System.Drawing.Point(6, 186)
        Me.gbRecomander.Name = "gbRecomander"
        Me.gbRecomander.Size = New System.Drawing.Size(176, 84)
        Me.gbRecomander.TabIndex = 70
        Me.gbRecomander.TabStop = False
        Me.gbRecomander.Text = " Options Recommandé"
        '
        'OptC
        '
        Me.OptC.AutoSize = True
        Me.OptC.BackColor = System.Drawing.Color.Black
        Me.OptC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptC.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptC.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptC.Location = New System.Drawing.Point(104, 59)
        Me.OptC.Name = "OptC"
        Me.OptC.Size = New System.Drawing.Size(35, 15)
        Me.OptC.TabIndex = 71
        Me.OptC.Text = "/C"
        Me.OptC.UseVisualStyleBackColor = False
        '
        'OptE
        '
        Me.OptE.AutoSize = True
        Me.OptE.BackColor = System.Drawing.Color.Black
        Me.OptE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptE.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptE.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptE.Location = New System.Drawing.Point(104, 38)
        Me.OptE.Name = "OptE"
        Me.OptE.Size = New System.Drawing.Size(35, 15)
        Me.OptE.TabIndex = 72
        Me.OptE.Text = "/E"
        Me.OptE.UseVisualStyleBackColor = False
        '
        'OptS
        '
        Me.OptS.AutoSize = True
        Me.OptS.BackColor = System.Drawing.Color.Black
        Me.OptS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptS.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptS.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptS.Location = New System.Drawing.Point(104, 17)
        Me.OptS.Name = "OptS"
        Me.OptS.Size = New System.Drawing.Size(35, 15)
        Me.OptS.TabIndex = 73
        Me.OptS.Text = "/S"
        Me.OptS.UseVisualStyleBackColor = False
        '
        'OptY
        '
        Me.OptY.AutoSize = True
        Me.OptY.BackColor = System.Drawing.Color.Black
        Me.OptY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptY.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptY.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptY.Location = New System.Drawing.Point(38, 38)
        Me.OptY.Name = "OptY"
        Me.OptY.Size = New System.Drawing.Size(35, 15)
        Me.OptY.TabIndex = 74
        Me.OptY.Text = "/Y"
        Me.OptY.UseVisualStyleBackColor = False
        '
        'invOptY
        '
        Me.invOptY.AutoSize = True
        Me.invOptY.BackColor = System.Drawing.Color.Black
        Me.invOptY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.invOptY.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.invOptY.ForeColor = System.Drawing.Color.RoyalBlue
        Me.invOptY.Location = New System.Drawing.Point(38, 17)
        Me.invOptY.Name = "invOptY"
        Me.invOptY.Size = New System.Drawing.Size(42, 15)
        Me.invOptY.TabIndex = 75
        Me.invOptY.Text = "/-Y"
        Me.invOptY.UseVisualStyleBackColor = False
        '
        'gbDate
        '
        Me.gbDate.BackColor = System.Drawing.Color.Black
        Me.gbDate.BorderColor = System.Drawing.Color.LightBlue
        Me.gbDate.Controls.Add(Me.OptD)
        Me.gbDate.Controls.Add(Me.txtDate)
        Me.gbDate.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbDate.ForeColor = System.Drawing.Color.LightBlue
        Me.gbDate.Location = New System.Drawing.Point(6, 324)
        Me.gbDate.Name = "gbDate"
        Me.gbDate.Size = New System.Drawing.Size(176, 70)
        Me.gbDate.TabIndex = 71
        Me.gbDate.TabStop = False
        Me.gbDate.Text = " Date"
        '
        'OptD
        '
        Me.OptD.AutoSize = True
        Me.OptD.BackColor = System.Drawing.Color.Black
        Me.OptD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptD.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.OptD.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OptD.Location = New System.Drawing.Point(10, 17)
        Me.OptD.Name = "OptD"
        Me.OptD.Size = New System.Drawing.Size(154, 15)
        Me.OptD.TabIndex = 1
        Me.OptD.Text = "/D    Format: j-m-a"
        Me.OptD.UseVisualStyleBackColor = False
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.Black
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtDate.ForeColor = System.Drawing.Color.LightBlue
        Me.txtDate.Location = New System.Drawing.Point(10, 38)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(157, 18)
        Me.txtDate.TabIndex = 0
        '
        'GuiDosbox_Groupbox1
        '
        Me.GuiDosbox_Groupbox1.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox1.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.txtExclude)
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.optExclude)
        Me.GuiDosbox_Groupbox1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox1.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox1.Location = New System.Drawing.Point(6, 400)
        Me.GuiDosbox_Groupbox1.Name = "GuiDosbox_Groupbox1"
        Me.GuiDosbox_Groupbox1.Size = New System.Drawing.Size(179, 50)
        Me.GuiDosbox_Groupbox1.TabIndex = 72
        Me.GuiDosbox_Groupbox1.TabStop = False
        '
        'txtExclude
        '
        Me.txtExclude.BackColor = System.Drawing.Color.Black
        Me.txtExclude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExclude.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtExclude.ForeColor = System.Drawing.Color.LightBlue
        Me.txtExclude.Location = New System.Drawing.Point(6, 26)
        Me.txtExclude.Name = "txtExclude"
        Me.txtExclude.Size = New System.Drawing.Size(167, 18)
        Me.txtExclude.TabIndex = 1
        '
        'optExclude
        '
        Me.optExclude.AutoSize = True
        Me.optExclude.BackColor = System.Drawing.Color.Black
        Me.optExclude.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optExclude.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optExclude.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optExclude.Location = New System.Drawing.Point(7, 5)
        Me.optExclude.Name = "optExclude"
        Me.optExclude.Size = New System.Drawing.Size(77, 15)
        Me.optExclude.TabIndex = 0
        Me.optExclude.Text = "/EXCLUDE"
        Me.optExclude.UseVisualStyleBackColor = False
        '
        'footer
        '
        Me.footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footer.Location = New System.Drawing.Point(0, 532)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(721, 22)
        Me.footer.TabIndex = 74
        '
        'XCopyApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(721, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.GuiDosbox_Groupbox1)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.gbDate)
        Me.Controls.Add(Me.gbRecomander)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.lblCmdExec)
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.lblSource)
        Me.Controls.Add(Me.btnFichier)
        Me.Controls.Add(Me.btnDestination)
        Me.Controls.Add(Me.gbUniqueOptions)
        Me.Controls.Add(Me.btnDossier)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.ForeColor = System.Drawing.Color.LightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "XCopyApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI DosBox - XCOPY"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.gbUniqueOptions.ResumeLayout(False)
        Me.gbUniqueOptions.PerformLayout()
        Me.gbRecomander.ResumeLayout(False)
        Me.gbRecomander.PerformLayout()
        Me.gbDate.ResumeLayout(False)
        Me.gbDate.PerformLayout()
        Me.GuiDosbox_Groupbox1.ResumeLayout(False)
        Me.GuiDosbox_Groupbox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents txtSource As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents txtDestination As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents btnDossier As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnDestination As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnFichier As GUIDosbox.GUIDosbox_Button
    Friend WithEvents lblSource As GUIDosbox.GUIDosbox_Label
    Friend WithEvents btnApply As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnClear As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnHelp As GUIDosbox.GUIDosbox_Button
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents lblCmdExec As GUIDosbox.GUIDosbox_Label
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents gbOptions As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents OptR As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptJ As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptU As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptK As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptX As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptG As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptN As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptH As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptI As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptO As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptT As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptV As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents gbUniqueOptions As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents OptA As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptM As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents gbRecomander As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents OptC As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptE As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptS As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents OptY As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents invOptY As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents gbDate As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents OptD As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents txtDate As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents GuiDosbox_Groupbox1 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents txtExclude As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents optExclude As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents footer As GUIDosbox.GUIDosbox_StatusStrip
End Class
