<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrdersList" runat="server" style="z-index: 1; left: 18px; top: 19px; position: absolute; height: 399px; width: 595px"></asp:ListBox>
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 19px; top: 461px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 84px; top: 461px; position: absolute; width: 58px" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 426px; position: absolute"></asp:Label>
    </form>
</body>
</html>
