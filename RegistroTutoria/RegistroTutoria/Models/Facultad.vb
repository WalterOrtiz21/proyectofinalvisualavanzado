Public Class Facultad

    Private CodigoFacultas As Integer
    Private Descripcion As String
    Private Siglas As String
    Private CodigoCarrera As Integer
    Private CodigoEmpleado As Integer

    Public Property CodigoFacultas1 As Integer
        Get
            Return CodigoFacultas
        End Get
        Set(value As Integer)
            CodigoFacultas = value
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

    Public Property Siglas1 As String
        Get
            Return Siglas
        End Get
        Set(value As String)
            Siglas = value
        End Set
    End Property

    Public Property CodigoCarrera1 As Integer
        Get
            Return CodigoCarrera
        End Get
        Set(value As Integer)
            CodigoCarrera = value
        End Set
    End Property

    Public Property CodigoEmpleado1 As Integer
        Get
            Return CodigoEmpleado
        End Get
        Set(value As Integer)
            CodigoEmpleado = value
        End Set
    End Property
End Class
