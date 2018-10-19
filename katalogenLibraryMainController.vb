Public Class katalogenLibraryMainController
    Public Function autocompleteBookinfoList(searchstr As String, Optional maxantal As Integer = 10) As List(Of ShortBookInfo)
        Dim ret As New List(Of ShortBookInfo)
        Dim obj As New autocompleteController

        Return obj.autocompletebyTitle(searchstr, maxantal)
    End Function
End Class
