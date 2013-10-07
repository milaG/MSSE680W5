<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MembersPage.aspx.cs" Inherits="WebLayer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="DomainLayer.Member" DeleteMethod="Delete" InsertMethod="InsertMember" SelectMethod="GetAll" TypeName="BusinessLayer.ManagerMember" UpdateMethod="Update"></asp:ObjectDataSource>
        <strong>List of All Members </strong>
        <br />
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="memberId" HeaderText="memberId" SortExpression="memberId" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="Phonenumber" HeaderText="Phonenumber" SortExpression="Phonenumber" />
                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/BooksPage.aspx" style="font-weight: 700">Go to Book List</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/DVDsPage.aspx" style="font-weight: 700">Go to the DVDs List</asp:HyperLink>
    </form>
</body>
</html>
