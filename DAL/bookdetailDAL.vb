Public Class bookdetailDAL

    Private _DalObj As New KatalogeSearchDAL


#Region "DATA LINQ SETUP"
    Private connectionObj As New connectionstringHandler
    Private _linqObj As New katalogenLibraryLINQDataContext(connectionObj.CurrentConnectionString)
#End Region

    Public Function getBookDetails(bookid As Integer) As List(Of bookdetailbaseInfo)

        Dim bookObj = From i In _linqObj.AjKatalog_GetBookDetailbyID(bookid)
        Return createFullReturnList(bookObj)

    End Function


    Private Function createFullReturnList(bookObj As Object) As List(Of bookdetailbaseInfo)
        Dim retobj As New List(Of bookdetailbaseInfo)
        Dim counter As Integer = 0

        For Each x In bookObj
            Dim tmp As New bookdetailbaseInfo
            tmp.title = x.Title
            tmp.Subtitle = x.Subtitle
            tmp.Bookid = x.bookID
            tmp.isbn = x.isbn
            tmp.Published = x.published
            tmp.Serie = x.serie
            tmp.Serienr = x.serienr
            tmp.Easyread = x.easyread
            If (Not String.IsNullOrEmpty(x.review)) Then
                tmp.BookReview = x.review
            Else
                tmp.BookReview = x.presentation
            End If

            retobj.Add(tmp)
            counter += 1
        Next

        Return retobj

    End Function
End Class
