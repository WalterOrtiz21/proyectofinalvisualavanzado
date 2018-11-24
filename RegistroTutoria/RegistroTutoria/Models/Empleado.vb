Public MustInherit Class Empleado

    Private CodigoEmpleado As Integer
    Private CodigoProfesion As Integer
    Private CodigoTipoDocumento As Integer
    Private Telefono As String
    Private Direccion As String
    Private Email As String

    Public Property CodigoEmpleado1 As Integer
        Get
            Return CodigoEmpleado
        End Get
        Set(value As Integer)
            CodigoEmpleado = value
        End Set
    End Property

    Public Property CodigoProfesion1 As Integer
        Get
            Return CodigoProfesion
        End Get
        Set(value As Integer)
            CodigoProfesion = value
        End Set
    End Property

    Public Property CodigoTipoDocumento1 As Integer
        Get
            Return CodigoTipoDocumento
        End Get
        Set(value As Integer)
            CodigoTipoDocumento = value
        End Set
    End Property

    Public Property Telefono1 As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property

    Public Property Direccion1 As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set

    End Property


    Public Shared Function GetEmpleados() As DataTable

        Return Util.gDatos.TraerDataTable("spListarProfesores")

    End Function

    Public Shared Function GetEmpleado() As DataTable

        Return Util.gDatos.TraerDataTable("sp")

    End Function

    Public Shared Function CargarEmpleadosLista() As DataTable

        Return Util.gDatos.TraerDataTable("spCargarEmpleados")

    End Function

End Class

Public Class Decano
    Inherits Empleado
End Class

Public Class Profesor
    Inherits Empleado
End Class

Public Class Gerente
    Inherits Empleado
End Class

Public Class Director
    Inherits Empleado
End Class