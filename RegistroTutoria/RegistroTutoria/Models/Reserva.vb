﻿Public Class Reserva

    Private CodigoReserva As Integer
    Private CodigoHorario As Integer
    Private CodigoEmpleado As Integer
    Private CodigoAlumno As Integer
    Private Hora As String
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

    Public Property Hora1 As String
        Get
            Return Hora
        End Get
        Set(value As String)
            Hora = value
        End Set
    End Property

    Public Function GetReservas(hora As String, fecha As DateTime) As DataTable

        Return Util.gDatos.TraerDataTable("spListarReservas", hora, fecha)


    End Function


    Sub GuardarReserva()

        Util.gDatos.Ejecutar("spGuardarReserva", Me.CodigoAlumno, Me.CodigoReserva, Me.Fecha, Me.Hora, Me.CodigoEmpleado)

    End Sub

    Public Shared Function ConsultarDiasDisponibles(dia As String) As DataTable

        Return Util.gDatos.TraerDataTable("spListarDiasDisponibles", dia)

    End Function

    Public Shared Function ConsultarReservasEmpleado(empleado As Integer, disp As Integer) As DataTable

        Return Util.gDatos.TraerDataTable("spListarReservasEmpleado", disp, empleado)

    End Function


End Class
