Public Class Rol
    Public Sub New(
           ByVal ID As String,
           ByVal ROL As String,
           ByVal MODULOS As String
        )

        Me._ID = ID
        Me._ROL = ROL
        Me._MODULOS = MODULOS

    End Sub

    Private _ID As String
    Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property


    Private _ROL As String
    Property ROL() As String
        Get
            Return _ROL
        End Get
        Set(ByVal value As String)
            _ROL = value
        End Set
    End Property


    Private _MODULOS As String
    Property MODULOS() As String
        Get
            Return _MODULOS
        End Get
        Set(ByVal value As String)
            _MODULOS = value
        End Set
    End Property
End Class
