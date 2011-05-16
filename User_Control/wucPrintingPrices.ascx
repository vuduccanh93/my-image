<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucPrintingPrices.ascx.cs" Inherits="admin_wuc_wucPrintingPrices" %>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
<asp:Label ID="lblPrintingPrice" runat="server" Text="Printing Prices" Font-Size="16pt" Height="27px" Width="133px"></asp:Label>
&nbsp; &nbsp;<br />
<br />
&nbsp;&nbsp;&nbsp;<asp:GridView ID="grvPrintingPrices" runat="server" AutoGenerateColumns="False"  OnRowCancelingEdit="grvPrintingPrices_RowCancelingEdit"  OnRowEditing="grvPrintingPrices_RowEditing" OnRowUpdated="grvPrintingPrices_RowUpdated" ShowFooter="True" OnRowUpdating="grvPrintingPrices_RowUpdating" OnRowCommand="grvPrintingPrices_RowCommand"> 
    <Columns>
        
        <asp:TemplateField HeaderText="ID" >
            <EditItemTemplate>
                <asp:TextBox ID="txtId" runat="server" Text='<%# Bind("ID") %>' CssClass="editmod-hide"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblId" runat="server" Text='<%# Bind("ID") %>' CssClass="editmod-hide"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>        
        
        <asp:TemplateField HeaderText="Size">
            <EditItemTemplate>
                <asp:TextBox ID="txtSize" runat="server" Text='<%# Bind("Size") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblSize" runat="server" Text='<%# Bind("Size") %>'></asp:Label>
            </ItemTemplate>                        
            <HeaderTemplate>
                &nbsp;
                <asp:TextBox ID="txtNewSize" runat="server" OnTextChanged="txtNewSize_TextChanged"></asp:TextBox>
            </HeaderTemplate>
            <FooterTemplate>
                &nbsp;
            </FooterTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Price">        
            <EditItemTemplate>
                <asp:TextBox ID="txtPrice" runat="server" Text='<%# Bind("Price") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblPrice" runat="server" Text='<%# Bind("Price") %>'></asp:Label>
            </ItemTemplate>    
            <HeaderTemplate>
                &nbsp;
                <asp:TextBox ID="txtNewPrice" runat="server"></asp:TextBox>
            </HeaderTemplate>
            <FooterTemplate>
                &nbsp;
            </FooterTemplate>
        </asp:TemplateField>   
        <asp:TemplateField>
            <HeaderTemplate>
                <asp:Button ID="btnNewInsert" runat="server" CommandName="NewInsert" Text=" Insert" />
            </HeaderTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" DeleteText="" />
    </Columns>
</asp:GridView>
<br />
<br />
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;
&nbsp; &nbsp; &nbsp;

