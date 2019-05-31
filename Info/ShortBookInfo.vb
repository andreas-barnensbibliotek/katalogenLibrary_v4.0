Public Class ShortBookInfo

    Public Sub New()
        _bookid = 0
        _title = ""
        _bookimg = "https://www.barnensbibliotek.se/Portals/0/bokomslag/foto_saknas.jpg"
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

    Private _isbn As String
    Public Property Isbn() As String
        Get
            Return _isbn
        End Get
        Set(ByVal value As String)
            _isbn = value
        End Set
    End Property

    Private _bookimg As String
    Public Property Bookimg() As String
        Get
            Return _bookimg
        End Get
        Set(ByVal value As String)
            _bookimg = value
        End Set
    End Property
End Class
