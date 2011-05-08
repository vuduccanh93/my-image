<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrderDetail.ascx.cs" Inherits="admin_wuc_wucOrderDetail" %>
<table>
<tr>
    <td>No:</td>
    <td>
        <asp:Label ID="lblNo" runat="server" Text="Label"></asp:Label></td>
    <td>Date:</td>
    <td>
        <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td>
        Status</td>
    <td>
        <asp:Label ID="lblStatus" runat="server" Text="Label"></asp:Label></td>
    <td></td>
    <td></td>
</tr>
<tr>
    <td>Customer:</td>
    <td>
        <asp:Label ID="lblCustomer" runat="server" Text="Label"></asp:Label></td>
    <td></td>
    <td></td>
</tr>
<tr>
    <td>Payment:</td>
    <td>
        <asp:Label ID="lblPayment" runat="server" Text="Label"></asp:Label></td>
    <td>Credit card:</td>
    <td>
        <asp:Label ID="lblCC" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td>Printing price:</td>
    <td>
        <asp:Label ID="lblPPrice" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td>
        Province/State:</td>
    <td>
        <asp:Label ID="lblPState" runat="server" Text="Label"></asp:Label></td>
    <td>Shipping price</td>
    <td>
        <asp:Label ID="lblSPrice" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td>
        Content:</td>
    <td colspan="3">
        <asp:Label ID="lblContent" runat="server" Text="Label"></asp:Label></td>
</tr>
</table>
<asp:GridView ID="grvOrderDetail" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="name" HeaderText="Image" />
        <asp:BoundField DataField="link" HeaderText="Link" />
        <asp:BoundField DataField="price" HeaderText="Price" />
        <asp:BoundField DataField="size" HeaderText="Size" />
        <asp:BoundField DataField="quantity" HeaderText="Quantity" />
        <asp:BoundField DataField="amount" HeaderText="Amount" />
    </Columns>
</asp:GridView>
