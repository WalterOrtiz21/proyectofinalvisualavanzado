/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [RegistroTutoria]
GO
/****** Object:  Table [dbo].[Actividad]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actividad](
	[CodigoActividad] [int] NOT NULL,
	[CodigoEmpleado] [int] NOT NULL,
	[Fecha] [date] NULL,
	[Hora] [varchar](10) NULL,
	[CodigoAlumno] [int] NOT NULL,
	[Codigo
CodigoMotivo] [int] NOT NULL,
 CONSTRAINT [PK_Actividad] PRIMARY KEY CLUSTERED 
(
	[CodigoActividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[CodigoAlumno] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[FechaNacimiento] [date] NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[NumeroDocumento] [varchar](50) NULL,
	[CodigoTipoDocumento] [int] NOT NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[CodigoAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Area]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area](
	[CodigoArea] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Areq] PRIMARY KEY CLUSTERED 
(
	[CodigoArea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carrera]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carrera](
	[CodigoCarrera] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[CodigoDirector] [int] NULL,
 CONSTRAINT [PK_Carrera] PRIMARY KEY CLUSTERED 
(
	[CodigoCarrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Decano]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Decano](
	[CodigoDecano] [int] NOT NULL,
 CONSTRAINT [PK_Decano] PRIMARY KEY CLUSTERED 
(
	[CodigoDecano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Director]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Director](
	[CodigoDirector] [int] NOT NULL,
 CONSTRAINT [PK_Director] PRIMARY KEY CLUSTERED 
(
	[CodigoDirector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Disponibilidad]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disponibilidad](
	[CodigoHorario] [int] NOT NULL,
	[CodigoEmpleado] [int] NOT NULL,
	[CodigoDisponibilidad] [int] NOT NULL,
 CONSTRAINT [PK_Disponibilidad] PRIMARY KEY CLUSTERED 
(
	[CodigoDisponibilidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[CodigoEmpleado] [int] NOT NULL,
	[CodigoProfesion] [int] NULL,
	[CodigoTipoDocumento] [int] NULL,
	[Telefono] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[CodigoEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[CodigoEstado] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[CodigoEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facultad]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facultad](
	[CodigoFacultad] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Siglas] [varchar](10) NULL,
	[CodigoCarrera] [int] NULL,
	[CodigoDecano] [int] NULL,
 CONSTRAINT [PK_Facultad] PRIMARY KEY CLUSTERED 
(
	[CodigoFacultad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gerente]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gerente](
	[CodigoGerente] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Horario]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horario](
	[CodigoHorario] [int] NOT NULL,
	[Dia] [varchar](10) NULL,
	[HoraInicio] [varchar](10) NULL,
	[HoraFin] [varchar](10) NULL,
 CONSTRAINT [PK_Horario] PRIMARY KEY CLUSTERED 
(
	[CodigoHorario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Motivo]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Motivo](
	[CodigoMotivo] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Motivo] PRIMARY KEY CLUSTERED 
(
	[CodigoMotivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesion]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesion](
	[CodigoProfesion] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Profesion] PRIMARY KEY CLUSTERED 
(
	[CodigoProfesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[CodigoProfesor] [int] NOT NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[CodigoProfesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[CodigoReserva] [int] NOT NULL,
	[CodigoActividad] [int] NULL,
	[CodigoAlumno] [int] NULL,
	[Fecha] [date] NULL,
	[CodigoArea] [int] NULL,
	[CodigoEstado] [int] NULL,
	[CodigoMotivo] [int] NULL,
	[CodigoDisponbilidad] [int] NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[CodigoReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[CodigoTipoDocumento] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[CodigoTipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tutoria]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tutoria](
	[CodigoActividad] [int] NULL,
	[CodigoReserva] [int] NULL,
	[CodigoTutoria] [int] NOT NULL,
 CONSTRAINT [PK_Tutoria] PRIMARY KEY CLUSTERED 
(
	[CodigoTutoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Actividad]  WITH CHECK ADD  CONSTRAINT [FK_Actividad_Empleado] FOREIGN KEY([CodigoEmpleado])
REFERENCES [dbo].[Empleado] ([CodigoEmpleado])
GO
ALTER TABLE [dbo].[Actividad] CHECK CONSTRAINT [FK_Actividad_Empleado]
GO
ALTER TABLE [dbo].[Actividad]  WITH CHECK ADD  CONSTRAINT [FK_Actividad_Motivo] FOREIGN KEY([Codigo
CodigoMotivo])
REFERENCES [dbo].[Motivo] ([CodigoMotivo])
GO
ALTER TABLE [dbo].[Actividad] CHECK CONSTRAINT [FK_Actividad_Motivo]
GO
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_TipoDocumento] FOREIGN KEY([CodigoTipoDocumento])
REFERENCES [dbo].[TipoDocumento] ([CodigoTipoDocumento])
GO
ALTER TABLE [dbo].[Alumno] CHECK CONSTRAINT [FK_Alumno_TipoDocumento]
GO
ALTER TABLE [dbo].[Carrera]  WITH CHECK ADD  CONSTRAINT [FK_Carrera_Director] FOREIGN KEY([CodigoDirector])
REFERENCES [dbo].[Director] ([CodigoDirector])
GO
ALTER TABLE [dbo].[Carrera] CHECK CONSTRAINT [FK_Carrera_Director]
GO
ALTER TABLE [dbo].[Decano]  WITH CHECK ADD  CONSTRAINT [FK_Decano_Empleado] FOREIGN KEY([CodigoDecano])
REFERENCES [dbo].[Empleado] ([CodigoEmpleado])
GO
ALTER TABLE [dbo].[Decano] CHECK CONSTRAINT [FK_Decano_Empleado]
GO
ALTER TABLE [dbo].[Director]  WITH CHECK ADD  CONSTRAINT [FK_Director_Empleado] FOREIGN KEY([CodigoDirector])
REFERENCES [dbo].[Empleado] ([CodigoEmpleado])
GO
ALTER TABLE [dbo].[Director] CHECK CONSTRAINT [FK_Director_Empleado]
GO
ALTER TABLE [dbo].[Disponibilidad]  WITH CHECK ADD  CONSTRAINT [FK_Disponibilidad_Empleado] FOREIGN KEY([CodigoEmpleado])
REFERENCES [dbo].[Empleado] ([CodigoEmpleado])
GO
ALTER TABLE [dbo].[Disponibilidad] CHECK CONSTRAINT [FK_Disponibilidad_Empleado]
GO
ALTER TABLE [dbo].[Disponibilidad]  WITH CHECK ADD  CONSTRAINT [FK_Disponibilidad_Horario] FOREIGN KEY([CodigoHorario])
REFERENCES [dbo].[Horario] ([CodigoHorario])
GO
ALTER TABLE [dbo].[Disponibilidad] CHECK CONSTRAINT [FK_Disponibilidad_Horario]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Profesion] FOREIGN KEY([CodigoProfesion])
REFERENCES [dbo].[Profesion] ([CodigoProfesion])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Profesion]
GO
ALTER TABLE [dbo].[Facultad]  WITH CHECK ADD  CONSTRAINT [FK_Facultad_Carrera] FOREIGN KEY([CodigoCarrera])
REFERENCES [dbo].[Carrera] ([CodigoCarrera])
GO
ALTER TABLE [dbo].[Facultad] CHECK CONSTRAINT [FK_Facultad_Carrera]
GO
ALTER TABLE [dbo].[Facultad]  WITH CHECK ADD  CONSTRAINT [FK_Facultad_Decano] FOREIGN KEY([CodigoDecano])
REFERENCES [dbo].[Decano] ([CodigoDecano])
GO
ALTER TABLE [dbo].[Facultad] CHECK CONSTRAINT [FK_Facultad_Decano]
GO
ALTER TABLE [dbo].[Gerente]  WITH CHECK ADD  CONSTRAINT [FK_Gerente_Empleado] FOREIGN KEY([CodigoGerente])
REFERENCES [dbo].[Empleado] ([CodigoEmpleado])
GO
ALTER TABLE [dbo].[Gerente] CHECK CONSTRAINT [FK_Gerente_Empleado]
GO
ALTER TABLE [dbo].[Profesor]  WITH CHECK ADD  CONSTRAINT [FK_Profesor_Empleado] FOREIGN KEY([CodigoProfesor])
REFERENCES [dbo].[Empleado] ([CodigoEmpleado])
GO
ALTER TABLE [dbo].[Profesor] CHECK CONSTRAINT [FK_Profesor_Empleado]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Alumno] FOREIGN KEY([CodigoAlumno])
REFERENCES [dbo].[Alumno] ([CodigoAlumno])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Alumno]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Area] FOREIGN KEY([CodigoArea])
REFERENCES [dbo].[Area] ([CodigoArea])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Area]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Disponibilidad] FOREIGN KEY([CodigoDisponbilidad])
REFERENCES [dbo].[Disponibilidad] ([CodigoDisponibilidad])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Disponibilidad]
GO
ALTER TABLE [dbo].[Tutoria]  WITH CHECK ADD  CONSTRAINT [FK_Tutoria_Reserva] FOREIGN KEY([CodigoReserva])
REFERENCES [dbo].[Reserva] ([CodigoReserva])
GO
ALTER TABLE [dbo].[Tutoria] CHECK CONSTRAINT [FK_Tutoria_Reserva]
GO
/****** Object:  StoredProcedure [dbo].[spConsultarAlumnoPorCodigo]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spConsultarAlumnoPorCodigo] @codigo as int
AS
	BEGIN
		SELECT a.CodigoAlumno, a.NumeroDocumento, td.Descripcion, a.Nombre, a.Direccion, a.Email, a.Telefono, a.FechaNacimiento FROM dbo.Alumno a, dbo.TipoDocumento td
		JOIN Alumno ON Alumno.CodigoTipoDocumento = td.CodigoTipoDocumento
		WHERE a.CodigoAlumno = @codigo
	END	
GO
/****** Object:  StoredProcedure [dbo].[spCrearAlumno]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCrearAlumno] @Nombre as varchar(50), @telefono as varchar(50), @direccion as varchar(50), @email as varchar(50), @numero as varchar(50), @tipodoc as int
AS
	BEGIN
		INSERT INTO dbo.Alumno(Nombre, FechaNacimiento, Direccion, Telefono, Email, NumeroDocumento, CodigoTipoDocumento) VALUES(@Nombre, CONVERT(date, getdate()), @direccion, @telefono, @email, @numero, @tipodoc)
	END
GO
/****** Object:  StoredProcedure [dbo].[spEliminarAlumno]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarAlumno] @CodAlumno as int
AS
	BEGIN	
		DELETE FROM dbo.Alumno
		WHERE CodigoAlumno = @CodAlumno
	END
GO
/****** Object:  StoredProcedure [dbo].[spListarAlumnoIndex]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spListarAlumnoIndex]
AS
	BEGIN
		SELECT a.CodigoAlumno, a.NumeroDocumento, TipoDocumento.Descripcion, a.Nombre, a.FechaNacimiento, a.Direccion, a.Email, a.Telefono 
		FROM dbo.Alumno a
		INNER JOIN TipoDocumento ON TipoDocumento.CodigoTipoDocumento = a.CodigoTipoDocumento
	END	
GO
/****** Object:  StoredProcedure [dbo].[spListarTiposDocumentos]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spListarTiposDocumentos] 
	AS
	BEGIN
		SELECT * FROM TipoDocumento
	END
GO
/****** Object:  StoredProcedure [dbo].[spModificarAlumno]    Script Date: 14/10/2018 11:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spModificarAlumno] @codigo as int, @Nombre as varchar(50), @telefono as varchar(50), @direccion as varchar(50), @email as varchar(50)
AS
	BEGIN
		UPDATE DBO.Alumno
		SET Nombre = @Nombre, 
			Direccion = @direccion, 
			Telefono = @telefono,
			Email = @email
		WHERE CodigoAlumno = @codigo
	END
GO
