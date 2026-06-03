<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Staff List</h2>

            <asp:Label ID="lblUserName" runat="server"></asp:Label>
            <br /><br />

            <asp:ListBox ID="lstStaffList" runat="server" Width="500px" Height="220px"></asp:ListBox>
            <br /><br />

            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <br /><br />

            <asp:Label ID="lblFilter" runat="server" Text="Filter by Role:"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
            <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" OnClick="btnClearFilter_Click" />
            <br /><br />

            <asp:Button ID="btnMainMenu" runat="server" Text="Return to Main Menu" OnClick="btnMainMenu_Click" />
            <br /><br />

            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>