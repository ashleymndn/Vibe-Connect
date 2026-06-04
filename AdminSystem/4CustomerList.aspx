<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ListBox ID="lstCustomerList" runat="server"></asp:ListBox>

    <br /><br />

    <asp:Button ID="btnAdd"
        runat="server"
        Text="Add"
        OnClick="btnAdd_Click" />

    <asp:Button ID="btnEdit"
        runat="server"
        Text="Edit"
        OnClick="btnEdit_Click" />

    <br /><br />

    <asp:Label ID="lblError"
        runat="server"
        Text=""></asp:Label>
</div>
    </form>
</body>
</html>
