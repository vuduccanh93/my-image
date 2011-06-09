<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucMember.ascx.cs" Inherits="admin_wuc_wucMember" %>
			<div class="top-bar">
				<h1>  Member </h1>
			</div>
<asp:GridView ID="grvMember" runat="server" CssClass="listing" AutoGenerateColumns="False" OnRowCancelingEdit="grvMember_RowCancelingEdit" OnRowEditing="grvMember_RowEditing" OnRowUpdated="grvMember_RowUpdated" OnRowUpdating="grvMember_RowUpdating">
    <Columns>
        <asp:TemplateField HeaderText="ID">
            <EditItemTemplate>
                <asp:Label ID="lblId" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
            </ItemTemplate>
            <ItemStyle CssClass="editmod-hide" />
            <HeaderStyle CssClass="editmod-hide" />
            <FooterStyle CssClass="editmod-hide" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Username">
            <EditItemTemplate>
                <asp:TextBox ID="txtUsername" runat="server" Text='<%# Bind("Username") %>' ReadOnly="true" CssClass="first style1"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Username") %>' ></asp:Label>
            </ItemTemplate>
            <ControlStyle CssClass="first style1" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Password">
            <EditItemTemplate>
                <asp:TextBox ID="txtPassword" runat="server" Text='<%# Bind("Password") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label5" runat="server" Text='<%# Bind("Password") %>'></asp:Label>
            </ItemTemplate>
            <ItemStyle CssClass="editmod-hide" />
            <HeaderStyle CssClass="editmod-hide" />
            <FooterStyle CssClass="editmod-hide" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Role">
            <EditItemTemplate>
                <asp:DropDownList ID="drlRole" runat="server" >
                </asp:DropDownList>
                <asp:Label ID="lblRole" runat="server" Text='<%# Bind("Role_id") %>' Visible="false"></asp:Label>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Role_name") %>' ></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Status">
            <EditItemTemplate>
                <asp:DropDownList ID="drlStatus" runat="server" >
                </asp:DropDownList>
                <asp:Label ID="lblStatus" runat="server" Text='<%# Bind("Status_id") %>' Visible="false"></asp:Label>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Status_name") %>' CssClass="editmod-l"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" >
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Top" />
        </asp:CommandField>
    </Columns>
</asp:GridView>
