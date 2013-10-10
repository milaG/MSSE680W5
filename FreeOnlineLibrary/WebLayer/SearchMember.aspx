<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchMember.aspx.cs" Inherits="WebLayer.SearchMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Search Members<br />
        <br />
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Enter Member First name"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="memberId" HeaderText="memberId" SortExpression="memberId" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="Phonenumber" HeaderText="Phonenumber" SortExpression="Phonenumber" />
                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SearchByFirstName" TypeName="BusinessLayer.ManagerMember">
            <SelectParameters>
                <asp:SessionParameter Name="firstName" SessionField="ObjectParameterName" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
