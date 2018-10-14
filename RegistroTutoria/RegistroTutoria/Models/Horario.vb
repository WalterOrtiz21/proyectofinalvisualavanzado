Public Class Horario

    Private CodigoHorario As Integer
    Private Dia As String
    Private HoraInicio As String
    Private HoraFin As String

    Public Property CodigoHorario1 As Integer
        Get
            Return CodigoHorario
        End Get
        Set(value As Integer)
            CodigoHorario = value
        End Set
    End Property

    Public Property Dia1 As String
        Get
            Return Dia
        End Get
        Set(value As String)
            Dia = value
        End Set
    End Property

    Public Property HoraInicio1 As String
        Get
            Return HoraInicio
        End Get
        Set(value As String)
            HoraInicio = value
        End Set
    End Property

    Public Property HoraFin1 As String
        Get
            Return HoraFin
        End Get
        Set(value As String)
            HoraFin = value
        End Set
    End Property
End Class
