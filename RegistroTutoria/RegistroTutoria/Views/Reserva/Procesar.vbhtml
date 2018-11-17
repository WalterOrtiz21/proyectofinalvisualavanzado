
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
    <div>

        <!--
        crear formulario para realizar la reserva en base a las reservas ya listadas
    -->

        <div class="text-center">
            <h1 class="h1">Registro de Tutoría</h1>
            <h3 class="h3">Reserva</h3>
            <h5 class="h5">Registre su reserva, teniendo en cuenta que abajo están ya las reservas hechas</h5>
            <div class="btn-group">
                <a href="~/Home/Index" class="btn btn-primary">Inicio</a>
                
                @*<a href="~/Alumno/EditStudent" class="btn btn-success">Modificar Datos</a>*@

            </div>
            <br />
            <br />

            <form method="post" action="~/Reserva/SaveReserve">
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputName">Nombre del Alumno</label>
                        <input type="text" class="form-control" id="inputName" placeholder="Ingrese su nombre" name="Nombre">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="inputDocument">N° Documento</label>
                        <input type="text" class="form-control" id="inputDocument" placeholder="Ingrese su número de documento" name="NumeroDocumento">
                    </div>
                </div>
                <div class="form-group row">
                    <label for="cliente" class="col-sm-2 col-form-label">Actividad</label>
                    <div class="col-sm-12 col-lg-4">
                        <select class="form-control" id="cboTipo" name="cboTipo">
                            @For Each row In ViewData("listaMotivos")
                                @<option value="@row("CodigoMotivo")">@row("Descripcion")</option>
                            Next
                        </select>
                    </div>
                </div>

                <div class="form-group row">
                    <label for="cliente" class="col-sm-2 col-form-label">Area</label>
                    <div class="col-sm-12 col-lg-4">
                        <select class="form-control" id="cboTipo" name="cboTipo">
                            @For Each row In ViewData("listaAreas")
                                @<option value="@row("CodigoArea")">@row("Descripcion")</option>
                            Next
                        </select>
                    </div>
                </div>


                <input class="btn btn-primary col-lg-2 col-sm-12 col-md-6" type="submit" value="Guardar" />
                <input class="btn btn-primary col-lg-2 col-sm-12 col-md-6" type="reset" value="Limpiar" />
            </form>

        </div>
            <table width=80 class="table table-hover table-bordered table-active">
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
        </div>
    </div>
</body>
</html>
