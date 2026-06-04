<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3OrdersLogin.aspx.cs" Inherits="_3OrdersLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Orders Login</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <style>
        body {
            background-color: #f5f5f3;
            display: flex;
            align-items: center;
            justify-content: center;
            min-height: 100vh;
            margin: 0;
        }
        .login-card {
            background: #ffffff;
            border: 1px solid #e0ddd5;
            border-radius: 12px;
            padding: 4.5rem 4rem;
            width: 100%;
            max-width: 580px;
        }
        .login-icon {
            width: 60px; height: 60px;
            border-radius: 50%;
            background: #e6f1fb;
            display: flex; align-items: center; justify-content: center;
            margin: 0 auto 1.25rem;
            font-size: 27px; color: #185fa5;
        }
        .login-title {
            font-size: 25px; font-weight: 500;
            text-align: center; margin: 0 0 0.25rem;
        }
        .login-sub {
            font-size: 17px; color: #888780;
            text-align: center; margin: 0 0 2rem;
        }
        .form-control {
            border: 1px solid #d0cec8;
            background-color: #fafaf9;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="login-card">

            <div class="login-icon">📦</div>
            <h1 class="login-title">Orders Login</h1>
            <p class="login-sub">Sign in to manage your orders</p>

            <div class="form-group mb-3">
                <label for="txtUserName" class="form-label" style="font-size:18px; font-weight:400; color:#888780;">Username</label>
                <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" placeholder="Enter your username" Width="230px"></asp:TextBox>
            </div>

            <div class="form-group mb-3">
                <label for="txtPassword" class="form-label" style="font-size:18px; font-weight:400; color:#888780;">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter your password" Width="230px"></asp:TextBox>
            </div>

            <asp:Label ID="lblError" runat="server" CssClass="text-danger d-block mb-3" style="font-size:13px;"></asp:Label>

            <div class="d-flex gap-2">
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" CssClass="btn btn-primary flex-fill" Text="Login" />
                <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-outline-secondary" Text="Cancel" OnClick="btnCancel_Click" />
            </div>

        </div>
    </form>
</body>
</html>