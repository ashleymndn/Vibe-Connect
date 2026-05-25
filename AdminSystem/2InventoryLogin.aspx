<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2InventoryLogin.aspx.cs" Inherits="_2InventoryLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inventory Login</title>
</head>

<body style="height: 332px">

    <form id="form1" runat="server">

        <div>

            <asp:Label ID="lblTitle" runat="server"
                Text="Inventory Login Page"
                style="z-index:1; left:10px; top:31px; position:absolute; height:38px; width:226px">
            </asp:Label>

            <asp:Label ID="lblUserName" runat="server"
                Text="UserName:"
                style="z-index:1; left:50px; top:113px; position:absolute">
            </asp:Label>

            <asp:TextBox ID="txtUserName" runat="server"
                style="z-index:1; left:196px; top:115px; position:absolute; height:20px; width:145px">
            </asp:TextBox>

            <asp:Label ID="lblPassword" runat="server"
                Text="Password:"
                style="z-index:1; left:50px; top:163px; position:absolute">
            </asp:Label>

            <asp:TextBox ID="txtPassword" runat="server"
                TextMode="Password"
                style="z-index:1; left:195px; top:156px; position:absolute; height:23px; width:143px">
            </asp:TextBox>

            <asp:Label ID="lblError" runat="server"
                ForeColor="Red"
                style="z-index:1; left:395px; top:155px; position:absolute">
            </asp:Label>

            <asp:Button ID="btnLogin" runat="server"
                Text="Login"
                OnClick="btnLogin_Click"
                style="z-index:1; left:75px; top:236px; position:absolute; height:31px">
            </asp:Button>

            <asp:Button ID="btnCancel" runat="server"
                Text="Cancel"
                OnClick="btnCancel_Click"
                style="z-index:1; left:208px; top:234px; position:absolute; height:35px; width:78px">
            </asp:Button>

        </div>

    </form>

</body>
</html>
