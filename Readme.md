<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx](./CS/Dashboard_ConfigureDataConnection_Web/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/Dashboard_ConfigureDataConnection_Web/WebForm1.aspx))
* [WebForm1.aspx.cs](./CS/Dashboard_ConfigureDataConnection_Web/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/Dashboard_ConfigureDataConnection_Web/WebForm1.aspx.vb))
<!-- default file list end -->
# How to customize connection settings before ASPxDashboardViewer connects to a database


<p><strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br><br>This example demonstrates how to customize connection settings before <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebASPxDashboardViewertopic">ASPxDashboardViewer</a> connects to a database using the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboardViewer_ConfigureDataConnectiontopic">ConfigureDataConnection</a> event.</p>
<p>In this example, the dashboard visualizes data from the secured Microsoft Access database. To visualize data from this database file, it is necessary to provide connection parameters (a path to the database file, a user name and a password for authentication).</p>
<p>- The <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataAccessConnectionParametersFileConnectionParametersBase_FileNametopic">FileConnectionParametersBase.FileName</a> property specifies the path to a database file.<br>- The <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataAccessConnectionParametersAccess97ConnectionParameters_UserNametopic"><u>Access97ConnectionParameters.UserName</u></a> and <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataAccessConnectionParametersFileConnectionParametersBase_Passwordtopic"><u>FileConnectionParametersBase.Password</u></a> event parameters are used to provide the user name and password respectively.</p>

<br/>


