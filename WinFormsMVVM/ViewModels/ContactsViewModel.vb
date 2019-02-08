Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

<POCOViewModel>
Public Class ContactsViewModel


    Public Overridable Property PersonName As String
    Public Overridable Property PersonAddress As String
    Public Overridable Property ContactNumber As Integer

    Public Shared Function Create() As ContactsViewModel
        Return ViewModelSource.Create(Function() New ContactsViewModel)
    End Function
End Class
