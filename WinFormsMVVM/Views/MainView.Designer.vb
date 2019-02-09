<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainView
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PeopleView1 = New WinFormsMVVM.PeopleView()
        Me.SuspendLayout()
        '
        'PeopleView1
        '
        Me.PeopleView1.Location = New System.Drawing.Point(12, 12)
        Me.PeopleView1.Name = "PeopleView1"
        Me.PeopleView1.Size = New System.Drawing.Size(259, 106)
        Me.PeopleView1.TabIndex = 0
        '
        'MainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 122)
        Me.Controls.Add(Me.PeopleView1)
        Me.Name = "MainView"
        Me.Text = "MainView"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PeopleView1 As PeopleView
End Class
