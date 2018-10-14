Public Class Disponibilidad

    Private _codigoEmpleado As Integer
    Private _codigoHorario As Integer

    Public Property CodigoEmpleado As Integer
        Get
            Return _codigoEmpleado
        End Get
        Set(value As Integer)
            _codigoEmpleado = value
        End Set
    End Property

    Public Property CodigoHorario As Integer
        Get
            Return _codigoHorario
        End Get
        Set(value As Integer)
            _codigoHorario = value
        End Set
    End Property
End Class
