<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background: #f4f6f9;
            margin: 0;
        }

        form {
            width: 760px;
            margin: 40px auto;
            background: white;
            padding: 30px;
            border-radius: 12px;
            box-shadow: 0 4px 14px rgba(0,0,0,0.15);
        }

        h2 {
            text-align: center;
            color: #2c3e50;
        }

        select {
            width: 100%;
            height: 230px;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 6px;
        }

        input[type=text] {
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        input[type=submit] {
            background: #3498db;
            color: white;
            border: none;
            padding: 10px 16px;
            border-radius: 6px;
            cursor: pointer;
            margin: 4px;
        }

        input[type=submit]:hover {
            background: #2980b9;
        }

        .user {
            color: #555;
            font-weight: bold;
        }

        .section {
            margin-top: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Staff Management</h2>

            <asp:Label ID="lblUserName" runat="server" CssClass="user"></asp:Label>
            <br /><br />

            <asp:ListBox ID="lstStaffList" runat="server"></asp:ListBox>
            <br /><br />

            <div class="section">
                <asp:Button ID="btnAdd" runat="server" Text="Add Staff" OnClick="btnAdd_Click" />
                <asp:Button ID="btnEdit" runat="server" Text="Edit Staff" OnClick="btnEdit_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete Staff" OnClick="btnDelete_Click" />
            </div>

            <div class="section">
                <asp:Label ID="lblFilter" runat="server" Text="Filter by Role:"></asp:Label>
                <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
                <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
                <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" OnClick="btnClearFilter_Click" />
            </div>

            <div class="section">
                <asp:Button ID="btnMainMenu" runat="server" Text="Return to Main Menu" OnClick="btnMainMenu_Click" />
            </div>

            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>