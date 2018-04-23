Imports System
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.ConnectionParameters

Namespace Dashboard_ConfigureDataConnection_Web
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim dashboardPath As String = Server.MapPath("~/App_Data/nwindDashboard.xml")
            ASPxDashboardViewer1.DashboardSource = dashboardPath
        End Sub

        Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(ByVal sender As Object, _
                                           ByVal e As ConfigureDataConnectionWebEventArgs)
            ' Checks the name of the connection for which the event has been raised.
            If e.DataSourceName = "SQL Data Source 1" Then
                ' Gets the connection parameters used to establish a connection to the database.
                Dim parameters As Access97ConnectionParameters =
                    CType(e.ConnectionParameters, Access97ConnectionParameters)

                ' Specifies the path to a database file.
                Dim filePath As String = Server.MapPath("~/App_Data/nwind.mdb")
                parameters.FileName = filePath

                ' Specifies the user name used to access the database file. 
                parameters.UserName = "Admin"

                ' Specifies the password used to access the database file.
                parameters.Password = "password"
            End If
        End Sub
    End Class
End Namespace