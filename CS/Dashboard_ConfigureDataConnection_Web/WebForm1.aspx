﻿<%@ Page Language="C#" AutoEventWireup="true" 
                       CodeBehind="WebForm1.aspx.cs" 
                       Inherits="Dashboard_ConfigureDataConnection_Web.WebForm1" %>

<%@ Register Assembly="DevExpress.Dashboard.v14.2.Web, Version=14.2.4.0, 
                                                       Culture=neutral, 
                                                       PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
                      "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server" 
            onconfiguredataconnection="ASPxDashboardViewer1_ConfigureDataConnection" 
            Height="600px" Width="1200px">
        </dx:ASPxDashboardViewer>
    </div>
    </form>
</body>
</html>
