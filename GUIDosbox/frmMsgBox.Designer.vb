<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsgBox))
        Me.GuiDosbox_Label1 = New GUIDosbox.GUIDosbox_Label()
        Me.btnNon = New GUIDosbox.GUIDosbox_Button()
        Me.btnOui = New GUIDosbox.GUIDosbox_Button()
        Me.SuspendLayout()
        '
        'GuiDosbox_Label1
        '
        Me.GuiDosbox_Label1.AutoSize = True
        Me.GuiDosbox_Label1.BackColor = System.Drawing.Color.Transparent
        Me.GuiDosbox_Label1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Label1.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Label1.Location = New System.Drawing.Point(17, 13)
        Me.GuiDosbox_Label1.Name = "GuiDosbox_Label1"
        Me.GuiDosbox_Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GuiDosbox_Label1.Size = New System.Drawing.Size(614, 88)
        Me.GuiDosbox_Label1.TabIndex = 3
        Me.GuiDosbox_Label1.Text = resources.GetString("GuiDosbox_Label1.Text")
        '
        'btnNon
        '
        Me.btnNon.BackColor = System.Drawing.Color.Black
        Me.btnNon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNon.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNon.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnNon.ForeColor = System.Drawing.Color.LightBlue
        Me.btnNon.Location = New System.Drawing.Point(327, 132)
        Me.btnNon.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnNon.Name = "btnNon"
        Me.btnNon.Size = New System.Drawing.Size(105, 25)
        Me.btnNon.TabIndex = 1
        Me.btnNon.Text = "Non"
        Me.btnNon.UseVisualStyleBackColor = False
        '
        'btnOui
        '
        Me.btnOui.BackColor = System.Drawing.Color.Black
        Me.btnOui.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOui.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnOui.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOui.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnOui.ForeColor = System.Drawing.Color.LightBlue
        Me.btnOui.Location = New System.Drawing.Point(216, 132)
        Me.btnOui.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnOui.Name = "btnOui"
        Me.btnOui.Size = New System.Drawing.Size(105, 25)
        Me.btnOui.TabIndex = 0
        Me.btnOui.Text = "Oui"
        Me.btnOui.UseVisualStyleBackColor = False
        '
        'frmMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 176)
        Me.ControlBox = False
        Me.Controls.Add(Me.GuiDosbox_Label1)
        Me.Controls.Add(Me.btnNon)
        Me.Controls.Add(Me.btnOui)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(664, 214)
        Me.MinimizeBox = False
        Me.Name = "frmMsgBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUIDosbox"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOui As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnNon As GUIDosbox.GUIDosbox_Button
    Friend WithEvents GuiDosbox_Label1 As GUIDosbox.GUIDosbox_Label
End Class
