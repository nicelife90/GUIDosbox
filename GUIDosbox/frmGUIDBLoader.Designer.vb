<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGUIDBLoader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGUIDBLoader))
        Me.imgFlash = New System.Windows.Forms.PictureBox()
        Me.imgBtnClose = New System.Windows.Forms.PictureBox()
        Me.imgBtnMinimize = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnInstall = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.imgFlash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBtnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgFlash
        '
        Me.imgFlash.Image = Global.GUIDosbox.My.Resources.Resources.Flash11
        Me.imgFlash.Location = New System.Drawing.Point(12, 46)
        Me.imgFlash.Name = "imgFlash"
        Me.imgFlash.Size = New System.Drawing.Size(137, 131)
        Me.imgFlash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgFlash.TabIndex = 0
        Me.imgFlash.TabStop = False
        '
        'imgBtnClose
        '
        Me.imgBtnClose.Image = Global.GUIDosbox.My.Resources.Resources.btnClose
        Me.imgBtnClose.Location = New System.Drawing.Point(477, 10)
        Me.imgBtnClose.Name = "imgBtnClose"
        Me.imgBtnClose.Size = New System.Drawing.Size(28, 28)
        Me.imgBtnClose.TabIndex = 1
        Me.imgBtnClose.TabStop = False
        '
        'imgBtnMinimize
        '
        Me.imgBtnMinimize.Image = Global.GUIDosbox.My.Resources.Resources.btnMinimize
        Me.imgBtnMinimize.Location = New System.Drawing.Point(443, 10)
        Me.imgBtnMinimize.Name = "imgBtnMinimize"
        Me.imgBtnMinimize.Size = New System.Drawing.Size(28, 28)
        Me.imgBtnMinimize.TabIndex = 2
        Me.imgBtnMinimize.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(175, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(184, 18)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "GUI Dosbox - Prérequis"
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(162, 48)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(329, 150)
        Me.lblText.TabIndex = 4
        Me.lblText.Text = resources.GetString("lblText.Text")
        '
        'btnInstall
        '
        Me.btnInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstall.ForeColor = System.Drawing.Color.White
        Me.btnInstall.Location = New System.Drawing.Point(349, 218)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.Size = New System.Drawing.Size(75, 23)
        Me.btnInstall.TabIndex = 5
        Me.btnInstall.Text = "Installer"
        Me.btnInstall.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(430, 218)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmGUIDBLoader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(515, 253)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnInstall)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.imgBtnMinimize)
        Me.Controls.Add(Me.imgBtnClose)
        Me.Controls.Add(Me.imgFlash)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGUIDBLoader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI Dosbox - Prérequis"
        CType(Me.imgFlash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgFlash As System.Windows.Forms.PictureBox
    Friend WithEvents imgBtnClose As System.Windows.Forms.PictureBox
    Friend WithEvents imgBtnMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents btnInstall As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
