
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
    <link href="https://fonts.googleapis.com/css?family=Niramit" rel="stylesheet">

    <style>
        body {
            font-family: 'Niramit', sans-serif;
        }
        /* The sidebar menu */
        .sidenav {
            height: 100%; /* Full-height: remove this if you want "auto" height */
            width: 160px; /* Set the width of the sidebar */
            position: fixed; /* Fixed Sidebar (stay in place on scroll) */
            z-index: 1; /* Stay on top */
            top: 0; /* Stay at the top */
            left: 0;
            background-color: darkred; /* Black */
            overflow-x: hidden; /* Disable horizontal scroll */
            padding-top: 20px;
        }

            /* The navigation menu links */
            .sidenav a {
                padding: 6px 8px 6px 16px;
                text-decoration: none;
                font-size: 25px;
                color: #818181;
                display: block;
            }

                .sidenav a:hover {
                    color: #f1f1f1;
                }

        /* Style page content */
        .main {
            margin-left: 160px; /* Same as the width of the sidebar */
            padding: 0px 10px;
        }
    </style>
    <title>Reservas</title>
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
    <div class="sidenav">
        <a href="#">About</a>
        <a href="#">Services</a>
        <a href="#">Clients</a>
        <a href="#">Contact</a>
    </div>

    <!-- Page content -->
    <div class="main">
        <div class="form-group col-md-4">
            <label for="inputDocType">Profesor</label>
            <select id="CodigoEmpleado" class="form-control" name="CodigoEmpleado">
                @For Each row In ViewData("listaEmpleados")
                    @<option value="@row("CodigoEmpleado")">@row("NombreApellido")</option>
                Next
            </select>
        </div>




    </div>
</body>
</html>
