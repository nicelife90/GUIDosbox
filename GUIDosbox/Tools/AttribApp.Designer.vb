<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttribApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttribApp))
        Me.optL = New System.Windows.Forms.CheckBox()
        Me.optD = New System.Windows.Forms.CheckBox()
        Me.optS = New System.Windows.Forms.CheckBox()
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.gbH = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optHNull = New System.Windows.Forms.RadioButton()
        Me.optHPlus = New System.Windows.Forms.RadioButton()
        Me.optHMoin = New System.Windows.Forms.RadioButton()
        Me.gbI = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optINull = New System.Windows.Forms.RadioButton()
        Me.optIPlus = New System.Windows.Forms.RadioButton()
        Me.optIMoin = New System.Windows.Forms.RadioButton()
        Me.gbA = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optANull = New System.Windows.Forms.RadioButton()
        Me.optAplus = New System.Windows.Forms.RadioButton()
        Me.optAMoin = New System.Windows.Forms.RadioButton()
        Me.gbS = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optSNull = New System.Windows.Forms.RadioButton()
        Me.optSPlus = New System.Windows.Forms.RadioButton()
        Me.optSMoin = New System.Windows.Forms.RadioButton()
        Me.gbR = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optRNull = New System.Windows.Forms.RadioButton()
        Me.optRPlus = New System.Windows.Forms.RadioButton()
        Me.optRMoin = New System.Windows.Forms.RadioButton()
        Me.btnFolders = New GUIDosbox.GUIDosbox_Button()
        Me.btnFiles = New GUIDosbox.GUIDosbox_Button()
        Me.btnAide = New GUIDosbox.GUIDosbox_Button()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnApply = New GUIDosbox.GUIDosbox_Button()
        Me.btnClear = New GUIDosbox.GUIDosbox_Button()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        Me.txtFile = New GUIDosbox.GUIDosbox_Textbox()
        Me.txtCmdExec = New GUIDosbox.GUIDosbox_Textbox()
        Me.GuiDosboxLabel1 = New GUIDosbox.GUIDosbox_Label()
        Me.gbOptions = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
        Me.footer = New GUIDosbox.GUIDosbox_StatusStrip()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbH.SuspendLayout()
        Me.gbI.SuspendLayout()
        Me.gbA.SuspendLayout()
        Me.gbS.SuspendLayout()
        Me.gbR.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'optL
        '
        Me.optL.AutoSize = True
        Me.optL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optL.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optL.Location = New System.Drawing.Point(117, 19)
        Me.optL.Name = "optL"
        Me.optL.Size = New System.Drawing.Size(42, 15)
        Me.optL.TabIndex = 2
        Me.optL.Text = "/ L"
        Me.optL.UseVisualStyleBackColor = True
        '
        'optD
        '
        Me.optD.AutoSize = True
        Me.optD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optD.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optD.Location = New System.Drawing.Point(63, 19)
        Me.optD.Name = "optD"
        Me.optD.Size = New System.Drawing.Size(42, 15)
        Me.optD.TabIndex = 1
        Me.optD.Text = "/ D"
        Me.optD.UseVisualStyleBackColor = True
        '
        'optS
        '
        Me.optS.AutoSize = True
        Me.optS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optS.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optS.Location = New System.Drawing.Point(9, 19)
        Me.optS.Name = "optS"
        Me.optS.Size = New System.Drawing.Size(42, 15)
        Me.optS.TabIndex = 0
        Me.optS.Text = "/ S"
        Me.optS.UseVisualStyleBackColor = True
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(12, 66)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 24
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(0, 0)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(596, 40)
        Me.flashHeader.TabIndex = 30
        '
        'gbH
        '
        Me.gbH.BackColor = System.Drawing.Color.Black
        Me.gbH.BorderColor = System.Drawing.Color.LightBlue
        Me.gbH.Controls.Add(Me.optHNull)
        Me.gbH.Controls.Add(Me.optHPlus)
        Me.gbH.Controls.Add(Me.optHMoin)
        Me.gbH.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbH.ForeColor = System.Drawing.Color.LightBlue
        Me.gbH.Location = New System.Drawing.Point(334, 50)
        Me.gbH.Name = "gbH"
        Me.gbH.Size = New System.Drawing.Size(64, 88)
        Me.gbH.TabIndex = 41
        Me.gbH.TabStop = False
        Me.gbH.Text = "H"
        '
        'optHNull
        '
        Me.optHNull.AutoSize = True
        Me.optHNull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optHNull.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optHNull.Location = New System.Drawing.Point(6, 57)
        Me.optHNull.Name = "optHNull"
        Me.optHNull.Size = New System.Drawing.Size(50, 15)
        Me.optHNull.TabIndex = 2
        Me.optHNull.TabStop = True
        Me.optHNull.Text = "Null"
        Me.optHNull.UseVisualStyleBackColor = True
        '
        'optHPlus
        '
        Me.optHPlus.AutoSize = True
        Me.optHPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optHPlus.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optHPlus.Location = New System.Drawing.Point(6, 15)
        Me.optHPlus.Name = "optHPlus"
        Me.optHPlus.Size = New System.Drawing.Size(43, 15)
        Me.optHPlus.TabIndex = 0
        Me.optHPlus.TabStop = True
        Me.optHPlus.Text = "+ H"
        Me.optHPlus.UseVisualStyleBackColor = True
        '
        'optHMoin
        '
        Me.optHMoin.AutoSize = True
        Me.optHMoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optHMoin.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optHMoin.Location = New System.Drawing.Point(6, 36)
        Me.optHMoin.Name = "optHMoin"
        Me.optHMoin.Size = New System.Drawing.Size(43, 15)
        Me.optHMoin.TabIndex = 1
        Me.optHMoin.TabStop = True
        Me.optHMoin.Text = "- H"
        Me.optHMoin.UseVisualStyleBackColor = True
        '
        'gbI
        '
        Me.gbI.BackColor = System.Drawing.Color.Black
        Me.gbI.BorderColor = System.Drawing.Color.LightBlue
        Me.gbI.Controls.Add(Me.optINull)
        Me.gbI.Controls.Add(Me.optIPlus)
        Me.gbI.Controls.Add(Me.optIMoin)
        Me.gbI.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbI.ForeColor = System.Drawing.Color.LightBlue
        Me.gbI.Location = New System.Drawing.Point(404, 50)
        Me.gbI.Name = "gbI"
        Me.gbI.Size = New System.Drawing.Size(64, 88)
        Me.gbI.TabIndex = 40
        Me.gbI.TabStop = False
        Me.gbI.Text = "I"
        '
        'optINull
        '
        Me.optINull.AutoSize = True
        Me.optINull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optINull.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optINull.Location = New System.Drawing.Point(6, 59)
        Me.optINull.Name = "optINull"
        Me.optINull.Size = New System.Drawing.Size(50, 15)
        Me.optINull.TabIndex = 2
        Me.optINull.TabStop = True
        Me.optINull.Text = "Null"
        Me.optINull.UseVisualStyleBackColor = True
        '
        'optIPlus
        '
        Me.optIPlus.AutoSize = True
        Me.optIPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optIPlus.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optIPlus.Location = New System.Drawing.Point(6, 17)
        Me.optIPlus.Name = "optIPlus"
        Me.optIPlus.Size = New System.Drawing.Size(43, 15)
        Me.optIPlus.TabIndex = 0
        Me.optIPlus.TabStop = True
        Me.optIPlus.Text = "+ I"
        Me.optIPlus.UseVisualStyleBackColor = True
        '
        'optIMoin
        '
        Me.optIMoin.AutoSize = True
        Me.optIMoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optIMoin.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optIMoin.Location = New System.Drawing.Point(6, 38)
        Me.optIMoin.Name = "optIMoin"
        Me.optIMoin.Size = New System.Drawing.Size(43, 15)
        Me.optIMoin.TabIndex = 1
        Me.optIMoin.TabStop = True
        Me.optIMoin.Text = "- I"
        Me.optIMoin.UseVisualStyleBackColor = True
        '
        'gbA
        '
        Me.gbA.BackColor = System.Drawing.Color.Black
        Me.gbA.BorderColor = System.Drawing.Color.LightBlue
        Me.gbA.Controls.Add(Me.optANull)
        Me.gbA.Controls.Add(Me.optAplus)
        Me.gbA.Controls.Add(Me.optAMoin)
        Me.gbA.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbA.ForeColor = System.Drawing.Color.LightBlue
        Me.gbA.Location = New System.Drawing.Point(194, 50)
        Me.gbA.Name = "gbA"
        Me.gbA.Size = New System.Drawing.Size(64, 88)
        Me.gbA.TabIndex = 39
        Me.gbA.TabStop = False
        Me.gbA.Text = "A"
        '
        'optANull
        '
        Me.optANull.AutoSize = True
        Me.optANull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optANull.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optANull.Location = New System.Drawing.Point(6, 59)
        Me.optANull.Name = "optANull"
        Me.optANull.Size = New System.Drawing.Size(50, 15)
        Me.optANull.TabIndex = 2
        Me.optANull.TabStop = True
        Me.optANull.Text = "Null"
        Me.optANull.UseVisualStyleBackColor = True
        '
        'optAplus
        '
        Me.optAplus.AutoSize = True
        Me.optAplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAplus.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAplus.Location = New System.Drawing.Point(6, 17)
        Me.optAplus.Name = "optAplus"
        Me.optAplus.Size = New System.Drawing.Size(43, 15)
        Me.optAplus.TabIndex = 0
        Me.optAplus.TabStop = True
        Me.optAplus.Text = "+ A"
        Me.optAplus.UseVisualStyleBackColor = True
        '
        'optAMoin
        '
        Me.optAMoin.AutoSize = True
        Me.optAMoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAMoin.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAMoin.Location = New System.Drawing.Point(6, 38)
        Me.optAMoin.Name = "optAMoin"
        Me.optAMoin.Size = New System.Drawing.Size(43, 15)
        Me.optAMoin.TabIndex = 1
        Me.optAMoin.TabStop = True
        Me.optAMoin.Text = "- A"
        Me.optAMoin.UseVisualStyleBackColor = True
        '
        'gbS
        '
        Me.gbS.BackColor = System.Drawing.Color.Black
        Me.gbS.BorderColor = System.Drawing.Color.LightBlue
        Me.gbS.Controls.Add(Me.optSNull)
        Me.gbS.Controls.Add(Me.optSPlus)
        Me.gbS.Controls.Add(Me.optSMoin)
        Me.gbS.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbS.ForeColor = System.Drawing.Color.LightBlue
        Me.gbS.Location = New System.Drawing.Point(264, 50)
        Me.gbS.Name = "gbS"
        Me.gbS.Size = New System.Drawing.Size(64, 88)
        Me.gbS.TabIndex = 38
        Me.gbS.TabStop = False
        Me.gbS.Text = "S"
        '
        'optSNull
        '
        Me.optSNull.AutoSize = True
        Me.optSNull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optSNull.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optSNull.Location = New System.Drawing.Point(6, 59)
        Me.optSNull.Name = "optSNull"
        Me.optSNull.Size = New System.Drawing.Size(50, 15)
        Me.optSNull.TabIndex = 2
        Me.optSNull.TabStop = True
        Me.optSNull.Text = "Null"
        Me.optSNull.UseVisualStyleBackColor = True
        '
        'optSPlus
        '
        Me.optSPlus.AutoSize = True
        Me.optSPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optSPlus.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optSPlus.Location = New System.Drawing.Point(6, 17)
        Me.optSPlus.Name = "optSPlus"
        Me.optSPlus.Size = New System.Drawing.Size(43, 15)
        Me.optSPlus.TabIndex = 0
        Me.optSPlus.TabStop = True
        Me.optSPlus.Text = "+ S"
        Me.optSPlus.UseVisualStyleBackColor = True
        '
        'optSMoin
        '
        Me.optSMoin.AutoSize = True
        Me.optSMoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optSMoin.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optSMoin.Location = New System.Drawing.Point(6, 38)
        Me.optSMoin.Name = "optSMoin"
        Me.optSMoin.Size = New System.Drawing.Size(43, 15)
        Me.optSMoin.TabIndex = 1
        Me.optSMoin.TabStop = True
        Me.optSMoin.Text = "- S"
        Me.optSMoin.UseVisualStyleBackColor = True
        '
        'gbR
        '
        Me.gbR.BackColor = System.Drawing.Color.Black
        Me.gbR.BorderColor = System.Drawing.Color.LightBlue
        Me.gbR.Controls.Add(Me.optRNull)
        Me.gbR.Controls.Add(Me.optRPlus)
        Me.gbR.Controls.Add(Me.optRMoin)
        Me.gbR.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbR.ForeColor = System.Drawing.Color.LightBlue
        Me.gbR.Location = New System.Drawing.Point(124, 50)
        Me.gbR.Name = "gbR"
        Me.gbR.Size = New System.Drawing.Size(64, 88)
        Me.gbR.TabIndex = 37
        Me.gbR.TabStop = False
        Me.gbR.Text = "R"
        '
        'optRNull
        '
        Me.optRNull.AutoSize = True
        Me.optRNull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optRNull.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optRNull.Location = New System.Drawing.Point(7, 59)
        Me.optRNull.Name = "optRNull"
        Me.optRNull.Size = New System.Drawing.Size(50, 15)
        Me.optRNull.TabIndex = 2
        Me.optRNull.TabStop = True
        Me.optRNull.Text = "Null"
        Me.optRNull.UseVisualStyleBackColor = True
        '
        'optRPlus
        '
        Me.optRPlus.AutoSize = True
        Me.optRPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optRPlus.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optRPlus.Location = New System.Drawing.Point(7, 17)
        Me.optRPlus.Name = "optRPlus"
        Me.optRPlus.Size = New System.Drawing.Size(43, 15)
        Me.optRPlus.TabIndex = 0
        Me.optRPlus.TabStop = True
        Me.optRPlus.Text = "+ R"
        Me.optRPlus.UseVisualStyleBackColor = True
        '
        'optRMoin
        '
        Me.optRMoin.AutoSize = True
        Me.optRMoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optRMoin.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optRMoin.Location = New System.Drawing.Point(7, 38)
        Me.optRMoin.Name = "optRMoin"
        Me.optRMoin.Size = New System.Drawing.Size(43, 15)
        Me.optRMoin.TabIndex = 1
        Me.optRMoin.TabStop = True
        Me.optRMoin.Text = "- R"
        Me.optRMoin.UseVisualStyleBackColor = True
        '
        'btnFolders
        '
        Me.btnFolders.BackColor = System.Drawing.Color.Black
        Me.btnFolders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFolders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFolders.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnFolders.ForeColor = System.Drawing.Color.LightBlue
        Me.btnFolders.Location = New System.Drawing.Point(88, 210)
        Me.btnFolders.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnFolders.Name = "btnFolders"
        Me.btnFolders.Size = New System.Drawing.Size(75, 23)
        Me.btnFolders.TabIndex = 36
        Me.btnFolders.Text = "Dossier"
        Me.btnFolders.UseVisualStyleBackColor = False
        '
        'btnFiles
        '
        Me.btnFiles.BackColor = System.Drawing.Color.Black
        Me.btnFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiles.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnFiles.ForeColor = System.Drawing.Color.LightBlue
        Me.btnFiles.Location = New System.Drawing.Point(7, 210)
        Me.btnFiles.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnFiles.Name = "btnFiles"
        Me.btnFiles.Size = New System.Drawing.Size(75, 23)
        Me.btnFiles.TabIndex = 35
        Me.btnFiles.Text = "Fichier"
        Me.btnFiles.UseVisualStyleBackColor = False
        '
        'btnAide
        '
        Me.btnAide.BackColor = System.Drawing.Color.Black
        Me.btnAide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAide.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnAide.ForeColor = System.Drawing.Color.LightBlue
        Me.btnAide.Location = New System.Drawing.Point(7, 574)
        Me.btnAide.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnAide.Name = "btnAide"
        Me.btnAide.Size = New System.Drawing.Size(96, 23)
        Me.btnAide.TabIndex = 34
        Me.btnAide.Text = "Aide"
        Me.btnAide.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.LightBlue
        Me.btnBack.Location = New System.Drawing.Point(484, 574)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(96, 23)
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
        Me.btnApply.Location = New System.Drawing.Point(382, 574)
        Me.btnApply.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(96, 23)
        Me.btnApply.TabIndex = 32
        Me.btnApply.Text = "Appliquer"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.LightBlue
        Me.btnClear.Location = New System.Drawing.Point(484, 545)
        Me.btnClear.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 23)
        Me.btnClear.TabIndex = 31
        Me.btnClear.Text = "Effacer"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(7, 239)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(573, 277)
        Me.myConsole.TabIndex = 29
        '
        'txtFile
        '
        Me.txtFile.BackColor = System.Drawing.Color.Black
        Me.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFile.Enabled = False
        Me.txtFile.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtFile.ForeColor = System.Drawing.Color.LightBlue
        Me.txtFile.Location = New System.Drawing.Point(169, 212)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(411, 18)
        Me.txtFile.TabIndex = 42
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(155, 522)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(425, 18)
        Me.txtCmdExec.TabIndex = 43
        '
        'GuiDosboxLabel1
        '
        Me.GuiDosboxLabel1.AutoSize = True
        Me.GuiDosboxLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosboxLabel1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosboxLabel1.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosboxLabel1.Location = New System.Drawing.Point(5, 524)
        Me.GuiDosboxLabel1.Name = "GuiDosboxLabel1"
        Me.GuiDosboxLabel1.Size = New System.Drawing.Size(131, 11)
        Me.GuiDosboxLabel1.TabIndex = 44
        Me.GuiDosboxLabel1.Text = "Commande exécuté :"
        '
        'gbOptions
        '
        Me.gbOptions.BackColor = System.Drawing.Color.Black
        Me.gbOptions.BorderColor = System.Drawing.Color.LightBlue
        Me.gbOptions.Controls.Add(Me.optL)
        Me.gbOptions.Controls.Add(Me.optS)
        Me.gbOptions.Controls.Add(Me.optD)
        Me.gbOptions.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.gbOptions.ForeColor = System.Drawing.Color.LightBlue
        Me.gbOptions.Location = New System.Drawing.Point(210, 148)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(168, 44)
        Me.gbOptions.TabIndex = 45
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "/options"
        '
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.BackColor = System.Drawing.Color.Black
        Me.optAdvanceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAdvanceMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAdvanceMode.Location = New System.Drawing.Point(110, 581)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(98, 15)
        Me.optAdvanceMode.TabIndex = 46
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
        Me.btnSend.Location = New System.Drawing.Point(290, 555)
        Me.btnSend.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 47
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'footer
        '
        Me.footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footer.Location = New System.Drawing.Point(0, 600)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(585, 22)
        Me.footer.TabIndex = 48
        '
        'AttribApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(585, 622)
        Me.ControlBox = False
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.gbI)
        Me.Controls.Add(Me.gbH)
        Me.Controls.Add(Me.gbS)
        Me.Controls.Add(Me.gbA)
        Me.Controls.Add(Me.gbR)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.GuiDosboxLabel1)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.btnFolders)
        Me.Controls.Add(Me.btnFiles)
        Me.Controls.Add(Me.btnAide)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.chkbxLangue)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AttribApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI DosBox - ATTRIB"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbH.ResumeLayout(False)
        Me.gbH.PerformLayout()
        Me.gbI.ResumeLayout(False)
        Me.gbI.PerformLayout()
        Me.gbA.ResumeLayout(False)
        Me.gbA.PerformLayout()
        Me.gbS.ResumeLayout(False)
        Me.gbS.PerformLayout()
        Me.gbR.ResumeLayout(False)
        Me.gbR.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optL As System.Windows.Forms.CheckBox
    Friend WithEvents optD As System.Windows.Forms.CheckBox
    Friend WithEvents optS As System.Windows.Forms.CheckBox
    Friend WithEvents optRMoin As System.Windows.Forms.RadioButton
    Friend WithEvents optRPlus As System.Windows.Forms.RadioButton
    Friend WithEvents optAMoin As System.Windows.Forms.RadioButton
    Friend WithEvents optAplus As System.Windows.Forms.RadioButton
    Friend WithEvents optSMoin As System.Windows.Forms.RadioButton
    Friend WithEvents optSPlus As System.Windows.Forms.RadioButton
    Friend WithEvents optHMoin As System.Windows.Forms.RadioButton
    Friend WithEvents optHPlus As System.Windows.Forms.RadioButton
    Friend WithEvents optIMoin As System.Windows.Forms.RadioButton
    Friend WithEvents optIPlus As System.Windows.Forms.RadioButton
    Friend WithEvents optRNull As System.Windows.Forms.RadioButton
    Friend WithEvents optANull As System.Windows.Forms.RadioButton
    Friend WithEvents optSNull As System.Windows.Forms.RadioButton
    Friend WithEvents optHNull As System.Windows.Forms.RadioButton
    Friend WithEvents optINull As System.Windows.Forms.RadioButton
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents btnClear As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnApply As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnAide As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnFiles As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnFolders As GUIDosbox.GUIDosbox_Button
    Friend WithEvents gbR As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents gbS As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents gbA As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents gbI As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents gbH As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents txtFile As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents GuiDosboxLabel1 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents gbOptions As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
    Friend WithEvents footer As GUIDosbox.GUIDosbox_StatusStrip
End Class
