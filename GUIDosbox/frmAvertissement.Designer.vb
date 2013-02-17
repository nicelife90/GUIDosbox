<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvertissement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAvertissement))
        Me.GuiDosbox_Label1 = New GUIDosbox.GUIDosbox_Label()
        Me.btnOK = New GUIDosbox.GUIDosbox_Button()
        Me.SuspendLayout()
        '
        'GuiDosbox_Label1
        '
        Me.GuiDosbox_Label1.AutoSize = True
        Me.GuiDosbox_Label1.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label1.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Label1.Location = New System.Drawing.Point(11, 19)
        Me.GuiDosbox_Label1.Name = "GuiDosbox_Label1"
        Me.GuiDosbox_Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GuiDosbox_Label1.Size = New System.Drawing.Size(628, 121)
        Me.GuiDosbox_Label1.TabIndex = 3
        Me.GuiDosbox_Label1.Text = resources.GetString("GuiDosbox_Label1.Text")
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Black
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnOK.ForeColor = System.Drawing.Color.LightBlue
        Me.btnOK.Location = New System.Drawing.Point(273, 151)
        Me.btnOK.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(105, 25)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'frmAvertissement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(650, 189)
        Me.Controls.Add(Me.GuiDosbox_Label1)
        Me.Controls.Add(Me.btnOK)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAvertissement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUIDosbox"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As GUIDosbox.GUIDosbox_Button
    Friend WithEvents GuiDosbox_Label1 As GUIDosbox.GUIDosbox_Label
End Class
