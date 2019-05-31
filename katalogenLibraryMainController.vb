Public Class katalogenLibraryMainController
    Public Function autocompleteBookinfoList(searchstr As String, Optional maxantal As Integer = 10) As autocompleteInfo
        Dim ret As New autocompleteInfo
        Dim obj As New autocompleteController

        Return obj.autocompletebyTitle(searchstr, maxantal)
    End Function

    Public Function mainSearchList(searchstr As String, Optional maxantal As Integer = 10) As mainSearchResultInfo
        Dim ret As New mainSearchResultInfo
        Dim obj As New SearchController
        Try
            ret.Bookitems = obj.MainSearch(searchstr, maxantal)
            ret.Antal = ret.Bookitems.Count
            ret.Status = "Sökning på: " & searchstr & " är utförd!"

        Catch ex As Exception
            ret.Status = "Error Fel i sökningnen på " & searchstr
        End Try
        Return ret

    End Function

    Public Function mainCatSearchList(catid As Integer, Optional maxantal As Integer = 500) As mainSearchResultInfo
        Dim ret As New mainSearchResultInfo
        Dim obj As New SearchController
        Try
            ret.Bookitems = obj.MainSearchHandler("cat", catid, maxantal)
            ret.Antal = ret.Bookitems.Count
            ret.Status = "Sökning på kategori: " & catid & " är utförd!"

        Catch ex As Exception
            ret.Status = "Error Fel i sökningnen på kategori: " & catid
        End Try
        Return ret

    End Function

    Public Function mainAmneSearchList(amnid As Integer, Optional maxantal As Integer = 500) As mainSearchResultInfo
        Dim ret As New mainSearchResultInfo
        Dim obj As New SearchController
        Try
            ret.Bookitems = obj.MainSearchHandler("amne", amnid, maxantal)
            ret.Antal = ret.Bookitems.Count
            ret.Status = "Sökning på Ämne: " & amnid & " är utförd!"

        Catch ex As Exception
            ret.Status = "Error Fel i sökningnen på Ämne: " & amnid
        End Try
        Return ret

    End Function

End Class
