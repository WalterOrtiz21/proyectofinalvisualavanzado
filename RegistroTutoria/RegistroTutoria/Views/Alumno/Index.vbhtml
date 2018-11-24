
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <link href="~/scripts/css/bootstrap.min.css" rel="stylesheet" />

    <link href="https://fonts.googleapis.com/css?family=Quicksand|Rubik" rel="stylesheet">
    <meta name="viewport" content="width=device-width" />
    <link href="~/scripts/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/gijgo@1.9.10/js/gijgo.min.js" type="text/javascript"></script>
    <link href="https://cdn.jsdelivr.net/npm/gijgo@1.9.10/css/gijgo.min.css" rel="stylesheet" type="text/css" />


    <link href="https://fonts.googleapis.com/css?family=Quicksand|Rubik" rel="stylesheet">
    <style>


        .sidenav {
            height: 100%;
            width: 0;
            position: fixed;
            z-index: 1;
            top: 0;
            left: 0;
            background-color: darkred;
            overflow-x: hidden;
            transition: 0.5s;
            padding-top: 60px;
        }

            .sidenav a {
                padding: 8px 8px 8px 32px;
                text-decoration: none;
                font-size: 25px;
                color: #818181;
                display: block;
                transition: 0.3s;
            }

                .sidenav a:hover {
                    color: #f1f1f1;
                }

            .sidenav .closebtn {
                position: absolute;
                top: 0;
                right: 25px;
                font-size: 36px;
                margin-left: 50px;
            }

        #main {
            transition: margin-left .5s;
            padding: 16px;
        }


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
            transition: background-color .5s;
        }

        .bg-company-red {
            background-color: darkred;
        }
    </style>
    <title>R.T. - Alumno</title>
</head>
<body>


    <nav class="navbar navbar-expand-sm bg-company-red">
        <!-- Brand/logo -->
        <a class="navbar-brand" href="#">
            <img class="pull-right" src="~/Resources/logoUaa.jpg" alt="logo" style="width:40px;">
        </a>

        <span>
            <span class="navbar-text form-inline" style="color:white;">Registro de Tutoria</span>
        </span>
    </nav>


    <div id="mySidenav" class="sidenav">
        <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
        <a href="#">Inicio</a>
        <a href="#">Alumno</a>
        <a href="#">Mis reservas</a>
        <a href="#">Contacto</a>
    </div>
    <script>
        function openNav() {
            document.getElementById("mySidenav").style.width = "250px";
            document.getElementById("main").style.marginLeft = "250px";
            document.body.style.backgroundColor = "rgba(0,0,0,0.4)";
        }

        function closeNav() {
            document.getElementById("mySidenav").style.width = "0";
            document.getElementById("main").style.marginLeft = "0";
            document.body.style.backgroundColor = "#cccccc";
        }
    </script>
    <div id="main">

        <div id="main">
            <span style="font-size:30px;cursor:pointer" onclick="openNav()">Menu</span>


            <div class="text-center">
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
            <table class="table table-hover table-bordered table-active">
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
    </div>
    <script src="~/scripts/jquery-3.3.1.min.js"></script>
    <script src="~/scripts/js/bootstrap.min.js"></script>
</body>
</html>
