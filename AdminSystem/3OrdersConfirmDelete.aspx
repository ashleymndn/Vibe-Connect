<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 88px; top: 120px; position: absolute; width: 85px; height: 30px" Text="Yes" />
            <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 43px; top: 61px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 208px; top: 120px; position: absolute; width: 85px; height: 30px" Text="No" />
    </form>
</body>
</html>
