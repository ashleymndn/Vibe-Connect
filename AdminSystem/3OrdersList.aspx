<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrdersList" runat="server" style="z-index: 1; left: 21px; top: 62px; position: absolute; height: 399px; width: 662px"></asp:ListBox>
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 24px; top: 518px; position: absolute; width: 48px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 74px; top: 617px; position: absolute; height: 28px" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 213px; top: 616px; position: absolute; height: 28px;" Text="Clear Filter" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 96px; top: 519px; position: absolute; width: 58px; right: 1663px;" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 477px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 179px; top: 519px; position: absolute" Text="Delete" />
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 25px; top: 578px; position: absolute" Text="Enter an Order Status"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 210px; top: 574px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 498px; top: 617px; position: absolute; height: 28px" Text="Return to Main Menu" />
    </form>
</body>
</html>
