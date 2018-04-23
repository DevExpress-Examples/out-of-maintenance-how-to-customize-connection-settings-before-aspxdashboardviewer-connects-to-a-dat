using System;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;

namespace Dashboard_ConfigureDataConnection_Web {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string dashboardPath = Server.MapPath("~/App_Data/nwindDashboard.xml");
            ASPxDashboardViewer1.DashboardSource = dashboardPath;
        }

        protected void ASPxDashboardViewer1_ConfigureDataConnection(object sender, 
            ConfigureDataConnectionWebEventArgs e) {
            // Checks the name of the connection for which the event has been raised.
            if (e.DataSourceName == "SQL Data Source 1") {
                // Gets the connection parameters used to establish a connection to the database.
                Access97ConnectionParameters parameters =
                    (Access97ConnectionParameters)e.ConnectionParameters;

                // Specifies the path to a database file.
                string filePath = Server.MapPath("~/App_Data/nwind.mdb");
                parameters.FileName = filePath;

                // Specifies the user name used to access the database file. 
                parameters.UserName = "Admin";

                // Specifies the password used to access the database file.
                parameters.Password = "password";
            }
        }
    }
}