<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2InventoryLogin.aspx.cs" Inherits="_2InventoryLogin" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Inventory Login</title>

    <!-- Bootstrap CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />

    <style>
        body {
            background: linear-gradient(135deg, #1e3c72, #2a5298);
            height: 100vh;
        }

        .login-card {
            width: 100%;
            max-width: 420px;
            border-radius: 15px;
        }

        .error-text {
            color: #ff6b6b;
            font-weight: 500;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">

        <div class="d-flex justify-content-center align-items-center h-100">

            <div class="card login-card shadow-lg p-4">

                <h3 class="text-center mb-4">Inventory System Login</h3>

                <!-- Username -->
                <div class="mb-3">
                    <label class="form-label">Username</label>
                    <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" />
                </div>

                <!-- Password -->
                <div class="mb-3">
                    <label class="form-label">Password</label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" />
                </div>

                <!-- Error Label -->
                <div class="mb-3 text-center">
                    <asp:Label ID="lblError" runat="server" CssClass="error-text" />
                </div>

                <!-- Buttons -->
                <div class="d-grid gap-2">

                    <asp:Button 
                        ID="btnLogin" 
                        runat="server" 
                        Text="Login" 
                        CssClass="btn btn-primary"
                        OnClick="btnLogin_Click" />

                    <asp:Button 
                        ID="btnCancel" 
                        runat="server" 
                        Text="Cancel" 
                        CssClass="btn btn-outline-secondary"
                        OnClick="btnCancel_Click" />

                </div>

            </div>

        </div>

    </form>


    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>

</body>
</html>