<%@ Page Language="C#" AutoEventWireup="true" CodeFile="selectedcandidate.aspx.cs" Inherits="selectedcandidate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Password1
        {
            z-index: 1;
            left: 10px;
            top: 15px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" 
            style="z-index: 1; left: 339px; top: 123px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
    
    </div>
    </form>
    
</body>
</html>
