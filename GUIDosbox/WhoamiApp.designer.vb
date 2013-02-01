<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhoamiApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhoamiApp))
        Me.BtnGo = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TextReturns = New System.Windows.Forms.TextBox()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.chkbxLangue = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Opt8 = New System.Windows.Forms.CheckBox()
        Me.Opt7 = New System.Windows.Forms.CheckBox()
        Me.Opt6 = New System.Windows.Forms.CheckBox()
        Me.Opt5 = New System.Windows.Forms.CheckBox()
        Me.Opt4 = New System.Windows.Forms.CheckBox()
        Me.Opt3 = New System.Windows.Forms.CheckBox()
        Me.Opt2 = New System.Windows.Forms.CheckBox()
        Me.Opt1 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Opt9 = New System.Windows.Forms.CheckBox()
        Me.rbTable = New System.Windows.Forms.RadioButton()
        Me.rbList = New System.Windows.Forms.RadioButton()
        Me.rbCSV = New System.Windows.Forms.RadioButton()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip6 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip7 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip8 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip9 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip10 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.btnAide = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGo
        '
        Me.BtnGo.Location = New System.Drawing.Point(604, 480)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(75, 23)
        Me.BtnGo.TabIndex = 0
        Me.BtnGo.Text = "Go"
        Me.BtnGo.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(685, 480)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'TextReturns
        '
        Me.TextReturns.BackColor = System.Drawing.SystemColors.WindowText
        Me.TextReturns.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextReturns.Enabled = False
        Me.TextReturns.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextReturns.ForeColor = System.Drawing.SystemColors.Window
        Me.TextReturns.Location = New System.Drawing.Point(12, 193)
        Me.TextReturns.MaxLength = 0
        Me.TextReturns.Multiline = True
        Me.TextReturns.Name = "TextReturns"
        Me.TextReturns.ReadOnly = True
        Me.TextReturns.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextReturns.Size = New System.Drawing.Size(748, 269)
        Me.TextReturns.TabIndex = 2
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(-2, -2)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(776, 60)
        Me.AxShockwaveFlash1.TabIndex = 3
        '
        'chkbxLangue
        '
        Me.chkbxLangue.AutoSize = True
        Me.chkbxLangue.Checked = True
        Me.chkbxLangue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxLangue.Location = New System.Drawing.Point(12, 489)
        Me.chkbxLangue.Name = "chkbxLangue"
        Me.chkbxLangue.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLangue.TabIndex = 4
        Me.chkbxLangue.UseVisualStyleBackColor = True
        Me.chkbxLangue.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.WindowText
        Me.GroupBox1.Controls.Add(Me.gbInfo)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Opt8)
        Me.GroupBox1.Controls.Add(Me.Opt7)
        Me.GroupBox1.Controls.Add(Me.Opt6)
        Me.GroupBox1.Controls.Add(Me.Opt5)
        Me.GroupBox1.Controls.Add(Me.Opt4)
        Me.GroupBox1.Controls.Add(Me.Opt3)
        Me.GroupBox1.Controls.Add(Me.Opt2)
        Me.GroupBox1.Controls.Add(Me.Opt1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Snow
        Me.GroupBox1.Location = New System.Drawing.Point(71, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 134)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paramètres"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbCSV)
        Me.GroupBox2.Controls.Add(Me.rbList)
        Me.GroupBox2.Controls.Add(Me.rbTable)
        Me.GroupBox2.Controls.Add(Me.Opt9)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Snow
        Me.GroupBox2.Location = New System.Drawing.Point(206, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(148, 101)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Format"
        '
        'Opt8
        '
        Me.Opt8.AutoSize = True
        Me.Opt8.Location = New System.Drawing.Point(104, 100)
        Me.Opt8.Name = "Opt8"
        Me.Opt8.Size = New System.Drawing.Size(54, 19)
        Me.Opt8.TabIndex = 7
        Me.Opt8.Text = "/ N&H"
        Me.Opt8.UseVisualStyleBackColor = True
        '
        'Opt7
        '
        Me.Opt7.AutoSize = True
        Me.Opt7.Location = New System.Drawing.Point(104, 73)
        Me.Opt7.Name = "Opt7"
        Me.Opt7.Size = New System.Drawing.Size(58, 19)
        Me.Opt7.TabIndex = 6
        Me.Opt7.Text = "/ AL&L"
        Me.Opt7.UseVisualStyleBackColor = True
        '
        'Opt6
        '
        Me.Opt6.AutoSize = True
        Me.Opt6.Location = New System.Drawing.Point(104, 47)
        Me.Opt6.Name = "Opt6"
        Me.Opt6.Size = New System.Drawing.Size(96, 19)
        Me.Opt6.TabIndex = 5
        Me.Opt6.Text = "/ LO&GONID"
        Me.Opt6.UseVisualStyleBackColor = True
        '
        'Opt5
        '
        Me.Opt5.AutoSize = True
        Me.Opt5.Location = New System.Drawing.Point(104, 22)
        Me.Opt5.Name = "Opt5"
        Me.Opt5.Size = New System.Drawing.Size(65, 19)
        Me.Opt5.TabIndex = 4
        Me.Opt5.Text = "/ PR&IV"
        Me.Opt5.UseVisualStyleBackColor = True
        '
        'Opt4
        '
        Me.Opt4.AutoSize = True
        Me.Opt4.Location = New System.Drawing.Point(7, 99)
        Me.Opt4.Name = "Opt4"
        Me.Opt4.Size = New System.Drawing.Size(92, 19)
        Me.Opt4.TabIndex = 3
        Me.Opt4.Text = "/ GR&OUPS"
        Me.Opt4.UseVisualStyleBackColor = True
        '
        'Opt3
        '
        Me.Opt3.AutoSize = True
        Me.Opt3.Location = New System.Drawing.Point(7, 73)
        Me.Opt3.Name = "Opt3"
        Me.Opt3.Size = New System.Drawing.Size(72, 19)
        Me.Opt3.TabIndex = 2
        Me.Opt3.Text = "/ US&ER"
        Me.Opt3.UseVisualStyleBackColor = True
        '
        'Opt2
        '
        Me.Opt2.AutoSize = True
        Me.Opt2.Location = New System.Drawing.Point(7, 47)
        Me.Opt2.Name = "Opt2"
        Me.Opt2.Size = New System.Drawing.Size(72, 19)
        Me.Opt2.TabIndex = 1
        Me.Opt2.Text = "/ FQ&DN"
        Me.Opt2.UseVisualStyleBackColor = True
        '
        'Opt1
        '
        Me.Opt1.AutoSize = True
        Me.Opt1.Location = New System.Drawing.Point(7, 21)
        Me.Opt1.Name = "Opt1"
        Me.Opt1.Size = New System.Drawing.Size(63, 19)
        Me.Opt1.TabIndex = 0
        Me.Opt1.Text = "/ UP&N"
        Me.Opt1.UseVisualStyleBackColor = True
        '
        'Opt9
        '
        Me.Opt9.AutoSize = True
        Me.Opt9.Location = New System.Drawing.Point(7, 21)
        Me.Opt9.Name = "Opt9"
        Me.Opt9.Size = New System.Drawing.Size(52, 19)
        Me.Opt9.TabIndex = 0
        Me.Opt9.Text = "/ FO"
        Me.Opt9.UseVisualStyleBackColor = True
        '
        'rbTable
        '
        Me.rbTable.AutoSize = True
        Me.rbTable.Location = New System.Drawing.Point(65, 20)
        Me.rbTable.Name = "rbTable"
        Me.rbTable.Size = New System.Drawing.Size(77, 19)
        Me.rbTable.TabIndex = 1
        Me.rbTable.TabStop = True
        Me.rbTable.Text = "Tableau"
        Me.rbTable.UseVisualStyleBackColor = True
        '
        'rbList
        '
        Me.rbList.AutoSize = True
        Me.rbList.Location = New System.Drawing.Point(65, 45)
        Me.rbList.Name = "rbList"
        Me.rbList.Size = New System.Drawing.Size(56, 19)
        Me.rbList.TabIndex = 2
        Me.rbList.TabStop = True
        Me.rbList.Text = "Liste"
        Me.rbList.UseVisualStyleBackColor = True
        '
        'rbCSV
        '
        Me.rbCSV.AutoSize = True
        Me.rbCSV.Location = New System.Drawing.Point(65, 70)
        Me.rbCSV.Name = "rbCSV"
        Me.rbCSV.Size = New System.Drawing.Size(51, 19)
        Me.rbCSV.TabIndex = 3
        Me.rbCSV.TabStop = True
        Me.rbCSV.Text = "CSV"
        Me.rbCSV.UseVisualStyleBackColor = True
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.txtInfo)
        Me.gbInfo.ForeColor = System.Drawing.Color.Snow
        Me.gbInfo.Location = New System.Drawing.Point(358, 18)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Size = New System.Drawing.Size(251, 101)
        Me.gbInfo.TabIndex = 9
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "Info"
        '
        'txtInfo
        '
        Me.txtInfo.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInfo.ForeColor = System.Drawing.Color.Snow
        Me.txtInfo.Location = New System.Drawing.Point(10, 20)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.Size = New System.Drawing.Size(232, 69)
        Me.txtInfo.TabIndex = 0
        Me.txtInfo.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vous pouvez passer votre curseur " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "au-dessus des cases à cocher pour" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "plus d'in" & _
            "formation sur l'option."
        Me.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAide
        '
        Me.btnAide.Location = New System.Drawing.Point(33, 480)
        Me.btnAide.Name = "btnAide"
        Me.btnAide.Size = New System.Drawing.Size(75, 23)
        Me.btnAide.TabIndex = 6
        Me.btnAide.Text = "Aide"
        Me.btnAide.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(114, 480)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(180, 23)
        Me.ProgressBar1.TabIndex = 7
        '
        'WhoamiApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(772, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnAide)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkbxLangue)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.TextReturns)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.BtnGo)
        Me.Name = "WhoamiApp"
        Me.Text = "GUI DosBox - Whoami"
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbInfo.ResumeLayout(False)
        Me.gbInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGo As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents TextReturns As System.Windows.Forms.TextBox
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents chkbxLangue As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Opt8 As System.Windows.Forms.CheckBox
    Friend WithEvents Opt7 As System.Windows.Forms.CheckBox
    Friend WithEvents Opt6 As System.Windows.Forms.CheckBox
    Friend WithEvents Opt5 As System.Windows.Forms.CheckBox
    Friend WithEvents Opt4 As System.Windows.Forms.CheckBox
    Friend WithEvents Opt3 As System.Windows.Forms.CheckBox
    Friend WithEvents Opt2 As System.Windows.Forms.CheckBox
    Friend WithEvents Opt1 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents rbCSV As System.Windows.Forms.RadioButton
    Friend WithEvents rbList As System.Windows.Forms.RadioButton
    Friend WithEvents rbTable As System.Windows.Forms.RadioButton
    Friend WithEvents Opt9 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip4 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip5 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip6 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip7 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip8 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip9 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip10 As System.Windows.Forms.ToolTip
    Friend WithEvents gbInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents btnAide As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
