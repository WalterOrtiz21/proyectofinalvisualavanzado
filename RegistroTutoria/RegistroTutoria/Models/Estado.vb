Public Class Estado

    Private CodigoEstado As Integer
    Private Descripcion As Integer

    Public Property CodigoEstadoField As Integer
        Get
            Return CodigoEstado
        End Get
        Set(value As Integer)
            CodigoEstado = value
        End Set
    End Property

    Public Property DescripcionField As Integer
        Get
            Return Descripcion
        End Get
        Set(value As Integer)
            Descripcion = value
        End Set
    End Property
End Class
