<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="username" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:BoundField DataField="username" HeaderText="username" ReadOnly="True" SortExpression="username" />
        <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
        <asp:BoundField DataField="firstname" HeaderText="firstname" SortExpression="firstname" />
        <asp:BoundField DataField="lastname" HeaderText="lastname" SortExpression="lastname" />
        <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
        <asp:BoundField DataField="state" HeaderText="state" SortExpression="state" />
        <asp:BoundField DataField="mobile" HeaderText="mobile" SortExpression="mobile" />
        <asp:BoundField DataField="birthdate" HeaderText="birthdate" SortExpression="birthdate" />
        <asp:BoundField DataField="remark" HeaderText="remark" SortExpression="remark" />
    </Columns>
</asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AspFormDBConnectionString %>" SelectCommand="SELECT * FROM [userTable]"></asp:SqlDataSource>


</asp:Content>

