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
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 19px; top: 461px; position: absolute; width: 48px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 53px; top: 568px; position: absolute; height: 29px" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 210px; top: 569px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 93px; top: 461px; position: absolute; width: 58px; right: 2337px;" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 426px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 174px; top: 461px; position: absolute" Text="Delete" />
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 24px; top: 522px; position: absolute" Text="Enter an Order Status"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 214px; top: 516px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
