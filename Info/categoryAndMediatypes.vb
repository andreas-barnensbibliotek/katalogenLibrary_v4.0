Public Class categoryAndMediatypes
    Private _categorylist As New List(Of bookCategoryInfo)
    Public Property Categorylist() As List(Of bookCategoryInfo)
        Get
            Return _categorylist
        End Get
        Set(ByVal value As List(Of bookCategoryInfo))
            _categorylist = value
        End Set
    End Property

    Private _mediatyplist As New List(Of bookCategoryInfo)
    Public Property MediatypeList() As List(Of bookCategoryInfo)
        Get
            Return _mediatyplist
        End Get
        Set(ByVal value As List(Of bookCategoryInfo))
            _mediatyplist = value
        End Set
    End Property
End Class
