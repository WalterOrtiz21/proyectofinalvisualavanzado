ALTER PROCEDURE spListarAlumnoIndex
AS
	BEGIN
		SELECT a.CodigoAlumno, a.NumeroDocumento, TipoDocumento.Descripcion, a.Nombre, a.FechaNacimiento, a.Direccion, a.Email, a.Telefono 
		FROM dbo.Alumno a
		INNER JOIN TipoDocumento ON TipoDocumento.CodigoTipoDocumento = a.CodigoTipoDocumento
	END	
		
EXEC spListarAlumnoIndex '1'

CREATE PROCEDURE spEliminarAlumno @CodAlumno as int
AS
	BEGIN	
		DELETE FROM dbo.Alumno
		WHERE CodigoAlumno = @CodAlumno
	END

alter PROCEDURE spCrearAlumno @Nombre as varchar(50), @telefono as varchar(50), @direccion as varchar(50), @email as varchar(50), @numero as varchar(50), @tipodoc as int
AS
	BEGIN
		INSERT INTO dbo.Alumno(Nombre, FechaNacimiento, Direccion, Telefono, Email, NumeroDocumento, CodigoTipoDocumento) VALUES(@Nombre, CONVERT(date, getdate()), @direccion, @telefono, @email, @numero, @tipodoc)
	END

ALTER PROCEDURE spModificarAlumno @codigo as int, @Nombre as varchar(50), @telefono as varchar(50), @direccion as varchar(50), @email as varchar(50)
AS
	BEGIN
		UPDATE DBO.Alumno
		SET Nombre = @Nombre, Direccion = @direccion, Telefono = @telefono
		WHERE CodigoAlumno = @codigo
	END

ALTER PROCEDURE spConsultarAlumnoPorCodigo @codigo as int
AS
	BEGIN
		SELECT a.CodigoAlumno, a.NumeroDocumento, td.Descripcion, a.Nombre, a.Direccion, a.Email, a.Telefono, a.FechaNacimiento FROM dbo.Alumno a, dbo.TipoDocumento td
		JOIN Alumno ON Alumno.CodigoTipoDocumento = td.CodigoTipoDocumento
		WHERE a.CodigoAlumno = @codigo
	END	
	exec spConsultarAlumnoPorCodigo '1'

	CREATE PROCEDURE spListarTiposDocumentos 
	AS
	BEGIN
		SELECT * FROM TipoDocumento
	END

	exec spListarAlumnoIndex