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

    <asp:Button ID="btnDelete"
        runat="server"
        Text="Delete"
        OnClick="btnDelete_Click" />

    <asp:Button ID="btnMainMenu"
    runat="server"
    Text="Return to Main Menu"
    OnClick="btnMainMenu_Click" />



    <br /><br />

<asp:Label ID="lblCustomerName"
    runat="server"
    Text="Customer Name">
</asp:Label>

<asp:TextBox ID="txtCustomerNameFilter"
    runat="server">
</asp:TextBox>

<asp:Button ID="btnApply"
    runat="server"
    Text="Apply Filter"
    OnClick="btnApply_Click" />

<asp:Button ID="btnClear"
    runat="server"
    Text="Clear Filter"
    OnClick="btnClear_Click" />

    
    <br /><br />

    <asp:Label ID="lblError"
        runat="server"
        Text=""></asp:Label>
</div>
    </form>
</body>
</html>
