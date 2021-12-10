Imports System.Net
Imports System.Web.Http
Imports MC_TICKETS_V3.Db
Imports System.Data.SqlClient


Public Class RolesController
    Inherits ApiController
    ' POST api/<controller>
    Public Function PostValue(<FromBody()> ByVal value As AppModel)
        Select Case value.ACCION
            Case "ListaRoles"
                Dim cmd As New SqlCommand()
                cmd.CommandText = "SP_CONTROL_ROLES"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@accion", SqlDbType.VarChar).Value = "ListaRoles"
                Dim data As DataTable = Consulta_Procedure(cmd, "Roles")
                Return data
            Case "ObtenerRol"
                Dim cmd As New SqlCommand()
                cmd.CommandText = "SP_CONTROL_ROLES"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@accion", SqlDbType.VarChar).Value = "ObtenerRol"
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = value.ROL.ID
                Dim data As DataTable = Consulta_Procedure(cmd, "Roles")
                Return data
        End Select
    End Function
End Class
