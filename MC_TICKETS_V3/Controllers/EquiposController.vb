Imports System.Net
Imports System.Web.Http
Imports MC_TICKETS_V3.Db
Imports System.Data.SqlClient

Public Class EquiposController
    Inherits ApiController

    Public Function PostValue(<FromBody()> ByVal value As AppModel)
        Select Case value.ACCION
            Case "ListaEscuadrones"
                Dim cmd As New SqlCommand()
                cmd.CommandText = "SP_CONTROL_ESCUADRONES"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@accion", SqlDbType.VarChar).Value = "ListaEscuadrones"
                Dim data As DataTable = Consulta_Procedure(cmd, "Usuarios")
                Return data
        End Select
    End Function

End Class
