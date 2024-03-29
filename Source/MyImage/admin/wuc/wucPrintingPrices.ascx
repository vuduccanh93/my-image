<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucPrintingPrices.ascx.cs" Inherits="admin_wuc_wucPrintingPrices" %>
			<div class="top-bar">
				<h1>  Printing Price </h1>
			</div>
<asp:GridView ID="grvPrintingPrices" runat="server" AutoGenerateColumns="False"  OnRowCancelingEdit="grvPrintingPrices_RowCancelingEdit"  OnRowEditing="grvPrintingPrices_RowEditing" OnRowUpdated="grvPrintingPrices_RowUpdated" ShowFooter="True" OnRowUpdating="grvPrintingPrices_RowUpdating" OnRowCommand="grvPrintingPrices_RowCommand" CssClass="listing"> 
    <Columns>
        <asp:TemplateField HeaderText="ID">
            <EditItemTemplate>
                <asp:TextBox ID="txtId" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblId" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
            </ItemTemplate>
            <ItemStyle CssClass="editmod-hide" />
            <HeaderStyle CssClass="editmod-hide" />
            <FooterStyle CssClass="editmod-hide" />
        </asp:TemplateField>        
        <asp:TemplateField HeaderText="Size">
            <EditItemTemplate>
                <asp:TextBox ID="txtSize" runat="server" Text='<%# Bind("Size") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblSize" runat="server" Text='<%# Bind("Size") %>'></asp:Label>
            </ItemTemplate>                        
            <FooterTemplate>
                <asp:TextBox ID="txtNewSize" runat="server"></asp:TextBox>
                <asp:Label id="lblNewSizeErr" ForeColor="red" runat="server"></asp:Label>
            </FooterTemplate>
            <FooterStyle CssClass="first style1" />
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Price">        
            <EditItemTemplate>
                <asp:TextBox ID="txtPrice" runat="server" Text='<%# Bind("Price") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblPrice" runat="server" Text='<%# Bind("Price") %>'></asp:Label>
            </ItemTemplate>
            <FooterTemplate>
                <asp:TextBox ID="txtNewPrice" runat="server"></asp:TextBox>
                <asp:Label id="lblPriceErr" ForeColor="red" runat="server"></asp:Label>
            </FooterTemplate>
            <FooterStyle CssClass="first style1" />
        </asp:TemplateField>   
        <asp:TemplateField>
            <FooterTemplate>
                <asp:Button ID="btnNewInsert" runat="server" CommandName="NewInsert" Text=" Insert" CssClass="text-center" />
            </FooterTemplate>
            <FooterStyle CssClass="style2" />
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" DeleteText="" />
    </Columns>
</asp:GridView>

