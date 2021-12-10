Public Class AppModel
    Public Sub New(
 ByVal ACCION As String,
 ByVal ID As String,
 ByVal USUARIO As Usuario,
 ByVal ROL As Rol
 )
        Me._ID = ID
        Me._ACCION = ACCION
        Me._USUARIO = USUARIO
        Me._ROL = ROL
    End Sub

    Private _ROL As Rol
    Property ROL() As Rol
        Get
            Return _ROL
        End Get
        Set(ByVal value As Rol)
            _ROL = value
        End Set
    End Property

    Private _ID As String
    Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property

    Private _ACCION As String
    Property ACCION() As String
        Get
            Return _ACCION
        End Get
        Set(ByVal value As String)
            _ACCION = value
        End Set
    End Property

    Private _USUARIO As Usuario
    Property USUARIO() As Usuario
        Get
            Return _USUARIO
        End Get
        Set(ByVal value As Usuario)
            _USUARIO = value
        End Set
    End Property


End Class
