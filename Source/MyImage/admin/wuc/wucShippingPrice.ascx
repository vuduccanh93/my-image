<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucShippingPrice.ascx.cs" Inherits="admin_wuc_wucShippingPrice" %>
			<div class="top-bar">
				<h1>  Shipping Price </h1>
			</div>
<asp:GridView ID="grvPrintingPrice" runat="server" AutoGenerateColumns="False" CssClass="listing" OnRowCancelingEdit="grvPrintingPrice_RowCancelingEdit" OnRowCommand="grvPrintingPrice_RowCommand" OnRowEditing="grvPrintingPrice_RowEditing" OnRowUpdated="grvPrintingPrice_RowUpdated" OnRowUpdating="grvPrintingPrice_RowUpdating" ShowFooter="True" AllowPaging="True" PageSize="4" OnPageIndexChanging="grvPrintingPrice_PageIndexChanging">
    <Columns>
        <asp:TemplateField HeaderText="ID">
            <EditItemTemplate>
                <asp:TextBox ID="txtId" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
            </ItemTemplate>
            <ItemStyle CssClass="editmod-hide" />
            <HeaderStyle CssClass="editmod-hide" />
            <FooterTemplate>
            </FooterTemplate>
            <FooterStyle CssClass="editmod-hide" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="State/Province ID" Visible="False">
            <EditItemTemplate>
                <asp:TextBox ID="txtSpId" runat="server" Text='<%# Bind("S_providers_id") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label5" runat="server" Text='<%# Bind("S_providers_id") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="State/Province name">
            <EditItemTemplate>
                <asp:DropDownList ID="drlStateProvince" runat="server">
                </asp:DropDownList>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("S_providers_name") %>'></asp:Label>
            </ItemTemplate>
            <FooterTemplate>
                <asp:DropDownList ID="drlNewSProvince" runat="server">
                </asp:DropDownList>
            </FooterTemplate>
            <FooterStyle CssClass="first style1" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Shipping time">
            <EditItemTemplate>
                <asp:TextBox ID="txtShippingTime" runat="server" CssClass="editmod-xs" Text='<%# Bind("Ship_time") %>' Width="60px"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Ship_time") %>'></asp:Label>
            </ItemTemplate>
            <FooterTemplate>
                <asp:TextBox ID="txtNewShippingTime" runat="server"></asp:TextBox>
            </FooterTemplate>
            <FooterStyle CssClass="first style1" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Price">
            <EditItemTemplate>
                <asp:TextBox ID="txtPrice" runat="server" Text='<%# Bind("Price") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Price") %>'></asp:Label>
            </ItemTemplate>
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
            <FooterTemplate>
                <asp:TextBox ID="txtNewPrice" runat="server"></asp:TextBox>
            </FooterTemplate>
            <FooterStyle CssClass="first style1" />
        </asp:TemplateField>
        <asp:TemplateField>
            <FooterTemplate>
                <asp:Button ID="btnNewInsert" runat="server" CommandName="NewInsert" Text="Insert" />
            </FooterTemplate>
            <FooterStyle CssClass="style2" />
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" />
    </Columns>
</asp:GridView>
