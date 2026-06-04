<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2InventoryDataEntry.aspx.cs" Inherits="_2InventoryDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inventory Data Entry</title>

```
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />

<style>
    .medium-textbox {
        max-width: 450px;
    }
</style>
```

</head>
<body>

<form id="form1" runat="server">

<div class="container mt-5">

```
<div class="card shadow">
    <div class="card-header bg-primary text-white">
        <h3 class="mb-0">Inventory Data Entry</h3>
    </div>

    <div class="card-body">

        <div class="mb-3">
            <asp:Label ID="InventoryIdlbl" runat="server" Text="Inventory ID" CssClass="form-label"></asp:Label>

            <div class="d-flex gap-2">
                <asp:TextBox ID="InventoryIdTextBox" runat="server"
                    CssClass="form-control medium-textbox"></asp:TextBox>

                <asp:Button ID="btnFind" runat="server"
                    Text="Find"
                    CssClass="btn btn-info"
                    OnClick="btnFind_Click" />
            </div>
        </div>

        <div class="mb-3">
            <asp:Label ID="ProductIdlbl" runat="server" Text="Product ID" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="ProductIdTextBox" runat="server" CssClass="form-control medium-textbox"></asp:TextBox>
        </div>

        <div class="mb-3">
            <asp:Label ID="ProductNamelbl" runat="server" Text="Product Name" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="ProductNameTextBox" runat="server" CssClass="form-control medium-textbox"></asp:TextBox>
        </div>

        <div class="mb-3">
            <asp:Label ID="ProductPricelbl" runat="server" Text="Product Price" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="ProductPriceTextBox" runat="server" CssClass="form-control medium-textbox"></asp:TextBox>
        </div>

        <div class="mb-3">
            <asp:Label ID="QuantityInStocklbl" runat="server" Text="Quantity In Stock" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="QuantityInStockTextBox" runat="server" CssClass="form-control medium-textbox"></asp:TextBox>
        </div>

        <div class="mb-3">
            <asp:Label ID="LastUpdatedlbl" runat="server" Text="Last Updated" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="LastUpdatedTextBox" runat="server" CssClass="form-control medium-textbox"></asp:TextBox>
        </div>

        <div class="mb-3">
            <asp:Label ID="StockStatuslbl" runat="server" Text="Stock Status" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="StockStatusTextBox" runat="server" CssClass="form-control medium-textbox"></asp:TextBox>
        </div>

        <div class="form-check mb-3">
            <asp:CheckBox ID="chkActive" runat="server" CssClass="form-check-input" />
            <asp:Label ID="lblActive" runat="server" Text="Active" CssClass="form-check-label"></asp:Label>
        </div>

        <div class="mb-3">
            <asp:Label ID="lblError" runat="server" CssClass="text-danger fw-bold"></asp:Label>
        </div>

        <div class="d-flex gap-2">
            <asp:Button ID="btnOk" runat="server"
                Text="OK"
                CssClass="btn btn-success"
                OnClick="btnOk_Click" />

            <asp:Button ID="btnCancel" runat="server"
                Text="Cancel"
                CssClass="btn btn-secondary"
                PostBackUrl="~/InventoryList.aspx" />

            <asp:Button ID="btnMainMenu" runat="server"
                Text="Return To Main Menu"
                CssClass="btn btn-primary"
                OnClick="btnMainMenu_Click" />
        </div>

    </div>
</div>
```

</div>

</form>

</body>
</html>
