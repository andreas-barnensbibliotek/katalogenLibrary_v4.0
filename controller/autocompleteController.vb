Public Class autocompleteController
    Public Function autocompletebyTitle(searchstr As String, maxantal As Integer) As List(Of ShortBookInfo)
        Dim ret As New List(Of ShortBookInfo)
        Dim dalobj As New KatalogeSearchDAL
        Try
            ret = dalobj.getshortbooklistByTitle(searchstr, maxantal)
        Catch ex As Exception

        End Try


        Return ret
    End Function
End Class
