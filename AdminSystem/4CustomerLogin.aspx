<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4CustomerLogin.aspx.cs" Inherits="_4CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblUserName"
                runat="server"
                Text="User Name">
            </asp:Label>

            <asp:TextBox ID="txtUserName"
                runat="server">
            </asp:TextBox>

            <br /><br />

            <asp:Label ID="lblPassword"
                runat="server"
                Text="Password">
            </asp:Label>

            <asp:TextBox ID="txtPassword"
                runat="server"
                TextMode="Password">
            </asp:TextBox>

            <br /><br />

            <asp:Button ID="btnLogin"
                runat="server"
                Text="Login"
                OnClick="btnLogin_Click" />

            <br /><br />

            <asp:Label ID="lblError"
                runat="server"
                Text="">
            </asp:Label>

        </div>
    </form>
</body>
</html>