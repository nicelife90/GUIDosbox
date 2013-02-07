Option Strict On

''' <summary>
''' Label personnalisé GUIDosbox.
''' </summary>
Public Class GUIDosbox_Label
    Inherits System.Windows.Forms.Label

    Public Sub New()
        Me.BackColor = Color.Transparent
        Me.ForeColor = Color.LightBlue
        Me.Font = New Font("Lucida Console", 8, FontStyle.Regular)
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        Me.ResumeLayout(False)

    End Sub
End Class
