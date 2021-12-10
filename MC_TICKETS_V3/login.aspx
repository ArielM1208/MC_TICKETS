<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="MC_TICKETS_V3.WebForm1" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>MC COLLECT</title>
    <script src="//cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <script src="JS/ControlApp.js"></script>
</head>
<body>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css"/>
    <link href="css/index.css" rel="stylesheet" />
    <!------ Include the above in your HEAD tag ---------->

    <div class="sidenav">
        <div class="login-main-text">
            <h2>MC TICKETS<br>
                </h2>
            <p>Inicio de sesión.</p>
        </div>
    </div>
    <div class="main">
        <div class="col-md-6 col-sm-12">
            <div class="login-form">
                <form id="form1" runat="server">
                    <div class="form-group">
                        <label>Usuario</label>
                         <input type="email" class="form-control" id="usuario" aria-describedby="emailHelp" placeholder="Ingresa tu usuario"/>
                    </div>
                    <div class="form-group">
                        <label>Contaseña</label>
                         <input type="password" class="form-control" id="contrasenia" placeholder="Ingresa tu contraseña"/>
                    </div>
                    <span class ="btn btn-primary" id="btnLogin">Iniciar sesión</span>
                </form>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#btnLogin').click(() => {
                iniciarSesion();
            })
        });
    </script>
</body>
</html>
