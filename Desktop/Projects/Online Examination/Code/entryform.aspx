<%@ Page Language="C#" AutoEventWireup="true" CodeFile="entryform.aspx.cs" Inherits="entryform" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Label ID="Label1" runat="server" 
        style="z-index: 1; left: 598px; top: 94px; position: absolute" Text="Test Date"></asp:Label>
    <p>
        <asp:Label ID="Label2" runat="server" 
            style="z-index: 1; left: 275px; top: 92px; position: absolute" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" 
            style="z-index: 1; left: 359px; top: 94px; position: absolute; width: 204px"></asp:TextBox>
    </p>
    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
        style="z-index: 1; left: 434px; top: 179px; position: absolute">Start Test</asp:LinkButton>
    </form>
</body>
</html>
