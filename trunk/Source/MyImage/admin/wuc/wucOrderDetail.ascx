<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrderDetail.ascx.cs" Inherits="admin_wuc_wucOrderDetail" %>
<table class="order-detail">
<tr>
    <td style="width:100px;">No:</td>
    <td class="style2">
        <asp:Label ID="lblNo" runat="server" Text="Label"></asp:Label></td>
    <td>Date:</td>
    <td class="style2">
        <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td style="height: 21px">
        Status:</td>
    <td colspan="3" class="style2">
        &nbsp;<asp:DropDownList ID="drlStatus" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnSaveStatus" runat="server" OnClick="btnSaveStatus_Click" Text="Save" /></td>
</tr>
<tr>
    <td >Customer:</td>
    <td colspan="3" class="style2">
        <asp:Label ID="lblCustomer" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td>Payment:</td>
    <td class="style2">
        <asp:Label ID="lblPayment" runat="server" Text="Label"></asp:Label></td>
    <td>Credit card:</td>
    <td class="style2">
        <asp:Label ID="lblCC" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td>Printing price:</td>
    <td class="style2">
        <asp:Label ID="lblPPrice" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td>
        Province/State:</td>
    <td class="style2">
        <asp:Label ID="lblPState" runat="server" Text="Label"></asp:Label></td>
    <td>Shipping price:</td>
    <td class="style2">
        <asp:Label ID="lblSPrice" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td>Amount:</td>
    <td class="style2">
        <asp:Label ID="lblAmount" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td>
        Content:</td>
    <td colspan="3">
        <asp:Label ID="lblContent" runat="server" Text="Label"></asp:Label></td>
</tr>
</table>
<div class="clear">
</div>
<asp:GridView ID="grvOrderDetail" runat="server" AutoGenerateColumns="False" CssClass="order">
    <Columns>
        <asp:BoundField DataField="name" HeaderText="Image" />
        <asp:BoundField DataField="link" HeaderText="Link" />
        <asp:BoundField DataField="price" HeaderText="Price" >
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </asp:BoundField>
        <asp:BoundField DataField="size" HeaderText="Size" >
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:BoundField>
        <asp:BoundField DataField="quantity" HeaderText="Quantity" >
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:BoundField>
        <asp:BoundField DataField="amount" HeaderText="Amount" >
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
            <HeaderStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </asp:BoundField>
    </Columns>
</asp:GridView>
<asp:DataList ID="DataList1" runat="server" RepeatColumns="1">
    <ItemTemplate>
        <asp:Image ID="Image1" runat="server" ImageUrl='<% #  Eval("Link") %>' />
    </ItemTemplate>
</asp:DataList><br />
