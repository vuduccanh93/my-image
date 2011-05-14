<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucCustomer.ascx.cs" Inherits="admin_wuc_wucCustomer" %>
<asp:GridView ID="grvCustomer" runat="server" AutoGenerateColumns="False" CssClass="customer" OnRowEditing="grvCustomer_RowEditing" OnRowCancelingEdit="grvCustomer_RowCancelingEdit" OnRowUpdated="grvCustomer_RowUpdated" EditRowStyle-CssClass="customer" OnRowUpdating="grvCustomer_RowUpdating" AllowPaging="True" >
    <Columns>
        <asp:TemplateField HeaderText="ID" Visible="False" >
            <EditItemTemplate>
                <asp:TextBox ID="txtID" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label6" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Username" >
            <EditItemTemplate>
                <asp:TextBox ID="txtUsername" runat="server" Text='<%# Bind("Username") %>' ReadOnly="True" CssClass="editmod-l"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label5" runat="server" Text='<%# Bind("Username") %>'></asp:Label>
            </ItemTemplate>
            <ControlStyle CssClass="editmod-s" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="First name">
            <EditItemTemplate>
                <asp:TextBox ID="txtF_name" runat="server" Text='<%# Bind("F_name") %>' CssClass="editmod-m"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("F_name") %>'></asp:Label>
            </ItemTemplate>
            <ControlStyle CssClass="editmod-m" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Last name">
            <EditItemTemplate>
                <asp:TextBox ID="txtL_name" runat="server" Text='<%# Bind("L_name") %>' CssClass="editmod-m"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("L_name") %>'></asp:Label>
            </ItemTemplate>
            <ControlStyle CssClass="editmod-m" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Male">
            <EditItemTemplate>
                <asp:CheckBox ID="ckbGender" runat="server" Checked='<%# Bind("Gender") %>' CssClass="editmod-s" />
            </EditItemTemplate>
            <ItemTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Gender") %>' Enabled="false" />
            </ItemTemplate>
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <ControlStyle CssClass="editmod-s" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Email">
            <EditItemTemplate>
                <asp:TextBox ID="txtEmail" runat="server" Text='<%# Bind("Email") %>' CssClass="editmod-m"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label7" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
            </ItemTemplate>
            <ControlStyle CssClass="editmod-m" />
        </asp:TemplateField>
        <asp:BoundField DataField="Dob" HeaderText="Birthday" Visible="False" />
        <asp:TemplateField HeaderText="Phone .no">
            <EditItemTemplate>
                <asp:TextBox ID="txtP_no" runat="server" Text='<%# Bind("P_no") %>' CssClass="editmod-s"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("P_no") %>'></asp:Label>
            </ItemTemplate>
            <ControlStyle CssClass="editmod-s" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Address">
            <EditItemTemplate>
                <asp:TextBox ID="txtAddress" runat="server" Text='<%# Bind("Address") %>' TextMode="MultiLine" CssClass="editmod-m"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Address") %>'></asp:Label>
            </ItemTemplate>
            <ControlStyle CssClass="editmod-m" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Status">
            <EditItemTemplate>
                <asp:DropDownList ID="drlStatus" runat="server">
                </asp:DropDownList>
                <asp:Label ID="lblStatusId" runat="server" Text='<%# Bind("Status_id") %>' CssClass="editmod-hide"></asp:Label>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblStatus" runat="server" Text='<%# Bind("Status") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:HyperLinkField HeaderText="Order(s)" Text="View" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="../?t=or&amp;cusid={0}" >
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:HyperLinkField>
        <asp:CommandField ShowEditButton="True" />
    </Columns>
    <EditRowStyle CssClass="customer" />
</asp:GridView>
