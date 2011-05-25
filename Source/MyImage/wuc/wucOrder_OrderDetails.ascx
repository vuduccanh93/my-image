<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrder_OrderDetails.ascx.cs" Inherits="wuc_wucOrder_OrderDetails" %>
<asp:GridView ID="grvUploadDetails" runat="server" AutoGenerateColumns="False" >
    <Columns>
        <asp:TemplateField HeaderText="Checkbox">
            <ItemTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ID">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:ImageField DataImageUrlField="ImgLink" HeaderText="Image">
            <ItemStyle Height="100px" HorizontalAlign="Center" VerticalAlign="Top" Width="100px" />
            <ControlStyle Height="100px" Width="100px" />
        </asp:ImageField>
        <asp:TemplateField>
            <ItemTemplate >
                <asp:PlaceHolder ID="phlPrintingPrice" runat="server"></asp:PlaceHolder>
            </ItemTemplate>
            <ItemStyle VerticalAlign="Top" />
        </asp:TemplateField>
    </Columns>
</asp:GridView>
&nbsp;
