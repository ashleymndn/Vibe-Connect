<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <style>
        body {
            background-color: #f5f5f3;
            min-height: 100vh;
        }

        .delete-card {
            max-width: 500px;
            width: 100%;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">

        <div class="container d-flex justify-content-center align-items-center min-vh-100">
            <div class="card shadow delete-card">

                <div class="card-body text-center">
                    <asp:Label ID="lblConfirmDelete" runat="server" Text="Are you sure you want to delete this record?" CssClass="fs-5"> </asp:Label>

                    <div class="mt-4">
                        <asp:Button ID="btnYes" runat="server" Text="Yes" CssClass="btn btn-danger me-2" OnClick="btnYes_Click" Width="80px" />
                        <asp:Button ID="btnNo" runat="server" Text="No" CssClass="btn btn-secondary" OnClick="btnNo_Click" Width="80px" />
                    </div>
                </div>

            </div>
        </div>
    </form>
</body>
</html>
