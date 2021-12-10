function llenarTablaUsuarios() {
    $.ajax({
        type: "POST",
        url: "../api/Usuarios",
        data: '{ACCION: "ListaUsuarios"}',
        datatype: 'JSON',
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            let tabla = ''
            $.map(response, (e) => {
                tabla += `
            <tr>
            <th>${e.CAT_US_ID}</th>
            <td>${e.CAT_US_NOMBRE + ' ' + e.CAT_US_APELLIDO_PATERNO + ' ' + e.CAT_US_APELLIDO_MATERNO}</td>
            <td>${e.CAT_US_CORREO}</td>
            <td>${e.CAT_US_USUARIO}</td>
            <td>
                <div class="dropdown">
                    <a class="btn" href="#" role="button" id="dropdownMenuLink" data-bs-toggle="dropdown" aria-expanded="false">
                        <i class="fas fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu" aria-labelledby="dropdownMenuLink">
                        <li><span class="dropdown-item" onclick="llenarUsuarioEdit(${e.CAT_US_ID})" data-bs-toggle="modal" data-bs-target="#modalEditarUsuario">Editar</a></span>
                        <li><span class="dropdown-item" onclick="eliminarUsuario(${e.CAT_US_ID})" >Eliminar</a></span>
                    </ul>
                </div>
               </td>
            </tr>`
            })
            $('#tablaUsuariosBody').empty().append(tabla);
        },
        failure: function (response) {
            alert(response.d);
        }
    });
}

function llenarSelectEquipos() {
    $.ajax({
        type: "POST",
        url: "../api/Equipos",
        data: '{ACCION: "ListaEscuadrones"}',
        datatype: 'JSON',
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            options = "<option value='0'>Seleccione</option>"
            $.map(response, (e) => {
                options += `
                  <option value="${e.CAT_ESC_ID}">${e.CAT_ESC_NOMBRE}</option>
                            `
            })
            $('.slc_equipos').empty().append(options);
        },
        failure: function (response) {
            alert(response.d);
        }
    });
}

function llenarUsuarioEdit(id) {
    $.ajax({
        type: "POST",
        url: "../api/Usuarios",
        data: '{ACCION: "BuscarUsuario",ID:' + id + '}',
        datatype: 'JSON',
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            let res = response[0]
            localStorage.setItem('edit_id', res.CAT_US_ID)
            $('#edit_nombre').val(res.CAT_US_NOMBRE);
            $('#edit_ap_paterno').val(res.CAT_US_APELLIDO_PATERNO);
            $('#edit_ap_materno').val(res.CAT_US_APELLIDO_MATERNO);
            $('#edit_usuario').val(res.CAT_US_USUARIO);
            $('#edit_correo').val(res.CAT_US_CORREO);
            $('#edit_contrasenia').val(res.CAT_US_CONTRASENIA);
            $('#edit_slc_equipo').val(res.FK_CAT_ESC_ID == null ? 0 : res.FK_CAT_ESC_ID);
            validarModulos(res.CAT_US_MODULOS)
        },
        failure: function (response) {
            alert(response.d);
        }
    });
}


function validarModulos(cadenaModulos) {
    cadenaModulos = cadenaModulos.split(",")
    cadenaModulos[0] == '1' ? $("#M_Administrador_edit").prop("checked", true) : $("#M_Administrador_edit").prop("checked", false)
    cadenaModulos[1] == '1' ? $("#M_Desarrollo_edit").prop("checked", true) : $("#M_Desarrollo_edit").prop("checked", false)
    cadenaModulos[2] == '1' ? $("#M_Soporte_edit").prop("checked", true) : $("#M_Soporte_edit").prop("checked", false)
}

