Imports RegistroTutoria.Util

Public Class TipoDocumento
    Private Codigo As Integer
    Private Descripcion As String

    Public Property Codigo1 As Integer
        Get
            Return Codigo
        End Get
        Set(value As Integer)
            Codigo = value
        End Set
    End Property

    Public Property Descripcion1 As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property

    Function GetTiposDocumentos() As DataTable

        Return gDatos.TraerDataTable("spListarTiposDocumentos")

    End Function
End Class
