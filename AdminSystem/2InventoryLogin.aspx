<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2InventoryLogin.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 332px">
    <form id="form1" runat="server">
        <div>
            <p>
    <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 10px; top: 31px; position: absolute; height: 38px; width: 226px" Text="Inventory Login Page"></asp:Label>
</p>
<asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 50px; top: 113px; position: absolute" Text="UserName:"></asp:Label>
<asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 196px; top: 115px; position: absolute; height: 20px; width: 145px; bottom: 618px;"></asp:TextBox>
<asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 50px; top: 163px; position: absolute; height: 31px; width: 87px" Text="Password:"></asp:Label>

<asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 195px; top: 156px; position: absolute; height: 23px; width: 143px" TextMode="Password"></asp:TextBox>

<p>

<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 395px; top: 155px;color:#ff0000; position: absolute; height: 26px; width: 92px;" Text=""></asp:Label>

</p>
<p>
    <a href="2InventoryList.aspx">2InventoryList.aspx</a>
    <asp:Button ID="BtnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 75px; top: 236px; position: absolute; height: 31px" Text="Login" />
</p>
<p>
    <asp:Button ID="BtnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 208px; top: 234px; position: absolute; height: 35px; width: 78px" Text="Cancel" />
</p>

        </div>
    </form>
</body>
</html>
