<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID"></asp:Label>
<asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
<asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
<br /><br />
            <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name"></asp:Label>
    <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Label ID="lblCustomerEmail" runat="server" Text="Customer Email"></asp:Label>
    <asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Label ID="lblCustomerPhone" runat="server" Text="Customer Phone"></asp:Label>
    <asp:TextBox ID="txtCustomerPhone" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Label ID="lblCustomerAddress" runat="server" Text="Customer Address"></asp:Label>
    <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Label ID="lblCustomerPassword" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="txtCustomerPassword" runat="server"></asp:TextBox>
    <br /><br />

    <asp:CheckBox ID="chkCustomerIsActive" runat="server" Text="Active" />
    <br /><br />

    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    <br /><br />

    <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />

    <asp:Button ID="btnMainMenu"
    runat="server"
    Text="Return to Main Menu"
    OnClick="btnMainMenu_Click" />
        </div>
    </form>
</body>
</html>
