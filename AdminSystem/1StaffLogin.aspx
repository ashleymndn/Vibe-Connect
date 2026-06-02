<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1StaffLogin.aspx.cs" Inherits="_1StaffLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Staff Login Page</h2>

            <asp:Label ID="lblUserName" runat="server" Text="UserName:"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
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