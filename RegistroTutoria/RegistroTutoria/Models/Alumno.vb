Imports AccesoDatos
Imports RegistroTutoria.Util
Public Class Alumno

    Private CodigoAlumno As Integer
    Private Nombre As String
    Private FechaNacimiento As Date
    Private Direccion As String
    Private Telefono As String
    Private Email As String
    Private NumeroDocumento As String
    Private CodigoTipoDocumento As String



    Public Property CodigoAlumno1 As Integer
        Get
            Return CodigoAlumno
        End Get
        Set(value As Integer)
            CodigoAlumno = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property FechaNacimiento1 As Date
        Get
            Return FechaNacimiento
        End Get
        Set(value As Date)
            FechaNacimiento = value
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

    Public Property Telefono1 As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
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

    Public Property NumeroDocumento1 As String
        Get
            Return NumeroDocumento
        End Get
        Set(value As String)
            NumeroDocumento = value
        End Set
    End Property

    Public Property CodigoTipoDocumento1 As String
        Get
            Return CodigoTipoDocumento
        End Get
        Set(value As String)
            CodigoTipoDocumento = value
        End Set
    End Property

    Public Function GetAlumnos() As DataTable
        Return gDatos.TraerDataTable("spListarAlumnoIndex")
    End Function


    Sub Delete()
        gDatos.Ejecutar("spEliminarAlumno", Me.CodigoAlumno)
    End Sub

    Sub Save()
        gDatos.Ejecutar("spCrearAlumno", Me.Nombre, Me.Telefono, Me.Direccion, Me.Email, Me.NumeroDocumento, Me.CodigoTipoDocumento)
    End Sub

    Sub Update()
        gDatos.Ejecutar("spModificarAlumno", Me.CodigoAlumno, Me.Nombre, Me.Telefono, Me.Direccion, Me.Email)
    End Sub

    Public Function GetAlumno(codigo As Integer) As Alumno
        Dim tabla As New DataTable

        tabla = gDatos.TraerDataTable("spConsultarAlumnoPorCodigo", codigo)
        Try
            If tabla.Rows.Count > 0 Then
                Dim vAlumno As New Alumno
                ''se pasa de la tabla temporal a cada propiedad del objeto y luego retorno este objeto
                vAlumno.CodigoAlumno = tabla.Rows(0).Item(AlumnoController.CODIGO_ALUMNO)
                vAlumno.NumeroDocumento = tabla.Rows(0).Item(AlumnoController.NUMERO_DOCUMENTO)
                vAlumno.Nombre = tabla.Rows(0).Item(AlumnoController.NOMBRE)
                vAlumno.Direccion = tabla.Rows(0).Item(AlumnoController.DIRECCION)
                vAlumno.Email = tabla.Rows(0).Item(AlumnoController.EMAIL)
                vAlumno.Telefono = tabla.Rows(0).Item(AlumnoController.TELEFONO)
                vAlumno.FechaNacimiento = tabla.Rows(0).Item(AlumnoController.FECHA_NACIMIENTO)
                Return vAlumno
            End If
            Return Nothing
        Catch ex As Exception
            Throw ex
        End Try


    End Function

    Public Shared Function GetAlumnoPorDocumento(documento As String) As DataTable

        Return gDatos.TraerDataTable("spObtenerAlumno", documento)

    End Function
End Class
