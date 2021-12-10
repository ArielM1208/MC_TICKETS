Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim usuario As Usuario = Session("Usuario")
        If (usuario Is Nothing) Then
            Response.Redirect("login.aspx")
        End If
        validarModulos(usuario.MODULOS)

    End Sub

    Function validarModulos(modulos As String)
        Dim ArrCadena As String() = modulos.Split(",")
        For i = 0 To ArrCadena.Length
            Select Case i
                Case 0
                    If (ArrCadena(i) = "1") Then
                        pnl_admin.Visible = True
                    End If
                Case 1
                    If (ArrCadena(i) = "1") Then
                        pnl_desarrollo.Visible = True
                    End If
                Case 2
                    If (ArrCadena(i) = "1") Then
                        pnl_soporte.Visible = True
                    End If
            End Select
        Next
    End Function
End Class