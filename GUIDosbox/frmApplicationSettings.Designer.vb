<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApplicationSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApplicationSettings))
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabColoration = New System.Windows.Forms.TabPage()
        Me.btnCsDefault = New System.Windows.Forms.Button()
        Me.btnCsCancel = New System.Windows.Forms.Button()
        Me.btnCsApply = New System.Windows.Forms.Button()
        Me.gbSyntaxtOnOff = New System.Windows.Forms.GroupBox()
        Me.optOperators = New System.Windows.Forms.CheckBox()
        Me.optComments = New System.Windows.Forms.CheckBox()
        Me.optVariables = New System.Windows.Forms.CheckBox()
        Me.optInteger = New System.Windows.Forms.CheckBox()
        Me.optCommands = New System.Windows.Forms.CheckBox()
        Me.optAnchors = New System.Windows.Forms.CheckBox()
        Me.optKeywords = New System.Windows.Forms.CheckBox()
        Me.gbSyntaxColor = New System.Windows.Forms.GroupBox()
        Me.pbColorKeywords = New System.Windows.Forms.PictureBox()
        Me.pbColorCommands = New System.Windows.Forms.PictureBox()
        Me.pbColorAnchors = New System.Windows.Forms.PictureBox()
        Me.pbColorVariables = New System.Windows.Forms.PictureBox()
        Me.pbColorComments = New System.Windows.Forms.PictureBox()
        Me.pbColorOperators = New System.Windows.Forms.PictureBox()
        Me.pbColorIntegers = New System.Windows.Forms.PictureBox()
        Me.tabEditeur = New System.Windows.Forms.TabPage()
        Me.cd = New System.Windows.Forms.ColorDialog()
        Me.optArobas = New System.Windows.Forms.CheckBox()
        Me.GuiDosbox_Checkbox1 = New GUIDosbox.GUIDosbox_Checkbox()
        Me.GuiDosbox_Label8 = New GUIDosbox.GUIDosbox_Label()
        Me.lblKeywords = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label9 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label10 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label11 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label12 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label13 = New GUIDosbox.GUIDosbox_Label()
        Me.lblCommands = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label1 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label7 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label6 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label5 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label4 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label3 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label2 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label14 = New GUIDosbox.GUIDosbox_Label()
        Me.pbColorArobas = New System.Windows.Forms.PictureBox()
        Me.tabGeneral.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabColoration.SuspendLayout()
        Me.gbSyntaxtOnOff.SuspendLayout()
        Me.gbSyntaxColor.SuspendLayout()
        CType(Me.pbColorKeywords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColorCommands, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColorAnchors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColorVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColorComments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColorOperators, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColorIntegers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColorArobas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabGeneral
        '
        Me.tabGeneral.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tabGeneral.Controls.Add(Me.GuiDosbox_Checkbox1)
        Me.tabGeneral.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.tabGeneral.Location = New System.Drawing.Point(174, 4)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(508, 403)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "Général"
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.tabGeneral)
        Me.TabControl1.Controls.Add(Me.tabColoration)
        Me.TabControl1.Controls.Add(Me.tabEditeur)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(30, 170)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(686, 411)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'tabColoration
        '
        Me.tabColoration.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tabColoration.Controls.Add(Me.btnCsDefault)
        Me.tabColoration.Controls.Add(Me.btnCsCancel)
        Me.tabColoration.Controls.Add(Me.btnCsApply)
        Me.tabColoration.Controls.Add(Me.gbSyntaxtOnOff)
        Me.tabColoration.Controls.Add(Me.gbSyntaxColor)
        Me.tabColoration.Location = New System.Drawing.Point(174, 4)
        Me.tabColoration.Name = "tabColoration"
        Me.tabColoration.Padding = New System.Windows.Forms.Padding(3)
        Me.tabColoration.Size = New System.Drawing.Size(508, 403)
        Me.tabColoration.TabIndex = 1
        Me.tabColoration.Text = "Coloration Syntaxique"
        '
        'btnCsDefault
        '
        Me.btnCsDefault.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.btnCsDefault.Location = New System.Drawing.Point(21, 314)
        Me.btnCsDefault.Name = "btnCsDefault"
        Me.btnCsDefault.Size = New System.Drawing.Size(124, 23)
        Me.btnCsDefault.TabIndex = 34
        Me.btnCsDefault.Text = "Valeurs par défaut"
        Me.btnCsDefault.UseVisualStyleBackColor = True
        '
        'btnCsCancel
        '
        Me.btnCsCancel.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.btnCsCancel.Location = New System.Drawing.Point(427, 372)
        Me.btnCsCancel.Name = "btnCsCancel"
        Me.btnCsCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCsCancel.TabIndex = 33
        Me.btnCsCancel.Text = "Annuler"
        Me.btnCsCancel.UseVisualStyleBackColor = True
        '
        'btnCsApply
        '
        Me.btnCsApply.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.btnCsApply.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCsApply.Location = New System.Drawing.Point(349, 372)
        Me.btnCsApply.Name = "btnCsApply"
        Me.btnCsApply.Size = New System.Drawing.Size(75, 23)
        Me.btnCsApply.TabIndex = 32
        Me.btnCsApply.Text = "Appliquer"
        Me.btnCsApply.UseVisualStyleBackColor = True
        '
        'gbSyntaxtOnOff
        '
        Me.gbSyntaxtOnOff.Controls.Add(Me.optArobas)
        Me.gbSyntaxtOnOff.Controls.Add(Me.GuiDosbox_Label8)
        Me.gbSyntaxtOnOff.Controls.Add(Me.optOperators)
        Me.gbSyntaxtOnOff.Controls.Add(Me.optComments)
        Me.gbSyntaxtOnOff.Controls.Add(Me.optVariables)
        Me.gbSyntaxtOnOff.Controls.Add(Me.optInteger)
        Me.gbSyntaxtOnOff.Controls.Add(Me.optCommands)
        Me.gbSyntaxtOnOff.Controls.Add(Me.optAnchors)
        Me.gbSyntaxtOnOff.Controls.Add(Me.optKeywords)
        Me.gbSyntaxtOnOff.Controls.Add(Me.lblKeywords)
        Me.gbSyntaxtOnOff.Controls.Add(Me.GuiDosbox_Label9)
        Me.gbSyntaxtOnOff.Controls.Add(Me.GuiDosbox_Label10)
        Me.gbSyntaxtOnOff.Controls.Add(Me.GuiDosbox_Label11)
        Me.gbSyntaxtOnOff.Controls.Add(Me.GuiDosbox_Label12)
        Me.gbSyntaxtOnOff.Controls.Add(Me.GuiDosbox_Label13)
        Me.gbSyntaxtOnOff.Controls.Add(Me.lblCommands)
        Me.gbSyntaxtOnOff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.gbSyntaxtOnOff.Location = New System.Drawing.Point(21, 11)
        Me.gbSyntaxtOnOff.Name = "gbSyntaxtOnOff"
        Me.gbSyntaxtOnOff.Size = New System.Drawing.Size(470, 140)
        Me.gbSyntaxtOnOff.TabIndex = 31
        Me.gbSyntaxtOnOff.TabStop = False
        Me.gbSyntaxtOnOff.Text = " Activer / Désactiver "
        '
        'optOperators
        '
        Me.optOperators.AutoSize = True
        Me.optOperators.Location = New System.Drawing.Point(438, 53)
        Me.optOperators.Name = "optOperators"
        Me.optOperators.Size = New System.Drawing.Size(15, 14)
        Me.optOperators.TabIndex = 36
        Me.optOperators.UseVisualStyleBackColor = True
        '
        'optComments
        '
        Me.optComments.AutoSize = True
        Me.optComments.Location = New System.Drawing.Point(438, 84)
        Me.optComments.Name = "optComments"
        Me.optComments.Size = New System.Drawing.Size(15, 14)
        Me.optComments.TabIndex = 35
        Me.optComments.UseVisualStyleBackColor = True
        '
        'optVariables
        '
        Me.optVariables.AutoSize = True
        Me.optVariables.Location = New System.Drawing.Point(438, 24)
        Me.optVariables.Name = "optVariables"
        Me.optVariables.Size = New System.Drawing.Size(15, 14)
        Me.optVariables.TabIndex = 34
        Me.optVariables.UseVisualStyleBackColor = True
        '
        'optInteger
        '
        Me.optInteger.AutoSize = True
        Me.optInteger.Location = New System.Drawing.Point(202, 112)
        Me.optInteger.Name = "optInteger"
        Me.optInteger.Size = New System.Drawing.Size(15, 14)
        Me.optInteger.TabIndex = 33
        Me.optInteger.UseVisualStyleBackColor = True
        '
        'optCommands
        '
        Me.optCommands.AutoSize = True
        Me.optCommands.Location = New System.Drawing.Point(202, 53)
        Me.optCommands.Name = "optCommands"
        Me.optCommands.Size = New System.Drawing.Size(15, 14)
        Me.optCommands.TabIndex = 32
        Me.optCommands.UseVisualStyleBackColor = True
        '
        'optAnchors
        '
        Me.optAnchors.AutoSize = True
        Me.optAnchors.Location = New System.Drawing.Point(202, 83)
        Me.optAnchors.Name = "optAnchors"
        Me.optAnchors.Size = New System.Drawing.Size(15, 14)
        Me.optAnchors.TabIndex = 31
        Me.optAnchors.UseVisualStyleBackColor = True
        '
        'optKeywords
        '
        Me.optKeywords.AutoSize = True
        Me.optKeywords.Location = New System.Drawing.Point(202, 24)
        Me.optKeywords.Name = "optKeywords"
        Me.optKeywords.Size = New System.Drawing.Size(15, 14)
        Me.optKeywords.TabIndex = 30
        Me.optKeywords.UseVisualStyleBackColor = True
        '
        'gbSyntaxColor
        '
        Me.gbSyntaxColor.Controls.Add(Me.GuiDosbox_Label14)
        Me.gbSyntaxColor.Controls.Add(Me.pbColorArobas)
        Me.gbSyntaxColor.Controls.Add(Me.GuiDosbox_Label1)
        Me.gbSyntaxColor.Controls.Add(Me.GuiDosbox_Label7)
        Me.gbSyntaxColor.Controls.Add(Me.pbColorKeywords)
        Me.gbSyntaxColor.Controls.Add(Me.GuiDosbox_Label6)
        Me.gbSyntaxColor.Controls.Add(Me.pbColorCommands)
        Me.gbSyntaxColor.Controls.Add(Me.GuiDosbox_Label5)
        Me.gbSyntaxColor.Controls.Add(Me.pbColorAnchors)
        Me.gbSyntaxColor.Controls.Add(Me.GuiDosbox_Label4)
        Me.gbSyntaxColor.Controls.Add(Me.pbColorVariables)
        Me.gbSyntaxColor.Controls.Add(Me.GuiDosbox_Label3)
        Me.gbSyntaxColor.Controls.Add(Me.pbColorComments)
        Me.gbSyntaxColor.Controls.Add(Me.GuiDosbox_Label2)
        Me.gbSyntaxColor.Controls.Add(Me.pbColorOperators)
        Me.gbSyntaxColor.Controls.Add(Me.pbColorIntegers)
        Me.gbSyntaxColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.gbSyntaxColor.Location = New System.Drawing.Point(21, 167)
        Me.gbSyntaxColor.Name = "gbSyntaxColor"
        Me.gbSyntaxColor.Size = New System.Drawing.Size(470, 140)
        Me.gbSyntaxColor.TabIndex = 30
        Me.gbSyntaxColor.TabStop = False
        Me.gbSyntaxColor.Text = " Couleurs "
        '
        'pbColorKeywords
        '
        Me.pbColorKeywords.BackColor = System.Drawing.Color.Black
        Me.pbColorKeywords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorKeywords.Location = New System.Drawing.Point(187, 19)
        Me.pbColorKeywords.Name = "pbColorKeywords"
        Me.pbColorKeywords.Size = New System.Drawing.Size(23, 23)
        Me.pbColorKeywords.TabIndex = 16
        Me.pbColorKeywords.TabStop = False
        '
        'pbColorCommands
        '
        Me.pbColorCommands.BackColor = System.Drawing.Color.Black
        Me.pbColorCommands.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorCommands.Location = New System.Drawing.Point(187, 48)
        Me.pbColorCommands.Name = "pbColorCommands"
        Me.pbColorCommands.Size = New System.Drawing.Size(23, 23)
        Me.pbColorCommands.TabIndex = 17
        Me.pbColorCommands.TabStop = False
        '
        'pbColorAnchors
        '
        Me.pbColorAnchors.BackColor = System.Drawing.Color.Black
        Me.pbColorAnchors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorAnchors.Location = New System.Drawing.Point(187, 77)
        Me.pbColorAnchors.Name = "pbColorAnchors"
        Me.pbColorAnchors.Size = New System.Drawing.Size(23, 23)
        Me.pbColorAnchors.TabIndex = 18
        Me.pbColorAnchors.TabStop = False
        '
        'pbColorVariables
        '
        Me.pbColorVariables.BackColor = System.Drawing.Color.Black
        Me.pbColorVariables.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorVariables.Location = New System.Drawing.Point(414, 18)
        Me.pbColorVariables.Name = "pbColorVariables"
        Me.pbColorVariables.Size = New System.Drawing.Size(23, 23)
        Me.pbColorVariables.TabIndex = 19
        Me.pbColorVariables.TabStop = False
        '
        'pbColorComments
        '
        Me.pbColorComments.BackColor = System.Drawing.Color.Black
        Me.pbColorComments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorComments.Location = New System.Drawing.Point(414, 76)
        Me.pbColorComments.Name = "pbColorComments"
        Me.pbColorComments.Size = New System.Drawing.Size(23, 23)
        Me.pbColorComments.TabIndex = 20
        Me.pbColorComments.TabStop = False
        '
        'pbColorOperators
        '
        Me.pbColorOperators.BackColor = System.Drawing.Color.Black
        Me.pbColorOperators.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorOperators.Location = New System.Drawing.Point(414, 47)
        Me.pbColorOperators.Name = "pbColorOperators"
        Me.pbColorOperators.Size = New System.Drawing.Size(23, 23)
        Me.pbColorOperators.TabIndex = 21
        Me.pbColorOperators.TabStop = False
        '
        'pbColorIntegers
        '
        Me.pbColorIntegers.BackColor = System.Drawing.Color.Black
        Me.pbColorIntegers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorIntegers.Location = New System.Drawing.Point(187, 106)
        Me.pbColorIntegers.Name = "pbColorIntegers"
        Me.pbColorIntegers.Size = New System.Drawing.Size(23, 23)
        Me.pbColorIntegers.TabIndex = 22
        Me.pbColorIntegers.TabStop = False
        '
        'tabEditeur
        '
        Me.tabEditeur.Location = New System.Drawing.Point(174, 4)
        Me.tabEditeur.Name = "tabEditeur"
        Me.tabEditeur.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEditeur.Size = New System.Drawing.Size(508, 403)
        Me.tabEditeur.TabIndex = 2
        Me.tabEditeur.Text = "Éditeur de Batch"
        Me.tabEditeur.UseVisualStyleBackColor = True
        '
        'cd
        '
        Me.cd.FullOpen = True
        '
        'optArobas
        '
        Me.optArobas.AutoSize = True
        Me.optArobas.Location = New System.Drawing.Point(438, 111)
        Me.optArobas.Name = "optArobas"
        Me.optArobas.Size = New System.Drawing.Size(15, 14)
        Me.optArobas.TabIndex = 38
        Me.optArobas.UseVisualStyleBackColor = True
        '
        'GuiDosbox_Checkbox1
        '
        Me.GuiDosbox_Checkbox1.AutoSize = True
        Me.GuiDosbox_Checkbox1.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Checkbox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuiDosbox_Checkbox1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Checkbox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GuiDosbox_Checkbox1.Location = New System.Drawing.Point(17, 19)
        Me.GuiDosbox_Checkbox1.Name = "GuiDosbox_Checkbox1"
        Me.GuiDosbox_Checkbox1.Size = New System.Drawing.Size(315, 15)
        Me.GuiDosbox_Checkbox1.TabIndex = 0
        Me.GuiDosbox_Checkbox1.Text = "Activer / Désactiver Coloration Syntaxique"
        Me.GuiDosbox_Checkbox1.UseVisualStyleBackColor = False
        '
        'GuiDosbox_Label8
        '
        Me.GuiDosbox_Label8.AutoSize = True
        Me.GuiDosbox_Label8.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label8.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GuiDosbox_Label8.Location = New System.Drawing.Point(230, 112)
        Me.GuiDosbox_Label8.Name = "GuiDosbox_Label8"
        Me.GuiDosbox_Label8.Size = New System.Drawing.Size(180, 11)
        Me.GuiDosbox_Label8.TabIndex = 37
        Me.GuiDosbox_Label8.Text = "Coloration des arobas (@)"
        '
        'lblKeywords
        '
        Me.lblKeywords.AutoSize = True
        Me.lblKeywords.BackColor = System.Drawing.Color.Transparent
        Me.lblKeywords.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblKeywords.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblKeywords.Location = New System.Drawing.Point(16, 25)
        Me.lblKeywords.Name = "lblKeywords"
        Me.lblKeywords.Size = New System.Drawing.Size(173, 11)
        Me.lblKeywords.TabIndex = 23
        Me.lblKeywords.Text = "Coloration des mots clés"
        '
        'GuiDosbox_Label9
        '
        Me.GuiDosbox_Label9.AutoSize = True
        Me.GuiDosbox_Label9.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label9.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GuiDosbox_Label9.Location = New System.Drawing.Point(16, 113)
        Me.GuiDosbox_Label9.Name = "GuiDosbox_Label9"
        Me.GuiDosbox_Label9.Size = New System.Drawing.Size(166, 11)
        Me.GuiDosbox_Label9.TabIndex = 29
        Me.GuiDosbox_Label9.Text = "Coloration des chiffres"
        '
        'GuiDosbox_Label10
        '
        Me.GuiDosbox_Label10.AutoSize = True
        Me.GuiDosbox_Label10.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label10.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GuiDosbox_Label10.Location = New System.Drawing.Point(230, 83)
        Me.GuiDosbox_Label10.Name = "GuiDosbox_Label10"
        Me.GuiDosbox_Label10.Size = New System.Drawing.Size(194, 11)
        Me.GuiDosbox_Label10.TabIndex = 28
        Me.GuiDosbox_Label10.Text = "Coloration des commentaires"
        '
        'GuiDosbox_Label11
        '
        Me.GuiDosbox_Label11.AutoSize = True
        Me.GuiDosbox_Label11.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label11.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GuiDosbox_Label11.Location = New System.Drawing.Point(230, 54)
        Me.GuiDosbox_Label11.Name = "GuiDosbox_Label11"
        Me.GuiDosbox_Label11.Size = New System.Drawing.Size(180, 11)
        Me.GuiDosbox_Label11.TabIndex = 27
        Me.GuiDosbox_Label11.Text = "Coloration des opérateurs"
        '
        'GuiDosbox_Label12
        '
        Me.GuiDosbox_Label12.AutoSize = True
        Me.GuiDosbox_Label12.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label12.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GuiDosbox_Label12.Location = New System.Drawing.Point(230, 25)
        Me.GuiDosbox_Label12.Name = "GuiDosbox_Label12"
        Me.GuiDosbox_Label12.Size = New System.Drawing.Size(173, 11)
        Me.GuiDosbox_Label12.TabIndex = 26
        Me.GuiDosbox_Label12.Text = "Coloration des variables"
        '
        'GuiDosbox_Label13
        '
        Me.GuiDosbox_Label13.AutoSize = True
        Me.GuiDosbox_Label13.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label13.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label13.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GuiDosbox_Label13.Location = New System.Drawing.Point(16, 84)
        Me.GuiDosbox_Label13.Name = "GuiDosbox_Label13"
        Me.GuiDosbox_Label13.Size = New System.Drawing.Size(152, 11)
        Me.GuiDosbox_Label13.TabIndex = 25
        Me.GuiDosbox_Label13.Text = "Coloration des Ancres"
        '
        'lblCommands
        '
        Me.lblCommands.AutoSize = True
        Me.lblCommands.BackColor = System.Drawing.Color.Transparent
        Me.lblCommands.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblCommands.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblCommands.Location = New System.Drawing.Point(16, 54)
        Me.lblCommands.Name = "lblCommands"
        Me.lblCommands.Size = New System.Drawing.Size(173, 11)
        Me.lblCommands.TabIndex = 24
        Me.lblCommands.Text = "Coloration des commandes"
        '
        'GuiDosbox_Label1
        '
        Me.GuiDosbox_Label1.AutoSize = True
        Me.GuiDosbox_Label1.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GuiDosbox_Label1.Location = New System.Drawing.Point(16, 25)
        Me.GuiDosbox_Label1.Name = "GuiDosbox_Label1"
        Me.GuiDosbox_Label1.Size = New System.Drawing.Size(152, 11)
        Me.GuiDosbox_Label1.TabIndex = 23
        Me.GuiDosbox_Label1.Text = "Couleur des mots clés"
        '
        'GuiDosbox_Label7
        '
        Me.GuiDosbox_Label7.AutoSize = True
        Me.GuiDosbox_Label7.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label7.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GuiDosbox_Label7.Location = New System.Drawing.Point(16, 113)
        Me.GuiDosbox_Label7.Name = "GuiDosbox_Label7"
        Me.GuiDosbox_Label7.Size = New System.Drawing.Size(145, 11)
        Me.GuiDosbox_Label7.TabIndex = 29
        Me.GuiDosbox_Label7.Text = "Couleur des chiffres"
        '
        'GuiDosbox_Label6
        '
        Me.GuiDosbox_Label6.AutoSize = True
        Me.GuiDosbox_Label6.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label6.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GuiDosbox_Label6.Location = New System.Drawing.Point(230, 83)
        Me.GuiDosbox_Label6.Name = "GuiDosbox_Label6"
        Me.GuiDosbox_Label6.Size = New System.Drawing.Size(173, 11)
        Me.GuiDosbox_Label6.TabIndex = 28
        Me.GuiDosbox_Label6.Text = "Couleur des commentaires"
        '
        'GuiDosbox_Label5
        '
        Me.GuiDosbox_Label5.AutoSize = True
        Me.GuiDosbox_Label5.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label5.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GuiDosbox_Label5.Location = New System.Drawing.Point(230, 54)
        Me.GuiDosbox_Label5.Name = "GuiDosbox_Label5"
        Me.GuiDosbox_Label5.Size = New System.Drawing.Size(159, 11)
        Me.GuiDosbox_Label5.TabIndex = 27
        Me.GuiDosbox_Label5.Text = "Couleur des opérateurs"
        '
        'GuiDosbox_Label4
        '
        Me.GuiDosbox_Label4.AutoSize = True
        Me.GuiDosbox_Label4.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label4.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GuiDosbox_Label4.Location = New System.Drawing.Point(230, 25)
        Me.GuiDosbox_Label4.Name = "GuiDosbox_Label4"
        Me.GuiDosbox_Label4.Size = New System.Drawing.Size(152, 11)
        Me.GuiDosbox_Label4.TabIndex = 26
        Me.GuiDosbox_Label4.Text = "Couleur des variables"
        '
        'GuiDosbox_Label3
        '
        Me.GuiDosbox_Label3.AutoSize = True
        Me.GuiDosbox_Label3.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label3.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GuiDosbox_Label3.Location = New System.Drawing.Point(16, 84)
        Me.GuiDosbox_Label3.Name = "GuiDosbox_Label3"
        Me.GuiDosbox_Label3.Size = New System.Drawing.Size(131, 11)
        Me.GuiDosbox_Label3.TabIndex = 25
        Me.GuiDosbox_Label3.Text = "Couleur des Ancres"
        '
        'GuiDosbox_Label2
        '
        Me.GuiDosbox_Label2.AutoSize = True
        Me.GuiDosbox_Label2.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label2.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GuiDosbox_Label2.Location = New System.Drawing.Point(16, 54)
        Me.GuiDosbox_Label2.Name = "GuiDosbox_Label2"
        Me.GuiDosbox_Label2.Size = New System.Drawing.Size(152, 11)
        Me.GuiDosbox_Label2.TabIndex = 24
        Me.GuiDosbox_Label2.Text = "Couleur des commandes"
        '
        'GuiDosbox_Label14
        '
        Me.GuiDosbox_Label14.AutoSize = True
        Me.GuiDosbox_Label14.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label14.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label14.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GuiDosbox_Label14.Location = New System.Drawing.Point(230, 113)
        Me.GuiDosbox_Label14.Name = "GuiDosbox_Label14"
        Me.GuiDosbox_Label14.Size = New System.Drawing.Size(159, 11)
        Me.GuiDosbox_Label14.TabIndex = 31
        Me.GuiDosbox_Label14.Text = "Couleur des arobas (@)"
        '
        'pbColorArobas
        '
        Me.pbColorArobas.BackColor = System.Drawing.Color.Black
        Me.pbColorArobas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorArobas.Location = New System.Drawing.Point(414, 106)
        Me.pbColorArobas.Name = "pbColorArobas"
        Me.pbColorArobas.Size = New System.Drawing.Size(23, 23)
        Me.pbColorArobas.TabIndex = 30
        Me.pbColorArobas.TabStop = False
        '
        'frmApplicationSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(686, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmApplicationSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI Dosbox - Paramètres"
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabColoration.ResumeLayout(False)
        Me.gbSyntaxtOnOff.ResumeLayout(False)
        Me.gbSyntaxtOnOff.PerformLayout()
        Me.gbSyntaxColor.ResumeLayout(False)
        Me.gbSyntaxColor.PerformLayout()
        CType(Me.pbColorKeywords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColorCommands, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColorAnchors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColorVariables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColorComments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColorOperators, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColorIntegers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColorArobas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents GuiDosbox_Checkbox1 As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents cd As System.Windows.Forms.ColorDialog
    Friend WithEvents tabColoration As System.Windows.Forms.TabPage
    Friend WithEvents gbSyntaxColor As System.Windows.Forms.GroupBox
    Friend WithEvents GuiDosbox_Label1 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents GuiDosbox_Label7 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents pbColorKeywords As System.Windows.Forms.PictureBox
    Friend WithEvents GuiDosbox_Label6 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents pbColorCommands As System.Windows.Forms.PictureBox
    Friend WithEvents GuiDosbox_Label5 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents pbColorAnchors As System.Windows.Forms.PictureBox
    Friend WithEvents GuiDosbox_Label4 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents pbColorVariables As System.Windows.Forms.PictureBox
    Friend WithEvents GuiDosbox_Label3 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents pbColorComments As System.Windows.Forms.PictureBox
    Friend WithEvents GuiDosbox_Label2 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents pbColorOperators As System.Windows.Forms.PictureBox
    Friend WithEvents pbColorIntegers As System.Windows.Forms.PictureBox
    Friend WithEvents gbSyntaxtOnOff As System.Windows.Forms.GroupBox
    Friend WithEvents lblKeywords As GUIDosbox.GUIDosbox_Label
    Friend WithEvents GuiDosbox_Label9 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents GuiDosbox_Label10 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents GuiDosbox_Label11 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents GuiDosbox_Label12 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents GuiDosbox_Label13 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents lblCommands As GUIDosbox.GUIDosbox_Label
    Friend WithEvents optInteger As System.Windows.Forms.CheckBox
    Friend WithEvents optCommands As System.Windows.Forms.CheckBox
    Friend WithEvents optAnchors As System.Windows.Forms.CheckBox
    Friend WithEvents optKeywords As System.Windows.Forms.CheckBox
    Friend WithEvents optOperators As System.Windows.Forms.CheckBox
    Friend WithEvents optComments As System.Windows.Forms.CheckBox
    Friend WithEvents optVariables As System.Windows.Forms.CheckBox
    Friend WithEvents tabEditeur As System.Windows.Forms.TabPage
    Friend WithEvents btnCsCancel As System.Windows.Forms.Button
    Friend WithEvents btnCsApply As System.Windows.Forms.Button
    Friend WithEvents btnCsDefault As System.Windows.Forms.Button
    Friend WithEvents optArobas As System.Windows.Forms.CheckBox
    Friend WithEvents GuiDosbox_Label8 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents GuiDosbox_Label14 As GUIDosbox.GUIDosbox_Label
    Friend WithEvents pbColorArobas As System.Windows.Forms.PictureBox
End Class
