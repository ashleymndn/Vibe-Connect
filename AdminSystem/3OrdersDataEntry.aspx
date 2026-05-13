<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 439px">
    This is the Order Data Entry Page
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 25px; top: 63px; position: absolute; height: 22px" Text="Order Id" width="119px"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 148px; top: 61px; position: absolute; width: 193px"></asp:TextBox>

        </div>
        <p>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 25px; top: 100px; position: absolute" Text="Customer Id" width="119px" height="22px"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 147px; top: 99px; position: absolute; width: 193px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 25px; top: 139px; position: absolute" Text="Order Date" width="119px" height="22px"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 148px; top: 141px; position: absolute; width: 193px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 374px; top: 17px; position: absolute; width: 66px" Text="Find" />
        </p>
        <p>
            <asp:Label ID="lblbTotal" runat="server" style="z-index: 1; left: 25px; top: 180px; position: absolute" Text="Total" width="119px" height="22px"></asp:Label>
            <asp:TextBox ID="txtTotal" runat="server" style="z-index: 1; left: 145px; top: 187px; position: absolute; width: 193px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 25px; top: 220px; position: absolute" Text="Address" width="119px" height="22px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 144px; top: 222px; position: absolute; width: 193px"></asp:TextBox>
        </p>

        <p>
            <asp:Label ID="lblStatus" runat="server" style="z-index: 1; left: 25px; top: 264px; position: absolute; width: 119px; right: 1248px;" Text="Order Status"></asp:Label>
            <asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; left: 145px; top: 266px; position: absolute; width: 193px"></asp:TextBox>
        </p>

        <p>
   
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 33px; top: 342px; position: absolute"></asp:Label>
            <asp:CheckBox ID="chkIsDelivered" runat="server" style="z-index: 1; left: 138px; top: 298px; position: absolute" Text="Is Delivered" />
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 31px; top: 399px; position: absolute" Text="OK" />
        </p>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 106px; top: 398px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
