<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContactsView
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mvvmContext1 = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.SuspendLayout()
        ' 
        ' mvvmContext1
        ' 
        Me.mvvmContext1.ContainerControl = Me
        Me.mvvmContext1.ViewModelType = GetType(WinFormsMVVM.ContactsViewModel)
        ' 
        ' ContactsView
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ContactsView"
        Me.ResumeLayout(False)
    End Sub

    Private mvvmContext1 As DevExpress.Utils.MVVM.MVVMContext
End Class
