﻿Public Class connectionstringHandler

    Private _connectionstring As String

    Public Sub New()
        '_connectionstring = "Data Source=DE-2697;Initial Catalog=AJDNNDatabase_v1;User ID=forfAdmin2;Password=Barnbib1;" ' Live Siten
        _connectionstring = "Data Source=.\SQLEXPRESS;Initial Catalog=AJDNNDatabase_v5;Persist Security Info=True;User ID=forfAdmin4;Password=Barnbib1;"
        '_connectionstring = "Data Source=DE-2697;Initial Catalog=AJDNNDatabase;User ID=forfAdmin2;Password=Barnbib1;"
        '_connectionstring = "Data Source=DE-2697;Initial Catalog=Ny_AJDNNDatabase_v1;User ID=forfAdmin6;Password=Barnbib1;"
        '_connectionstring = "Data Source=DE-2697;Initial Catalog=dev1_AJDNNDatabase_v1;User ID=forfAdminDev1;Password=Barnbib1;" 'Nya dev1.barnensbibliotek.se
    End Sub
    Public ReadOnly Property CurrentConnectionString() As String
        Get
            Return _connectionstring
        End Get

    End Property

End Class
