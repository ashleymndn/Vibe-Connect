<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1StaffConfirmDelete.aspx.cs" Inherits="_1StaffConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete Staff</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Confirm Delete</h2>

            <asp:Label ID="lblMessage" runat="server" Text="Are you sure you want to delete this staff record?"></asp:Label>
            <br /><br />

            <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>