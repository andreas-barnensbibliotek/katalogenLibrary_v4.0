Imports System.Data.Linq.SqlClient

Public Class KatalogeSearchDAL

#Region "DATA LINQ SETUP"
    Private connectionObj As New connectionstringHandler
    Private _linqObj As New katalogenLibraryLINQDataContext(connectionObj.CurrentConnectionString)
#End Region

    Public Function getshortbooklistByTitle(searchtitle As String, maxantal As Integer) As List(Of ShortBookInfo)
        Dim bookList As New List(Of ShortBookInfo)

        Try
            Dim bookObj = From i In _linqObj.AjKat_getBookByTitle(searchtitle).Take(maxantal)

            bookList = createReturnList(bookObj, bookList, maxantal)

        Catch ex As Exception
        End Try

        Return bookList

    End Function

    Public Function getshortbooklistByForfattare(searchforfattare As String, maxantal As Integer) As List(Of ShortBookInfo)
        Dim bookList As New List(Of ShortBookInfo)

        Try

            Dim bookObj = From i In _linqObj.AjKat_GetBooksFromForfattare(searchforfattare).Take(maxantal)
            bookList = createReturnList(bookObj, bookList, maxantal)

        Catch ex As Exception

        End Try

        Return bookList

    End Function


    Private Function extendSearch(seartstr As String, maxantal As Integer) As Object
        Return (From i In _linqObj.tblAjKatalogBooks
                Where SqlMethods.Like(i.Title, "%" & seartstr & "%")
                Select i
                Order By i.Title).Take(maxantal)

    End Function

    Private Function extendPredictSearch(seartstr As String, maxantal As Integer) As Object
        Return (From i In _linqObj.tblAjKatalogBooks
                Where SqlMethods.Like(i.Title, seartstr & "%")
                Select i
                Order By i.Title).Take(maxantal)

    End Function


    Private Function createReturnList(bookObj As Object, bookList As List(Of ShortBookInfo), maxantal As Integer) As List(Of ShortBookInfo)

        For Each x In bookObj
            Dim tmp As New ShortBookInfo
            tmp.Title = x.Title
            tmp.Bookid = x.bookID
            tmp.Isbn = x.isbn

            bookList.Add(tmp)
        Next
        Return bookList
    End Function

#Region "search"

    Public Function getSearchByTitle(searchtitle As String, maxantal As Integer) As List(Of bookdetailbaseInfo)

        Dim bookObj = From i In _linqObj.AjKat_getBookByTitle(searchtitle).Take(500)

        Return createFullReturnList(bookObj)

    End Function

    Public Function getSearchByForfattare(searchforfattare As String) As List(Of bookdetailbaseInfo)

        Dim bookObj = From i In _linqObj.AjKat_GetBooksFromForfattare(searchforfattare).Take(500)

        Return createFullReturnList(bookObj)

    End Function

    Public Function getSearchByISBN(searchIsbn As String) As List(Of bookdetailbaseInfo)

        Dim bookObj = From i In _linqObj.tblAjKatalogBooks
                      Where SqlMethods.Like(i.isbn, searchIsbn)
                      Select i

        Return createFullReturnList(bookObj)

    End Function

    Public Function getSearchByCategory(catid As Integer, Optional antal As Integer = 500) As List(Of bookdetailbaseInfo)

        Dim bookObj = From i In _linqObj.ajkat_GetBookImgFromAJBarnboksKatalog(catid).Take(antal)

        Return createFullReturnList(bookObj)

    End Function

    Public Function getSearchByAmne(amnid As Integer, Optional antal As Integer = 500) As List(Of bookdetailbaseInfo)

        Dim bookObj = From i In _linqObj.ajkat_GetBookImgFromAJBarnboksKatalog_byAmne(amnid).Take(antal)

        Return createFullReturnList(bookObj)

    End Function

#End Region

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

            retobj.Add(tmp)
            counter += 1
        Next

        Return retobj

    End Function


#Region "SearchLOG"
    Public Sub logSearch(searchstr As String, typ As String, resultantal As Integer, speed As Integer)

        Dim SpeedlogStop As Integer = Date.Now.Millisecond
        Dim speedlog = SpeedlogStop - speed

        If searchstr.Length > 4 Then
            Try
                Dim log As New tbl_aj_SearchLogkatalogen
                log.Search = searchstr
                log.typ = typ
                log.Datum = Date.Now()
                log.millisecond = speedlog

                _linqObj.tbl_aj_SearchLogkatalogens.InsertOnSubmit(log)
                _linqObj.SubmitChanges()

            Catch ex As Exception

            End Try
        End If

    End Sub

#End Region
End Class
