
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <link href="~/scripts/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Quicksand|Rubik" rel="stylesheet">
    <style>

        body {
            font-family: 'Rubik', sans-serif;
            background-color: #0066cc;
        }
        html, body {
            height: 100%;
            color: #333333;
            background-color: red; /* For browsers that do not support gradients */
            background-image: linear-gradient(#f48041, #41cdf4); /* Standard syntax (must be last) */
        }

        .form-control{
            font-family: 'Quicksand', sans-serif;
        }
    </style>

    <meta name="viewport" content="width=device-width" />
    <title>R.T. - Alumno</title>
</head>
<body>
    <div class="container">
        <h1 class="h1 text-center">Registro de un nuevo alumno</h1>
        <form method="post" action="~/Alumno/CreateStudent">
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="inputName">Nombre</label>
                    <input type="text" class="form-control" id="inputName" placeholder="Ingrese su nombre" name="Nombre">
                </div>
                <div class="form-group col-md-6">
                    <label for="inputDocument">N° Documento</label>
                    <input type="text" class="form-control" id="inputDocument" placeholder="Ingrese su número de documento" name="NumeroDocumento">
                </div>
            </div>
            <div class="form-group">
                <label for="inputAddress">Dirección</label>
                <input type="text" class="form-control" id="inputAddress" placeholder="Su dirección" name="Direccion">
            </div>
            <div class="form-group">
                <label for="inputPhone">Teléfono</label>
                <input type="text" class="form-control" id="inputPhone" placeholder="Número de teléfono" name="Telefono">
            </div>
            <div class="form-group">
                <label for="inputMail">Email</label>
                <input type="email" class="form-control" id="inputMail" placeholder="dirección de email" name="Email">
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="inputDate">Fecha Nac.</label>
                    <input type="date" class="form-control" id="inputDate" name="FechaNacimiento">
                </div>
                <div class="form-group col-md-4">
                    <label for="inputDocType">Tipo Documento</label>
                    <select id="inputDocType" class="form-control" name="CodigoTipoDocumento">
                        @For Each row In ViewData("listaDocumento")
                            @<option value="@row("CodigoTipoDocumento")">@row("Descripcion")</option>
                        Next
                    </select>
                </div>
            </div>

            <input class="btn btn-primary col-lg-2 col-sm-12 col-md-6" type="submit" value="Guardar" />
            <input class="btn btn-primary col-lg-2 col-sm-12 col-md-6" type="reset" value="Limpiar" />
        </form>

        @*<form method="post" action="~/Alumno/CreateStudent">
            <div class="form-group">
                Nombre:<input class="form-control col-md-6 col-lg-4 col-sm-4" type="text" name="Nombre" required placeholder="Ingrese el nombre del alumno" />
                N° Documento:<input class="form-control col-md-6 col-lg-4 col-sm-4" type="text" name="NumeroDocumento" required placeholder="Ingrese el nombre del alumno" />
                Fecha de Nacimiento:<input class="form-control col-md-6 col-lg-4 col-sm-4" type="date" name="FechaNacimiento" required placeholder="Ingrese la fecha de nacimiento" />
                Direccion:<input class="form-control col-md-6 col-lg-4 col-sm-4" type="text" name="Direccion" required placeholder="Ingrese su dirección" />
                Teléfono: <input class="form-control col-md-6 col-lg-4 col-sm-4" type="text" name="Telefono" required placeholder="Ingrese su teléfono" />
                Email:<input class="form-control col-md-6 col-lg-4 col-sm-4" type="text" name="Email" required placeholder="Ingrese su email" />

                Tipo Documento:<select name="CodigoTipoDocumento">
                    @For Each row In ViewData("listaDocumento")
                        @<option value="@row("CodigoTipoDocumento")">@row("Descripcion")</option>
                    Next
                </select>
            </div>
            <br /><br />
            <input class="btn btn-primary col-lg-2 col-sm-12 col-md-6" type="submit" value="Guardar" />
        </form>*@


    </div>
    <script src="~/scripts/js/jquery-3.3.1.min.js"></script>
    <script src="~/scripts/js/bootstrap.min.js"></script>
</body>
</html>
