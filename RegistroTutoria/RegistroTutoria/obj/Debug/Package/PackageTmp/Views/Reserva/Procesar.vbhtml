
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
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
    <title>R.T. - Reserva </title>
    
</head>
<body>

    <nav class="navbar navbar-expand-sm bg-company-red">
        <!-- Brand/logo -->
        <a class="navbar-brand" href="#">
            <img class="pull-right" src="~/Resources/logoUaa.jpg" alt="logo" style="width:40px;">
        </a>
        
            <span>
                <span class="navbar-text form-inline" style="color:white;" >Registro de Tutoria</span>
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
        <span style="font-size:30px;cursor:pointer" onclick="openNav()">Menu</span>
        <h3 class="h3 text-center">Reserva</h3>
        <h5 class="h5 text-center">Registre su reserva, teniendo en cuenta que abajo están las reservas ya hechas</h5>
 

    <form title="Reserva" style="width:60%; height:65%; margin: auto; border: 1px solid darkred; border-radius: 2px;   padding-top: 50px;padding-right: 10px;padding-bottom: 10px;padding-left: 10px;"
          method="post" action="~/Reserva/Guardar">
        
        <div class="form-row">
            <div class="col-md-4 mb-3">
                <label for="inputName">Alumno</label>
                <input type="text" class="form-control " id="inputName" placeholder="Ingrese su nombre" name="inputName" required>

            </div>
            <input type="text" value="@ViewData("disponibilidad")" hidden />
            <div class="col-md-4 mb-3">
                <label for="inputDocument">Nro. Documento</label>
                <input type="text" class="form-control is-valid" id="inputDocument" name="inputDocument" placeholder="Ingrese su nro. de documento" required>
            </div>
            <div class="col-md-4 mb-3">
                <label for="cboMotivo">Motivo</label>
                <div class="input-group">
                    <div class="input-group-prepend">
                        <span class="input-group" id="inputGroupPrepend3"></span>
                    </div>
                    <select class="form-control" id="cboMotivo" name="cboMotivo">
                        @For Each row In ViewData("listaMotivos")
                            @<option value="@row("CodigoMotivo")">@row("Descripcion")</option>
                        Next
                    </select>
                </div>
            </div>
            <div class="col-md-4 mb-3">
                <label for="cboArea">Area</label>
                <div class="input-group">
                    <div class="input-group-prepend">
                        <span class="input-group" id="inputGroupPrepend3"></span>
                    </div>
                    <select class="form-control" id="cboArea" name="cboArea">
                        @For Each row In ViewData("listaAreas")
                            @<option value="@row("CodigoArea")">@row("Descripcion")</option>
                        Next
                    </select>
                </div>
            </div>
            <div class="col-md-4 mb-3">
                <label for="datepicker">Fecha</label>
                <div class="input-group">
                    <input id="datepicker" width="276" name="datePicker" />
                    <script>
                        $('#datepicker').datepicker({
                            uiLibrary: 'bootstrap4'
                        });
                    </script>

                </div>
            </div>
            <div class="col-md-4 mb-3">
                <label for="timePicker">Hora</label>
                <div class="input-group">
                    <div class="input-group-prepend">
                        <span class="input-group" id="inputGroupPrepend3"></span>
                    </div>
                    <input type="time" class="form-control" name="timePicker" id="timePicker" />
                </div>
            </div>

        </div>
            <button class="btn btn-primary" type="submit">Hacer Reserva</button>
        </form>

    </div>
    <table class="table table-hover table-bordered table-active" style="width:50%;height:50%; margin:auto">
        <thead class="thead-dark">
            <tr>
                <th>Fecha</th>
                <th>Hora</th>
            </tr>
        </thead>
        <tbody>
            @For Each row In ViewData("listaReservas")
                @<tr>
                    <td hidden>@row("Fecha")</td>
                    <td>@row("Hora")</td>
                </tr>
            Next
        </tbody>
    </table>


    <script src="~/scripts/jquery-3.3.1.min.js"></script>
</body>
</html>
