<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

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
        style="z-index: 1; left: 359px; top: 267px; position: absolute" 
        Text="Password"></asp:Label>
    <asp:Label ID="Label2" runat="server" 
        
        style="z-index: 1; left: 365px; top: 161px; position: absolute; height: 19px;" 
        Text="User Id"></asp:Label>
    <asp:Button ID="Button1" runat="server"  
        style="z-index: 1; left: 411px; top: 340px; position: absolute;" 
        Text="OK" onclick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" 
        style="z-index: 1; left: 595px; top: 341px; position: absolute" 
        Text="Cancel" />
    <asp:TextBox ID="TextBox1" runat="server" 
        style="z-index: 1; left: 466px; top: 161px; position: absolute"></asp:TextBox>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <asp:TextBox ID="TextBox2" runat="server" 
        style="z-index: 1; left: 468px; top: 268px; position: absolute"></asp:TextBox>
    <asp:HyperLink ID="HyperLink1" runat="server" 
        NavigateUrl="~/selectedcandidate.aspx" 
        style="z-index: 1; left: 709px; top: 160px; position: absolute; bottom: 368px">Show Selected Candidates</asp:HyperLink>
    </form>
</body>
</html>
