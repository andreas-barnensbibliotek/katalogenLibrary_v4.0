Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports katalogenLibrary_v4_0


<TestClass()> Public Class katalogenLibraryMainControllerTEST

    <TestMethod()> Public Sub searchTEST()
        Dim searchstr As String = "Beaumont"
        Dim obj As New katalogenLibraryMainController

        Dim ret As New autocompleteInfo
        ret = obj.autocompleteBookinfoList(searchstr, 20)


    End Sub

    <TestMethod()> Public Sub MainSearchTEST()
        Dim searchstr As String = "Beaumont"
        Dim obj As New katalogenLibraryMainController

        Dim ret As New mainSearchResultInfo
        ret = obj.mainSearchList(searchstr, 20)

        Dim testar = ret.Antal

    End Sub
    <TestMethod()> Public Sub MainSearchCat()
        Dim catid As Integer = 9
        Dim obj As New katalogenLibraryMainController

        Dim ret As New mainSearchResultInfo
        ret = obj.mainCatSearchList(catid, 20)

        Dim testar = ret.Antal

    End Sub
    <TestMethod()> Public Sub MainSearchAmne()
        Dim amnid As Integer = 17
        Dim obj As New katalogenLibraryMainController

        Dim ret As New mainSearchResultInfo
        ret = obj.mainAmneSearchList(amnid, 20)

        Dim testar = ret.Antal

    End Sub

    <TestMethod()> Public Sub MainBookdetail()
        Dim bookid As Integer = 5666 ' 6223
        Dim obj As New katalogenLibraryMainController

        Dim ret As New mainSearchResultInfo
        ret = obj.mainBookDetailList(bookid)

        Dim testar = ret.Antal

    End Sub
End Class