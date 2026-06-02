<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Staff Data Entry</h2>

            <asp:Label ID="lblStfName" runat="server" Text="Staff Name"></asp:Label>
            <asp:TextBox ID="txtStfName" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblStfEmail" runat="server" Text="Staff Email"></asp:Label>
            <asp:TextBox ID="txtStfEmail" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblStfRole" runat="server" Text="Staff Role"></asp:Label>
            <asp:TextBox ID="txtStfRole" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblStfSalary" runat="server" Text="Staff Salary"></asp:Label>
            <asp:TextBox ID="txtStfSalary" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblStfDateJoined" runat="server" Text="Date Joined"></asp:Label>
            <asp:TextBox ID="txtStfDateJoined" runat="server"></asp:TextBox>
            <br /><br />

            <asp:CheckBox ID="chkStfIsActive" runat="server" Text="Active" />
            <br /><br />

            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <br /><br />

            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>