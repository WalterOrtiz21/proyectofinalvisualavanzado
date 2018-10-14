
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <link href="~/scripts/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Quicksand|Rubik" rel="stylesheet">
    <style>
        html, body {
            height: 100%;
            font-family: 'Rubik', sans-serif;
            color: #333333;
            background-color: red; /* For browsers that do not support gradients */
            background-image: linear-gradient(#f48041, #41cdf4); /* Standard syntax (must be last) */
        }

        .form-control {
            font-family: 'Quicksand', sans-serif;
        }
    </style>

    <meta name="viewport" content="width=device-width" />
    <title>R.T. - Alumno</title>
</head>
<body>
    <div class="container">
        <h1 class="text-center">Modificar Alumno</h1>
        <form method="post" action="~/Alumno/EditStudent">
            <input type="text" hidden name="CodigoAlumno" value="@Model.CodigoAlumno1"/>
            <div class="form-group row">
                <div class="form-group col-md-6">
                    <label for="inputName">Nombre</label>
                    <input type="text" readonly class="form-control-plaintext" id="inputName" name="Nombre" value="@Model.Nombre1">
                </div>
                <div class="form-group row col-md-6">
                    <label for="inputDocument">N° Documento</label>
                    <input type="text" class="form-control-plaintext" id="inputDocument" name="NumeroDocumento" value="@Model.NumeroDocumento1">
                </div>
            </div>
            <div class="form-row">
                <label for="inputAddress">Dirección</label>
                <input type="text" class="form-control" id="inputAddress" name="Direccion" value="@Model.Direccion1" required>
            </div>
            <div class="form-row">
                <label for="inputPhone">Teléfono</label>
                <input type="text" class="form-control" id="inputPhone" name="Telefono" value="@Model.Telefono1" required>
            </div>
            <div class="form-row">
                <label for="inputMail">Email</label>
                <input type="text" class="form-control" id="inputMail" name="Email" value="@Model.Email1" required>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="inputDate">Fecha Nac.</label>
                    <input type="text" class="form-control-plaintext" id="inputDate" name="FechaNacimiento" value="@Model.FechaNacimiento1" readonly>
                </div>
               
            </div>

            <input class="btn btn-primary col-lg-2 col-sm-12 col-md-6" type="submit" value="Modificar" />
        </form>


    </div>
    <script src="~/scripts/js/jquery-3.3.1.min.js"></script>
    <script src="~/scripts/js/bootstrap.min.js"></script>
</body>
</html>
