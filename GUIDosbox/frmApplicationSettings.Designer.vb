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
        Me.gbParametres = New System.Windows.Forms.GroupBox()
        Me.optAutoUpdate = New System.Windows.Forms.CheckBox()
        Me.optColorationOnOff = New System.Windows.Forms.CheckBox()
        Me.btnGenDefault = New System.Windows.Forms.Button()
        Me.btnGenApply = New System.Windows.Forms.Button()
        Me.btnGenCancel = New System.Windows.Forms.Button()
        Me.btnAllDefault = New System.Windows.Forms.Button()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.tabColoration = New System.Windows.Forms.TabPage()
        Me.btnCsDefault = New System.Windows.Forms.Button()
        Me.btnCsCancel = New System.Windows.Forms.Button()
        Me.btnCsApply = New System.Windows.Forms.Button()
        Me.gbSyntaxtOnOff = New System.Windows.Forms.GroupBox()
        Me.optArobas = New System.Windows.Forms.CheckBox()
        Me.optOperators = New System.Windows.Forms.CheckBox()
        Me.optComments = New System.Windows.Forms.CheckBox()
        Me.optVariables = New System.Windows.Forms.CheckBox()
        Me.optInteger = New System.Windows.Forms.CheckBox()
        Me.optCommands = New System.Windows.Forms.CheckBox()
        Me.optAnchors = New System.Windows.Forms.CheckBox()
        Me.optKeywords = New System.Windows.Forms.CheckBox()
        Me.gbSyntaxColor = New System.Windows.Forms.GroupBox()
        Me.pbColorArobas = New System.Windows.Forms.PictureBox()
        Me.pbColorKeywords = New System.Windows.Forms.PictureBox()
        Me.pbColorCommands = New System.Windows.Forms.PictureBox()
        Me.pbColorAnchors = New System.Windows.Forms.PictureBox()
        Me.pbColorVariables = New System.Windows.Forms.PictureBox()
        Me.pbColorComments = New System.Windows.Forms.PictureBox()
        Me.pbColorOperators = New System.Windows.Forms.PictureBox()
        Me.pbColorIntegers = New System.Windows.Forms.PictureBox()
        Me.tabEditeur = New System.Windows.Forms.TabPage()
        Me.btnEdtDefault = New System.Windows.Forms.Button()
        Me.btnEdtCancel = New System.Windows.Forms.Button()
        Me.btnEdtApply = New System.Windows.Forms.Button()
        Me.gbParamEditeur = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fpEditorFont = New GUIDB.Forms.Controls.FontPicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbEditorColor = New System.Windows.Forms.PictureBox()
        Me.cd = New System.Windows.Forms.ColorDialog()
        Me.GuiDosbox_Label8 = New GUIDosbox.GUIDosbox_Label()
        Me.lblKeywords = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label9 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label10 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label11 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label12 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label13 = New GUIDosbox.GUIDosbox_Label()
        Me.lblCommands = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label14 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label1 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label7 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label6 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label5 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label4 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label3 = New GUIDosbox.GUIDosbox_Label()
        Me.GuiDosbox_Label2 = New GUIDosbox.GUIDosbox_Label()
        Me.tabGeneral.SuspendLayout()
        Me.gbParametres.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.tabColoration.SuspendLayout()
        Me.gbSyntaxtOnOff.SuspendLayout()
        Me.gbSyntaxColor.SuspendLayout()
        CType(Me.pbColorArobas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColorKeywords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColorCommands, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColorAnchors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColorVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColorComments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColorOperators, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColorIntegers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEditeur.SuspendLayout()
        Me.gbParamEditeur.SuspendLayout()
        CType(Me.pbEditorColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabGeneral
        '
        Me.tabGeneral.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tabGeneral.Controls.Add(Me.gbParametres)
        Me.tabGeneral.Controls.Add(Me.btnGenDefault)
        Me.tabGeneral.Controls.Add(Me.btnGenApply)
        Me.tabGeneral.Controls.Add(Me.btnGenCancel)
        Me.tabGeneral.Controls.Add(Me.btnAllDefault)
        Me.tabGeneral.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.tabGeneral.Location = New System.Drawing.Point(174, 4)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(456, 369)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "Général"
        '
        'gbParametres
        '
        Me.gbParametres.Controls.Add(Me.optAutoUpdate)
        Me.gbParametres.Controls.Add(Me.optColorationOnOff)
        Me.gbParametres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.gbParametres.Location = New System.Drawing.Point(12, 9)
        Me.gbParametres.Name = "gbParametres"
        Me.gbParametres.Size = New System.Drawing.Size(438, 80)
        Me.gbParametres.TabIndex = 5
        Me.gbParametres.TabStop = False
        Me.gbParametres.Text = " Paramètres Général "
        '
        'optAutoUpdate
        '
        Me.optAutoUpdate.AutoSize = True
        Me.optAutoUpdate.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.optAutoUpdate.Location = New System.Drawing.Point(12, 46)
        Me.optAutoUpdate.Name = "optAutoUpdate"
        Me.optAutoUpdate.Size = New System.Drawing.Size(165, 18)
        Me.optAutoUpdate.TabIndex = 7
        Me.optAutoUpdate.Text = "Mise à jour automatique"
        Me.optAutoUpdate.UseVisualStyleBackColor = True
        '
        'optColorationOnOff
        '
        Me.optColorationOnOff.AutoSize = True
        Me.optColorationOnOff.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.optColorationOnOff.Location = New System.Drawing.Point(12, 22)
        Me.optColorationOnOff.Name = "optColorationOnOff"
        Me.optColorationOnOff.Size = New System.Drawing.Size(216, 18)
        Me.optColorationOnOff.TabIndex = 8
        Me.optColorationOnOff.Text = "Coloration Syntaxiques (Éditeur)"
        Me.optColorationOnOff.UseVisualStyleBackColor = True
        '
        'btnGenDefault
        '
        Me.btnGenDefault.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.btnGenDefault.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGenDefault.Location = New System.Drawing.Point(332, 95)
        Me.btnGenDefault.Name = "btnGenDefault"
        Me.btnGenDefault.Size = New System.Drawing.Size(118, 23)
        Me.btnGenDefault.TabIndex = 4
        Me.btnGenDefault.Text = "Valeur par défaut"
        Me.btnGenDefault.UseVisualStyleBackColor = True
        '
        'btnGenApply
        '
        Me.btnGenApply.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.btnGenApply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGenApply.Location = New System.Drawing.Point(294, 340)
        Me.btnGenApply.Name = "btnGenApply"
        Me.btnGenApply.Size = New System.Drawing.Size(75, 23)
        Me.btnGenApply.TabIndex = 3
        Me.btnGenApply.Text = "Appliquer"
        Me.btnGenApply.UseVisualStyleBackColor = True
        '
        'btnGenCancel
        '
        Me.btnGenCancel.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.btnGenCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGenCancel.Location = New System.Drawing.Point(375, 340)
        Me.btnGenCancel.Name = "btnGenCancel"
        Me.btnGenCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnGenCancel.TabIndex = 2
        Me.btnGenCancel.Text = "Annuler"
        Me.btnGenCancel.UseVisualStyleBackColor = True
        '
        'btnAllDefault
        '
        Me.btnAllDefault.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.btnAllDefault.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnAllDefault.Location = New System.Drawing.Point(6, 340)
        Me.btnAllDefault.Name = "btnAllDefault"
        Me.btnAllDefault.Size = New System.Drawing.Size(177, 23)
        Me.btnAllDefault.TabIndex = 1
        Me.btnAllDefault.Text = "Toute les valeurs par défaut"
        Me.btnAllDefault.UseVisualStyleBackColor = True
        '
        'TabControlMain
        '
        Me.TabControlMain.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControlMain.Controls.Add(Me.tabGeneral)
        Me.TabControlMain.Controls.Add(Me.tabColoration)
        Me.TabControlMain.Controls.Add(Me.tabEditeur)
        Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControlMain.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlMain.ItemSize = New System.Drawing.Size(30, 170)
        Me.TabControlMain.Location = New System.Drawing.Point(0, 0)
        Me.TabControlMain.Multiline = True
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(634, 377)
        Me.TabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControlMain.TabIndex = 0
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
        Me.tabColoration.Size = New System.Drawing.Size(456, 369)
        Me.tabColoration.TabIndex = 1
        Me.tabColoration.Text = "Coloration Syntaxique"
        '
        'btnCsDefault
        '
        Me.btnCsDefault.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.btnCsDefault.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnCsDefault.Location = New System.Drawing.Point(12, 311)
        Me.btnCsDefault.Name = "btnCsDefault"
        Me.btnCsDefault.Size = New System.Drawing.Size(124, 23)
        Me.btnCsDefault.TabIndex = 34
        Me.btnCsDefault.Text = "Valeurs par défaut"
        Me.btnCsDefault.UseVisualStyleBackColor = True
        '
        'btnCsCancel
        '
        Me.btnCsCancel.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.btnCsCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnCsCancel.Location = New System.Drawing.Point(375, 340)
        Me.btnCsCancel.Name = "btnCsCancel"
        Me.btnCsCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCsCancel.TabIndex = 33
        Me.btnCsCancel.Text = "Annuler"
        Me.btnCsCancel.UseVisualStyleBackColor = True
        '
        'btnCsApply
        '
        Me.btnCsApply.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.btnCsApply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnCsApply.Location = New System.Drawing.Point(294, 340)
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
        Me.gbSyntaxtOnOff.Location = New System.Drawing.Point(12, 9)
        Me.gbSyntaxtOnOff.Name = "gbSyntaxtOnOff"
        Me.gbSyntaxtOnOff.Size = New System.Drawing.Size(438, 140)
        Me.gbSyntaxtOnOff.TabIndex = 31
        Me.gbSyntaxtOnOff.TabStop = False
        Me.gbSyntaxtOnOff.Text = " Activer / Désactiver "
        '
        'optArobas
        '
        Me.optArobas.AutoSize = True
        Me.optArobas.Location = New System.Drawing.Point(219, 113)
        Me.optArobas.Name = "optArobas"
        Me.optArobas.Size = New System.Drawing.Size(15, 14)
        Me.optArobas.TabIndex = 38
        Me.optArobas.UseVisualStyleBackColor = True
        '
        'optOperators
        '
        Me.optOperators.AutoSize = True
        Me.optOperators.Location = New System.Drawing.Point(219, 55)
        Me.optOperators.Name = "optOperators"
        Me.optOperators.Size = New System.Drawing.Size(15, 14)
        Me.optOperators.TabIndex = 36
        Me.optOperators.UseVisualStyleBackColor = True
        '
        'optComments
        '
        Me.optComments.AutoSize = True
        Me.optComments.Location = New System.Drawing.Point(219, 84)
        Me.optComments.Name = "optComments"
        Me.optComments.Size = New System.Drawing.Size(15, 14)
        Me.optComments.TabIndex = 35
        Me.optComments.UseVisualStyleBackColor = True
        '
        'optVariables
        '
        Me.optVariables.AutoSize = True
        Me.optVariables.Location = New System.Drawing.Point(219, 26)
        Me.optVariables.Name = "optVariables"
        Me.optVariables.Size = New System.Drawing.Size(15, 14)
        Me.optVariables.TabIndex = 34
        Me.optVariables.UseVisualStyleBackColor = True
        '
        'optInteger
        '
        Me.optInteger.AutoSize = True
        Me.optInteger.Location = New System.Drawing.Point(16, 113)
        Me.optInteger.Name = "optInteger"
        Me.optInteger.Size = New System.Drawing.Size(15, 14)
        Me.optInteger.TabIndex = 33
        Me.optInteger.UseVisualStyleBackColor = True
        '
        'optCommands
        '
        Me.optCommands.AutoSize = True
        Me.optCommands.Location = New System.Drawing.Point(16, 55)
        Me.optCommands.Name = "optCommands"
        Me.optCommands.Size = New System.Drawing.Size(15, 14)
        Me.optCommands.TabIndex = 32
        Me.optCommands.UseVisualStyleBackColor = True
        '
        'optAnchors
        '
        Me.optAnchors.AutoSize = True
        Me.optAnchors.Location = New System.Drawing.Point(16, 84)
        Me.optAnchors.Name = "optAnchors"
        Me.optAnchors.Size = New System.Drawing.Size(15, 14)
        Me.optAnchors.TabIndex = 31
        Me.optAnchors.UseVisualStyleBackColor = True
        '
        'optKeywords
        '
        Me.optKeywords.AutoSize = True
        Me.optKeywords.Location = New System.Drawing.Point(16, 26)
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
        Me.gbSyntaxColor.Location = New System.Drawing.Point(12, 165)
        Me.gbSyntaxColor.Name = "gbSyntaxColor"
        Me.gbSyntaxColor.Size = New System.Drawing.Size(438, 140)
        Me.gbSyntaxColor.TabIndex = 30
        Me.gbSyntaxColor.TabStop = False
        Me.gbSyntaxColor.Text = " Couleurs "
        '
        'pbColorArobas
        '
        Me.pbColorArobas.BackColor = System.Drawing.Color.Black
        Me.pbColorArobas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorArobas.Location = New System.Drawing.Point(394, 109)
        Me.pbColorArobas.Name = "pbColorArobas"
        Me.pbColorArobas.Size = New System.Drawing.Size(20, 20)
        Me.pbColorArobas.TabIndex = 30
        Me.pbColorArobas.TabStop = False
        '
        'pbColorKeywords
        '
        Me.pbColorKeywords.BackColor = System.Drawing.Color.Black
        Me.pbColorKeywords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorKeywords.Location = New System.Drawing.Point(173, 22)
        Me.pbColorKeywords.Name = "pbColorKeywords"
        Me.pbColorKeywords.Size = New System.Drawing.Size(20, 20)
        Me.pbColorKeywords.TabIndex = 16
        Me.pbColorKeywords.TabStop = False
        '
        'pbColorCommands
        '
        Me.pbColorCommands.BackColor = System.Drawing.Color.Black
        Me.pbColorCommands.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorCommands.Location = New System.Drawing.Point(173, 51)
        Me.pbColorCommands.Name = "pbColorCommands"
        Me.pbColorCommands.Size = New System.Drawing.Size(20, 20)
        Me.pbColorCommands.TabIndex = 17
        Me.pbColorCommands.TabStop = False
        '
        'pbColorAnchors
        '
        Me.pbColorAnchors.BackColor = System.Drawing.Color.Black
        Me.pbColorAnchors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorAnchors.Location = New System.Drawing.Point(173, 80)
        Me.pbColorAnchors.Name = "pbColorAnchors"
        Me.pbColorAnchors.Size = New System.Drawing.Size(20, 20)
        Me.pbColorAnchors.TabIndex = 18
        Me.pbColorAnchors.TabStop = False
        '
        'pbColorVariables
        '
        Me.pbColorVariables.BackColor = System.Drawing.Color.Black
        Me.pbColorVariables.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorVariables.Location = New System.Drawing.Point(394, 22)
        Me.pbColorVariables.Name = "pbColorVariables"
        Me.pbColorVariables.Size = New System.Drawing.Size(20, 20)
        Me.pbColorVariables.TabIndex = 19
        Me.pbColorVariables.TabStop = False
        '
        'pbColorComments
        '
        Me.pbColorComments.BackColor = System.Drawing.Color.Black
        Me.pbColorComments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorComments.Location = New System.Drawing.Point(394, 80)
        Me.pbColorComments.Name = "pbColorComments"
        Me.pbColorComments.Size = New System.Drawing.Size(20, 20)
        Me.pbColorComments.TabIndex = 20
        Me.pbColorComments.TabStop = False
        '
        'pbColorOperators
        '
        Me.pbColorOperators.BackColor = System.Drawing.Color.Black
        Me.pbColorOperators.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorOperators.Location = New System.Drawing.Point(394, 51)
        Me.pbColorOperators.Name = "pbColorOperators"
        Me.pbColorOperators.Size = New System.Drawing.Size(20, 20)
        Me.pbColorOperators.TabIndex = 21
        Me.pbColorOperators.TabStop = False
        '
        'pbColorIntegers
        '
        Me.pbColorIntegers.BackColor = System.Drawing.Color.Black
        Me.pbColorIntegers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbColorIntegers.Location = New System.Drawing.Point(173, 109)
        Me.pbColorIntegers.Name = "pbColorIntegers"
        Me.pbColorIntegers.Size = New System.Drawing.Size(20, 20)
        Me.pbColorIntegers.TabIndex = 22
        Me.pbColorIntegers.TabStop = False
        '
        'tabEditeur
        '
        Me.tabEditeur.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tabEditeur.Controls.Add(Me.btnEdtDefault)
        Me.tabEditeur.Controls.Add(Me.btnEdtCancel)
        Me.tabEditeur.Controls.Add(Me.btnEdtApply)
        Me.tabEditeur.Controls.Add(Me.gbParamEditeur)
        Me.tabEditeur.Location = New System.Drawing.Point(174, 4)
        Me.tabEditeur.Name = "tabEditeur"
        Me.tabEditeur.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEditeur.Size = New System.Drawing.Size(456, 369)
        Me.tabEditeur.TabIndex = 2
        Me.tabEditeur.Text = "Éditeur de Batch"
        '
        'btnEdtDefault
        '
        Me.btnEdtDefault.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.btnEdtDefault.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnEdtDefault.Location = New System.Drawing.Point(326, 110)
        Me.btnEdtDefault.Name = "btnEdtDefault"
        Me.btnEdtDefault.Size = New System.Drawing.Size(124, 23)
        Me.btnEdtDefault.TabIndex = 37
        Me.btnEdtDefault.Text = "Valeurs par défaut"
        Me.btnEdtDefault.UseVisualStyleBackColor = True
        '
        'btnEdtCancel
        '
        Me.btnEdtCancel.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.btnEdtCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnEdtCancel.Location = New System.Drawing.Point(375, 340)
        Me.btnEdtCancel.Name = "btnEdtCancel"
        Me.btnEdtCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnEdtCancel.TabIndex = 36
        Me.btnEdtCancel.Text = "Annuler"
        Me.btnEdtCancel.UseVisualStyleBackColor = True
        '
        'btnEdtApply
        '
        Me.btnEdtApply.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.btnEdtApply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnEdtApply.Location = New System.Drawing.Point(294, 340)
        Me.btnEdtApply.Name = "btnEdtApply"
        Me.btnEdtApply.Size = New System.Drawing.Size(75, 23)
        Me.btnEdtApply.TabIndex = 35
        Me.btnEdtApply.Text = "Appliquer"
        Me.btnEdtApply.UseVisualStyleBackColor = True
        '
        'gbParamEditeur
        '
        Me.gbParamEditeur.Controls.Add(Me.Label2)
        Me.gbParamEditeur.Controls.Add(Me.fpEditorFont)
        Me.gbParamEditeur.Controls.Add(Me.Label1)
        Me.gbParamEditeur.Controls.Add(Me.pbEditorColor)
        Me.gbParamEditeur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.gbParamEditeur.Location = New System.Drawing.Point(12, 9)
        Me.gbParamEditeur.Name = "gbParamEditeur"
        Me.gbParamEditeur.Size = New System.Drawing.Size(438, 95)
        Me.gbParamEditeur.TabIndex = 0
        Me.gbParamEditeur.TabStop = False
        Me.gbParamEditeur.Text = " Paramètres de l'éditeur "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Police de caractère de l'éditeur"
        '
        'fpEditorFont
        '
        Me.fpEditorFont.BackColor = System.Drawing.SystemColors.Window
        Me.fpEditorFont.Context = Nothing
        Me.fpEditorFont.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.fpEditorFont.ForeColor = System.Drawing.SystemColors.WindowText
        Me.fpEditorFont.Location = New System.Drawing.Point(193, 58)
        Me.fpEditorFont.Name = "fpEditorFont"
        Me.fpEditorFont.ReadOnly = False
        Me.fpEditorFont.Size = New System.Drawing.Size(239, 20)
        Me.fpEditorFont.TabIndex = 4
        Me.fpEditorFont.Text = "Microsoft Sans Serif; 8,25pt"
        Me.fpEditorFont.Value = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Couleur de fond de l'éditeur"
        '
        'pbEditorColor
        '
        Me.pbEditorColor.BackColor = System.Drawing.Color.Black
        Me.pbEditorColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEditorColor.Location = New System.Drawing.Point(193, 30)
        Me.pbEditorColor.Name = "pbEditorColor"
        Me.pbEditorColor.Size = New System.Drawing.Size(20, 20)
        Me.pbEditorColor.TabIndex = 0
        Me.pbEditorColor.TabStop = False
        '
        'cd
        '
        Me.cd.FullOpen = True
        '
        'GuiDosbox_Label8
        '
        Me.GuiDosbox_Label8.AutoSize = True
        Me.GuiDosbox_Label8.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label8.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuiDosbox_Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GuiDosbox_Label8.Location = New System.Drawing.Point(240, 113)
        Me.GuiDosbox_Label8.Name = "GuiDosbox_Label8"
        Me.GuiDosbox_Label8.Size = New System.Drawing.Size(153, 14)
        Me.GuiDosbox_Label8.TabIndex = 37
        Me.GuiDosbox_Label8.Text = "Coloration des arobas (@)"
        '
        'lblKeywords
        '
        Me.lblKeywords.AutoSize = True
        Me.lblKeywords.BackColor = System.Drawing.Color.Transparent
        Me.lblKeywords.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeywords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lblKeywords.Location = New System.Drawing.Point(37, 25)
        Me.lblKeywords.Name = "lblKeywords"
        Me.lblKeywords.Size = New System.Drawing.Size(143, 14)
        Me.lblKeywords.TabIndex = 23
        Me.lblKeywords.Text = "Coloration des mots clés"
        '
        'GuiDosbox_Label9
        '
        Me.GuiDosbox_Label9.AutoSize = True
        Me.GuiDosbox_Label9.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label9.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuiDosbox_Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GuiDosbox_Label9.Location = New System.Drawing.Point(37, 113)
        Me.GuiDosbox_Label9.Name = "GuiDosbox_Label9"
        Me.GuiDosbox_Label9.Size = New System.Drawing.Size(134, 14)
        Me.GuiDosbox_Label9.TabIndex = 29
        Me.GuiDosbox_Label9.Text = "Coloration des chiffres"
        '
        'GuiDosbox_Label10
        '
        Me.GuiDosbox_Label10.AutoSize = True
        Me.GuiDosbox_Label10.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label10.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuiDosbox_Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GuiDosbox_Label10.Location = New System.Drawing.Point(240, 84)
        Me.GuiDosbox_Label10.Name = "GuiDosbox_Label10"
        Me.GuiDosbox_Label10.Size = New System.Drawing.Size(174, 14)
        Me.GuiDosbox_Label10.TabIndex = 28
        Me.GuiDosbox_Label10.Text = "Coloration des commentaires"
        '
        'GuiDosbox_Label11
        '
        Me.GuiDosbox_Label11.AutoSize = True
        Me.GuiDosbox_Label11.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label11.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuiDosbox_Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GuiDosbox_Label11.Location = New System.Drawing.Point(240, 55)
        Me.GuiDosbox_Label11.Name = "GuiDosbox_Label11"
        Me.GuiDosbox_Label11.Size = New System.Drawing.Size(153, 14)
        Me.GuiDosbox_Label11.TabIndex = 27
        Me.GuiDosbox_Label11.Text = "Coloration des opérateurs"
        '
        'GuiDosbox_Label12
        '
        Me.GuiDosbox_Label12.AutoSize = True
        Me.GuiDosbox_Label12.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label12.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuiDosbox_Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GuiDosbox_Label12.Location = New System.Drawing.Point(240, 26)
        Me.GuiDosbox_Label12.Name = "GuiDosbox_Label12"
        Me.GuiDosbox_Label12.Size = New System.Drawing.Size(145, 14)
        Me.GuiDosbox_Label12.TabIndex = 26
        Me.GuiDosbox_Label12.Text = "Coloration des variables"
        '
        'GuiDosbox_Label13
        '
        Me.GuiDosbox_Label13.AutoSize = True
        Me.GuiDosbox_Label13.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label13.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuiDosbox_Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GuiDosbox_Label13.Location = New System.Drawing.Point(37, 84)
        Me.GuiDosbox_Label13.Name = "GuiDosbox_Label13"
        Me.GuiDosbox_Label13.Size = New System.Drawing.Size(131, 14)
        Me.GuiDosbox_Label13.TabIndex = 25
        Me.GuiDosbox_Label13.Text = "Coloration des Ancres"
        '
        'lblCommands
        '
        Me.lblCommands.AutoSize = True
        Me.lblCommands.BackColor = System.Drawing.Color.Transparent
        Me.lblCommands.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommands.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lblCommands.Location = New System.Drawing.Point(37, 54)
        Me.lblCommands.Name = "lblCommands"
        Me.lblCommands.Size = New System.Drawing.Size(160, 14)
        Me.lblCommands.TabIndex = 24
        Me.lblCommands.Text = "Coloration des commandes"
        '
        'GuiDosbox_Label14
        '
        Me.GuiDosbox_Label14.AutoSize = True
        Me.GuiDosbox_Label14.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label14.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuiDosbox_Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GuiDosbox_Label14.Location = New System.Drawing.Point(216, 113)
        Me.GuiDosbox_Label14.Name = "GuiDosbox_Label14"
        Me.GuiDosbox_Label14.Size = New System.Drawing.Size(139, 14)
        Me.GuiDosbox_Label14.TabIndex = 31
        Me.GuiDosbox_Label14.Text = "Couleur des arobas (@)"
        '
        'GuiDosbox_Label1
        '
        Me.GuiDosbox_Label1.AutoSize = True
        Me.GuiDosbox_Label1.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuiDosbox_Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GuiDosbox_Label1.Location = New System.Drawing.Point(13, 25)
        Me.GuiDosbox_Label1.Name = "GuiDosbox_Label1"
        Me.GuiDosbox_Label1.Size = New System.Drawing.Size(129, 14)
        Me.GuiDosbox_Label1.TabIndex = 23
        Me.GuiDosbox_Label1.Text = "Couleur des mots clés"
        '
        'GuiDosbox_Label7
        '
        Me.GuiDosbox_Label7.AutoSize = True
        Me.GuiDosbox_Label7.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuiDosbox_Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GuiDosbox_Label7.Location = New System.Drawing.Point(13, 113)
        Me.GuiDosbox_Label7.Name = "GuiDosbox_Label7"
        Me.GuiDosbox_Label7.Size = New System.Drawing.Size(120, 14)
        Me.GuiDosbox_Label7.TabIndex = 29
        Me.GuiDosbox_Label7.Text = "Couleur des chiffres"
        '
        'GuiDosbox_Label6
        '
        Me.GuiDosbox_Label6.AutoSize = True
        Me.GuiDosbox_Label6.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuiDosbox_Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GuiDosbox_Label6.Location = New System.Drawing.Point(216, 84)
        Me.GuiDosbox_Label6.Name = "GuiDosbox_Label6"
        Me.GuiDosbox_Label6.Size = New System.Drawing.Size(160, 14)
        Me.GuiDosbox_Label6.TabIndex = 28
        Me.GuiDosbox_Label6.Text = "Couleur des commentaires"
        '
        'GuiDosbox_Label5
        '
        Me.GuiDosbox_Label5.AutoSize = True
        Me.GuiDosbox_Label5.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuiDosbox_Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GuiDosbox_Label5.Location = New System.Drawing.Point(216, 54)
        Me.GuiDosbox_Label5.Name = "GuiDosbox_Label5"
        Me.GuiDosbox_Label5.Size = New System.Drawing.Size(139, 14)
        Me.GuiDosbox_Label5.TabIndex = 27
        Me.GuiDosbox_Label5.Text = "Couleur des opérateurs"
        '
        'GuiDosbox_Label4
        '
        Me.GuiDosbox_Label4.AutoSize = True
        Me.GuiDosbox_Label4.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuiDosbox_Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GuiDosbox_Label4.Location = New System.Drawing.Point(216, 25)
        Me.GuiDosbox_Label4.Name = "GuiDosbox_Label4"
        Me.GuiDosbox_Label4.Size = New System.Drawing.Size(131, 14)
        Me.GuiDosbox_Label4.TabIndex = 26
        Me.GuiDosbox_Label4.Text = "Couleur des variables"
        '
        'GuiDosbox_Label3
        '
        Me.GuiDosbox_Label3.AutoSize = True
        Me.GuiDosbox_Label3.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuiDosbox_Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GuiDosbox_Label3.Location = New System.Drawing.Point(13, 84)
        Me.GuiDosbox_Label3.Name = "GuiDosbox_Label3"
        Me.GuiDosbox_Label3.Size = New System.Drawing.Size(117, 14)
        Me.GuiDosbox_Label3.TabIndex = 25
        Me.GuiDosbox_Label3.Text = "Couleur des Ancres"
        '
        'GuiDosbox_Label2
        '
        Me.GuiDosbox_Label2.AutoSize = True
        Me.GuiDosbox_Label2.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuiDosbox_Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GuiDosbox_Label2.Location = New System.Drawing.Point(13, 54)
        Me.GuiDosbox_Label2.Name = "GuiDosbox_Label2"
        Me.GuiDosbox_Label2.Size = New System.Drawing.Size(146, 14)
        Me.GuiDosbox_Label2.TabIndex = 24
        Me.GuiDosbox_Label2.Text = "Couleur des commandes"
        '
        'frmApplicationSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(634, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmApplicationSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI Dosbox - Paramètres"
        Me.tabGeneral.ResumeLayout(False)
        Me.gbParametres.ResumeLayout(False)
        Me.gbParametres.PerformLayout()
        Me.TabControlMain.ResumeLayout(False)
        Me.tabColoration.ResumeLayout(False)
        Me.gbSyntaxtOnOff.ResumeLayout(False)
        Me.gbSyntaxtOnOff.PerformLayout()
        Me.gbSyntaxColor.ResumeLayout(False)
        Me.gbSyntaxColor.PerformLayout()
        CType(Me.pbColorArobas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColorKeywords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColorCommands, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColorAnchors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColorVariables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColorComments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColorOperators, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColorIntegers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEditeur.ResumeLayout(False)
        Me.gbParamEditeur.ResumeLayout(False)
        Me.gbParamEditeur.PerformLayout()
        CType(Me.pbEditorColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents TabControlMain As System.Windows.Forms.TabControl
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
    Friend WithEvents gbParametres As System.Windows.Forms.GroupBox
    Friend WithEvents optAutoUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents optColorationOnOff As System.Windows.Forms.CheckBox
    Friend WithEvents btnGenDefault As System.Windows.Forms.Button
    Friend WithEvents btnGenApply As System.Windows.Forms.Button
    Friend WithEvents btnGenCancel As System.Windows.Forms.Button
    Friend WithEvents btnAllDefault As System.Windows.Forms.Button
    Friend WithEvents btnEdtDefault As System.Windows.Forms.Button
    Friend WithEvents btnEdtCancel As System.Windows.Forms.Button
    Friend WithEvents btnEdtApply As System.Windows.Forms.Button
    Friend WithEvents gbParamEditeur As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbEditorColor As System.Windows.Forms.PictureBox
    Friend WithEvents fpEditorFont As GUIDB.Forms.Controls.FontPicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
