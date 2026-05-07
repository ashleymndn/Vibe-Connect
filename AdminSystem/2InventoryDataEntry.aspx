<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2InventoryDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Checkbox1 {
            z-index: 1;
            left: 10px;
            top: 399px;
            position: absolute;
        }
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body style="height: 396px">
    <form id="form1" runat="server">
            <div class="auto-style1">
            <asp:Label ID="InventoryIdlbl" runat="server" style="z-index: 1; left: 11px; top: 36px; position: absolute; height: 28px; right: 1737px" Text="Label" width="130px">InventoryId</asp:Label>
        <div>
            <asp:TextBox ID="InventoryIdTextBox" runat="server" OnTextChanged="InventoryId_TextChanged" style="z-index: 1; left: 194px; top: 38px; position: absolute; width: 92px; height: 27px"></asp:TextBox>
            <br />  
        </div>
        <div>
            <asp:Label ID="ProductIdlbl" runat="server" style="z-index: 1; left: 10px; top: 83px; position: absolute; height: 28px; width: 130px; right: 1760px;" Text="Label">ProductId</asp:Label>
            <asp:TextBox ID="ProductIdTextBox" runat="server" OnTextChanged="ProductId_TextChanged" style="z-index: 1; left: 194px; top: 84px; position: absolute; width: 92px; height: 27px"></asp:TextBox>
            <br/>

        </div>
        <div>
            <asp:Label ID="ProductNamelbl" runat="server" style="z-index: 1; left: 8px; top: 130px; position: absolute; height: 28px; width: 130px; right: 1724px;" Text="Label">ProductName</asp:Label>
            <asp:TextBox ID="ProductNameTextBox" runat="server" OnTextChanged="ProductName_TextChanged" style="z-index: 1; left: 194px; top: 129px; position: absolute; width: 92px; height: 27px"></asp:TextBox>
            <br/>
        </div>
        <div>
            <asp:Label ID="ProductPricelbl" runat="server" style="z-index: 1; left: 11px; top: 178px; position: absolute; height: 28px; width: 130px; right: 1731px;" Text="Label">ProductPrice</asp:Label>
            <asp:TextBox ID="ProductPriceTextBox" runat="server" OnTextChanged="ProductPrice_TextChanged" style="z-index: 1; left: 194px; top: 174px; position: absolute; width: 92px; height: 27px"></asp:TextBox>

            <br/>

        </div>

        <div>
            <asp:Label ID="QuantityInStocklbl" runat="server" style="z-index: 1; left: 8px; top: 224px; position: absolute; height: 28px; width: 130px; right: 1670px;" Text="Label">QuantityInStock</asp:Label>
            <asp:TextBox ID="QuantityInStockTextBox" runat="server" OnTextChanged="QuantityInStock_TextChanged" style="z-index: 1; left: 194px; top: 218px; position: absolute; height: 27px; width: 92px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LastUpdatedlbl" runat="server" style="z-index: 1; left: 10px; top: 270px; position: absolute; height: 28px; width: 130px" Text="Label">LastUpdated</asp:Label>
            <asp:TextBox ID="LastUpdatedTextBox" runat="server" OnTextChanged="LastUpdated_TextChanged" style="z-index: 1; left: 194px; top: 267px; position: absolute; width: 92px; height: 27px"></asp:TextBox>
           
        </div>
        <div>
            <asp:Label ID="StockStatuslbl" runat="server" style="z-index: 1; left: 10px; top: 319px; position: absolute; height: 28px; width: 130px; right: 1691px;" Text="Label">StockStatus</asp:Label>
            <asp:TextBox ID="StockStatusTextBox" runat="server" OnTextChanged="StockStatus_TextChanged" style="z-index: 1; top: 314px; position: absolute; width: 92px; height: 27px; left: 194px"></asp:TextBox>
            
        </div>
        <div>   
           <p> 
               <asp:CheckBox ID="chkActive" Text="Active" runat="server" OnCheckedChanged="Active_CheckedChanged" style="z-index: 1; left: 193px; top: 371px; position: absolute; width: 92px" />
              
           </p>
            <asp:Label ID="lblError"  runat="server" style="z-index: 1; left: 24px; top: 434px; position: absolute" Text=""></asp:Label>
        </div>
       
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 13px; top: 469px; position: absolute; height: 28px; width: 41px;" Text="OK" />
       
        
            <asp:Button ID="btnCancel" runat="server"  style="z-index: 1; left: 73px; top: 469px; position: absolute; height: 29px; width: 74px;" Text="Cancel" />
       
        
       </div>
       
        
    </form>
</body>
</html>
