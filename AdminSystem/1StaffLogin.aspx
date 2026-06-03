<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1StaffLogin.aspx.cs" Inherits="_1StaffLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Login</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background: #f4f6f9;
            margin: 0;
        }

        form {
            width: 450px;
            margin: 70px auto;
            background: white;
            padding: 30px;
            border-radius: 12px;
            box-shadow: 0 4px 14px rgba(0,0,0,0.15);
        }

        h2 {
            text-align: center;
            color: #2c3e50;
            margin-bottom: 25px;
        }

        label {
            font-weight: bold;
            color: #333;
        }

        input[type=text],
        input[type=password] {
            width: 95%;
            padding: 9px;
            margin-top: 6px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        input[type=submit] {
            background: #3498db;
            color: white;
            border: none;
            padding: 10px 18px;
            border-radius: 6px;
            cursor: pointer;
            margin-right: 8px;
        }

        input[type=submit]:hover {
            background: #2980b9;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>VibeConnect Staff Login</h2>

            <asp:Label ID="lblUserName" runat="server" Text="Username"></asp:Label><br />
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            <br /><br />

            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>