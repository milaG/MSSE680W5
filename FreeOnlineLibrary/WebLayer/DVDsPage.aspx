<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DVDsPage.aspx.cs" Inherits="WebLayer.DVDsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>List of all DVDs Available in the Library<br />
        </strong>
    
    </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="DomainLayer.DVD" DeleteMethod="Delete" InsertMethod="InsertDVD" SelectMethod="GetAll" TypeName="BusinessLayer.ManagerDVD" UpdateMethod="Update"></asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="DvdId" HeaderText="DvdId" SortExpression="DvdId" />
                <asp:BoundField DataField="DvdTitle" HeaderText="DvdTitle" SortExpression="DvdTitle" />
                <asp:BoundField DataField="DvdSummary" HeaderText="DvdSummary" SortExpression="DvdSummary" />
                <asp:BoundField DataField="DvdRating" HeaderText="DvdRating" SortExpression="DvdRating" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/MembersPage.aspx" style="font-weight: 700">Go to Members List</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/BooksPage.aspx" style="font-weight: 700">Go to Books List</asp:HyperLink>
    </form>
</body>
</html>
