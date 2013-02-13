<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUIDosbox_StatusStrip
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblFonctionanlite = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFonctionanliteStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPrivileges = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPrivilegesStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblMode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblModeStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.StatusStrip1.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFonctionanlite, Me.lblFonctionanliteStatus, Me.ToolStripStatusLabel3, Me.lblPrivileges, Me.lblPrivilegesStatus, Me.ToolStripStatusLabel6, Me.lblMode, Me.lblModeStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(595, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 73
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblFonctionanlite
        '
        Me.lblFonctionanlite.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblFonctionanlite.Name = "lblFonctionanlite"
        Me.lblFonctionanlite.Size = New System.Drawing.Size(117, 17)
        Me.lblFonctionanlite.Text = "Fonctionnalités:"
        '
        'lblFonctionanliteStatus
        '
        Me.lblFonctionanliteStatus.ForeColor = System.Drawing.Color.MediumPurple
        Me.lblFonctionanliteStatus.Name = "lblFonctionanliteStatus"
        Me.lblFonctionanliteStatus.Size = New System.Drawing.Size(61, 17)
        Me.lblFonctionanliteStatus.Text = "Complète"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(12, 17)
        Me.ToolStripStatusLabel3.Text = "-"
        '
        'lblPrivileges
        '
        Me.lblPrivileges.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblPrivileges.Name = "lblPrivileges"
        Me.lblPrivileges.Size = New System.Drawing.Size(82, 17)
        Me.lblPrivileges.Text = "Privilèges:"
        '
        'lblPrivilegesStatus
        '
        Me.lblPrivilegesStatus.ForeColor = System.Drawing.Color.LightBlue
        Me.lblPrivilegesStatus.Name = "lblPrivilegesStatus"
        Me.lblPrivilegesStatus.Size = New System.Drawing.Size(103, 17)
        Me.lblPrivilegesStatus.Text = "Administrateur"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(12, 17)
        Me.ToolStripStatusLabel6.Text = "-"
        '
        'lblMode
        '
        Me.lblMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(145, 17)
        Me.lblMode.Text = "Mode d'utilisation :"
        '
        'lblModeStatus
        '
        Me.lblModeStatus.ForeColor = System.Drawing.Color.LightBlue
        Me.lblModeStatus.Name = "lblModeStatus"
        Me.lblModeStatus.Size = New System.Drawing.Size(47, 17)
        Me.lblModeStatus.Text = "Normal"
        '
        'GUIDosbox_StatusStrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "GUIDosbox_StatusStrip"
        Me.Size = New System.Drawing.Size(595, 22)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblFonctionanlite As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblFonctionanliteStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblPrivileges As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblPrivilegesStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblMode As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblModeStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
