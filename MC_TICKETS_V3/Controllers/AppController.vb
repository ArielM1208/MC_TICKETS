Imports System.Net
Imports System.Web.Http
Imports MC_TICKETS_V3.Db
Imports System.Data.SqlClient


Namespace Controllers
    Public Class AppController
        Inherits ApiController
        Public Function PostValue(<FromBody()> ByVal value As AppModel)
            Dim ObjSalida As Dictionary(Of String, String) = New Dictionary(Of String, String)()

            Select Case value.ACCION
                Case "INICIARSESION"
                    Dim cmd As New SqlCommand()
                    cmd.CommandText = "SP_CONTROL_USUARIOS"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@accion", SqlDbType.VarChar).Value = "InicioSesion"
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = value.USUARIO.USUARIO
                    cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar).Value = value.USUARIO.CONTRASENIA
                    Dim data As DataTable = Consulta_Procedure(cmd, "InicioSesion")
                    If (data.Rows(0).Item("Estatus") = "Exito") Then
                        Dim User As New Usuario("", "", "", "", "", "", "", "", "")

                        Dim row As DataRow = data.Rows(data.Rows.Count - 1)
                        User.MODULOS = CStr(row("CAT_US_MODULOS"))
                        User.APELLIDO_MATERNO = CStr(row("CAT_US_APELLIDO_MATERNO"))
                        User.APELLIDO_PATERNO = CStr(row("CAT_US_APELLIDO_PATERNO"))
                        User.CONTRASENIA = CStr(row("CAT_US_CONTRASENIA"))
                        User.CORREO = CStr(row("CAT_US_CORREO"))
                        User.ID = CStr(row("CAT_US_ID"))
                        User.NOMBRE = CStr(row("CAT_US_NOMBRE"))
                        User.EQUIPO = CStr(row("FK_CAT_ESC_ID"))
                        User.USUARIO = CStr(row("CAT_US_USUARIO"))

                        Dim session = HttpContext.Current.Session
                        session.Add("Usuario", User)

                        ObjSalida("ESTATUS") = "Exito"

                    Else
                        ObjSalida("ESTATUS") = "Usuario no encontrado"
                    End If
                Case "CERRARSESION"
                    Dim session = HttpContext.Current.Session
                    session.Abandon()

                    ObjSalida("ESTATUS") = "Sesion cerrada"

                Case ""
                    ObjSalida("ESTATUS") = "Sin accion"
            End Select

            Return ObjSalida

        End Function

    End Class

End Namespace