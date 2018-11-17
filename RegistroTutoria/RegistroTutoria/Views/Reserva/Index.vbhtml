
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
    <title>R.T. - Reserva </title>
</head>
<body>


    <div class="text-center">
        <h1 class="h1">Registro de tutoria</h1>
        <h3 class="h3">Reserva - Paso 1</h3>
        <h4 class="h4">Listado de disponbilidad de todos los empleados por dia</h4>

        <div class="btn-group">
            <a href="~/Home/Index" class="btn btn-primary">Inicio</a>
            <div class="form-group row">
                <label for="cliente" class="col-sm-2 col-form-label">Dia</label>
                <div class="col-sm-12 col-lg-4">
                    <select class="form-control" id="cboDia" name="cboDia" onchange="ConsultarDias()">
                        <option value="Lunes">Lunes</option>
                        <option value="Martes">Martes</option>
                        <option value="Miercoles">Miercoles</option>
                        <option value="Jueves">Jueves</option>
                        <option value="Viernes">Viernes</option>
                    </select>
                </div>
            </div>
            @*<a href="~/Alumno/EditStudent" class="btn btn-success">Modificar Datos</a>*@

        </div>
        <br />
        <br />

    </div>

    <Table Class="table table-striped table-hover table-bordered">
        <thead>
            <tr>
                <th> Empleado</th>
                <th> Dia</th>
                <th> Inicio</th>
                <th> Fin</th>
            </tr>
        </thead>
        <tbody id="planilla"></tbody>
    </Table>

    <script src="~/scripts/jquery-3.3.1.min.js"></script>
    <script src="~/scripts/js/bootstrap.min.js"></script>

    <script type="text/javascript">

        function ConsultarDias() {

            var parametro = { dia: $("#cboDia").val() };



            $.ajax({
                type: "POST",
                url: '/Reserva/ObtenerDiasDisponibles',
                data: parametro,
                dataType: "json",
                success: function (msg) {
                    alert("Llamada exitosa");
                    var datos = jQuery.parseJSON(msg);
                    var row = "";
                    for (i = 0; i < datos.length; i++) {
                        row += "<tr>" +
                            "<td>" + datos[i].NombreApellido +
                            "</td><td>" + datos[i].Dia +
                            "</td><td>" + datos[i].Inicio +
                            "</td><td>" + datos[i].Fin +
                            "</td><td><a href='../../Reserva/Procesar/?empleado=" + datos[i].CodigoEmpleado + "&disp=" + datos[i].CodigoDisponibilidad + "'>Seleccionar</a> </td></tr>";
                    }
                    $("#planilla").html(row);
                },
                error: function () {
                    alert("se ha producido un error cargar planilla.");
                }
            });

        }


    </script>
</body>
</html>
