<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="inicio.aspx.vb" Inherits="MC_TICKETS_V3.inicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../lib/fontawesome/css/fontawesome.css" rel="stylesheet" />
    <link href="../lib/fontawesome/css/brands.css" rel="stylesheet" />
    <link href="../lib/fontawesome/css/solid.css" rel="stylesheet" />
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    <script src="../JS/ControlApp.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar  navbar-expand-lg navbar-dark  bg-dark ">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">MC COLLECT</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNavDropdown">
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="#">Tickets</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Estatus</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Fechas</a>
                        </li>
                       
                    </ul>
                </div>
                    <span id="btnCerrarSesion" class="btn btn-outline-danger"><i class="fas fa-sign-out-alt"></i>Cerrar sesión
                            </span>
            </div>
        </nav>
      

    </form>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#btnCerrarSesion').click(() => {
                cerrarSesion();
            })

        });
    </script>
</body>
</html>
