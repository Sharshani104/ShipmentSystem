<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RetailCenter.aspx.cs" Inherits="ABC_Shipment_Client.RetailCenter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 707px;
        }
        .auto-style2 {
            width: 360px;
        }
        .auto-style3 {
            width: 370px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
            <h1 style="text-align:center;">Retail Center</h1>
            <table>
                <tr> 
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Retail Center ID"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtrcid" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr> 
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="Type"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txttype" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr> 
                    <td class="auto-style3"></td>
                    <td class="auto-style2">
                        <asp:Label ID="lblres" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr> 
                    <td class="auto-style3">
                        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Add" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                    </td>
                    <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
