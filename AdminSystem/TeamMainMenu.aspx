<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VibeConnect Main Menu</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background: #f4f6f9;
            margin: 0;
        }

        form {
            width: 500px;
            margin: 80px auto;
            background: white;
            padding: 35px;
            border-radius: 12px;
            box-shadow: 0 4px 14px rgba(0,0,0,0.15);
            text-align: center;
        }

        h2 {
            color: #2c3e50;
            margin-bottom: 30px;
        }

        input[type=submit] {
            background: #3498db;
            color: white;
            border: none;
            padding: 12px 25px;
            border-radius: 6px;
            cursor: pointer;
            font-size: 15px;
        }

        input[type=submit]:hover {
            background: #2980b9;
        }
    </style>
</head>
<body style="height: 173px">
    <form id="form1" runat="server">
        <div>
            <h2>VibeConnect Main Menu</h2>
            <asp:Button ID="btnStaff" runat="server" Text="Staff Management" OnClick="btnStaff_Click" />
        </div>
    </form>
</body>
</html>