Imports System.ComponentModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

<POCOViewModel>
Public Class PeopleViewModel
    Implements IEditableObject
    Protected Sub New()
        Dim person = PeopleList.GetData
        If person Is Nothing Then
            Return
        End If

        Dim a = person.Item(1)
        Load(a)
    End Sub

    Protected Sub OnAddressChanged()
        Me.RaiseCanExecuteChanged(Function(x) x.ResetAddress)
    End Sub
    Public Function CanResetAddress() As Boolean
        Return _person IsNot Nothing AndAlso Not String.IsNullOrEmpty
    End Function

    Public Function ResetAddress() As Object
        Return Me.Address = ""
    End Function

    Public Sub Load(ByVal peopleinfo As PeopleInfo)
        Me._person = peopleinfo

        Me.PersonName = _person.PersonName
        Me.Address = _person.Address
        Me.Mobile = _person.Mobile

    End Sub
    Private _person As PeopleInfo
    Public Overridable Property PersonName As String
    Public Overridable Property Address As String
    Public Overridable Property Mobile As Integer



    Public Shared Function Create() As PeopleViewModel
        Return ViewModelSource.Create(Function() New PeopleViewModel)
    End Function

    Public Sub BeginEdit() Implements IEditableObject.BeginEdit
        Throw New NotImplementedException()
    End Sub

    Public Sub EndEdit() Implements IEditableObject.EndEdit
        Throw New NotImplementedException()
    End Sub

    Public Sub CancelEdit() Implements IEditableObject.CancelEdit
        Load(Me._person)
    End Sub
End Class
