<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="inicio.aspx.vb" Inherits="MC_TICKETS_V3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="lib/fontawesome/css/fontawesome.css" rel="stylesheet" />
    <link href="lib/fontawesome/css/brands.css" rel="stylesheet" />
    <link href="lib/fontawesome/css/solid.css" rel="stylesheet" />
        <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    <script src="JS/ControlApp.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-light bg-light">
            <div class="container-fluid">
                <a class="navbar-brand" href="inicio.aspx">MC COLLECT</a>
                <span id="btnCerrarSesion" class="btn btn-outline-danger"><i class="fas fa-sign-out-alt"></i> Cerrar sesión
                </span>
            </div>
        </nav>
        <div class="container">
            <div class="row mt-5">
                <asp:Panel Visible="false" ID="pnl_admin" CssClass="col-lg-4" runat="server">
                    <div class="card btn" id="btn_pnl_administrador" style="color: black">
                        <img src="img/administrador.png" class="card-img-top" alt="..." style="border-radius: 20px" />
                        <div class="card-body">
                            <h5 class="card-title">Administrador</h5>
                        </div>
                    </div>
                </asp:Panel>
                <asp:Panel Visible="false" ID="pnl_desarrollo" CssClass="col-lg-4" runat="server">
                    <div class="card btn" id="btn_pnl_desarrollo" style="color: black;">
                        <img src="img/desarrollo.png" class="card-img-top" alt="..." style="border-radius: 20px" />
                        <div class="card-body">
                            <h5 class="card-title">Desarrollo</h5>
                        </div>
                    </div>
                </asp:Panel>
                <asp:Panel Visible="false" ID="pnl_soporte" CssClass="col-lg-4" runat="server">
                    <div class="card btn" id="btn_pnl_soporte" style="color: black">
                        <img src="img/soporte.png" class="card-img-top" alt="..." style="border-radius: 20px" />
                        <div class="card-body">
                            <h5 class="card-title">Soporte</h5>
                        </div>
                    </div>
                </asp:Panel>
            </div>
        </div>
    </form>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#btnCerrarSesion').click(() => {
                cerrarSesion();
            })

            $('#btn_pnl_administrador').click(() => {
                //location.href="M_Administrador/inicio.aspx";
                location.href="M_Administrador/usuarios.aspx";
            })
        });
    </script>
</body>
</html>
