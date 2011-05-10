<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucMember.ascx.cs" Inherits="admin_wuc_wucMember" %>
<asp:GridView ID="grvMember" runat="server" CssClass="member" AutoGenerateColumns="False" OnRowCancelingEdit="grvMember_RowCancelingEdit" OnRowEditing="grvMember_RowEditing" OnRowUpdated="grvMember_RowUpdated" OnRowUpdating="grvMember_RowUpdating">
    <Columns>
        <asp:TemplateField HeaderText="Username">
            <EditItemTemplate>
                <asp:TextBox ID="lblUsername" runat="server" Text='<%# Bind("Username") %>' ReadOnly="true" ></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Username") %>' ></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Role">
            <EditItemTemplate>
                <asp:DropDownList ID="drlRole" runat="server" CssClass="editmod-l">
                </asp:DropDownList>
                <asp:Label ID="lblRole" runat="server" Text='<%# Bind("Role_id") %>' Visible="false"></asp:Label>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Role_name") %>' CssClass="editmod-l"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Status">
            <EditItemTemplate>
                <asp:DropDownList ID="drlStatus" runat="server" CssClass="editmod-l">
                </asp:DropDownList>&nbsp;
                <asp:Label ID="lblStatus" runat="server" Text='<%# Bind("Status_id") %>' Visible="false"></asp:Label>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Status_name") %>' CssClass="editmod-l"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" ItemStyle-CssClass="editmod-m" ItemStyle-VerticalAlign="Top" ItemStyle-HorizontalAlign="right" />
    </Columns>
</asp:GridView>
