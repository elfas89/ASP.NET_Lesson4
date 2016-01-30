<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Less_4.Default" %>
<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="ctrl" TagName="Control1" %>
<%@ Register Assembly="Less_4"  Namespace="Less_4" TagPrefix="my" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <ctrl:Control1 ID="Control1" runat="server" />

        <my:MyControl ID="myControl1" runat="server" />

    </form>
</body>
</html>
