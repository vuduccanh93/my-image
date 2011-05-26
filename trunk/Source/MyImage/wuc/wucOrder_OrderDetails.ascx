<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrder_OrderDetails.ascx.cs" Inherits="wuc_wucOrder_OrderDetails" %>
<asp:GridView ID="grvUploadDetails" runat="server" AutoGenerateColumns="False" CssClass="upload_orderdetails" >
    <Columns>
        <asp:TemplateField HeaderText="ID">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:ImageField DataImageUrlField="ImgLink" HeaderText="Image">
            <ControlStyle Height="100px" Width="100px" />
        </asp:ImageField>
        <asp:TemplateField>
            <ItemTemplate >
                <asp:PlaceHolder ID="phlPrintingPrice" runat="server"></asp:PlaceHolder>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
&nbsp;
