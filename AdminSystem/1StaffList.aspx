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

            <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label>
            <br /><br />

            <asp:Button ID="btnMainMenu" runat="server" Text="Return to Main Menu" OnClick="btnMainMenu_Click" />
            <asp:Button ID="btnAdd" runat="server" Text="Add Staff" OnClick="btnAdd_Click" />
            <br /><br />

            <asp:Label ID="lblMessage" runat="server" Text="Staff list page loaded successfully."></asp:Label>
        </div>
    </form>
</body>
</html>