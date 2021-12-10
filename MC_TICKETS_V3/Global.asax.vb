﻿Imports System.Web.Http

Public Class Global_asax
    Inherits HttpApplication

    Sub Application_Start(sender As Object, e As EventArgs)
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
    End Sub
    Sub Application_PostAuthorizeRequest()
        HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Required)
    End Sub
End Class