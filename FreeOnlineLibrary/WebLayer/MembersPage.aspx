<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MembersPage.aspx.cs" Inherits="WebLayer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-decoration: underline">
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="DomainLayer.Member" DeleteMethod="Delete" InsertMethod="InsertMember" SelectMethod="GetAll" TypeName="BusinessLayer.ManagerMember" UpdateMethod="Update"></asp:ObjectDataSource>
        <strong>List of All Members 
        <br />
        <br />
        <br />
        </strong>
        First Name:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Last Name:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLinkAllMembers" runat="server" NavigateUrl="~/MembersDatabase.aspx">List of all Members</asp:HyperLink>
        <br />
    
    </div>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/BooksPage.aspx" style="font-weight: 700">Go to Book List</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/DVDsPage.aspx" style="font-weight: 700">Go to the DVDs List</asp:HyperLink>
    </form>
</body>
</html>
