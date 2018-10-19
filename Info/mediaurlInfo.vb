
Public Class mediaUrlInfo

    Public Enum mediatyper
        MovUrl = 1
        LjudUrl = 2
        ImgUrl = 3
        TeckenMovUrl = 4
        HtmlUrl = 5
    End Enum

    Private _mediaTyp As String
    Public Property MediaTyp() As Integer
        Get
            Return _mediaTyp
        End Get
        Set(ByVal value As Integer)
            _mediaTyp = value
        End Set
    End Property

    Private _mediaDescription As String
    Public Property MediaDescription() As String
        Get
            Return _mediaDescription
        End Get
        Set(ByVal value As String)
            _mediaDescription = value
        End Set
    End Property

    Private _mediaurl As String
    Public Property MediaURL() As String
        Get
            Return _mediaurl
        End Get
        Set(ByVal value As String)
            _mediaurl = value
        End Set
    End Property


End Class
