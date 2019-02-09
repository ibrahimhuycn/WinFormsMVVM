Imports System.Collections.ObjectModel

Public Class PeopleList
    Inherits ObservableCollection(Of PeopleInfo)
    Public Shared Function GetData()
        Dim a As New PeopleList From {
            New PeopleInfo() With {.PersonName = "Ibrahim Hussain", .Address = "Fari Kuri", .Mobile = 7657111},
            New PeopleInfo() With {.PersonName = "Ahmed Hisaan Saeed", .Address = "House One", .Mobile = 9131117}
        }
        Return a
    End Function
    Public Function GetFieldNames() As IEnumerable(Of String)
        Return New String() {"PersonName", "Address", "Mobile"}
    End Function
End Class
