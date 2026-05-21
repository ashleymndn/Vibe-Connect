<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2InventoryList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstAddressList" runat="server" style="z-index: 1; left: 16px; top: 14px; position: absolute; width: 261px; height: 281px" OnSelectedIndexChanged="lstAddressList_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 27px; top: 328px; position: absolute" Text="Add" />
    </form>
</body>
</html>
