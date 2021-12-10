Imports System.Data
Imports Microsoft.VisualBasic

Public Class Usuario
    Public Sub New(
           ByVal ID As String,
           ByVal NOMBRE As String,
           ByVal APELLIDO_PATERNO As String,
           ByVal APELLIDO_MATERNO As String,
           ByVal CORREO As String,
           ByVal CONTRASENIA As String,
           ByVal USUARIO As String,
           ByVal EQUIPO As String,
           ByVal MODULOS As String
        )

        Me._ID = ID
        Me._NOMBRE = NOMBRE
        Me._APELLIDO_PATERNO = APELLIDO_PATERNO
        Me._APELLIDO_MATERNO = APELLIDO_MATERNO
        Me._CORREO = CORREO
        Me._CONTRASENIA = CONTRASENIA
        Me._USUARIO = USUARIO
        Me._EQUIPO = EQUIPO
        Me._MODULOS = MODULOS
    End Sub

    Private _EQUIPO As String
    Property EQUIPO() As String
        Get
            Return _EQUIPO
        End Get
        Set(ByVal value As String)
            _EQUIPO = value
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
    Private _NOMBRE As String
    Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal value As String)
            _NOMBRE = value
        End Set
    End Property
    Private _APELLIDO_PATERNO As String
    Property APELLIDO_PATERNO() As String
        Get
            Return _APELLIDO_PATERNO
        End Get
        Set(ByVal value As String)
            _APELLIDO_PATERNO = value
        End Set
    End Property
    Private _APELLIDO_MATERNO As String
    Property APELLIDO_MATERNO() As String
        Get
            Return _APELLIDO_MATERNO
        End Get
        Set(ByVal value As String)
            _APELLIDO_MATERNO = value
        End Set
    End Property
    Private _CORREO As String
    Property CORREO() As String
        Get
            Return _CORREO
        End Get
        Set(ByVal value As String)
            _CORREO = value
        End Set
    End Property
    Private _CONTRASENIA As String
    Property CONTRASENIA() As String
        Get
            Return _CONTRASENIA
        End Get
        Set(ByVal value As String)
            _CONTRASENIA = value
        End Set
    End Property
    Private _USUARIO As String
    Property USUARIO() As String
        Get
            Return _USUARIO
        End Get
        Set(ByVal value As String)
            _USUARIO = value
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
