Public Class mainSearchResultInfo
    Public Sub New()
        _antal = 0
        _bookitems = New List(Of bookdetailbaseInfo)
        _status = ""
    End Sub
    Private _bookitems As List(Of bookdetailbaseInfo)
    Public Property Bookitems() As List(Of bookdetailbaseInfo)
        Get
            Return _bookitems
        End Get
        Set(ByVal value As List(Of bookdetailbaseInfo))
            _bookitems = value
        End Set
    End Property
    Private _antal As Integer
    Public Property Antal() As Integer
        Get
            Return _antal
        End Get
        Set(ByVal value As Integer)
            _antal = value
        End Set
    End Property

    Private _status As String
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property
End Class
