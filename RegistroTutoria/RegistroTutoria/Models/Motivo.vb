Public Class Motivo
    Private CodigoMotivo As Integer
    Private Descripcion As Integer

    Public Property CodigoMotivo1 As Integer
        Get
            Return CodigoMotivo
        End Get
        Set(value As Integer)
            CodigoMotivo = value
        End Set
    End Property

    Public Property Descripcion1 As Integer
        Get
            Return Descripcion
        End Get
        Set(value As Integer)
            Descripcion = value
        End Set
    End Property

    Public Shared Function ObtenerMotivos() As DataTable

        Return Util.gDatos.TraerDataTable("spObtenerMotivos")

    End Function
End Class
