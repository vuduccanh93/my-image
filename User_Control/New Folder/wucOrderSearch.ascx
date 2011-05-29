<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrderSearch.ascx.cs" Inherits="admin_wuc_wucOrderSearch" %>
<asp:Label ID="lblNo" runat="server" Text="No :"></asp:Label>
<asp:TextBox ID="txtNo" runat="server"></asp:TextBox><br />
<asp:Label ID="lblProvince" runat="server" Text="Province :"></asp:Label>
<asp:TextBox ID="txtProvince" runat="server"></asp:TextBox><br />
<asp:Label ID="lblCustomer" runat="server" Text="Customer"></asp:Label>
<asp:TextBox ID="txtCustomer" runat="server"></asp:TextBox>
<br />
<asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />&nbsp;
<br />
<br />
<asp:GridView ID="grvOrder" runat="server" AutoGenerateColumns="False" >
    <Columns>
        <asp:BoundField DataField="ID" HeaderText="ID" Visible="False" />
        <asp:BoundField DataField="No" HeaderText="No" />
        <asp:BoundField DataField="Order_content" HeaderText="Order content" Visible="False" />
        <asp:BoundField DataField="Customer_name" HeaderText="Fullname" />
        <asp:BoundField DataField="Address" HeaderText="Address" Visible="False" />
        <asp:BoundField DataField="S_provinces_id" HeaderText="Provinces id" Visible="False" />
        <asp:BoundField DataField="Shipping_price" HeaderText="Shipping price" Visible="False">
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </asp:BoundField>
        <asp:BoundField DataField="Printing_price" HeaderText="Printing price" Visible="False">
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </asp:BoundField>
        <asp:BoundField DataField="S_provinces_name" HeaderText="Province/State" />
        <asp:BoundField DataField="P_methods_id" HeaderText="Methods id" Visible="False" />
        <asp:BoundField DataField="P_Methods_name" HeaderText="Payment">
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </asp:BoundField>
        <asp:BoundField DataField="Amount" HeaderText="Amount">
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </asp:BoundField>
        <asp:BoundField DataField="C_cards_id" HeaderText="Cards id" Visible="False" />
        <asp:BoundField DataField="Customer_id" HeaderText="Customer id" Visible="False" />
        <asp:BoundField DataField="Username" HeaderText="Username" Visible="False" />
        <asp:BoundField DataField="Status_name" HeaderText="Status">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:BoundField>
        <asp:BoundField DataField="Created_date" HeaderText="Created date">
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </asp:BoundField>
    </Columns>
</asp:GridView>
