Imports System.Data.Linq.SqlClient

Public Class KatalogeSearchDAL

#Region "DATA LINQ SETUP"
    Private connectionObj As New connectionstringHandler
    Private _linqObj As New katalogenLibraryLINQDataContext(connectionObj.CurrentConnectionString)
#End Region

    Public Function getshortbooklistByTitle(searchtitle As String, maxantal As Integer) As List(Of ShortBookInfo)
        Dim bookList As New List(Of ShortBookInfo)
        Dim counter As Integer = 0
        Try
            Dim bookObj = (From i In _linqObj.tblAjKatalogBooks
                           Where SqlMethods.Like(i.Title, searchtitle & "%")
                           Select i
                           Order By i.Title).Take(maxantal)

            If bookObj.Count > maxantal Then
                bookList = createReturnList(bookObj, bookList, maxantal)
            Else
                bookObj = extendSearch(searchtitle, maxantal)
                bookList = createReturnList(bookObj, bookList, maxantal)
            End If


            'If bookObj.Count <= maxantal Then
            '    bookList = createReturnList(bookObj, bookList, maxantal)
            '    maxantal = maxantal - bookObj.Count

            '    bookObj = extendSearch(searchtitle, maxantal)
            '    bookList = createReturnList(bookObj, bookList, maxantal)

            'End If

            'If bookObj.Count <= 0 Then
            '    bookObj = extendSearch(searchtitle, maxantal)
            '    bookList = createReturnList(bookObj, bookList, maxantal)

            'End If


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

        Dim counter As Integer = 0
        For Each x In bookObj
            If counter = maxantal Then
                Exit For
            End If
            Dim tmp As New ShortBookInfo
            tmp.Title = x.Title
            tmp.Bookid = x.bookID
            tmp.Bookid = x.bookID

            bookList.Add(tmp)
            counter += 1
        Next
        Return bookList
    End Function
End Class
