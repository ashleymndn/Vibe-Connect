<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VibeConnect Main Menu</title>
</head>
<body style="height: 173px">
    <form id="form1" runat="server">
        <div>
        <div>
            <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 209px; top: 37px; position: absolute" Text="Vibe Connect Main Menu"></asp:Label>
        </div>
            <asp:Button ID="btnStaff" runat="server" height="29px" OnClick="btnStaff_Click" style="z-index: 1; left: 47px; top: 88px; position: absolute; right: 1669px" Text="Staff" width="101px" />
            <asp:Button ID="btnInventory" runat="server" height="29px" OnClick="btnInventory_Click" style="z-index: 1; left: 182px; top: 87px; position: absolute; right: 1534px" Text="Inventory" width="101px" />
            <asp:Button ID="btnOrders" runat="server" height="29px" OnClick="btnOrders_Click" style="z-index: 1; left: 324px; top: 87px; position: absolute; right: 1392px" Text="Orders" width="101px" />
            <asp:Button ID="btnCustomers" runat="server" height="29px" OnClick="btnCustomers_Click" style="z-index: 1; left: 460px; top: 87px; position: absolute" Text="Customers" width="101px" />
        </div>
    </form>
</body>
</html>
