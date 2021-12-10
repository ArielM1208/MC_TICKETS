Imports System.Net
Imports System.Web.Http
Imports MC_TICKETS_V3.Db
Imports System.Data.SqlClient


Public Class UsuariosController
    Inherits ApiController

    Public Function PostValue(<FromBody()> ByVal value As AppModel)
        Select Case value.ACCION
            Case "ListaUsuarios"
                Dim cmd As New SqlCommand()
                cmd.CommandText = "SP_CONTROL_USUARIOS"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@accion", SqlDbType.VarChar).Value = "ListaUsuarios"
                Dim data As DataTable = Consulta_Procedure(cmd, "Usuarios")
                Return data
            Case "BuscarUsuario"
                Dim cmd As New SqlCommand()
                cmd.CommandText = "SP_CONTROL_USUARIOS"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@accion", SqlDbType.VarChar).Value = "BuscarUsuario"
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = value.ID
                Dim data As DataTable = Consulta_Procedure(cmd, "Usuario")
                Return data
            Case "AgregarUsuario"
                Dim cmd As New SqlCommand()
                cmd.CommandText = "SP_CONTROL_USUARIOS"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@accion", SqlDbType.VarChar).Value = "AgregarUsuario"
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = value.USUARIO.NOMBRE
                cmd.Parameters.Add("@apPaterno", SqlDbType.VarChar).Value = value.USUARIO.APELLIDO_PATERNO
                cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = value.USUARIO.CORREO
                cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar).Value = value.USUARIO.CONTRASENIA
                cmd.Parameters.Add("@apMaterno", SqlDbType.VarChar).Value = value.USUARIO.APELLIDO_MATERNO
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = value.USUARIO.USUARIO
                cmd.Parameters.Add("@equipo", SqlDbType.VarChar).Value = value.USUARIO.EQUIPO
                cmd.Parameters.Add("@modulos", SqlDbType.VarChar).Value = value.USUARIO.MODULOS

                Dim data As DataTable = Consulta_Procedure(cmd, "DatosUsuario")
                Return data
            Case "EditarUsuario"
                Dim cmd As New SqlCommand()
                cmd.CommandText = "SP_CONTROL_USUARIOS"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@accion", SqlDbType.VarChar).Value = "EditarUsuario"
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = value.USUARIO.ID
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = value.USUARIO.NOMBRE
                cmd.Parameters.Add("@apPaterno", SqlDbType.VarChar).Value = value.USUARIO.APELLIDO_PATERNO
                cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = value.USUARIO.CORREO
                cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar).Value = value.USUARIO.CONTRASENIA
                cmd.Parameters.Add("@apMaterno", SqlDbType.VarChar).Value = value.USUARIO.APELLIDO_MATERNO
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = value.USUARIO.USUARIO
                cmd.Parameters.Add("@equipo", SqlDbType.VarChar).Value = value.USUARIO.EQUIPO
                cmd.Parameters.Add("@modulos", SqlDbType.VarChar).Value = value.USUARIO.MODULOS

                Dim data As DataTable = Consulta_Procedure(cmd, "DatosUsuario")
                Return data
            Case "desactivarUsuario"
                Dim cmd As New SqlCommand()
                cmd.CommandText = "SP_CONTROL_USUARIOS"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@accion", SqlDbType.VarChar).Value = "desactivarUsuario"
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = value.USUARIO.ID
                Dim data As DataTable = Consulta_Procedure(cmd, "Usuario")
                Return data
        End Select
    End Function

End Class
