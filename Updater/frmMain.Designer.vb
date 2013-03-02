<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnTerminer = New System.Windows.Forms.Button()
        Me.GuiDosbox_ProgressBar1 = New update.GUIDosbox_ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(204, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Assistant de mise à jour"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(46, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(448, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bienvenue dans l'assistant de mise à jour pour GUI Dosbox." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pour commencer la mis" & _
    "e à jour, appuyer sur le bouton mettre à jour."
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Silver
        Me.btnUpdate.Location = New System.Drawing.Point(164, 203)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(162, 33)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Mettre à jour"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnTerminer
        '
        Me.btnTerminer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTerminer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerminer.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminer.ForeColor = System.Drawing.Color.Silver
        Me.btnTerminer.Location = New System.Drawing.Point(332, 203)
        Me.btnTerminer.Name = "btnTerminer"
        Me.btnTerminer.Size = New System.Drawing.Size(162, 33)
        Me.btnTerminer.TabIndex = 6
        Me.btnTerminer.Text = "Terminer"
        Me.btnTerminer.UseVisualStyleBackColor = True
        '
        'GuiDosbox_ProgressBar1
        '
        Me.GuiDosbox_ProgressBar1.BackgroundImage = CType(resources.GetObject("GuiDosbox_ProgressBar1.BackgroundImage"), System.Drawing.Image)
        Me.GuiDosbox_ProgressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuiDosbox_ProgressBar1.FillProgress = 0
        Me.GuiDosbox_ProgressBar1.Location = New System.Drawing.Point(31, 108)
        Me.GuiDosbox_ProgressBar1.MaximumSize = New System.Drawing.Size(596, 80)
        Me.GuiDosbox_ProgressBar1.MinimumSize = New System.Drawing.Size(596, 80)
        Me.GuiDosbox_ProgressBar1.Name = "GuiDosbox_ProgressBar1"
        Me.GuiDosbox_ProgressBar1.OutputText = "Prêt"
        Me.GuiDosbox_ProgressBar1.Size = New System.Drawing.Size(596, 80)
        Me.GuiDosbox_ProgressBar1.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(658, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.GuiDosbox_ProgressBar1)
        Me.Controls.Add(Me.btnTerminer)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI Dosbox Updater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnTerminer As System.Windows.Forms.Button
    Friend WithEvents GuiDosbox_ProgressBar1 As update.GUIDosbox_ProgressBar

End Class
