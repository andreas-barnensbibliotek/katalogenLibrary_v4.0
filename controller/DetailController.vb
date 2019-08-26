Public Class DetailController
    Private _detailDalObj As New bookdetailDAL
    Private _searchcontrollerObj As New SearchController


    Public Function getbookdetailbyBookid(bookid As Integer) As List(Of bookdetailbaseInfo)
        Dim retobj As New List(Of bookdetailbaseInfo)

        retobj = _detailDalObj.getBookDetails(bookid)
        retobj = _searchcontrollerObj.extendResultlist(retobj)

        Return retobj

    End Function


End Class
