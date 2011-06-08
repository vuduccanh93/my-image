<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrderDetail.ascx.cs" Inherits="admin_wuc_wucOrderDetail" %>
<table class="order-detail">
<tr>
    <td style="width:100px;"><b>No:</b></td>
    <td class="style2">
        <asp:Label ID="lblNo" runat="server" Text="Label"></asp:Label></td>
    <td><b>Date:</b></td>
    <td class="style2">
        <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td style="height: 21px">
        <b>Status:</b></td>
    <td colspan="3" class="style2">
    <asp:Label ID="lblStatus" runat="server" Visible="False"></asp:Label>
        <asp:DropDownList ID="drlStatus" runat="server">
        </asp:DropDownList>
        
        <asp:Button ID="btnSaveStatus" runat="server" OnClick="btnSaveStatus_Click" Text="Save" /></td>
</tr>
<tr>
    <td ><b>Customer:</b></td>
    <td colspan="3" class="style2">
        <asp:Label ID="lblCustomer" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td><b>Payment:</b></td>
    <td class="style2">
        <asp:Label ID="lblPayment" runat="server" Text="Label"></asp:Label></td>
    <td><b>Credit card:</b></td>
    <td class="style2">
        <asp:Label ID="lblCC" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td><b>Printing price:</b></td>
    <td class="style2">
        <asp:Label ID="lblPPrice" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td>
        <b>Province/State:</b></td>
    <td class="style2">
        <asp:Label ID="lblPState" runat="server" Text="Label"></asp:Label></td>
    <td><b>Shipping price:</b></td>
    <td class="style2">
        <asp:Label ID="lblSPrice" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td></td>
    <td></td>
    <td><b>Amount:</b></td>
    <td class="style2">
        <asp:Label ID="lblAmount" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
    <td>
        <b>Content:</b></td>
    <td colspan="3">
        <asp:Label ID="lblContent" runat="server" Text="Label"></asp:Label></td>
</tr>
</table>
<div class="clear">
</div>
<asp:GridView ID="grvOrderDetail" runat="server" CssClass="listing" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="grvOrderDetail_PageIndexChanging" PageSize="3">
    <Columns>
        <asp:TemplateField HeaderText="Image">
            
            <ItemTemplate>
                <asp:Image ID="Image" runat="server" ImageUrl='<%# Eval("name") %>' />
                 <asp:Label ID="lblImage" runat="server" Text='<%# Eval("name") %>' Visible="false"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Link">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink" runat="server" NavigateUrl='<%# Eval("Link") %>' Text="Link"></asp:HyperLink>
                <asp:Label ID="lblLink" runat="server" Text='<%# Eval("folder") %>' Visible="false"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
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
<br />
