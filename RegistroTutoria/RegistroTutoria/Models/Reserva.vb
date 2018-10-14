Public Class Reserva

    Private CodigoReserva As Integer
    Private CodigoHorario As Integer
    Private CodigoEmpleado As Integer
    Private CodigoAlumno As Integer
    Private Fecha As DateTime
    Private CodigoArea As Integer
    Private CodigoEstado As Integer
    Private CodigoMotivo As Integer

    Public Property CodigoReserva1 As Integer
        Get
            Return CodigoReserva
        End Get
        Set(value As Integer)
            CodigoReserva = value
        End Set
    End Property

    Public Property CodigoHorario1 As Integer
        Get
            Return CodigoHorario
        End Get
        Set(value As Integer)
            CodigoHorario = value
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

    Public Property CodigoAlumno1 As Integer
        Get
            Return CodigoAlumno
        End Get
        Set(value As Integer)
            CodigoAlumno = value
        End Set
    End Property

    Public Property Fecha1 As Date
        Get
            Return Fecha
        End Get
        Set(value As Date)
            Fecha = value
        End Set
    End Property

    Public Property CodigoArea1 As Integer
        Get
            Return CodigoArea
        End Get
        Set(value As Integer)
            CodigoArea = value
        End Set
    End Property

    Public Property CodigoEstado1 As Integer
        Get
            Return CodigoEstado
        End Get
        Set(value As Integer)
            CodigoEstado = value
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
