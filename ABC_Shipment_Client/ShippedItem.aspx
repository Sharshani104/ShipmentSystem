<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShippedItem.aspx.cs" Inherits="ABC_Shipment_Client.ShippedItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 391px;
        }
        .auto-style2 {
            width: 403px;
        }
        .auto-style3 {
            height: 371px;
        }
    </style>
</head>
<body style="height: 630px">
    <form id="form1" runat="server">
        <div>
            <h1  style="text-align:center;">Shipping Items</h1>
            <table class="auto-style3">
                <tr>
                    <td class="auto-style2">&nbsp;<asp:Label ID="Label8" runat="server" Text="Item Id"></asp:Label>
                    </td>
                    <td class="auto-style1">&nbsp;<asp:TextBox ID="txtsiid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Weight"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtweight" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Dimention"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtdimen" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="Insurance"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtinsu" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="Amount"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtamnt" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label6" runat="server" Text="Destination"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtdesti" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label7" runat="server" Text="DeliveryDate"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Retail Center Id"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="RC_id" DataValueField="RC_id">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ABC_ShipmentsConnectionString %>" SelectCommand="SELECT [RC_id] FROM [RetailCenter]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style1">
                        <asp:Label ID="lblres" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="txtAdd" runat="server" OnClick="txtAdd_Click" Text="Add" />
                    </td>
                    <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="txtDelete" runat="server" OnClick="txtDelete_Click" Text="Delete" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="txtClear" runat="server" Text="Clear" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
