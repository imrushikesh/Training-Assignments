<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

 <h1>Article</h1>  
        <b>Title:</b><asp:Label ID="lblTitle" runat="server" Text="Label" Font-Bold="true"  
            ForeColor="blue"></asp:Label><br />  
        AuthorName<b>:</b><asp:Label ID="lblauthor" runat="server" Text="Label" Font-Bold="true"  
            ForeColor="blue"></asp:Label>  
        <br />  
        <br />  
        <b>Description:</b><br />  
        <asp:Label ID="lblDescription" runat="server" Text="Label"></asp:Label><br />  
        <br />  
        <br />  
        <br />  


        </div>
    </form>
</body>
</html>
