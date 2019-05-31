Public Class autocompleteInfo
    Public Sub New()
        _booktitleList = New List(Of ShortBookInfo)
        _status = ""
    End Sub

    Private _booktitleList As List(Of ShortBookInfo)
    Public Property Booktitlelist() As List(Of ShortBookInfo)
        Get
            Return _booktitleList
        End Get
        Set(ByVal value As List(Of ShortBookInfo))
            _booktitleList = value
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
