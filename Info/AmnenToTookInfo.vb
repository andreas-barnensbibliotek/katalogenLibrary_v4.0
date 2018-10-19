Public Class AmnenToTookInfo
    ' local property declarations
    Private _bookid As Integer
    Private _amnesord As String
    Private _AmnesordID As Integer

    ' initialization
    Public Sub New()
    End Sub

    Public Sub New(ByVal bookID As Integer)
        bookID = bookID
        AmnesordID = AmnesordID
        amnesord = amnesord
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

    Public Property AmnesordID() As Integer
        Get
            Return _AmnesordID
        End Get
        Set(ByVal Value As Integer)
            _AmnesordID = Value
        End Set
    End Property

    Public Property amnesord() As String
        Get
            Return _amnesord
        End Get
        Set(ByVal Value As String)
            _amnesord = Value
        End Set
    End Property

End Class
