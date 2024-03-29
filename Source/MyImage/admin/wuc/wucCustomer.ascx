<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucCustomer.ascx.cs" Inherits="admin_wuc_wucCustomer" %>
			<div class="top-bar">
				<h1>  Customer </h1>
			</div>
<asp:GridView ID="grvCustomer" runat="server" AutoGenerateColumns="False" CssClass="listing" OnRowEditing="grvCustomer_RowEditing" OnRowCancelingEdit="grvCustomer_RowCancelingEdit" OnRowUpdated="grvCustomer_RowUpdated" EditRowStyle-CssClass="customer" OnRowUpdating="grvCustomer_RowUpdating" AllowPaging="True" >
    <Columns>
        <asp:TemplateField HeaderText="ID" HeaderStyle-CssClass="editmod-hide">
            <EditItemTemplate>
                <asp:TextBox ID="txtID" runat="server" Text='<%# Bind("ID") %>' CssClass="editmod-hide"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label6" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
            </ItemTemplate>
            <HeaderStyle CssClass="editmod-hide" />
            <FooterStyle CssClass="editmod-hide" />
            <ItemStyle CssClass="editmod-hide" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Username" >
            <EditItemTemplate>
                <asp:TextBox ID="txtUsername" runat="server" Text='<%# Bind("Username") %>' ReadOnly="True"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label5" runat="server" Text='<%# Bind("Username") %>'></asp:Label>
            </ItemTemplate>
            <ControlStyle CssClass="first style1" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="First name">
            <EditItemTemplate>
                <asp:TextBox ID="txtF_name" runat="server" ReadOnly="True" Text='<%# Bind("F_name") %>' CssClass="editmod-s" Width="80px"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("F_name") %>'></asp:Label>
            </ItemTemplate>
            <ControlStyle CssClass="editmod-m" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Last name">
            <EditItemTemplate>
                <asp:TextBox ID="txtL_name" runat="server" ReadOnly="True" Text='<%# Bind("L_name") %>' CssClass="editmod-s" Width="80px"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("L_name") %>'></asp:Label>
            </ItemTemplate>
            <ControlStyle CssClass="editmod-m" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Male">
            <EditItemTemplate>
                <asp:CheckBox ID="ckbGender" runat="server" ReadOnly="True" Checked='<%# Bind("Gender") %>' CssClass="editmod-s" />
            </EditItemTemplate>
            <ItemTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Gender") %>' Enabled="false" />
            </ItemTemplate>
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <ControlStyle CssClass="editmod-s" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Email">
            <EditItemTemplate>
                <asp:TextBox ID="txtEmail" runat="server" ReadOnly="True" Text='<%# Bind("Email") %>' CssClass="editmod-s" Width="90px"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label7" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
            </ItemTemplate>
            <ControlStyle CssClass="editmod-m" />
        </asp:TemplateField>
        <asp:BoundField DataField="Dob" HeaderText="Birthday" ReadOnly="True" Visible="False" />
        <asp:TemplateField HeaderText="Phone .no">
            <EditItemTemplate>
                <asp:TextBox ID="txtP_no" runat="server" ReadOnly="True" Text='<%# Bind("P_no") %>' Width="90px"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("P_no") %>'></asp:Label>
            </ItemTemplate>
            <ControlStyle CssClass="editmod-s" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Address">
            <EditItemTemplate>
                <asp:TextBox ID="txtAddress" runat="server" ReadOnly="True" Text='<%# Bind("Address") %>' TextMode="MultiLine" CssClass="editmod-s" Width="140px"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Address") %>'></asp:Label>
            </ItemTemplate>
            <ControlStyle CssClass="editmod-m" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Status">
            <EditItemTemplate>
                <asp:DropDownList ID="drlStatus" runat="server" Width="55px">
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
