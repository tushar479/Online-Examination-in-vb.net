<%@ Page Language="C#" AutoEventWireup="true" CodeFile="testpage1.aspx.cs" Inherits="testpage1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" 
            
            style="z-index: 1; left: 234px; top: 71px; position: absolute; right: 748px;" 
            Text="2."></asp:Label>
        <asp:Label ID="Label3" runat="server" 
            style="z-index: 1; left: 278px; top: 72px; position: absolute; width: 731px" 
            Text="Label" Font-Bold="True"></asp:Label>
    
    
    
   
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
        
            style="z-index: 1; left: 293px; top: 123px; position: absolute; height: 27px; width: 284px; bottom: 376px" 
            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
            RepeatColumns="1">
    </asp:RadioButtonList>
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        style="z-index: 1; left: 169px; top: 290px; position: absolute" 
        Text="Back" />
    
    </div>
    
        <asp:Button ID="Button1" runat="server" 
            style="z-index: 1; top: 292px; position: absolute; right: 603px;" 
            Text="Next" onclick="Button1_Click" />
    
    </form>
</body>
</html>
