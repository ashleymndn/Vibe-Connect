<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background: #f4f6f9;
            margin: 0;
        }

        form {
            width: 580px;
            margin: 40px auto;
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

        input[type=text] {
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
            <h2>Staff Data Entry</h2>

            <asp:Label ID="lblStfName" runat="server" Text="Staff Name"></asp:Label><br />
            <asp:TextBox ID="txtStfName" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblStfEmail" runat="server" Text="Staff Email"></asp:Label><br />
            <asp:TextBox ID="txtStfEmail" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblStfRole" runat="server" Text="Staff Role"></asp:Label><br />
            <asp:TextBox ID="txtStfRole" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblStfSalary" runat="server" Text="Staff Salary"></asp:Label><br />
            <asp:TextBox ID="txtStfSalary" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblStfDateJoined" runat="server" Text="Date Joined"></asp:Label><br />
            <asp:TextBox ID="txtStfDateJoined" runat="server"></asp:TextBox>
            <br /><br />

            <asp:CheckBox ID="chkStfIsActive" runat="server" Text=" Active Staff Member" />
            <br /><br />

            <asp:Button ID="btnOK" runat="server" Text="Save Staff" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <br /><br />

            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>