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
        <asp:ListBox ID="lstInventoryList" runat="server" style="z-index: 1; left: 9px; top: 14px; position: absolute; width: 261px; height: 281px" OnSelectedIndexChanged="lstInventoryList_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 27px; top: 322px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 115px; top: 319px; position: absolute; height: 38px; width: 63px" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 26px; top: 377px; position: absolute; height: 23px; width: 92px" Text=""></asp:Label>
    </form>
</body>
</html>
    