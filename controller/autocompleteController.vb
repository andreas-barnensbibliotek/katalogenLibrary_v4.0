Imports barnenskrypinIMGHandler
Public Class autocompleteController
    Public Function autocompletebyTitle(searchstr As String, maxantal As Integer) As autocompleteInfo
        Dim Speedlogstart As Integer = Date.Now.Millisecond

        Dim ret As New autocompleteInfo
        Dim dalobj As New KatalogeSearchDAL
        Try
            ret.Booktitlelist = dalobj.getshortbooklistByTitle(searchstr, maxantal)
            If ret.Booktitlelist.Count <= maxantal Then
                maxantal = maxantal - ret.Booktitlelist.Count
                ret.Booktitlelist.AddRange(dalobj.getshortbooklistByForfattare(searchstr, maxantal))

            End If

            ret.Booktitlelist = fiximg(ret.Booktitlelist)

            ret.Status = "Autocomplete by: " & searchstr & " Klar!"
        Catch ex As Exception
            ret.Status = "ERROR in autocomplete by: " & searchstr

        End Try

        'Log
        dalobj.logSearch(searchstr, "auto", ret.Booktitlelist.Count, Speedlogstart)


        Return ret
    End Function
    Private Function fiximg(listobj As List(Of ShortBookInfo)) As List(Of ShortBookInfo)
        Dim imgobj As New checkImgExist

        For Each itm In listobj
            itm.Bookimg = imgobj.getimgurlbyIsbn(itm.Isbn)

        Next

        Return listobj

    End Function
End Class
