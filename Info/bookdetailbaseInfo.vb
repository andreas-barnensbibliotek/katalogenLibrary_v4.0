Public Class bookdetailbaseInfo
    ' local property declarations
    Private _bookID As Integer
    Private _title As String
    Private _isbn As String
    Private _forfattare As List(Of forfattardetailInfo)
    Private _illustrators As List(Of forfattardetailInfo)
    Private _Published As String
    Private _forlag As String
    Private _categories As List(Of bookCategoryInfo)
    Private _extracategories As List(Of bookCategoryInfo)
    Private _amnen As List(Of AmnenToBookInfo)
    Private _Serie As String
    Private _Serienr As String
    Private _Subtitle As String
    Private _Easyread As Integer
    Private _Review As String
    Private _bokomslagURL As String
    Private _status As Integer
    Private _mediaUrler As List(Of mediaUrlInfo)


    ' initialization
    Public Sub New()
        _bookID = 0
        _title = ""
        _isbn = ""
        _forfattare = New List(Of forfattardetailInfo)
        _illustrators = New List(Of forfattardetailInfo)
        _Published = ""
        _forlag = ""
        _categories = New List(Of bookCategoryInfo)
        _extracategories = New List(Of bookCategoryInfo)
        _amnen = New List(Of AmnenToBookInfo)
        _Serie = ""
        _Serienr = ""
        _Subtitle = ""
        _Easyread = 0
        _Review = ""
        _bokomslagURL = ""
        _status = 0
        _mediaUrler = New List(Of mediaUrlInfo)
        _booklists = New List(Of userBookListInfo)
    End Sub

    ' public properties
    Public Property Bookid() As Integer
        Get
            Return _bookID
        End Get
        Set(ByVal Value As Integer)
            _bookID = Value
        End Set
    End Property

    Public Property title() As String
        Get
            Return _title
        End Get
        Set(ByVal Value As String)
            _title = Value
        End Set
    End Property

    Public Property isbn() As String
        Get
            Return _isbn
        End Get
        Set(ByVal Value As String)
            _isbn = Value
        End Set
    End Property

    Public Property Forfattare() As List(Of forfattardetailInfo)
        Get
            Return _forfattare
        End Get
        Set(ByVal value As List(Of forfattardetailInfo))
            _forfattare = value
        End Set
    End Property

    Public Property Illustrator() As List(Of forfattardetailInfo)
        Get
            Return _illustrators
        End Get
        Set(ByVal value As List(Of forfattardetailInfo))
            _illustrators = value
        End Set
    End Property

    Public Property Published() As String
        Get
            Return _Published
        End Get
        Set(ByVal Value As String)
            _Published = Value
        End Set
    End Property

    Public Property forlag() As String
        Get
            Return _forlag
        End Get
        Set(ByVal Value As String)
            _forlag = Value
        End Set
    End Property

    Public Property Categories() As List(Of bookCategoryInfo)
        Get
            Return _categories
        End Get
        Set(ByVal value As List(Of bookCategoryInfo))
            _categories = value
        End Set
    End Property

    Public Property MediatypCategories() As List(Of bookCategoryInfo)
        Get
            Return _extracategories
        End Get
        Set(ByVal value As List(Of bookCategoryInfo))
            _extracategories = value
        End Set
    End Property

    Public Property Amnen() As List(Of AmnenToBookInfo)
        Get
            Return _amnen
        End Get
        Set(ByVal value As List(Of AmnenToBookInfo))
            _amnen = value
        End Set
    End Property

    Public Property Serie() As String
        Get
            Return _Serie
        End Get
        Set(ByVal Value As String)
            _Serie = Value
        End Set
    End Property

    Public Property Serienr() As String
        Get
            Return _Serienr
        End Get
        Set(ByVal Value As String)
            _Serienr = Value
        End Set
    End Property

    Public Property Subtitle() As String
        Get
            Return _Subtitle
        End Get
        Set(ByVal Value As String)
            _Subtitle = Value
        End Set
    End Property

    Public Property Easyread() As Integer
        Get
            Return _Easyread
        End Get
        Set(ByVal Value As Integer)
            _Easyread = Value
        End Set
    End Property

    Public Property BookReview() As String
        Get
            Return _Review
        End Get
        Set(ByVal Value As String)
            _Review = Value
        End Set
    End Property

    Public Property BokomslagURL() As String
        Get
            Return _bokomslagURL
        End Get
        Set(ByVal Value As String)
            _bokomslagURL = Value
        End Set
    End Property
    Private _booklists As List(Of userBookListInfo)
    Public Property Booklists() As List(Of userBookListInfo)
        Get
            Return _booklists
        End Get
        Set(ByVal value As List(Of userBookListInfo))
            _booklists = value
        End Set
    End Property

    ' public properties
    Public Property status() As Integer
        Get
            Return _status
        End Get
        Set(ByVal Value As Integer)
            _status = Value
        End Set
    End Property
End Class
