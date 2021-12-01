<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViewPage.aspx.cs" Inherits="GridViewPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

   <span style="color: #009900">URL Routing</span></h1>  
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84"  
            BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2"  
            Width="788px" Height="80px">  
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />  
            <Columns>  
                <asp:TemplateField HeaderText="Title">  
                    <ItemTemplate>  
                        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="ArticleTitle" href='<%# GetRouteUrl("RouteForArticle", new {id = Eval("id"), Title= getTitle(Eval("Title"))})%>'  
                            Text='<%# Eval("Title") %>'>  
                        </asp:HyperLink>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Description">  
                    <ItemTemplate>  
                        <asp:Label ID="lblDesc" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Description")%>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Author">  
                    <ItemTemplate>  
                        <asp:Label ID="lblauthor" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Author")%>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
            </Columns>  
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />  
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />  
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />  
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />  
        </asp:GridView> 
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AspFormDBConnectionString %>" SelectCommand="SELECT * FROM [userTable]"></asp:SqlDataSource>
    

        </div>
    </form>
</body>
</html>
