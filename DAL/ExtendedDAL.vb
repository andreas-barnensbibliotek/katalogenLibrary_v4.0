
Imports System.Data.Linq.SqlClient

Public Class ExtendedDAL

#Region "DATA LINQ SETUP"
    Private connectionObj As New connectionstringHandler
    Private _linqObj As New katalogenLibraryLINQDataContext(connectionObj.CurrentConnectionString)
#End Region

#Region "Författare"

    Public Function getForfattarlistByBookid(bookid) As List(Of forfattardetailInfo)
        Dim ret As New List(Of forfattardetailInfo)

        Dim forfObj = From i In _linqObj.AJKat_GetForfattareToBook(bookid, 1)

        For Each itm In forfObj
            Dim forf As New forfattardetailInfo
            forf.creatorid = itm.CreatorID
            forf.CreatorRollID = itm.CreatorRollID
            forf.namn = itm.Namn
            forf.bookid = bookid

            ret.Add(forf)
        Next

        Return ret

    End Function

#End Region

#Region "Kategori"

    Public Function getKategorilistByBookid(bookid) As categoryAndMediatypes
        Dim rettypobj As New categoryAndMediatypes

        Dim catObj = From i In _linqObj.AJKat_getAllBooksCatbyBookid(bookid)

        For Each itm In catObj
            Dim cat As New bookCategoryInfo
            cat.CategoryID = itm.CategoryID
            cat.catnamn = itm.categoryName
            cat.bookid = itm.bookID

            Select Case itm.CategoryID

                Case 6 'ljudbok
                    cat.iconSrc = "ljudbokURL.png"
                    rettypobj.MediatypeList.Add(cat)
                Case 24 'ebok
                    cat.iconSrc = "ebokURL.png"
                    rettypobj.MediatypeList.Add(cat)

                Case Else
                    rettypobj.Categorylist.Add(cat)
            End Select

        Next

        Return rettypobj

    End Function

#End Region

#Region "Ämnen"

    Public Function getAmnenlistByBookid(bookid) As List(Of AmnenToBookInfo)
        Dim ret As New List(Of AmnenToBookInfo)

        Dim amnObj = From i In _linqObj.AJKat_GetAmnenToBook(bookid)

        For Each itm In amnObj
            Dim amn As New AmnenToBookInfo
            amn.AmnesordID = itm.AmnesordID
            amn.amnesord = itm.amnesord
            amn.bookid = bookid
            ret.Add(amn)
        Next

        Return ret

    End Function

#End Region

End Class
