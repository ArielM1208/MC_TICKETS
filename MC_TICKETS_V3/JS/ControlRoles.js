function llenarTablaRoles() {
    $.ajax({
        type: "POST",
        url: "../api/Roles",
        data: '{ACCION: "ListaRoles"}',
        datatype: 'JSON',
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            let tabla = ''
            $.map(response, (e) => {
                tabla += `
            <tr>
            <th>${e.CAT_ROL_ID}</th>
            <td>${e.CAT_ROL_NOMBRE}</td>
            <td>
                <div class="dropdown">
                    <a class="btn" href="#" role="button" id="dropdownMenuLink" data-bs-toggle="dropdown" aria-expanded="false">
                        <i class="fas fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu" aria-labelledby="dropdownMenuLink">
                        <li><span class="dropdown-item" onclick="llenarRolEdit(${e.CAT_ROL_ID})" data-bs-toggle="modal" data-bs-target="#modalEditaRol">Editar</a></span>
                        <li><span class="dropdown-item" onclick="eliminarUsuario(${e.CAT_ROL_ID})" >Eliminar</a></span>
                    </ul>
                </div>
               </td>
            </tr>`
            })
            $('#tablaPermisosBody').empty().append(tabla);
        },
        failure: function (response) {
            alert(response);
        }
    });
}

function llenarRolEdit(id) {

    objRol = {
        ID : id
    }
    $.ajax({
        type: "POST",
        url: "../api/Roles",
        data: '{ACCION: "ObtenerRol",ROL:'+JSON.stringify(objRol)+'}',
        datatype: 'JSON',
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            console.log(response)

            let res = response[0];
            validarModulos(res.CAT_ROL_MODULOS)
        },
        failure: function (response) {
            alert(response);
        }
    });
}

function validarModulos(cadenaModulos) {
    cadenaModulos = cadenaModulos.split(",")
    cadenaModulos[0] == '1' ? $("#M_Administrador_edit").prop("checked", true) : $("#M_Administrador_edit").prop("checked", false)
    cadenaModulos[1] == '1' ? $("#M_Desarrollo_edit").prop("checked", true) : $("#M_Desarrollo_edit").prop("checked", false)
    cadenaModulos[2] == '1' ? $("#M_Soporte_edit").prop("checked", true) : $("#M_Soporte_edit").prop("checked", false)
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