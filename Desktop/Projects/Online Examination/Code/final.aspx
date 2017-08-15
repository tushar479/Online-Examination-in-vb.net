<%@ Page Language="C#" AutoEventWireup="true" CodeFile="final.aspx.cs" Inherits="final" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" 
            style="z-index: 1; left: 197px; top: 143px; position: absolute" 
            Text="Correct Answers"></asp:Label>
        
            <asp:Label ID="Label9" runat="server" 
                style="z-index: 1; left: 407px; top: 187px; position: absolute" Text="Name"></asp:Label>
            <asp:Label ID="Label10" runat="server" 
                style="z-index: 1; left: 204px; top: 63px; position: absolute" Text="Name"></asp:Label>
        
        <asp:Label ID="Label4" runat="server" 
            style="z-index: 1; left: 410px; top: 66px; position: absolute" Text="Name"></asp:Label>
        <asp:Label ID="Label7" runat="server" 
            style="z-index: 1; left: 407px; top: 224px; position: absolute" Text="Name"></asp:Label>
        <asp:Label ID="Label8" runat="server" 
            style="z-index: 1; left: 409px; top: 139px; position: absolute" Text="Name"></asp:Label>
    
    </div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label11" runat="server" 
            style="z-index: 1; left: 202px; top: 106px; position: absolute" 
            Text="Marks Obtained"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label13" runat="server" 
            style="z-index: 1; left: 201px; top: 187px; position: absolute" 
            Text="InCorrecrt Answers"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" 
            style="z-index: 1; left: 410px; top: 103px; position: absolute; height: 25px" 
            Text="Name"></asp:Label>
        <asp:Label ID="Label12" runat="server" 
            style="z-index: 1; left: 198px; top: 228px; position: absolute" 
            Text="Not Attempted"></asp:Label>
    </p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        style="z-index: 1; left: 334px; top: 300px; position: absolute" 
        Text="Submit" />
    </form>
</body>
</html>
