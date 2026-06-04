<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2InventoryList.aspx.cs" Inherits="_1_InventoryList" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inventory List</title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>

<body class="bg-light">

<form id="form1" runat="server">

<div class="container mt-4">

    <h3 class="mb-3">Inventory List</h3>

    <div class="row">

        <div class="col-md-8">

            <asp:ListBox ID="lstInventoryList" runat="server"
                CssClass="form-control"
                Rows="18"
                AutoPostBack="True"
                OnSelectedIndexChanged="lstInventoryList_SelectedIndexChanged">
            </asp:ListBox>

        </div>

        <div class="col-md-4">

            <asp:Button ID="btnAdd" runat="server" Text="Add"
                CssClass="btn btn-success w-100 mb-2"
                OnClick="btnAdd_Click" />

            <asp:Button ID="btnEdit" runat="server" Text="Edit"
                CssClass="btn btn-primary w-100 mb-2"
                OnClick="btnEdit_Click" />

            <asp:Button ID="btnDelete" runat="server" Text="Delete"
                CssClass="btn btn-danger w-100 mb-2"
                OnClick="btnDelete_Click" />

        </div>

    </div>

    <div class="row mt-4">

        <div class="col-md-6">

            <asp:Label ID="lblFilter" runat="server" Text="Enter Status"></asp:Label>

            <asp:TextBox ID="txtFilter" runat="server" CssClass="form-control"></asp:TextBox>

        </div>

        <div class="col-md-6 d-flex align-items-end gap-2">

            <asp:Button ID="btnApplyFilter" runat="server"
                Text="Apply Filter"
                CssClass="btn btn-outline-primary w-50"
                OnClick="btnApplyFilter_Click" />

            <asp:Button ID="btnClearFilter" runat="server"
                Text="Clear Filter"
                CssClass="btn btn-outline-secondary w-50"
                OnClick="btnClearFilter_Click" />

        </div>

    </div>

    <div class="row mt-3">

        <div class="col-md-6">

            <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>

        </div>

        <div class="col-md-6 text-end">

            <asp:Button ID="btnReturn" runat="server"
                Text="Return"
                CssClass="btn btn-dark"
                OnClick="btnReturn_Click" />

        </div>

    </div>

</div>

</form>

</body>
</html>