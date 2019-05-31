Imports barnenskrypinIMGHandler
Public Class SearchController

    Private _DalObj As New KatalogeSearchDAL
    Private _extDalObj As New ExtendedDAL

    Public Function autocompletebyTitle(searchstr As String, maxantal As Integer) As List(Of ShortBookInfo)
        Dim ret As New List(Of ShortBookInfo)
        Try
            ret = _DalObj.getshortbooklistByTitle(searchstr, maxantal)
        Catch ex As Exception

        End Try
        Return ret
    End Function

    Public Function MainSearch(searchStr As String, antal As Integer) As List(Of bookdetailbaseInfo)
        Dim tstart As Integer = Date.Now.Millisecond

        Dim resultList As New List(Of bookdetailbaseInfo)

        'Dim resultList As New Object
        Dim searchCount As Integer = 0

        resultList = _DalObj.getSearchByTitle(searchStr, antal)
        searchCount = resultList.Count

        If searchCount <= 0 Then
            resultList = _DalObj.getSearchByForfattare(searchStr)
            searchCount = resultList.Count
        End If

        If searchCount <= 0 Then
            resultList = _DalObj.getSearchByISBN(searchStr)
            searchCount = resultList.Count
        End If

        If searchCount > 0 Then
            resultList = extendResultlist(resultList)
        End If

        'Log

        _DalObj.logSearch(searchStr, "search", resultList.Count, tstart)

        Return resultList

    End Function



    Public Function MainSearchHandler(typ As String, id As Integer, antal As Integer) As List(Of bookdetailbaseInfo)
        Dim tstart As Integer = Date.Now.Millisecond
        Dim logstr As String = ""

        Dim resultList As New List(Of bookdetailbaseInfo)
        Dim searchCount As Integer = 0

        Select Case typ
            Case "cat"
                resultList = _DalObj.getSearchByCategory(id, antal)
                logstr = "Category"
            Case "amne"
                resultList = _DalObj.getSearchByAmne(id, antal)
                logstr = "Amne"
            Case Else

        End Select

        searchCount = resultList.Count

        If searchCount > 0 Then
            resultList = extendResultlist(resultList)
        End If

        'Log
        _DalObj.logSearch(id.ToString, logstr, resultList.Count, tstart)

        Return resultList

    End Function


    Private Function extendResultlist(listobj As List(Of bookdetailbaseInfo)) As List(Of bookdetailbaseInfo)
        Dim retobj As New List(Of bookdetailbaseInfo)
        Dim imgobj As New checkImgExist

        ' Run test finished: 1 run (0:00:01,5289125) ========== kalle
        For Each itm In listobj

            'Run test finished: 1 run (0:00:03,0573669) ========== kalle
            Dim mixedCatObj As categoryAndMediatypes = _extDalObj.getKategorilistByBookid(itm.Bookid)
            itm.Categories = mixedCatObj.Categorylist
            itm.MediatypCategories = mixedCatObj.MediatypeList


            ' Run test finished: 1 run (0:00:02,9117882) ==========kalle
            itm.Forfattare = _extDalObj.getForfattarlistByBookid(itm.Bookid)

            ' Run test finished: 1 run (0:00:03,1262559) ==========kalle
            itm.Amnen = _extDalObj.getAmnenlistByBookid(itm.Bookid)

            ''Run test finished: 1 run (0:00:07,0806581) ==========kalle
            itm.BokomslagURL = imgobj.getimgurlbyIsbn(itm.isbn)
        Next

        Return listobj

    End Function

    Private Function createReturnList(bookObj As Object, maxantal As Integer) As List(Of ShortBookInfo)
        Dim list As New List(Of ShortBookInfo)

        Dim counter As Integer = 0
        For Each x In bookObj
            If counter = maxantal Then
                Exit For
            End If
            Dim tmp As New ShortBookInfo
            tmp.Title = x.Title
            tmp.Bookid = x.bookID

            list.Add(tmp)
            counter += 1
        Next
        Return list
    End Function
End Class
