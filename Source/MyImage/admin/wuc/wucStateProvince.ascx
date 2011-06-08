<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucStateProvince.ascx.cs" Inherits="admin_wuc_wucStateProvince" %>
<asp:Label ID="lblLabel" runat="server" Text="Label"></asp:Label>
<asp:GridView ID="grvStateProvince" runat="server" AutoGenerateColumns="False" CssClass="listing" OnRowCancelingEdit="grvStateProvince_RowCancelingEdit" OnRowEditing="grvStateProvince_RowEditing" OnRowUpdated="grvStateProvince_RowUpdated" OnRowUpdating="grvStateProvince_RowUpdating" OnRowCommand="grvStateProvince_RowCommand" ShowFooter="True" AllowPaging="True" OnPageIndexChanging="grvStateProvince_PageIndexChanging" PageSize="5">
    <Columns>
        <asp:TemplateField HeaderText="ID" Visible="False">
            <EditItemTemplate>
                <asp:TextBox ID="txtId" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblId" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
            </ItemTemplate>
            <ControlStyle CssClass="first style1" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="State/Province">
            <EditItemTemplate>
                <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
            </ItemTemplate>
            <HeaderTemplate>
            </HeaderTemplate>
            <FooterTemplate>
                <asp:TextBox ID="txtNewSProvince" runat="server" ></asp:TextBox>
            </FooterTemplate>
            <FooterStyle CssClass="first style2" />
            <ItemStyle CssClass="first style2" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Available">
            <EditItemTemplate>
                <asp:CheckBox ID="ckbAvailable" runat="server" Checked='<%# Bind("Available") %>'/>
            </EditItemTemplate>
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Available") %>' Enabled="false" />
            </ItemTemplate>
            <FooterTemplate>
                <div style="vertical-align: middle; text-align: center">
                <asp:CheckBox ID="ckbNewAvailable" runat="server" CssClass="text-center"/>
                </div>
            </FooterTemplate>
            <FooterStyle CssClass="first style1" />
        </asp:TemplateField>
        <asp:TemplateField>
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
            </EditItemTemplate>
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </ItemTemplate>
            <FooterTemplate>
                <div>
                    <asp:Button ID="btnInsertNewRow" CommandName="InsertNewSProvince" runat="server" Text="Insert" />
                </div>
            </FooterTemplate>
            <FooterStyle CssClass="style2" />
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" />
    </Columns>
    <EmptyDataTemplate>
    </EmptyDataTemplate>
</asp:GridView>
