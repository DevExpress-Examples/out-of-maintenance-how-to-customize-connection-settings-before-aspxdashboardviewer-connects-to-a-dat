<%@ Page Language="C#" AutoEventWireup="true" 
                       CodeBehind="WebForm1.aspx.cs" 
                       Inherits="Dashboard_ConfigureDataConnection_Web.WebForm1" %>

<%@ Register Assembly="DevExpress.Dashboard.v15.1.Web, Version=15.1.7.0, 
                                                       Culture=neutral, 
                                                       PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server" 
            onconfiguredataconnection="ASPxDashboardViewer1_ConfigureDataConnection" 
            Height="800px" Width="1200px">
        </dx:ASPxDashboardViewer>
    </div>
    </form>
</body>
</html>
