<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrder.ascx.cs" Inherits="admin_wuc_wucOrder" %>
			<div class="top-bar">
				<h1>  Order </h1>
				<div class="breadcrumbs"><h2><asp:HyperLink ID="hplOrderStatistic" runat="server">Search Order</asp:HyperLink></h2><br /></div>
			</div>
<asp:GridView ID="grvOrder" runat="server" AutoGenerateColumns="False" CssClass="listing" >
    <Columns>
        <asp:BoundField DataField="ID" HeaderText="ID" Visible="False" />
        <asp:BoundField DataField="No" HeaderText="No" ControlStyle-CssClass="first style1" />
        <asp:BoundField DataField="Order_content" HeaderText="Order content" Visible="False" />
        <asp:BoundField DataField="Customer_name" HeaderText="Fullname" />
        <asp:BoundField DataField="Address" HeaderText="Address" Visible="False" />
        <asp:BoundField DataField="S_provinces_id" HeaderText="Provinces id" Visible="False" />
        <asp:BoundField DataField="Shipping_price" HeaderText="Shipping price" Visible="False" >
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </asp:BoundField>
        <asp:BoundField DataField="Printing_price" HeaderText="Printing price" Visible="False" >
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </asp:BoundField>
        <asp:BoundField DataField="S_provinces_name" HeaderText="Province/State" />
        <asp:BoundField DataField="P_methods_id" HeaderText="Methods id" Visible="False" />
        <asp:BoundField DataField="P_Methods_name" HeaderText="Payment" >
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </asp:BoundField>
        <asp:BoundField DataField="Amount" HeaderText="Amount" >
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </asp:BoundField>
        <asp:BoundField DataField="C_cards_id" HeaderText="Cards id" Visible="False" />
        <asp:BoundField DataField="Customer_id" HeaderText="Customer id" Visible="False" />
        <asp:BoundField DataField="Username" HeaderText="Username" Visible="False" />
        <asp:BoundField DataField="Status_name" HeaderText="Status" >
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:BoundField>
        <asp:BoundField DataField="Created_date" HeaderText="Created date" >
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </asp:BoundField>
        <asp:HyperLinkField HeaderText="Detail" Text="View" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="../?t=or&amp;oid={0}" >
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:HyperLinkField>
    </Columns>
</asp:GridView>
