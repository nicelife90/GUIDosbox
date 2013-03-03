<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssocApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssocApp))
        Me.flashHeader = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.btnSend = New GUIDosbox.GUIDosbox_Button()
        Me.optAdvanceMode = New GUIDosbox.GUIDosbox_Checkbox()
        Me.lblTypeFichier = New GUIDosbox.GUIDosbox_Label()
        Me.lblExtention = New GUIDosbox.GUIDosbox_Label()
        Me.lblCommande = New GUIDosbox.GUIDosbox_Label()
        Me.txtCmdExec = New GUIDosbox.GUIDosbox_Textbox()
        Me.btnHelp = New GUIDosbox.GUIDosbox_Button()
        Me.btnApply = New GUIDosbox.GUIDosbox_Button()
        Me.btnBack = New GUIDosbox.GUIDosbox_Button()
        Me.btnClear = New GUIDosbox.GUIDosbox_Button()
        Me.btnExtShow = New GUIDosbox.GUIDosbox_Button()
        Me.txtExtSet = New GUIDosbox.GUIDosbox_Textbox()
        Me.txtExtFile = New GUIDosbox.GUIDosbox_Textbox()
        Me.myConsole = New GUIDosbox.GUIDosbox_Console()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.footer = New GUIDosbox.GUIDosbox_StatusStrip()
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flashHeader
        '
        Me.flashHeader.Enabled = True
        Me.flashHeader.Location = New System.Drawing.Point(1, 0)
        Me.flashHeader.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.flashHeader.Name = "flashHeader"
        Me.flashHeader.OcxState = CType(resources.GetObject("flashHeader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flashHeader.Size = New System.Drawing.Size(594, 40)
        Me.flashHeader.TabIndex = 20
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Black
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnSend.ForeColor = System.Drawing.Color.LightBlue
        Me.btnSend.Location = New System.Drawing.Point(260, 478)
        Me.btnSend.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 33
        Me.btnSend.Text = "Envoyer"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'optAdvanceMode
        '
        Me.optAdvanceMode.AutoSize = True
        Me.optAdvanceMode.BackColor = System.Drawing.Color.Black
        Me.optAdvanceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAdvanceMode.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.optAdvanceMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.optAdvanceMode.Location = New System.Drawing.Point(87, 514)
        Me.optAdvanceMode.Name = "optAdvanceMode"
        Me.optAdvanceMode.Size = New System.Drawing.Size(98, 15)
        Me.optAdvanceMode.TabIndex = 32
        Me.optAdvanceMode.Text = "Mode avancé"
        Me.optAdvanceMode.UseVisualStyleBackColor = False
        '
        'lblTypeFichier
        '
        Me.lblTypeFichier.AutoSize = True
        Me.lblTypeFichier.BackColor = System.Drawing.Color.Transparent
        Me.lblTypeFichier.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblTypeFichier.ForeColor = System.Drawing.Color.LightBlue
        Me.lblTypeFichier.Location = New System.Drawing.Point(18, 101)
        Me.lblTypeFichier.Name = "lblTypeFichier"
        Me.lblTypeFichier.Size = New System.Drawing.Size(124, 11)
        Me.lblTypeFichier.TabIndex = 31
        Me.lblTypeFichier.Text = "Type de fichier :"
        '
        'lblExtention
        '
        Me.lblExtention.AutoSize = True
        Me.lblExtention.BackColor = System.Drawing.Color.Transparent
        Me.lblExtention.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblExtention.ForeColor = System.Drawing.Color.LightBlue
        Me.lblExtention.Location = New System.Drawing.Point(18, 77)
        Me.lblExtention.Name = "lblExtention"
        Me.lblExtention.Size = New System.Drawing.Size(82, 11)
        Me.lblExtention.TabIndex = 30
        Me.lblExtention.Text = "Extension :"
        '
        'lblCommande
        '
        Me.lblCommande.AutoSize = True
        Me.lblCommande.BackColor = System.Drawing.Color.Transparent
        Me.lblCommande.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.lblCommande.ForeColor = System.Drawing.Color.LightBlue
        Me.lblCommande.Location = New System.Drawing.Point(4, 454)
        Me.lblCommande.Name = "lblCommande"
        Me.lblCommande.Size = New System.Drawing.Size(131, 11)
        Me.lblCommande.TabIndex = 29
        Me.lblCommande.Text = "Commande exécuté :"
        '
        'txtCmdExec
        '
        Me.txtCmdExec.BackColor = System.Drawing.Color.Black
        Me.txtCmdExec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmdExec.Enabled = False
        Me.txtCmdExec.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtCmdExec.ForeColor = System.Drawing.Color.LightBlue
        Me.txtCmdExec.Location = New System.Drawing.Point(141, 452)
        Me.txtCmdExec.Name = "txtCmdExec"
        Me.txtCmdExec.Size = New System.Drawing.Size(450, 18)
        Me.txtCmdExec.TabIndex = 28
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Black
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnHelp.ForeColor = System.Drawing.Color.LightBlue
        Me.btnHelp.Location = New System.Drawing.Point(5, 507)
        Me.btnHelp.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 27
        Me.btnHelp.Text = "Aide"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.Black
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnApply.ForeColor = System.Drawing.Color.LightBlue
        Me.btnApply.Location = New System.Drawing.Point(405, 505)
        Me.btnApply.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(90, 23)
        Me.btnApply.TabIndex = 26
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
        Me.btnBack.Location = New System.Drawing.Point(501, 505)
        Me.btnBack.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 23)
        Me.btnBack.TabIndex = 25
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
        Me.btnClear.Location = New System.Drawing.Point(501, 476)
        Me.btnClear.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 23)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Effacer"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExtShow
        '
        Me.btnExtShow.BackColor = System.Drawing.Color.Black
        Me.btnExtShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExtShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExtShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExtShow.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.btnExtShow.ForeColor = System.Drawing.Color.LightBlue
        Me.btnExtShow.Location = New System.Drawing.Point(405, 476)
        Me.btnExtShow.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnExtShow.Name = "btnExtShow"
        Me.btnExtShow.Size = New System.Drawing.Size(90, 23)
        Me.btnExtShow.TabIndex = 23
        Me.btnExtShow.Text = "Extension"
        Me.btnExtShow.UseVisualStyleBackColor = False
        '
        'txtExtSet
        '
        Me.txtExtSet.BackColor = System.Drawing.Color.Black
        Me.txtExtSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExtSet.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtExtSet.ForeColor = System.Drawing.Color.LightBlue
        Me.txtExtSet.Location = New System.Drawing.Point(165, 75)
        Me.txtExtSet.Name = "txtExtSet"
        Me.txtExtSet.Size = New System.Drawing.Size(79, 18)
        Me.txtExtSet.TabIndex = 22
        '
        'txtExtFile
        '
        Me.txtExtFile.BackColor = System.Drawing.Color.Black
        Me.txtExtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExtFile.Font = New System.Drawing.Font("Lucida Console", 8.0!)
        Me.txtExtFile.ForeColor = System.Drawing.Color.LightBlue
        Me.txtExtFile.Location = New System.Drawing.Point(165, 99)
        Me.txtExtFile.Name = "txtExtFile"
        Me.txtExtFile.Size = New System.Drawing.Size(151, 18)
        Me.txtExtFile.TabIndex = 21
        '
        'myConsole
        '
        Me.myConsole.BackColor = System.Drawing.Color.Gainsboro
        Me.myConsole.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.myConsole.Location = New System.Drawing.Point(5, 140)
        Me.myConsole.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.myConsole.myConsole = Nothing
        Me.myConsole.Name = "myConsole"
        Me.myConsole.Size = New System.Drawing.Size(586, 306)
        Me.myConsole.TabIndex = 19
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(595, 556)
        Me.ShapeContainer1.TabIndex = 34
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Black
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightBlue
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape1.FillColor = System.Drawing.Color.LightBlue
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal
        Me.RectangleShape1.Location = New System.Drawing.Point(5, 55)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(328, 78)
        '
        'footer
        '
        Me.footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footer.Location = New System.Drawing.Point(0, 534)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(595, 22)
        Me.footer.TabIndex = 35
        '
        'AssocApp
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(595, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.optAdvanceMode)
        Me.Controls.Add(Me.lblTypeFichier)
        Me.Controls.Add(Me.lblExtention)
        Me.Controls.Add(Me.lblCommande)
        Me.Controls.Add(Me.txtCmdExec)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExtShow)
        Me.Controls.Add(Me.txtExtSet)
        Me.Controls.Add(Me.txtExtFile)
        Me.Controls.Add(Me.flashHeader)
        Me.Controls.Add(Me.myConsole)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AssocApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI Dosbox - ASSOC"
        CType(Me.flashHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myConsole As GUIDosbox.GUIDosbox_Console
    Friend WithEvents flashHeader As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents txtExtFile As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents txtExtSet As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents btnExtShow As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnClear As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnBack As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnApply As GUIDosbox.GUIDosbox_Button
    Friend WithEvents btnHelp As GUIDosbox.GUIDosbox_Button
    Friend WithEvents txtCmdExec As GUIDosbox.GUIDosbox_Textbox
    Friend WithEvents lblCommande As GUIDosbox.GUIDosbox_Label
    Friend WithEvents lblExtention As GUIDosbox.GUIDosbox_Label
    Friend WithEvents lblTypeFichier As GUIDosbox.GUIDosbox_Label
    Friend WithEvents optAdvanceMode As GUIDosbox.GUIDosbox_Checkbox
    Friend WithEvents btnSend As GUIDosbox.GUIDosbox_Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents footer As GUIDosbox.GUIDosbox_StatusStrip
End Class
