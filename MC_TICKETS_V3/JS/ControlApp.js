function iniciarSesion() {
    let usuario = $('#usuario').val();
    let contrasenia = $('#contrasenia').val();

    if (usuario == "" || contrasenia == "") {
        Swal.fire(
            'Campos insuficientes para acceso',
            'Favor de llevar los campos para ingresar a la plataforma',
            'warning'
        )
        return false;
    }
    objUsuario = {
        USUARIO: usuario,
        CONTRASENIA: contrasenia,
    };

    $.ajax({
        type: "POST",
        url: "api/App",
        data: '{ACCION: "INICIARSESION",USUARIO:' + JSON.stringify(objUsuario) + '}',
        datatype: 'JSON',
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            if (response.ESTATUS == "Exito") {
                Swal.fire(
                    'Bienvenido',
                    'Espere un momento...',
                    'success'
                ).then(() => {
                    location.href = "inicio.aspx"
                })
            } else {
                Swal.fire(
                    'Usuario no encontrado',
                    'Revise sus accesos',
                    'warning'
                )
            }
        },
        failure: function (response) {
            alert(response.d);
        }
    });
}

function cerrarSesion() {
    $.ajax({
        type: "POST",
        url: "api/App",
        data: '{ACCION: "CERRARSESION"}',
        datatype: 'JSON',
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            location.href = "login.aspx"
        },
        failure: function (response) {
            alert(response.d);
        }
    });
}