<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VibeConnect Main Menu</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>VibeConnect Main Menu</h2>

            <asp:Button ID="btnStaff" runat="server" Text="Staff" OnClick="btnStaff_Click" />
        </div>
    </form>
</body>
</html>
