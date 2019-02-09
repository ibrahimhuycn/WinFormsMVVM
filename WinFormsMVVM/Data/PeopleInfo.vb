Imports System.ComponentModel

Public Class PeopleInfo
    Implements INotifyPropertyChanged

    Public Sub New()
    End Sub
    Public Sub New(ByVal sender As Object, ByVal personInfo As Person)
        Me.PersonName = personInfo.FullName
        Me.Address = personInfo.Address
        Me.Mobile = personInfo.Mobile

    End Sub

    Property PersonName As String
    Property Address As String
    Property Mobile As Integer
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
