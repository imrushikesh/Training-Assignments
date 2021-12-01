<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Repeater.aspx.cs" Inherits="Repeater" %>




<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1" >
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AspFormDBConnectionString %>" SelectCommand="SELECT * FROM [userTable]"></asp:SqlDataSource>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1" OnItemCommand="Repeater1_ItemCommand">
       
          <HeaderTemplate> Department Data 
              <br />
        <table>
            <thead>
                <th>username</th>
                  <th>password</th>
            </thead>
       


          </HeaderTemplate>  
        <ItemTemplate >
            <tr style="background-color:aqua">
                <td>
                 <asp:Label runat="server" ID="one" Text='<%#Bind("username")%>'></asp:Label> </td>
                   <td>
               <asp:Label runat="server"  ID="two" Text='<%#Bind("password")%>'></asp:Label>
                    </td>
            </tr>
        </ItemTemplate>
        <AlternatingItemTemplate>

              <tr>
                <td>
                 <asp:Label runat="server"  ID="three" Text='<%#Bind("username")%>'></asp:Label> </td>
                   <td>
               <asp:Label runat="server"  ID="four" Text='<%#Bind("password")%>'></asp:Label>
                    </td>
            </tr>

        </AlternatingItemTemplate>

            <FooterTemplate>
                <td colspan="4"> end</td>
                </table>
            </FooterTemplate>
        
        
        </asp:Repeater>



</asp:Content>