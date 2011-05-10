<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucStateProvince.ascx.cs" Inherits="admin_wuc_wucStateProvince" %>
<asp:GridView ID="grvStateProvince" runat="server" AutoGenerateColumns="False" CssClass="state-province" OnRowCancelingEdit="grvStateProvince_RowCancelingEdit" OnRowEditing="grvStateProvince_RowEditing" OnRowUpdated="grvStateProvince_RowUpdated" OnRowUpdating="grvStateProvince_RowUpdating" OnRowCommand="grvStateProvince_RowCommand" ShowFooter="True">
    <Columns>
        <asp:TemplateField HeaderText="ID" Visible="False">
            <EditItemTemplate>
                <asp:TextBox ID="txtId" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblId" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="State/Province(s)">
            <EditItemTemplate>
                <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
            </ItemTemplate>
            <FooterTemplate>
                 <asp:TextBox ID="txtNewSProvince" runat="server"></asp:TextBox>&nbsp;
                 <asp:Button ID="btnInsertNewRow" CommandName="InsertNewSProvince" runat="server" Text="Insert" />
                <br />
                <asp:Label ID="lblInsertError" runat="server" Text=" " ForeColor="DarkRed"></asp:Label>
            </FooterTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" />
    </Columns>
    <EmptyDataTemplate>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        
    </EmptyDataTemplate>
</asp:GridView>
