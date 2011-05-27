<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrder_Order.ascx.cs"
    Inherits="wuc_wucOrder_Order" %>
<table>
    <caption>
        Infomation Of User
    </caption>
    <tr>
        <td align="right">
            No.
        </td>
        <td>
            <asp:TextBox ID="txtNo" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            Content</td>
        <td>
            <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right">
            State/province</td>
        <td>
            <asp:DropDownList ID="drlStateProvince" runat="server">
            </asp:DropDownList></td>
    </tr>
</table>
<table>
    <caption>
        Infomation Of User
    </caption>
    <tr>
        <td align="right">
            Ship. :</td>
        <td>
            <asp:TextBox ID="txtShippingPrice" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            Print.:
        </td>
        <td>
            <asp:TextBox ID="txtPrintingPrice" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right">
            Amount:
        </td>
        <td>
            <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right">
            Payment method:
        </td>
        <td>
            <asp:DropDownList ID="drlPaymenMethod" runat="server">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td align="right">
            Credit card number:
        </td>
        <td>
            &nbsp;<asp:TextBox ID="txtCCNumber" runat="server"></asp:TextBox></td>
    </tr>
        <tr>
        <td align="right" style="height: 21px">
            Expert date:
        </td>
        <td style="height: 21px">
            <asp:TextBox ID="ccExpertDate" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right">
            CVV:</td>
        <td>
            <asp:TextBox ID="txtCVV" runat="server"></asp:TextBox></td>
    </tr>
</table>
