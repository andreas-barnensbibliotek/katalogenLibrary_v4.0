Public Class forfattardetailInfo
    ' local property declarations
    Private _bookid As Integer
    Private _namn As String
    Private _CreatorRollid As Integer
    Private _creatorid As Integer

    ' initialization
    Public Sub New()
        _bookid = 0
        _namn = ""
        _CreatorRollid = 0
        _creatorid = 0
    End Sub
    Public Sub New(ByVal bookID As Integer)
        Me.bookid = bookID
        Me.namn = namn
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

    ' public properties
    Public Property creatorid() As Integer
        Get
            Return _creatorid
        End Get
        Set(ByVal Value As Integer)
            _creatorid = Value
        End Set
    End Property

    Public Property namn() As String
        Get
            Return _namn
        End Get
        Set(ByVal Value As String)
            _namn = Value
        End Set
    End Property

    Public Property CreatorRollID() As Integer
        Get
            Return _CreatorRollid
        End Get
        Set(ByVal Value As Integer)
            _CreatorRollid = Value
        End Set
    End Property
End Class