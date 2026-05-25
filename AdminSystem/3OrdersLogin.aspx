<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3OrdersLogin.aspx.cs" Inherits="_3OrdersLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Orders Login Page</p>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 66px; top: 133px; position: absolute" Text="UserName:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 68px; top: 175px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 171px; top: 132px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 170px; top: 172px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 386px; top: 149px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 156px; top: 238px; position: absolute" Text="Login" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 244px; top: 238px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
