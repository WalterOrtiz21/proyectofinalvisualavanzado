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


    Public Shared Function ObtenerHorariosPorDisponibilidad(disp As Integer) As String

        Dim horarios As String = 0
        Dim dt As New DataTable

        dt = Util.gDatos.TraerDataTable("ObtenerHorariosPorDisponbilidad", disp)

        If dt.Rows.Count > 0 Then

            horarios = dt.Rows(0).Item("Inicio") + "-" + dt.Rows(0).Item("Fin")

        End If

        Return horarios

    End Function
End Class
