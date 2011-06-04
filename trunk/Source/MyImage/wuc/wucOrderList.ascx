<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrderList.ascx.cs" Inherits="wuc_wucOrderList" %>
<asp:Label ID="lblInfo" runat="server" Text="Label"></asp:Label><br />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="No" HeaderText="No" />
        <asp:BoundField DataField="Content" HeaderText="Content" />
        <asp:BoundField DataField="Address" HeaderText="Address" />
        <asp:BoundField DataField="S_provinces_name" HeaderText="State/Provinces" />
        <asp:BoundField DataField="Shipping_price" HeaderText="Shipping price" />
        <asp:BoundField DataField="Printing_price" HeaderText="Printing price" />
        <asp:BoundField DataField="Amount" HeaderText="Amount" />
        <asp:BoundField DataField="P_methods_name" HeaderText="Payment Methods" />
        <asp:BoundField DataField="Customer_name" HeaderText="Customer name" />
        <asp:BoundField DataField="Status_name" HeaderText="Status" />
        <asp:BoundField DataField="Created_date" HeaderText="Created date" />
    </Columns>
</asp:GridView>
