<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="perfiles.aspx.vb" Inherits="MC_TICKETS_V3.perfiles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../lib/fontawesome/css/fontawesome.css" rel="stylesheet" />
    <link href="../lib/fontawesome/css/brands.css" rel="stylesheet" />
    <link href="../lib/fontawesome/css/solid.css" rel="stylesheet" />
    <script src="//cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    <script src="../JS/ControlRoles.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar  navbar-expand-lg navbar-dark  bg-dark ">
                <div class="container-fluid">
                    <a class="navbar-brand" href="#">MC COLLECT</a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarNavDropdown">
                        <ul class="navbar-nav">

                            <li class="nav-item ">
                                <a class="nav-link active" href="perfiles.aspx">Permisos</a>
                            </li>
                            <li class="nav-item dropdown">
                                <a class="nav-link  dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-bs-toggle="dropdown" aria-expanded="false">Catalogos
                                </a>
                                <ul class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                                    <li><a class="dropdown-item" href="usuarios.aspx">Usuarios</a></li>
                                    <li><a class="dropdown-item" href="#">Nucleos</a></li>
                                </ul>
                            </li>
                            <li class="nav-item dropdown">
                                <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink2" role="button" data-bs-toggle="dropdown" aria-expanded="false">Clientes
                                </a>
                                <ul class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink2">
                                    <li><a class="dropdown-item" href="#">Datos 360</a></li>
                                    <li><a class="dropdown-item" href="#">Conteos</a></li>
                                    <li><a class="dropdown-item" href="#">Categoria</a></li>
                                    <li><a class="dropdown-item" href="#">SLA</a></li>
                                    <li><a class="dropdown-item" href="#">Polizas</a></li>
                                </ul>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#">Campañas</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#">Nucleos</a>
                            </li>
                        </ul>
                    </div>
                    <span id="btnCerrarSesion" class="btn btn-outline-danger"><i class="fas fa-sign-out-alt"></i>Cerrar sesión
                    </span>
                </div>
            </nav>
            <div class="container mt-5">
                <div id="tbl_permisos"></div>
            </div>
        </div>

        <!-- Modal -->
        <div class="modal fade" id="modalEditaRol" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-xl">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Editar rol</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="d-flex flex-row justify-content-center alig-items-center">
                                <p class="h5">Permisos de sistema</p>
                            </div>
                            <div class="col-4 mt-3 justify-content-center alig-items-center">
                                <p class="h6 mb-3">Modulos</p>
                                <div class="form-check form-switch mb-3">
                                    <input id="M_Administrador_edit" class="form-check-input" type="checkbox" />
                                    <label class="form-check-label" for="flexSwitchCheckDefault">Administrador</label>
                                </div>
                                <div class="form-check form-switch mb-3">
                                    <input id="M_Desarrollo_edit" class="form-check-input" type="checkbox" />
                                    <label class="form-check-label" for="flexSwitchCheckDefault">Desarrollo</label>
                                </div>
                                <div class="form-check form-switch mb-3">
                                    <input id="M_Soporte_edit" class="form-check-input" type="checkbox" />
                                    <label class="form-check-label" for="flexSwitchCheckDefault">Soporte</label>
                                </div>
                            </div>

                            <div class="col-4 mt-3 justify-content-center alig-items-center">
                                <p class="h6">Vistas</p>
                            </div>

                            <div class="col-4 mt-3 justify-content-center alig-items-center">
                                <p class="h6 mb-3">Acciones</p>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                        <button type="button" class="btn btn-primary">Save changes</button>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#tbl_permisos').load('elementos/tbl_Permisos.html')

        })

    </script>
</body>
</html>
