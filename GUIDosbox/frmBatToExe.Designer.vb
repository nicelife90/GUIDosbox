<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatToExe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBatToExe))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.optAsAdmin = New GUIDosbox.GUIDosbox_Checkbox()
        Me.GuiDosbox_Groupbox2 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.btnBrowseIcone = New GUIDosbox.GUIDosbox_Button()
        Me.txtIcone = New GUIDosbox.GUIDosbox_Textbox()
        Me.GuiDosbox_Groupbox1 = New GUIDosbox.GUIDosbox_Groupbox()
        Me.btnBrowse = New GUIDosbox.GUIDosbox_Button()
        Me.txtSource = New GUIDosbox.GUIDosbox_Textbox()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnBuild = New GUIDosbox.GUIDosbox_Button()
        Me.lblStatus = New GUIDosbox.GUIDosbox_Label()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GuiDosbox_Groupbox2.SuspendLayout()
        Me.GuiDosbox_Groupbox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 234)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(384, 10)
        Me.ProgressBar1.TabIndex = 8
        '
        'flashHeader
        '
        Me.flashHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(0, 0)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(588, 40)
        Me.flashHeader.TabIndex = 12
        '
        'optAsAdmin
        '
        Me.optAsAdmin.AutoSize = True
        Me.optAsAdmin.BackColor = System.Drawing.Color.Black
        Me.optAsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAsAdmin.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAsAdmin.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAsAdmin.Location = New System.Drawing.Point(13, 195)
        Me.optAsAdmin.Name = "optAsAdmin"
        Me.optAsAdmin.Size = New System.Drawing.Size(203, 15)
        Me.optAsAdmin.TabIndex = 16
        Me.optAsAdmin.Text = "Add Administrator manifest"
        Me.optAsAdmin.UseVisualStyleBackColor = False
        '
        'GuiDosbox_Groupbox2
        '
        Me.GuiDosbox_Groupbox2.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox2.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox2.Controls.Add(Me.btnBrowseIcone)
        Me.GuiDosbox_Groupbox2.Controls.Add(Me.txtIcone)
        Me.GuiDosbox_Groupbox2.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox2.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox2.Location = New System.Drawing.Point(12, 120)
        Me.GuiDosbox_Groupbox2.Name = "GuiDosbox_Groupbox2"
        Me.GuiDosbox_Groupbox2.Size = New System.Drawing.Size(566, 68)
        Me.GuiDosbox_Groupbox2.TabIndex = 15
        Me.GuiDosbox_Groupbox2.TabStop = False
        Me.GuiDosbox_Groupbox2.Text = " Icone (Optionel)"
        '
        'btnBrowseIcone
        '
        Me.btnBrowseIcone.BackColor = System.Drawing.Color.Black
        Me.btnBrowseIcone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowseIcone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBrowseIcone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseIcone.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnBrowseIcone.ForeColor = System.Drawing.Color.LightBlue
        Me.btnBrowseIcone.Location = New System.Drawing.Point(19, 23)
        Me.btnBrowseIcone.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBrowseIcone.Name = "btnBrowseIcone"
        Me.btnBrowseIcone.Size = New System.Drawing.Size(82, 23)
        Me.btnBrowseIcone.TabIndex = 9
        Me.btnBrowseIcone.Text = "Parcourir"
        Me.btnBrowseIcone.UseVisualStyleBackColor = False
        '
        'txtIcone
        '
        Me.txtIcone.BackColor = System.Drawing.Color.Black
        Me.txtIcone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIcone.Enabled = False
        Me.txtIcone.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtIcone.ForeColor = System.Drawing.Color.LightBlue
        Me.txtIcone.Location = New System.Drawing.Point(107, 26)
        Me.txtIcone.Name = "txtIcone"
        Me.txtIcone.Size = New System.Drawing.Size(440, 18)
        Me.txtIcone.TabIndex = 11
        '
        'GuiDosbox_Groupbox1
        '
        Me.GuiDosbox_Groupbox1.BackColor = System.Drawing.Color.Black
        Me.GuiDosbox_Groupbox1.BorderColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.btnBrowse)
        Me.GuiDosbox_Groupbox1.Controls.Add(Me.txtSource)
        Me.GuiDosbox_Groupbox1.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.GuiDosbox_Groupbox1.ForeColor = System.Drawing.Color.LightBlue
        Me.GuiDosbox_Groupbox1.Location = New System.Drawing.Point(12, 46)
        Me.GuiDosbox_Groupbox1.Name = "GuiDosbox_Groupbox1"
        Me.GuiDosbox_Groupbox1.Size = New System.Drawing.Size(566, 68)
        Me.GuiDosbox_Groupbox1.TabIndex = 14
        Me.GuiDosbox_Groupbox1.TabStop = False
        Me.GuiDosbox_Groupbox1.Text = " Fichier"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Black
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnBrowse.ForeColor = System.Drawing.Color.LightBlue
        Me.btnBrowse.Location = New System.Drawing.Point(19, 23)
        Me.btnBrowse.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(82, 23)
        Me.btnBrowse.TabIndex = 9
        Me.btnBrowse.Text = "Parcourir"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'txtSource
        '
        Me.txtSource.BackColor = System.Drawing.Color.Black
        Me.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSource.Enabled = False
        Me.txtSource.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtSource.ForeColor = System.Drawing.Color.LightBlue
        Me.txtSource.Location = New System.Drawing.Point(107, 26)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(440, 18)
        Me.txtSource.TabIndex = 11
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.LightBlue
        Me.btnBack.Location = New System.Drawing.Point(496, 221)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 23)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnBuild
        '
        Me.btnBuild.BackColor = System.Drawing.Color.Black
        Me.btnBuild.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuild.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnBuild.ForeColor = System.Drawing.Color.LightBlue
        Me.btnBuild.Location = New System.Drawing.Point(408, 221)
        Me.btnBuild.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBuild.Name = "btnBuild"
        Me.btnBuild.Size = New System.Drawing.Size(82, 23)
        Me.btnBuild.TabIndex = 10
        Me.btnBuild.Text = "Build"
        Me.btnBuild.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.LightBlue
        Me.lblStatus.Location = New System.Drawing.Point(10, 220)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(61, 11)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "[Status]"
        '
        'frmBatToExe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(588, 254)
        Me.ControlBox = False
        Me.Controls.Add(Me.optAsAdmin)
        Me.Controls.Add(Me.GuiDosbox_Groupbox2)
        Me.Controls.Add(Me.GuiDosbox_Groupbox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.btnBuild)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblStatus)
        Me.ForeColor = System.Drawing.Color.LightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBatToExe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batch To Exe"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GuiDosbox_Groupbox2.ResumeLayout(False)
        Me.GuiDosbox_Groupbox2.PerformLayout()
        Me.GuiDosbox_Groupbox1.ResumeLayout(False)
        Me.GuiDosbox_Groupbox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatus As GUIDosbox.GUIDosbox_Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnBrowse As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBuild As GUIDosbox.GUIDosbox_Button
    Friend WithEvents txtSource As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents GuiDosbox_Groupbox1 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents GuiDosbox_Groupbox2 As GUIDosbox.GUIDosbox_Groupbox
    Friend WithEvents btnBrowseIcone As GUIDosbox.GUIDosbox_Button
    Friend WithEvents txtIcone As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents optAsAdmin As GUIDosbox.GUIDosbox_Checkbox

End Class
