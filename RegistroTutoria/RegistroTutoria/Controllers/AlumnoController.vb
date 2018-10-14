Imports System.Web.Mvc

Public Class AlumnoController
    Inherits Controller
    Public Shared CODIGO_ALUMNO As String = "CodigoAlumno"
    Public Shared DIRECCION As String = "Direccion"
    Public Shared NOMBRE As String = "Nombre"
    Public Shared TELEFONO As String = "Telefono"
    Public Shared EMAIL As String = "Email"
    Public Shared TIPO_DOCUMENTO As String = "CodigoTipoDocumento"
    Public Shared NUMERO_DOCUMENTO As String = "NumeroDocumento"
    Public Shared FECHA_NACIMIENTO As String = "FechaNacimiento"

    <HttpGet>
    Function Index() As ActionResult
        Dim dbServer, dbUser, dbPass, dbName As String
        ''System.Configuration.ConfigurationManager.AppSettings["AdminPassword"].ToString()

        dbServer = ConfigurationManager.AppSettings("DBServer").ToString
        dbName = ConfigurationManager.AppSettings("DBName").ToString
        dbPass = ConfigurationManager.AppSettings("DBPassword").ToString
        dbUser = ConfigurationManager.AppSettings("DBUser").ToString
        Try
            Util.inicializaSesion(dbServer, dbName, dbUser, dbPass)
            Dim tabla As New DataTable
            Dim vAlumno As New Alumno
            tabla = vAlumno.GetAlumnos()
            ViewData("listaAlumnos") = tabla.AsEnumerable
        Catch ex As Exception
            Throw ex
        End Try
        Return View()
    End Function

    Function CreateStudent() As ActionResult

        Dim documentType As New TipoDocumento
        Dim table As New DataTable

        table = documentType.GetTiposDocumentos()
        ViewData("listaDocumento") = table.AsEnumerable
        Return View()
    End Function

    <HttpPost>
    Function CreateStudent(form As FormCollection) As ActionResult

        Dim student As New Alumno

        student.Direccion1 = form(DIRECCION)
        student.Nombre1 = form(NOMBRE)
        student.Telefono1 = form(TELEFONO)
        student.Email1 = form(EMAIL)
        student.CodigoTipoDocumento1 = form(TIPO_DOCUMENTO)
        student.NumeroDocumento1 = form(NUMERO_DOCUMENTO)

        student.Save()

        Return RedirectToAction("Index")


    End Function

    <HttpGet>
    Function EditStudent(id As Integer) As ActionResult
        Dim student As New Alumno

        student = student.GetAlumno(id)

        Return View(student)

    End Function

    ''<HttpPost()>
    Function EditStudent(form As FormCollection) As ActionResult
        Dim student As New Alumno
        student.CodigoAlumno1 = form(CODIGO_ALUMNO)
        student.Direccion1 = form(DIRECCION)
        student.Nombre1 = form(NOMBRE)
        student.Telefono1 = form(TELEFONO)
        student.Email1 = form(EMAIL)
        ''se llama al metodo que a su vez llama al procedimiento de almacenado
        student.Update()
        ''se redirecciona a la accion index
        Return RedirectToAction("Index")
    End Function


    Function DeleteStudent(id As Integer) As ActionResult
        Dim student As New Alumno
        student.CodigoAlumno1 = id
        student.Delete()

        Return RedirectToAction("Index")
    End Function
End Class