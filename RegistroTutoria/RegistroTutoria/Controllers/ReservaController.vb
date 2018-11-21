Imports System.Web.Mvc
Imports Newtonsoft.Json
Namespace Controllers
    Public Class ReservaController
        Inherits Controller

        ' GET: Reserva
        Function Index() As ActionResult

            Return View()

        End Function


        Function GetEmpleados() As JsonResult

            Dim vTable As New DataTable

            vTable = Empleado.GetEmpleados()

            Return Json(Newtonsoft.Json.JsonConvert.SerializeObject(vTable))

        End Function

        Function ObtenerDiasDisponibles(dia As String) As JsonResult
            Dim dt As DataTable
            dt = Reserva.ConsultarDiasDisponibles(dia)

            Return Json(Newtonsoft.Json.JsonConvert.SerializeObject(dt))

        End Function

        <HttpGet()>
        Function Procesar(empleado As Integer, disp As Integer) As ActionResult

            ''recibir los parametros y ejecutar el sp en base a los mismos
            Try

                Dim dt As New DataTable

                dt = Reserva.ConsultarReservasEmpleado(empleado, disp)

                ViewData("disponibilidad") = disp

                ViewData("listaReservas") = dt.AsEnumerable

                dt = Motivo.ObtenerMotivos()

                ViewData("listaMotivos") = dt.AsEnumerable

                dt = Area.ObtenerArea()

                ViewData("listaAreas") = dt.AsEnumerable

            Catch ex As Exception
                Throw ex
            End Try



            ''retornar una tabla con la lista de reservas para ese empleado en particular
            Return View()

        End Function

        <HttpPost>
        Public Function Guardar(formulario As FormCollection) As ActionResult

            Dim reserva As New Reserva
            Dim codigoAlumno As Integer
            Dim dtemp As New DataTable
            dtemp = Alumno.GetAlumnoPorDocumento(formulario("inputDocument"))
            If dtemp.Rows.Count > 0 Then
                codigoAlumno = dtemp.Rows(0).Item(AlumnoController.CODIGO_ALUMNO)
            End If

            Try
                reserva.CodigoAlumno1 = codigoAlumno
                reserva.Fecha1 = formulario("datePicker")
                reserva.Hora1 = formulario("timepicker")
                reserva.CodigoArea1 = formulario("cboArea")
                reserva.CodigoEstado1 = 2
                reserva.CodigoDisponibilidad1 = formulario("disponibilidad")
                reserva.CodigoMotivo1 = formulario("cboMotivo")
                reserva.GuardarReserva()
                ViewData("mensaje") = "Su reserva ha sido registrada con éxito"
            Catch Ex As Exception
                ViewData("mensaje") = "Disculpe los inconvenientes, intente de nuevo más tarde"

            End Try

            Return View()

        End Function

    End Class
End Namespace