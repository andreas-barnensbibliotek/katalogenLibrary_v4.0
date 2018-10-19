Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports katalogenLibrary_v4_0


<TestClass()> Public Class katalogenLibraryMainControllerTEST

    <TestMethod()> Public Sub searchTEST()
        Dim searchstr As String = "potter"
        Dim obj As New katalogenLibraryMainController

        Dim ret As New List(Of ShortBookInfo)
        ret = obj.autocompleteBookinfoList(searchstr, 20)


    End Sub

End Class