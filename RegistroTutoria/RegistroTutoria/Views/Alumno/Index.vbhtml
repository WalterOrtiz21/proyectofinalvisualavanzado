
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <link href="~/scripts/css/bootstrap.min.css" rel="stylesheet" />

    <link href="https://fonts.googleapis.com/css?family=Quicksand|Rubik" rel="stylesheet">

    <style>
        table {
            font-family: 'Quicksand', sans-serif;
           
        }

        table .w-30 {
            width: 30%;
        }

        body {
            font-family: 'Rubik', sans-serif;
            background-image: url("~/Resources/fondo.jpg");
            background-color: #cccccc;
        }
    </style>
    <title>R.T. - Alumno</title>
</head>
<body>
    
  
    <div class="container"  style="background-image: url('~/Resources/fondo.jpg');">

        <div  class="text-center">
            <h1 class="h1">Registro de Tutoría</h1>
            <h3 class="h3">Registro de Alumnos</h3>

            <div class="btn-group">
                <a href="~/Home/Index" class="btn btn-primary">Inicio</a>
                <a href="~/Alumno/CreateStudent" class="btn btn-secondary">Registrar</a>
                @*<a href="~/Alumno/EditStudent" class="btn btn-success">Modificar Datos</a>*@

            </div>
            <br />
            <br />
        </div>
        <table width=80 class="table table-hover table-bordered table-active">
            <thead class="thead-dark">
                <tr>
                    <th>N° Documento</th>
                    <th>Tipo Documento</th>
                    <th>Nombre</th>
                    <th>Fecha de Nac.</th>
                    <th>Email</th>
                    <th>Teléfono</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody>
                @For Each row In ViewData("listaAlumnos")
                    @<tr>
                        <td hidden>@row("CodigoAlumno")</td>
                        <td>@row("NumeroDocumento")</td>
                        <td>@row("Descripcion")</td>
                        <td>@row("Nombre")</td>
                        <td>@row("FechaNacimiento")</td>
                        <td>@row("Email")</td>
                        <td>@row("Telefono")</td>

                        <td>
                            <a href="~/Alumno/EditStudent/@row("CodigoAlumno")" class="btn btn-secondary" title="Modificar">M</a>
                            <a href="~/Alumno/DeleteStudent/@row("CodigoAlumno")" class="btn btn-danger" title="Borrar">B</a>
                        </td>
                    </tr>
                Next
            </tbody>
        </table>
    </div>
        <script src="~/scripts/js/jquery-3.3.1.min.js"></script>
        <script src="~/scripts/js/bootstrap.min.js"></script>
    </body>
</html>
