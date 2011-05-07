<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucCustomer.ascx.cs" Inherits="admin_wuc_wucCustomer" %>
<asp:GridView ID="grvCustomer" runat="server" AutoGenerateColumns="False" CssClass="customer" OnRowEditing="grvCustomer_RowEditing" OnRowCancelingEdit="grvCustomer_RowCancelingEdit" OnRowUpdated="grvCustomer_RowUpdated" Width="810px" OnRowUpdating="grvCustomer_RowUpdating" AllowPaging="True">
    <Columns>
        <asp:TemplateField HeaderText="ID" Visible="False">
            <EditItemTemplate>
                <asp:TextBox ID="txtID" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label6" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Username">
            <EditItemTemplate>
                <asp:TextBox ID="txtUsername" runat="server" Text='<%# Bind("Username") %>' ReadOnly="True"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label5" runat="server" Text='<%# Bind("Username") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="First name">
            <EditItemTemplate>
                <asp:TextBox ID="txtF_name" runat="server" Text='<%# Bind("F_name") %>' Width="150px"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("F_name") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Last name">
            <EditItemTemplate>
                <asp:TextBox ID="txtL_name" runat="server" Text='<%# Bind("L_name") %>' Width="150px"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("L_name") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Male">
            <EditItemTemplate>
                <asp:CheckBox ID="ckbGender" runat="server" Checked='<%# Bind("Gender") %>' />
            </EditItemTemplate>
            <ItemTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Gender") %>' Enabled="false" />
            </ItemTemplate>
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:TemplateField>
        <asp:BoundField DataField="Dob" HeaderText="Birthday" Visible="False" />
        <asp:TemplateField HeaderText="Phone .no">
            <EditItemTemplate>
                <asp:TextBox ID="txtP_no" runat="server" Text='<%# Bind("P_no") %>' Width="150px"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("P_no") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Address">
            <EditItemTemplate>
                <asp:TextBox ID="txtAddress" runat="server" Text='<%# Bind("Address") %>' Width="150px"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Address") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:CommandField HeaderText="Order(s)" SelectText="View" ShowCancelButton="False"
            ShowSelectButton="True">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:CommandField>
        <asp:CommandField ShowEditButton="True" />
    </Columns>
</asp:GridView>
