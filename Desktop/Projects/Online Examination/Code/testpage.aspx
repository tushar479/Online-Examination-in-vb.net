<%@ Page Language="C#" AutoEventWireup="true" CodeFile="testpage.aspx.cs" Inherits="testpage" %>

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
            Text="1."></asp:Label>
        <asp:Label ID="Label3" runat="server" 
            style="z-index: 1; left: 309px;top: 72px; position: absolute; width: 651px" 
            Text="Label" Font-Bold="True"></asp:Label>
    
    
    
   
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
        
            style="z-index: 1; left: 298px; top: 113px; position: absolute; height: 27px; width: 196px; bottom: 407px" 
            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged1" 
            RepeatColumns="1">
    </asp:RadioButtonList>
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        style="z-index: 1; left: 169px; top: 271px; position: absolute" 
        Text="Back" />
    
        <asp:Button ID="Button1" runat="server" 
            style="z-index: 1; left: 307px; top: 271px; position: absolute" 
            Text="Next" onclick="Button1_Click" />
    
     </div>
    </form>
    </body>
</html>
