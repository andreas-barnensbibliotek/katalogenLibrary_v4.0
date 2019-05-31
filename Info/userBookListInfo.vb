Public Class userBookListInfo

    Public Sub New()
        _boklistId = 0
        _boklistnamn = ""
        _bookinlist = ""
    End Sub

    Private _boklistId As Integer
    Public Property BoklistId() As Integer
        Get
            Return _boklistId
        End Get
        Set(ByVal value As Integer)
            _boklistId = value
        End Set
    End Property

    Private _boklistnamn As String
    Public Property Boklistnamn() As String
        Get
            Return _boklistnamn
        End Get
        Set(ByVal value As String)
            _boklistnamn = value
        End Set
    End Property

    Private _bookinlist As String
    Public Property Bookinlist() As String
        Get
            Return _bookinlist
        End Get
        Set(ByVal value As String)
            _bookinlist = value
        End Set
    End Property

End Class