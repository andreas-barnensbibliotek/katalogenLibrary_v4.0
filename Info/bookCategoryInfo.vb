Public Class bookCategoryInfo
    ' local property declarations
    Private _bookid As Integer
    Private _catnamn As String
    Private _CategoryID As Integer

    ' initialization
    Public Sub New()
    End Sub
    Public Sub New(ByVal bookID As Integer)
        Me.bookid = bookID
        Me.CategoryID = CategoryID
        Me.catnamn = catnamn
    End Sub

    ' public properties
    Public Property bookid() As Integer
        Get
            Return _bookid
        End Get
        Set(ByVal Value As Integer)
            _bookid = Value
        End Set
    End Property

    Public Property CategoryID() As Integer
        Get
            Return _CategoryID
        End Get
        Set(ByVal Value As Integer)
            _CategoryID = Value
        End Set
    End Property

    Public Property catnamn() As String
        Get
            Return _catnamn
        End Get
        Set(ByVal Value As String)
            _catnamn = Value
        End Set
    End Property

End Class