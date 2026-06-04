<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Orders List</title>

    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <style>
        body {
            background-color: #f5f5f3;
            min-height: 100vh;
            margin: 5px;
        }

        .orderlist-icon {
            width: 60px; height: 60px;
            border-radius: 50%;
            background: #e6f1fb;
            display: flex; align-items: center; justify-content: center;
            margin: 0 auto 1.25rem;
            font-size: 27px; color: #185fa5;
        }

        .orderlist.title {
            font-size: 25px;
            font-weight: 500;
            text-align: center;
            margin: 0 0 0.25rem;
        }

        .orderlist-sub {
            font-size: 17px;
            color: #888780;
            text-align: center;
            margin: 0 0 2rem;
        }
       

        .orders-card {
            max-width: 900px;
            width: 100%;
        }

        .listbox {
            width: 100%;
            height: 350px;
        }

        .form-control {
            border: 1px solid #d0cec8;
            background-color: #fafaf9;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container d-flex justify-content-center align-items-center min-vh-100">
            <div class="card shadow orders-card">

                <div class="card-header bg-white text-black text-center">
                    <div class="orderlist-icon">📋</div>
                    <h3 class="orderlist-title">Orders List</h3>
                    <p class="orderlist-sub">View, add, edit, or remove customer orders</p>
                </div>

                <div class="card-body">
                    <asp:ListBox ID="lstOrdersList" runat="server" CssClass="form-control listbox"></asp:ListBox>

                    <asp:Label ID="lblError" runat="server" CssClass="text-danger d-block mt-2"></asp:Label>

                    <div class="mt-3">
                        <div class="row g-2">
                            <div class="col-auto">
                                <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn btn-success" OnClick="btnAdd_Click" />
                            </div>

                            <div class="col-auto">
                                <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn btn-warning" OnClick="btnEdit_Click" />
                            </div>

                            <div class="col-auto">
                                <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="btnDelete_Click" />
                            </div>
                        </div>
                    </div>

                    <hr />

                    <div class="row align-items-center g-2">
                        <div class="col-md-3">
                            <asp:Label ID="lblFilter" runat="server" Text="Order Status:" class="form-label" style="font-size:18px; font-weight:400; color:#888780;"></asp:Label>
                            <asp:TextBox ID="txtFilter" runat="server" CssClass="form-control" placeholder="e.g. Pending, Shipped, .."></asp:TextBox>
                        </div>

                        <div class="col-md-5">
                            <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" CssClass="btn btn-primary me-2" OnClick="btnApplyFilter_Click" />
                            <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" CssClass="btn btn-secondary" OnClick="btnClearFilter_Click" />
                        </div>
                    </div>

                    <div class="text-end mt-4">
                        <asp:Button ID="btnReturn" runat="server" Text="Return to Main Menu" CssClass="btn btn-secondary" OnClick="btnReturn_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>