function editarUsuario() {
    let id = localStorage.getItem('edit_id')

    let modulos = $("#M_Administrador_edit").prop("checked") == true ? "1,":"0,"
     modulos += $("#M_Desarrollo_edit").prop("checked") == true ? "1,":"0,"
     modulos += $("#M_Soporte_edit").prop("checked") == true ? "1" : "0"

    objUsuario = {
        ID: id,
        NOMBRE: $('#edit_nombre').val(),
        APELLIDO_PATERNO: $('#edit_ap_paterno').val(),
        APELLIDO_MATERNO: $('#edit_ap_materno').val(),
        CORREO: $('#edit_correo').val(),
        CONTRASENIA: $('#edit_contrasenia').val(),
        USUARIO: $('#edit_usuario').val(),
        EQUIPO: $('#edit_slc_equipo').val(),
        MODULOS: modulos
    }
    console.log(objUsuario);
    $.ajax({
        type: "POST",
        url: "../api/Usuarios",
        data: '{ACCION: "EditarUsuario",USUARIO:' + JSON.stringify(objUsuario) + '}',
        datatype: 'JSON',
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            let res = response[0]

            if (res.estatus == 'Actualizado') {
                Swal.fire({
                    icon: 'success',
                    title: 'Usuario actualizado exitosamente',
                    showConfirmButton: false,
                    timer: 2000
                })
                llenarTablaUsuarios();

            } else {
                Swal.fire({
                    icon: 'error',
                    title: 'No se puedo realizar la actualización del usuario',
                    showConfirmButton: false,
                    timer: 2000
                })
            }
        },
        failure: function (response) {
            alert(response.d);
        }
    });

}

function agregarUsuario() {

       let modulos = $("#M_Administrador_add").prop("checked") == true ? "1,":"0,"
     modulos += $("#M_Desarrollo_add").prop("checked") == true ? "1,":"0,"
     modulos += $("#M_Soporte_add").prop("checked") == true ? "1" : "0"

    objUsuario = {
        NOMBRE: $('#add_nombre').val(),
        APELLIDO_PATERNO: $('#add_ap_paterno').val(),
        APELLIDO_MATERNO: $('#add_ap_materno').val(),
        CORREO: $('#add_correo').val(),
        CONTRASENIA: $('#add_contrasenia').val(),
        USUARIO: $('#add_usuario').val(),
        EQUIPO: $('#add_slc_equipo').val(),
        MODULOS: modulos
    }

    $.ajax({
        type: "POST",
        url: "../api/Usuarios",
        data: '{ACCION: "AgregarUsuario",USUARIO:' + JSON.stringify(objUsuario) + '}',
        datatype: 'JSON',
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            let res = response[0]

            if (res.estatus == 'Insertado') {
                Swal.fire({
                    icon: 'success',
                    title: 'Usuario agregado exitosamente',
                    showConfirmButton: false,
                    timer: 2000
                })
                llenarTablaUsuarios();

            } else {
                Swal.fire({
                    icon: 'error',
                    title: 'No se puedo realizar la actualización del usuario',
                    showConfirmButton: false,
                    timer: 2000
                })
            }
        },
        failure: function (response) {
            alert(response.d);
        }
    });
}

function eliminarUsuario(id) {
    objUsuario = {
        ID: id
    }
    console.log(objUsuario)
    const swalWithBootstrapButtons = Swal.mixin({
        customClass: {
            confirmButton: 'btn btn-success',
            cancelButton: 'btn btn-danger'
        },
        buttonsStyling: false
    })

    swalWithBootstrapButtons.fire({
        title: '¿Esta seguro que quiere eliminar este registro?',
        text: "Una vez que sea eliminado no podra recuperarse",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonText: 'Si, quiero eliminarlo',
        cancelButtonText: 'No, ya me arrepenti',
        reverseButtons: true
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: "POST",
                url: "../api/Usuarios",
                data: '{ACCION: "desactivarUsuario",USUARIO:' + JSON.stringify(objUsuario) + '}',
                datatype: 'JSON',
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    let res = response[0]

                    if (res.estatus == 'Desactivado') {
                        Swal.fire({
                            icon: 'success',
                            title: 'Registro eliminado exitosamente',
                            showConfirmButton: false,
                            timer: 2000
                        })
                        llenarTablaUsuarios();

                    } else {
                        Swal.fire({
                            icon: 'error',
                            title: 'No se puedo realizar la actualización del usuario',
                            showConfirmButton: false,
                            timer: 2000
                        })
                    }
                },
                failure: function (response) {
                    alert(response.d);
                }
            });
     
        } else if (
            /* Read more about handling dismissals below */
            result.dismiss === Swal.DismissReason.cancel
        ) {
            swalWithBootstrapButtons.fire(
                'Cancelled',
                'Your imaginary file is safe :)',
                'error'
            )
        }
    })
   
}

function cerrarSesion() {
    $.ajax({
        type: "POST",
        url: "../api/App",
        data: '{ACCION: "CERRARSESION"}',
        datatype: 'JSON',
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            location.href = "../login.aspx"
        },
        failure: function (response) {
            alert(response.d);
        }
    });
}