Public Class Actividad

    Private CodigoActividad As Integer
    Private CodigoEmpleado As Integer
    Private FechaHora As DateTime
    Private CodigoAlumno As Integer
    Private CodigoMotivo As Integer

    Public Property CodigoActividad1 As Integer
        Get
            Return CodigoActividad
        End Get
        Set(value As Integer)
            CodigoActividad = value
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

    Public Property FechaHora1 As Date
        Get
            Return FechaHora
        End Get
        Set(value As Date)
            FechaHora = value
        End Set
    End Property

    Public Property CodigoAlumno1 As Integer
        Get
            Return CodigoAlumno
        End Get
        Set(value As Integer)
            CodigoAlumno = value
        End Set
    End Property

    Public Property CodigoMotivo1 As Integer
        Get
            Return CodigoMotivo
        End Get
        Set(value As Integer)
            CodigoMotivo = value
        End Set
    End Property
End Class
