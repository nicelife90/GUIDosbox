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
        Me.cd = New System.Windows.Forms.ColorDialog()
        Me.tabEditeur = New System.Windows.Forms.TabPage()
        Me.btnEdtDefault = New System.Windows.Forms.Button()
        Me.btnEdtCancel = New System.Windows.Forms.Button()
        Me.btnEdtApply = New System.Windows.Forms.Button()
        Me.gbParamEditeur = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbLineColor = New System.Windows.Forms.PictureBox()
        Me.cbHighLightLine = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fpEditorFont = New GUIDB.Forms.Controls.FontPicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbEditorColor = New System.Windows.Forms.PictureBox()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.gbParametres = New System.Windows.Forms.GroupBox()
        Me.optSaveWarning = New System.Windows.Forms.CheckBox()
        Me.optAutoUpdate = New System.Windows.Forms.CheckBox()
        Me.btnGenDefault = New System.Windows.Forms.Button()
        Me.btnGenApply = New System.Windows.Forms.Button()
        Me.btnGenCancel = New System.Windows.Forms.Button()
        Me.btnAllDefault = New System.Windows.Forms.Button()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.tabEditeur.SuspendLayout()
        Me.gbParamEditeur.SuspendLayout()
        CType(Me.pbLineColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEditorColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGeneral.SuspendLayout()
        Me.gbParametres.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'cd
        '
        Me.cd.FullOpen = True
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
        Me.btnEdtDefault.Location = New System.Drawing.Point(326, 169)
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
        Me.gbParamEditeur.Controls.Add(Me.Label3)
        Me.gbParamEditeur.Controls.Add(Me.pbLineColor)
        Me.gbParamEditeur.Controls.Add(Me.cbHighLightLine)
        Me.gbParamEditeur.Controls.Add(Me.Label2)
        Me.gbParamEditeur.Controls.Add(Me.fpEditorFont)
        Me.gbParamEditeur.Controls.Add(Me.Label1)
        Me.gbParamEditeur.Controls.Add(Me.pbEditorColor)
        Me.gbParamEditeur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.gbParamEditeur.Location = New System.Drawing.Point(12, 9)
        Me.gbParamEditeur.Name = "gbParamEditeur"
        Me.gbParamEditeur.Size = New System.Drawing.Size(438, 154)
        Me.gbParamEditeur.TabIndex = 0
        Me.gbParamEditeur.TabStop = False
        Me.gbParamEditeur.Text = " Paramètres de l'éditeur "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Couleur de la ligne sélectionnée"
        '
        'pbLineColor
        '
        Me.pbLineColor.BackColor = System.Drawing.Color.Black
        Me.pbLineColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbLineColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLineColor.Location = New System.Drawing.Point(202, 111)
        Me.pbLineColor.Name = "pbLineColor"
        Me.pbLineColor.Size = New System.Drawing.Size(20, 20)
        Me.pbLineColor.TabIndex = 11
        Me.pbLineColor.TabStop = False
        '
        'cbHighLightLine
        '
        Me.cbHighLightLine.AutoSize = True
        Me.cbHighLightLine.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.cbHighLightLine.Location = New System.Drawing.Point(9, 84)
        Me.cbHighLightLine.Name = "cbHighLightLine"
        Me.cbHighLightLine.Size = New System.Drawing.Size(254, 18)
        Me.cbHighLightLine.TabIndex = 10
        Me.cbHighLightLine.Text = "Mettre en évidence la ligne sélectionnée"
        Me.cbHighLightLine.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 58)
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
        Me.fpEditorFont.Location = New System.Drawing.Point(202, 55)
        Me.fpEditorFont.Name = "fpEditorFont"
        Me.fpEditorFont.ReadOnly = False
        Me.fpEditorFont.Size = New System.Drawing.Size(230, 20)
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
        Me.pbEditorColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbEditorColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEditorColor.Location = New System.Drawing.Point(202, 26)
        Me.pbEditorColor.Name = "pbEditorColor"
        Me.pbEditorColor.Size = New System.Drawing.Size(20, 20)
        Me.pbEditorColor.TabIndex = 0
        Me.pbEditorColor.TabStop = False
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
        Me.gbParametres.Controls.Add(Me.optSaveWarning)
        Me.gbParametres.Controls.Add(Me.optAutoUpdate)
        Me.gbParametres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.gbParametres.Location = New System.Drawing.Point(12, 9)
        Me.gbParametres.Name = "gbParametres"
        Me.gbParametres.Size = New System.Drawing.Size(438, 106)
        Me.gbParametres.TabIndex = 5
        Me.gbParametres.TabStop = False
        Me.gbParametres.Text = " Paramètres Général "
        '
        'optSaveWarning
        '
        Me.optSaveWarning.AutoSize = True
        Me.optSaveWarning.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.optSaveWarning.Location = New System.Drawing.Point(12, 46)
        Me.optSaveWarning.Name = "optSaveWarning"
        Me.optSaveWarning.Size = New System.Drawing.Size(256, 18)
        Me.optSaveWarning.TabIndex = 9
        Me.optSaveWarning.Text = "Message d'avertissement à la fermeture "
        Me.optSaveWarning.UseVisualStyleBackColor = True
        '
        'optAutoUpdate
        '
        Me.optAutoUpdate.AutoSize = True
        Me.optAutoUpdate.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.optAutoUpdate.Location = New System.Drawing.Point(12, 22)
        Me.optAutoUpdate.Name = "optAutoUpdate"
        Me.optAutoUpdate.Size = New System.Drawing.Size(165, 18)
        Me.optAutoUpdate.TabIndex = 7
        Me.optAutoUpdate.Text = "Mise à jour automatique"
        Me.optAutoUpdate.UseVisualStyleBackColor = True
        '
        'btnGenDefault
        '
        Me.btnGenDefault.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.btnGenDefault.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGenDefault.Location = New System.Drawing.Point(332, 121)
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
        Me.tabEditeur.ResumeLayout(False)
        Me.gbParamEditeur.ResumeLayout(False)
        Me.gbParamEditeur.PerformLayout()
        CType(Me.pbLineColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEditorColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGeneral.ResumeLayout(False)
        Me.gbParametres.ResumeLayout(False)
        Me.gbParametres.PerformLayout()
        Me.TabControlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cd As System.Windows.Forms.ColorDialog
    Friend WithEvents tabEditeur As System.Windows.Forms.TabPage
    Friend WithEvents btnEdtDefault As System.Windows.Forms.Button
    Friend WithEvents btnEdtCancel As System.Windows.Forms.Button
    Friend WithEvents btnEdtApply As System.Windows.Forms.Button
    Friend WithEvents gbParamEditeur As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fpEditorFont As GUIDB.Forms.Controls.FontPicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbEditorColor As System.Windows.Forms.PictureBox
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents gbParametres As System.Windows.Forms.GroupBox
    Friend WithEvents optSaveWarning As System.Windows.Forms.CheckBox
    Friend WithEvents optAutoUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents btnGenDefault As System.Windows.Forms.Button
    Friend WithEvents btnGenApply As System.Windows.Forms.Button
    Friend WithEvents btnGenCancel As System.Windows.Forms.Button
    Friend WithEvents btnAllDefault As System.Windows.Forms.Button
    Friend WithEvents TabControlMain As System.Windows.Forms.TabControl
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents cbHighLightLine As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pbLineColor As System.Windows.Forms.PictureBox
End Class
