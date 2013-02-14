<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaclsApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CaclsApp))
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.GuiDosboxGroupbox6 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.btnBrowse = New GUIDosbox.GUIDosbox_Button()
        Me.txtFile = New GUIDosbox.GUIDosbox_Textbox()
        Me.GuiDosboxGroupbox5 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.cbUserD = New GUIDosbox.GUIDosbox_Combobox()
        Me.lblUtili4 = New System.Windows.Forms.Label()
        Me.optD = New System.Windows.Forms.CheckBox()
        Me.GuiDosboxGroupbox1 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optC = New System.Windows.Forms.CheckBox()
        Me.optT = New System.Windows.Forms.CheckBox()
        Me.optE = New System.Windows.Forms.CheckBox()
        Me.optM = New System.Windows.Forms.CheckBox()
        Me.optL = New System.Windows.Forms.CheckBox()
        Me.GuiDosboxGroupbox2 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.cbUserP = New GUIDosbox.GUIDosbox_Combobox()
        Me.lblUtili = New System.Windows.Forms.Label()
        Me.optP = New System.Windows.Forms.CheckBox()
        Me.optPLecture = New GUIDosbox.GUIDosbox_RadioButton()
        Me.optPAucun = New GUIDosbox.GUIDosbox_RadioButton()
        Me.optPControlT = New GUIDosbox.GUIDosbox_RadioButton()
        Me.optPModif = New GUIDosbox.GUIDosbox_RadioButton()
        Me.optPEcrire = New GUIDosbox.GUIDosbox_RadioButton()
        Me.GuiDosboxGroupbox3 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.optGControlT = New GUIDosbox.GUIDosbox_RadioButton()
        Me.optGModif = New GUIDosbox.GUIDosbox_RadioButton()
        Me.optGEcrire = New GUIDosbox.GUIDosbox_RadioButton()
        Me.optGLecture = New GUIDosbox.GUIDosbox_RadioButton()
        Me.cbUserG = New GUIDosbox.GUIDosbox_Combobox()
        Me.lblutili2 = New System.Windows.Forms.Label()
        Me.optG = New System.Windows.Forms.CheckBox()
        Me.GuiDosboxGroupbox4 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.cbUserR = New GUIDosbox.GUIDosbox_Combobox()
        Me.lblUtili3 = New System.Windows.Forms.Label()
        Me.optR = New System.Windows.Forms.CheckBox()
        Me.optAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
        Me.btnApply = New GUIDosbox.GUIDosbox_Button()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnClear = New GUIDosbox.GUIDosbox_Button()
        Me.btnHelp = New GUIDosbox.GUIDosbox_Button()
        Me.lblCmdExec = New GUIDosbox.GUIDosbox_Label()
        Me.txtCmdExec = New GUIDosbox.GUIDosbox_Textbox()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        Me.footer = New GUIDosbox.GUIDosbox_StatusStrip()
        Me.btnYes = New GUIDosbox.GUIDosbox_Button()
        Me.btnNo = New GUIDosbox.GUIDosbox_Button()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GuiDosboxGroupbox6.SuspendLayout()
        Me.GuiDosboxGroupbox5.SuspendLayout()
        Me.GuiDosboxGroupbox1.SuspendLayout()
        Me.GuiDosboxGroupbox2.SuspendLayout()
        Me.GuiDosboxGroupbox3.SuspendLayout()
        Me.GuiDosboxGroupbox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(29, 498)
        Me.chkbxLangue.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
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
        Me.flashHeader.Location = New System.Drawing.Point(0, 0)
        Me.flashHeader.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(850, 40)
        Me.flashHeader.TabIndex = 32
        '
        'GuiDosboxGroupbox6
        '
        Me.GuiDosboxGroupbox6.BackColor = System.Drawing.Color.Black
        Me.GuiDosboxGroupbox6.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosboxGroupbox6.Controls.Add(Me.btnBrowse)
        Me.GuiDosboxGroupbox6.Controls.Add(Me.txtFile)
        Me.GuiDosboxGroupbox6.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosboxGroupbox6.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosboxGroupbox6.Location = New System.Drawing.Point(9, 117)
        Me.GuiDosboxGroupbox6.Name = "GuiDosboxGroupbox6"
        Me.GuiDosboxGroupbox6.Size = New System.Drawing.Size(321, 66)
        Me.GuiDosboxGroupbox6.TabIndex = 3
        Me.GuiDosboxGroupbox6.TabStop = False
        Me.GuiDosboxGroupbox6.Text = " Fichier "
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Black
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.btnBrowse.ForeColor = System.Drawing.Color.LightBlue
        Me.btnBrowse.Location = New System.Drawing.Point(6, 14)
        Me.btnBrowse.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(91, 23)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Parcourir"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'txtFile
        '
        Me.txtFile.BackColor = System.Drawing.Color.Black
        Me.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFile.Enabled = False
        Me.txtFile.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtFile.ForeColor = System.Drawing.Color.LightBlue
        Me.txtFile.Location = New System.Drawing.Point(6, 42)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(308, 18)
        Me.txtFile.TabIndex = 3
        '
        'GuiDosboxGroupbox5
        '
        Me.GuiDosboxGroupbox5.BackColor = System.Drawing.Color.Black
        Me.GuiDosboxGroupbox5.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosboxGroupbox5.Controls.Add(Me.cbUserD)
        Me.GuiDosboxGroupbox5.Controls.Add(Me.lblUtili4)
        Me.GuiDosboxGroupbox5.Controls.Add(Me.optD)
        Me.GuiDosboxGroupbox5.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosboxGroupbox5.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosboxGroupbox5.Location = New System.Drawing.Point(173, 191)
        Me.GuiDosboxGroupbox5.Name = "GuiDosboxGroupbox5"
        Me.GuiDosboxGroupbox5.Size = New System.Drawing.Size(158, 66)
        Me.GuiDosboxGroupbox5.TabIndex = 41
        Me.GuiDosboxGroupbox5.TabStop = False
        '
        'cbUserD
        '
        Me.cbUserD.BackColor = System.Drawing.Color.Black
        Me.cbUserD.DropDownWidth = 330
        Me.cbUserD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbUserD.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.cbUserD.ForeColor = System.Drawing.Color.LightBlue
        Me.cbUserD.FormattingEnabled = True
        Me.cbUserD.Location = New System.Drawing.Point(5, 41)
        Me.cbUserD.Name = "cbUserD"
        Me.cbUserD.Size = New System.Drawing.Size(147, 19)
        Me.cbUserD.Sorted = True
        Me.cbUserD.TabIndex = 3
        '
        'lblUtili4
        '
        Me.lblUtili4.AutoSize = True
        Me.lblUtili4.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblUtili4.Location = New System.Drawing.Point(3, 27)
        Me.lblUtili4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblUtili4.Name = "lblUtili4"
        Me.lblUtili4.Size = New System.Drawing.Size(138, 11)
        Me.lblUtili4.TabIndex = 2
        Me.lblUtili4.Text = "Utilisateur/Groupe:"
        '
        'optD
        '
        Me.optD.AutoSize = True
        Me.optD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optD.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optD.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optD.Location = New System.Drawing.Point(120, 9)
        Me.optD.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.optD.Name = "optD"
        Me.optD.Size = New System.Drawing.Size(35, 15)
        Me.optD.TabIndex = 0
        Me.optD.Text = "/D"
        Me.optD.UseVisualStyleBackColor = True
        '
        'GuiDosboxGroupbox1
        '
        Me.GuiDosboxGroupbox1.BackColor = System.Drawing.Color.Black
        Me.GuiDosboxGroupbox1.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosboxGroupbox1.Controls.Add(Me.optC)
        Me.GuiDosboxGroupbox1.Controls.Add(Me.optT)
        Me.GuiDosboxGroupbox1.Controls.Add(Me.optE)
        Me.GuiDosboxGroupbox1.Controls.Add(Me.optM)
        Me.GuiDosboxGroupbox1.Controls.Add(Me.optL)
        Me.GuiDosboxGroupbox1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosboxGroupbox1.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosboxGroupbox1.Location = New System.Drawing.Point(9, 47)
        Me.GuiDosboxGroupbox1.Name = "GuiDosboxGroupbox1"
        Me.GuiDosboxGroupbox1.Size = New System.Drawing.Size(322, 66)
        Me.GuiDosboxGroupbox1.TabIndex = 4
        Me.GuiDosboxGroupbox1.TabStop = False
        Me.GuiDosboxGroupbox1.Text = " Options "
        '
        'optC
        '
        Me.optC.AutoSize = True
        Me.optC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optC.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optC.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optC.Location = New System.Drawing.Point(141, 17)
        Me.optC.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.optC.Name = "optC"
        Me.optC.Size = New System.Drawing.Size(42, 15)
        Me.optC.TabIndex = 25
        Me.optC.Text = "/ C"
        Me.optC.UseVisualStyleBackColor = True
        '
        'optT
        '
        Me.optT.AutoSize = True
        Me.optT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optT.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optT.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optT.Location = New System.Drawing.Point(89, 18)
        Me.optT.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.optT.Name = "optT"
        Me.optT.Size = New System.Drawing.Size(42, 15)
        Me.optT.TabIndex = 21
        Me.optT.Text = "/ T"
        Me.optT.UseVisualStyleBackColor = True
        '
        'optE
        '
        Me.optE.AutoSize = True
        Me.optE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optE.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optE.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optE.Location = New System.Drawing.Point(193, 17)
        Me.optE.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.optE.Name = "optE"
        Me.optE.Size = New System.Drawing.Size(42, 15)
        Me.optE.TabIndex = 24
        Me.optE.Text = "/ E"
        Me.optE.UseVisualStyleBackColor = True
        '
        'optM
        '
        Me.optM.AutoSize = True
        Me.optM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optM.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optM.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optM.Location = New System.Drawing.Point(88, 39)
        Me.optM.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.optM.Name = "optM"
        Me.optM.Size = New System.Drawing.Size(42, 15)
        Me.optM.TabIndex = 22
        Me.optM.Text = "/ M"
        Me.optM.UseVisualStyleBackColor = True
        '
        'optL
        '
        Me.optL.AutoSize = True
        Me.optL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optL.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optL.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optL.Location = New System.Drawing.Point(141, 38)
        Me.optL.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.optL.Name = "optL"
        Me.optL.Size = New System.Drawing.Size(42, 15)
        Me.optL.TabIndex = 23
        Me.optL.Text = "/ L"
        Me.optL.UseVisualStyleBackColor = True
        '
        'GuiDosboxGroupbox2
        '
        Me.GuiDosboxGroupbox2.BackColor = System.Drawing.Color.Black
        Me.GuiDosboxGroupbox2.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosboxGroupbox2.Controls.Add(Me.cbUserP)
        Me.GuiDosboxGroupbox2.Controls.Add(Me.lblUtili)
        Me.GuiDosboxGroupbox2.Controls.Add(Me.optP)
        Me.GuiDosboxGroupbox2.Controls.Add(Me.optPLecture)
        Me.GuiDosboxGroupbox2.Controls.Add(Me.optPAucun)
        Me.GuiDosboxGroupbox2.Controls.Add(Me.optPControlT)
        Me.GuiDosboxGroupbox2.Controls.Add(Me.optPModif)
        Me.GuiDosboxGroupbox2.Controls.Add(Me.optPEcrire)
        Me.GuiDosboxGroupbox2.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosboxGroupbox2.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosboxGroupbox2.Location = New System.Drawing.Point(9, 263)
        Me.GuiDosboxGroupbox2.Name = "GuiDosboxGroupbox2"
        Me.GuiDosboxGroupbox2.Size = New System.Drawing.Size(322, 107)
        Me.GuiDosboxGroupbox2.TabIndex = 0
        Me.GuiDosboxGroupbox2.TabStop = False
        '
        'cbUserP
        '
        Me.cbUserP.BackColor = System.Drawing.Color.Black
        Me.cbUserP.DropDownWidth = 330
        Me.cbUserP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbUserP.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.cbUserP.ForeColor = System.Drawing.Color.LightBlue
        Me.cbUserP.FormattingEnabled = True
        Me.cbUserP.Location = New System.Drawing.Point(151, 29)
        Me.cbUserP.Name = "cbUserP"
        Me.cbUserP.Size = New System.Drawing.Size(163, 19)
        Me.cbUserP.Sorted = True
        Me.cbUserP.TabIndex = 5
        '
        'lblUtili
        '
        Me.lblUtili.AutoSize = True
        Me.lblUtili.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblUtili.Location = New System.Drawing.Point(8, 32)
        Me.lblUtili.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblUtili.Name = "lblUtili"
        Me.lblUtili.Size = New System.Drawing.Size(138, 11)
        Me.lblUtili.TabIndex = 3
        Me.lblUtili.Text = "Utilisateur/Groupe:"
        '
        'optP
        '
        Me.optP.AutoSize = True
        Me.optP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optP.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optP.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optP.Location = New System.Drawing.Point(284, 10)
        Me.optP.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.optP.Name = "optP"
        Me.optP.Size = New System.Drawing.Size(35, 15)
        Me.optP.TabIndex = 0
        Me.optP.Text = "/P"
        Me.optP.UseVisualStyleBackColor = True
        '
        'optPLecture
        '
        Me.optPLecture.AutoSize = True
        Me.optPLecture.BackColor = System.Drawing.Color.Black
        Me.optPLecture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optPLecture.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optPLecture.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optPLecture.Location = New System.Drawing.Point(19, 54)
        Me.optPLecture.Name = "optPLecture"
        Me.optPLecture.Size = New System.Drawing.Size(99, 15)
        Me.optPLecture.TabIndex = 47
        Me.optPLecture.TabStop = True
        Me.optPLecture.Text = "Lecture (R)"
        Me.optPLecture.UseVisualStyleBackColor = False
        '
        'optPAucun
        '
        Me.optPAucun.AutoSize = True
        Me.optPAucun.BackColor = System.Drawing.Color.Black
        Me.optPAucun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optPAucun.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optPAucun.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optPAucun.Location = New System.Drawing.Point(19, 86)
        Me.optPAucun.Name = "optPAucun"
        Me.optPAucun.Size = New System.Drawing.Size(85, 15)
        Me.optPAucun.TabIndex = 43
        Me.optPAucun.TabStop = True
        Me.optPAucun.Text = "Aucun (N)"
        Me.optPAucun.UseVisualStyleBackColor = False
        '
        'optPControlT
        '
        Me.optPControlT.AutoSize = True
        Me.optPControlT.BackColor = System.Drawing.Color.Black
        Me.optPControlT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optPControlT.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optPControlT.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optPControlT.Location = New System.Drawing.Point(156, 71)
        Me.optPControlT.Name = "optPControlT"
        Me.optPControlT.Size = New System.Drawing.Size(148, 15)
        Me.optPControlT.TabIndex = 44
        Me.optPControlT.TabStop = True
        Me.optPControlT.Text = "Contrôle Total (F)"
        Me.optPControlT.UseVisualStyleBackColor = False
        '
        'optPModif
        '
        Me.optPModif.AutoSize = True
        Me.optPModif.BackColor = System.Drawing.Color.Black
        Me.optPModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optPModif.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optPModif.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optPModif.Location = New System.Drawing.Point(19, 71)
        Me.optPModif.Name = "optPModif"
        Me.optPModif.Size = New System.Drawing.Size(134, 15)
        Me.optPModif.TabIndex = 46
        Me.optPModif.TabStop = True
        Me.optPModif.Text = "Modification (C)"
        Me.optPModif.UseVisualStyleBackColor = False
        '
        'optPEcrire
        '
        Me.optPEcrire.AutoSize = True
        Me.optPEcrire.BackColor = System.Drawing.Color.Black
        Me.optPEcrire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optPEcrire.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optPEcrire.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optPEcrire.Location = New System.Drawing.Point(156, 54)
        Me.optPEcrire.Name = "optPEcrire"
        Me.optPEcrire.Size = New System.Drawing.Size(106, 15)
        Me.optPEcrire.TabIndex = 45
        Me.optPEcrire.TabStop = True
        Me.optPEcrire.Text = "Écriture (W)"
        Me.optPEcrire.UseVisualStyleBackColor = False
        '
        'GuiDosboxGroupbox3
        '
        Me.GuiDosboxGroupbox3.BackColor = System.Drawing.Color.Black
        Me.GuiDosboxGroupbox3.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosboxGroupbox3.Controls.Add(Me.optGControlT)
        Me.GuiDosboxGroupbox3.Controls.Add(Me.optGModif)
        Me.GuiDosboxGroupbox3.Controls.Add(Me.optGEcrire)
        Me.GuiDosboxGroupbox3.Controls.Add(Me.optGLecture)
        Me.GuiDosboxGroupbox3.Controls.Add(Me.cbUserG)
        Me.GuiDosboxGroupbox3.Controls.Add(Me.lblutili2)
        Me.GuiDosboxGroupbox3.Controls.Add(Me.optG)
        Me.GuiDosboxGroupbox3.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosboxGroupbox3.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosboxGroupbox3.Location = New System.Drawing.Point(9, 376)
        Me.GuiDosboxGroupbox3.Name = "GuiDosboxGroupbox3"
        Me.GuiDosboxGroupbox3.Size = New System.Drawing.Size(322, 92)
        Me.GuiDosboxGroupbox3.TabIndex = 0
        Me.GuiDosboxGroupbox3.TabStop = False
        '
        'optGControlT
        '
        Me.optGControlT.AutoSize = True
        Me.optGControlT.BackColor = System.Drawing.Color.Black
        Me.optGControlT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optGControlT.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optGControlT.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optGControlT.Location = New System.Drawing.Point(157, 71)
        Me.optGControlT.Name = "optGControlT"
        Me.optGControlT.Size = New System.Drawing.Size(148, 15)
        Me.optGControlT.TabIndex = 48
        Me.optGControlT.TabStop = True
        Me.optGControlT.Text = "Contrôle Total (F)"
        Me.optGControlT.UseVisualStyleBackColor = False
        '
        'optGModif
        '
        Me.optGModif.AutoSize = True
        Me.optGModif.BackColor = System.Drawing.Color.Black
        Me.optGModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optGModif.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optGModif.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optGModif.Location = New System.Drawing.Point(17, 71)
        Me.optGModif.Name = "optGModif"
        Me.optGModif.Size = New System.Drawing.Size(134, 15)
        Me.optGModif.TabIndex = 49
        Me.optGModif.TabStop = True
        Me.optGModif.Text = "Modification (C)"
        Me.optGModif.UseVisualStyleBackColor = False
        '
        'optGEcrire
        '
        Me.optGEcrire.AutoSize = True
        Me.optGEcrire.BackColor = System.Drawing.Color.Black
        Me.optGEcrire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optGEcrire.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optGEcrire.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optGEcrire.Location = New System.Drawing.Point(157, 52)
        Me.optGEcrire.Name = "optGEcrire"
        Me.optGEcrire.Size = New System.Drawing.Size(106, 15)
        Me.optGEcrire.TabIndex = 50
        Me.optGEcrire.TabStop = True
        Me.optGEcrire.Text = "Écriture (W)"
        Me.optGEcrire.UseVisualStyleBackColor = False
        '
        'optGLecture
        '
        Me.optGLecture.AutoSize = True
        Me.optGLecture.BackColor = System.Drawing.Color.Black
        Me.optGLecture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optGLecture.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optGLecture.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optGLecture.Location = New System.Drawing.Point(17, 53)
        Me.optGLecture.Name = "optGLecture"
        Me.optGLecture.Size = New System.Drawing.Size(99, 15)
        Me.optGLecture.TabIndex = 51
        Me.optGLecture.TabStop = True
        Me.optGLecture.Text = "Lecture (R)"
        Me.optGLecture.UseVisualStyleBackColor = False
        '
        'cbUserG
        '
        Me.cbUserG.BackColor = System.Drawing.Color.Black
        Me.cbUserG.DropDownWidth = 330
        Me.cbUserG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbUserG.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.cbUserG.ForeColor = System.Drawing.Color.LightBlue
        Me.cbUserG.FormattingEnabled = True
        Me.cbUserG.Location = New System.Drawing.Point(151, 28)
        Me.cbUserG.Name = "cbUserG"
        Me.cbUserG.Size = New System.Drawing.Size(163, 19)
        Me.cbUserG.Sorted = True
        Me.cbUserG.TabIndex = 4
        '
        'lblutili2
        '
        Me.lblutili2.AutoSize = True
        Me.lblutili2.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblutili2.Location = New System.Drawing.Point(8, 31)
        Me.lblutili2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblutili2.Name = "lblutili2"
        Me.lblutili2.Size = New System.Drawing.Size(138, 11)
        Me.lblutili2.TabIndex = 3
        Me.lblutili2.Text = "Utilisateur/Groupe:"
        '
        'optG
        '
        Me.optG.AutoSize = True
        Me.optG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optG.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optG.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optG.Location = New System.Drawing.Point(284, 10)
        Me.optG.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.optG.Name = "optG"
        Me.optG.Size = New System.Drawing.Size(35, 15)
        Me.optG.TabIndex = 2
        Me.optG.Text = "/G"
        Me.optG.UseVisualStyleBackColor = True
        '
        'GuiDosboxGroupbox4
        '
        Me.GuiDosboxGroupbox4.BackColor = System.Drawing.Color.Black
        Me.GuiDosboxGroupbox4.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosboxGroupbox4.Controls.Add(Me.cbUserR)
        Me.GuiDosboxGroupbox4.Controls.Add(Me.lblUtili3)
        Me.GuiDosboxGroupbox4.Controls.Add(Me.optR)
        Me.GuiDosboxGroupbox4.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosboxGroupbox4.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosboxGroupbox4.Location = New System.Drawing.Point(9, 191)
        Me.GuiDosboxGroupbox4.Name = "GuiDosboxGroupbox4"
        Me.GuiDosboxGroupbox4.Size = New System.Drawing.Size(158, 66)
        Me.GuiDosboxGroupbox4.TabIndex = 0
        Me.GuiDosboxGroupbox4.TabStop = False
        '
        'cbUserR
        '
        Me.cbUserR.BackColor = System.Drawing.Color.Black
        Me.cbUserR.DropDownWidth = 330
        Me.cbUserR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbUserR.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.cbUserR.ForeColor = System.Drawing.Color.LightBlue
        Me.cbUserR.FormattingEnabled = True
        Me.cbUserR.Location = New System.Drawing.Point(5, 41)
        Me.cbUserR.Name = "cbUserR"
        Me.cbUserR.Size = New System.Drawing.Size(147, 19)
        Me.cbUserR.Sorted = True
        Me.cbUserR.TabIndex = 42
        '
        'lblUtili3
        '
        Me.lblUtili3.AutoSize = True
        Me.lblUtili3.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblUtili3.Location = New System.Drawing.Point(5, 27)
        Me.lblUtili3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblUtili3.Name = "lblUtili3"
        Me.lblUtili3.Size = New System.Drawing.Size(138, 11)
        Me.lblUtili3.TabIndex = 2
        Me.lblUtili3.Text = "Utilisateur/Groupe:"
        '
        'optR
        '
        Me.optR.AutoSize = True
        Me.optR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optR.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optR.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optR.Location = New System.Drawing.Point(121, 9)
        Me.optR.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.optR.Name = "optR"
        Me.optR.Size = New System.Drawing.Size(35, 15)
        Me.optR.TabIndex = 0
        Me.optR.Text = "/R"
        Me.optR.UseVisualStyleBackColor = True
        '
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.BackColor = System.Drawing.Color.Black
        Me.optAdvanceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAdvanceMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAdvanceMode.Location = New System.Drawing.Point(106, 535)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(98, 15)
        Me.optAdvanceMode.TabIndex = 40
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
        Me.btnSend.Location = New System.Drawing.Point(507, 498)
        Me.btnSend.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(91, 23)
        Me.btnSend.TabIndex = 39
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
        Me.btnApply.Location = New System.Drawing.Point(651, 527)
        Me.btnApply.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(91, 23)
        Me.btnApply.TabIndex = 38
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
        Me.btnBack.Location = New System.Drawing.Point(749, 527)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(91, 23)
        Me.btnBack.TabIndex = 37
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
        Me.btnClear.Location = New System.Drawing.Point(749, 498)
        Me.btnClear.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 23)
        Me.btnClear.TabIndex = 36
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
        Me.btnHelp.Location = New System.Drawing.Point(9, 527)
        Me.btnHelp.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(91, 23)
        Me.btnHelp.TabIndex = 35
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'lblCmdExec
        '
        Me.lblCmdExec.AutoSize = True
        Me.lblCmdExec.BackColor = System.Drawing.Color.Transparent
        Me.lblCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.lblCmdExec.Location = New System.Drawing.Point(200, 478)
        Me.lblCmdExec.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCmdExec.Name = "lblCmdExec"
        Me.lblCmdExec.Size = New System.Drawing.Size(131, 11)
        Me.lblCmdExec.TabIndex = 34
        Me.lblCmdExec.Text = "Commande exécuté :"
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(337, 474)
        Me.txtCmdExec.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(503, 18)
        Me.txtCmdExec.TabIndex = 33
        '
        'myConsole
        '
        Me.myConsole.Location = New System.Drawing.Point(337, 50)
        Me.myConsole.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(503, 418)
        Me.myConsole.TabIndex = 31
        '
        'footer
        '
        Me.footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footer.Location = New System.Drawing.Point(0, 554)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(846, 22)
        Me.footer.TabIndex = 42
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.Black
        Me.btnYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYes.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnYes.ForeColor = System.Drawing.Color.LightBlue
        Me.btnYes.Location = New System.Drawing.Point(651, 498)
        Me.btnYes.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(42, 23)
        Me.btnYes.TabIndex = 43
        Me.btnYes.Text = "Oui"
        Me.btnYes.UseVisualStyleBackColor = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.Black
        Me.btnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNo.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnNo.ForeColor = System.Drawing.Color.LightBlue
        Me.btnNo.Location = New System.Drawing.Point(699, 498)
        Me.btnNo.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(44, 23)
        Me.btnNo.TabIndex = 44
        Me.btnNo.Text = "Non"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'CaclsApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(846, 576)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.GuiDosboxGroupbox6)
        Me.Controls.Add(Me.GuiDosboxGroupbox5)
        Me.Controls.Add(Me.GuiDosboxGroupbox1)
        Me.Controls.Add(Me.GuiDosboxGroupbox2)
        Me.Controls.Add(Me.GuiDosboxGroupbox3)
        Me.Controls.Add(Me.GuiDosboxGroupbox4)
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblCmdExec)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CaclsApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI DosBox - CACLS"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GuiDosboxGroupbox6.ResumeLayout(False)
        Me.GuiDosboxGroupbox6.PerformLayout()
        Me.GuiDosboxGroupbox5.ResumeLayout(False)
        Me.GuiDosboxGroupbox5.PerformLayout()
        Me.GuiDosboxGroupbox1.ResumeLayout(False)
        Me.GuiDosboxGroupbox1.PerformLayout()
        Me.GuiDosboxGroupbox2.ResumeLayout(False)
        Me.GuiDosboxGroupbox2.PerformLayout()
        Me.GuiDosboxGroupbox3.ResumeLayout(False)
        Me.GuiDosboxGroupbox3.PerformLayout()
        Me.GuiDosboxGroupbox4.ResumeLayout(False)
        Me.GuiDosboxGroupbox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents optT As System.Windows.Forms.CheckBox
    Friend WithEvents optM As System.Windows.Forms.CheckBox
    Friend WithEvents optL As System.Windows.Forms.CheckBox
    Friend WithEvents optC As System.Windows.Forms.CheckBox
    Friend WithEvents optE As System.Windows.Forms.CheckBox
    Friend WithEvents optP As System.Windows.Forms.CheckBox
    Friend WithEvents optD As System.Windows.Forms.CheckBox
    Friend WithEvents optG As System.Windows.Forms.CheckBox
    Friend WithEvents optR As System.Windows.Forms.CheckBox
    Friend WithEvents lblutili2 As System.Windows.Forms.Label
    Friend WithEvents lblUtili As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblUtili3 As System.Windows.Forms.Label
    Friend WithEvents lblUtili4 As System.Windows.Forms.Label
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents lblCmdExec As GUIDosbox.GUIDosbox_Label
    Friend WithEvents btnHelp As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnClear As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnApply As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents GuiDosboxGroupbox1 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents GuiDosboxGroupbox2 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents GuiDosboxGroupbox3 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents GuiDosboxGroupbox4 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents GuiDosboxGroupbox5 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents GuiDosboxGroupbox6 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents txtFile As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents btnBrowse As GUIDosbox.GUIDosbox_Button
    Friend WithEvents cbUserD As GUIDosbox.GUIDosbox_Combobox
    Friend WithEvents cbUserP As GUIDosbox.GUIDosbox_Combobox
    Friend WithEvents cbUserG As GUIDosbox.GUIDosbox_Combobox
    Friend WithEvents cbUserR As GUIDosbox.GUIDosbox_Combobox
    Friend WithEvents footer As GUIDosbox.GUIDosbox_StatusStrip
    Friend WithEvents optPLecture As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents optPAucun As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents optPControlT As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents optPModif As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents optPEcrire As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents optGControlT As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents optGModif As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents optGEcrire As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents optGLecture As GUIDosbox.GUIDosbox_RadioButton
    Friend WithEvents btnYes As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnNo As GUIDosbox.GUIDosbox_Button
End Class
