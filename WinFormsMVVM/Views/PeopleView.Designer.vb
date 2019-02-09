<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PeopleView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PeopleView))
        Me.TextEditName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControlName = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControlAddress = New DevExpress.XtraEditors.LabelControl()
        Me.TextEditAddress = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControlMobile = New DevExpress.XtraEditors.LabelControl()
        Me.TextEditMobile = New DevExpress.XtraEditors.TextEdit()
        Me.mvvmContext1 = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.SimpleButtonDeleteAddress = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TextEditName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditMobile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextEditName
        '
        Me.TextEditName.Location = New System.Drawing.Point(59, 15)
        Me.TextEditName.Name = "TextEditName"
        Me.TextEditName.Size = New System.Drawing.Size(164, 20)
        Me.TextEditName.TabIndex = 0
        '
        'LabelControlName
        '
        Me.LabelControlName.Location = New System.Drawing.Point(26, 18)
        Me.LabelControlName.Name = "LabelControlName"
        Me.LabelControlName.Size = New System.Drawing.Size(27, 13)
        Me.LabelControlName.TabIndex = 1
        Me.LabelControlName.Text = "Name"
        '
        'LabelControlAddress
        '
        Me.LabelControlAddress.Location = New System.Drawing.Point(14, 44)
        Me.LabelControlAddress.Name = "LabelControlAddress"
        Me.LabelControlAddress.Size = New System.Drawing.Size(39, 13)
        Me.LabelControlAddress.TabIndex = 3
        Me.LabelControlAddress.Text = "Address"
        '
        'TextEditAddress
        '
        Me.TextEditAddress.Location = New System.Drawing.Point(59, 41)
        Me.TextEditAddress.Name = "TextEditAddress"
        Me.TextEditAddress.Size = New System.Drawing.Size(164, 20)
        Me.TextEditAddress.TabIndex = 2
        '
        'LabelControlMobile
        '
        Me.LabelControlMobile.Location = New System.Drawing.Point(23, 70)
        Me.LabelControlMobile.Name = "LabelControlMobile"
        Me.LabelControlMobile.Size = New System.Drawing.Size(30, 13)
        Me.LabelControlMobile.TabIndex = 5
        Me.LabelControlMobile.Text = "Mobile"
        '
        'TextEditMobile
        '
        Me.TextEditMobile.Location = New System.Drawing.Point(59, 67)
        Me.TextEditMobile.Name = "TextEditMobile"
        Me.TextEditMobile.Size = New System.Drawing.Size(164, 20)
        Me.TextEditMobile.TabIndex = 4
        '
        'mvvmContext1
        '
        Me.mvvmContext1.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(GetType(WinFormsMVVM.PeopleViewModel), "Address", Me.TextEditAddress, "EditValue"), DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(GetType(WinFormsMVVM.PeopleViewModel), "Mobile", Me.TextEditMobile, "EditValue"), DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(GetType(WinFormsMVVM.PeopleViewModel), "PersonName", Me.TextEditName, "EditValue")})
        Me.mvvmContext1.ContainerControl = Me
        Me.mvvmContext1.ViewModelType = GetType(WinFormsMVVM.PeopleViewModel)
        '
        'SimpleButtonDeleteAddress
        '
        Me.SimpleButtonDeleteAddress.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButtonDeleteAddress.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButtonDeleteAddress.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButtonDeleteAddress.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.SimpleButtonDeleteAddress.Location = New System.Drawing.Point(225, 41)
        Me.SimpleButtonDeleteAddress.Name = "SimpleButtonDeleteAddress"
        Me.SimpleButtonDeleteAddress.Size = New System.Drawing.Size(20, 20)
        Me.SimpleButtonDeleteAddress.TabIndex = 6
        '
        'PeopleView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SimpleButtonDeleteAddress)
        Me.Controls.Add(Me.LabelControlMobile)
        Me.Controls.Add(Me.TextEditMobile)
        Me.Controls.Add(Me.LabelControlAddress)
        Me.Controls.Add(Me.TextEditAddress)
        Me.Controls.Add(Me.LabelControlName)
        Me.Controls.Add(Me.TextEditName)
        Me.Name = "PeopleView"
        Me.Size = New System.Drawing.Size(259, 106)
        CType(Me.TextEditName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditMobile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private mvvmContext1 As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents TextEditName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControlMobile As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEditMobile As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControlAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEditAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControlName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButtonDeleteAddress As DevExpress.XtraEditors.SimpleButton
End Class
