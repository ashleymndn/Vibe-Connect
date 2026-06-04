<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Data Entry</title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <style>
        body {
            background-color: #f5f5f3;
            min-height: 100vh;
        }

        .entry-card {
            max-width: 850px;
            width: 100%;
        }

        .orderdata-icon {
            width: 60px; height: 60px;
            border-radius: 50%;
            background: #e6f1fb;
            display: flex; align-items: center; justify-content: center;
            margin: 0 auto 1.25rem;
            font-size: 27px; color: #185fa5;
        }

        .orderdata.title {
            font-size: 25px;
            font-weight: 500;
            text-align: center;
            margin: 0 0 0.25rem;
        }

        .orderdata-sub {
            font-size: 17px;
            color: #888780;
            text-align: center;
            margin: 0 0 2rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container d-flex justify-content-center align-items-center min-vh-100">
            <div class="card shadow entry-card">

                <div class="card-header bg-white text-black text-center">
                    <div class="orderdata-icon">📝</div>
                    <h3 class="orderdata-title">Orders Data Entry</h3>
                    <p class="orderdata-sub">Add customer order record</p>
                </div>

                <div class="card-body">

                    <div class="row mb-3">
                        <div class="col-md-3">
                            <asp:Label ID="lblOrderId" runat="server" Text="Order ID" CssClass="form-label" />
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtOrderId" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-md-3">
                            <asp:Button ID="btnFind" runat="server" Text="Find" CssClass="btn btn-primary w-100" OnClick="btnFind_Click" />
                        </div>
                    </div>

                    <div class="row mb-3">
                        <div class="col-md-3">
                            <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID" CssClass="form-label" />
                        </div>
                        <div class="col-md-9">
                            <asp:TextBox ID="txtCustomerId" runat="server" CssClass="form-control" />
                        </div>
                    </div>

                    <div class="row mb-3">
                        <div class="col-md-3">
                            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" CssClass="form-label" />
                        </div>
                        <div class="col-md-9">
                            <asp:TextBox ID="txtOrderDate" runat="server" CssClass="form-control" />
                        </div>
                    </div>

                    <div class="row mb-3">
                        <div class="col-md-3">
                            <asp:Label ID="lblbTotal" runat="server" Text="Total" CssClass="form-label" />
                        </div>
                        <div class="col-md-9">
                            <asp:TextBox ID="txtTotal" runat="server" CssClass="form-control" />
                        </div>
                    </div>

                    <div class="row mb-3">
                        <div class="col-md-3">
                            <asp:Label ID="lblAddress" runat="server" Text="Address" CssClass="form-label" />
                        </div>
                        <div class="col-md-9">
                            <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" />
                        </div>
                    </div>

                    <div class="row mb-3">
                        <div class="col-md-3">
                            <asp:Label ID="lblStatus" runat="server" Text="Order Status" CssClass="form-label" />
                        </div>
                        <div class="col-md-9">
                            <asp:TextBox ID="txtOrderStatus" runat="server" CssClass="form-control" />
                        </div>
                    </div>

                    <div class="form-check mb-3">
                        <asp:CheckBox ID="chkIsDelivered" runat="server" Text="Is Delivered" />
                    </div>

                    <asp:Label ID="lblError" runat="server" CssClass="text-danger d-block mb-3" />

                    <div class="d-flex justify-content-between">
                        <div>
                            <asp:Button ID="btnOK" runat="server" Text="OK" CssClass="btn btn-success me-2" OnClick="btnOK_Click" />
                            <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-secondary" OnClick="btnCancel_Click" />
                        </div>

                        <asp:Button ID="btnMainMenu" runat="server" Text="Return to Main Menu" CssClass="btn btn-secondary" OnClick="btnMainMenu_Click" />
                    </div>

                </div>
            </div>
        </div>

    </form>
</body>
</html>