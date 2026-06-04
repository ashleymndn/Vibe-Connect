<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2InventoryLogin.aspx.cs" Inherits="_2InventoryLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inventory Login</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>

            <asp:Label ID="lblTitle" runat="server"
                Text="Inventory Login Page"
                Style="position:absolute; left:16px; top:19px;">
            </asp:Label>

            <asp:Label ID="lblUserName" runat="server"
                Text="User Name:"
                Style="position:absolute; left:50px; top:113px;">
            </asp:Label>

            <asp:TextBox ID="txtUserName" runat="server"
                Style="position:absolute; left:196px; top:115px; width:145px;">
            </asp:TextBox>

            <asp:Label ID="lblPassword" runat="server"
                Text="Password:"
                Style="position:absolute; left:50px; top:163px;">
            </asp:Label>

            <asp:TextBox ID="txtPassword" runat="server"
                TextMode="Password"
                Style="position:absolute; left:195px; top:156px; width:143px;">
            </asp:TextBox>

            <asp:Label ID="lblError" runat="server"
                ForeColor="Red"
                Style="position:absolute; left:395px; top:155px;">
            </asp:Label>

            <asp:Button ID="btnLogin" runat="server"
                Text="Login"
                OnClick="btnLogin_Click"
                Style="position:absolute; left:75px; top:236px;" />

            <asp:Button ID="btnCancel" runat="server"
                Text="Cancel"
                OnClick="btnCancel_Click"
                Style="position:absolute; left:208px; top:234px; width:78px;" />

        </div>

    </form>
</body>
</html>