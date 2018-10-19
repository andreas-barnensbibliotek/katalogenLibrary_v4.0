Public Class ShortBookInfo

    Public Sub New()
        _bookid = 0
        _title = ""
    End Sub
    Private _bookid As Integer
    Public Property Bookid() As Integer
        Get
            Return _bookid
        End Get
        Set(ByVal value As Integer)
            _bookid = value
        End Set
    End Property

    Private _title As String
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
        End Set
    End Property

End Class
