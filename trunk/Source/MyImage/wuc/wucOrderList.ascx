<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrderList.ascx.cs" Inherits="wuc_wucOrderList" %>
<asp:Label ID="lblInfo" runat="server"></asp:Label><br />
<asp:GridView ID="grvOrder" runat="server" Width="580px" AutoGenerateColumns="False" OnRowCommand="grvOrder_RowCommand" OnRowCancelingEdit="grvOrder_RowCancelingEdit">
    <Columns>
        <asp:TemplateField HeaderText="ID">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
            </ItemTemplate>
            <ItemStyle CssClass="hide" />
            <HeaderStyle CssClass="hide" />
            <FooterStyle CssClass="hide" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="No">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("No") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblNo" runat="server" Text='<%# Bind("No") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="S_provinces_name" HeaderText="State/Provinces" />
        <asp:BoundField DataField="Amount" HeaderText="Amount"  >
            <ItemStyle HorizontalAlign="Right" />
        </asp:BoundField>
        <asp:BoundField DataField="Status_name" HeaderText="Status" />
        <asp:TemplateField HeaderText="StatusId">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Status_id") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblStatusId" runat="server" Text='<%# Bind("Status_id") %>'></asp:Label>
            </ItemTemplate>
            <ItemStyle CssClass="hide" />
            <HeaderStyle CssClass="hide" />
            <FooterStyle CssClass="hide" />
        </asp:TemplateField>
        <asp:BoundField DataField="Created_date" HeaderText="Created date" >
            <ItemStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:TemplateField HeaderText="Cancel" ShowHeader="False">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemTemplate>
                <asp:LinkButton ID="lbtnCancel" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CausesValidation="false" CommandName="cancel"
                    Text="X"></asp:LinkButton>
                <asp:Label ID="lblCancelDisable" runat="server" Text="Disable"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
