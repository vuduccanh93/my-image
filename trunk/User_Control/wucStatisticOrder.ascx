<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucStatisticOrder.ascx.cs" Inherits="admin_wuc_wucStatisticOrder" %>
&nbsp;<asp:Label ID="lbl1" runat="server" Font-Size="16pt" Text="Order from "></asp:Label>
&nbsp; &nbsp; &nbsp;<asp:TextBox ID="txt1" runat="server">2011/01/03</asp:TextBox>
&nbsp; &nbsp; &nbsp;<asp:Label ID="lbl2" runat="server" Font-Size="16pt" Text="to"></asp:Label>
&nbsp; &nbsp;&nbsp;
<asp:TextBox ID="txt2" runat="server">2011/05/07</asp:TextBox><br />
<br />
<asp:GridView ID="grvStatisticOrder" runat="server" AutoGenerateColumns="False" 
     ShowFooter="True" Width="437px" >
     
    <Columns>
        <asp:TemplateField HeaderText="No_Order">
            <EditItemTemplate>
                <asp:TextBox ID="txtNo_Order" runat="server" Text='<%# Bind("No") %>'></asp:TextBox>
            </EditItemTemplate>
                        
            <ItemTemplate>
                <asp:Label ID="lblNo_Order" runat="server" Text='<%# Bind("No") %>'></asp:Label>
            </ItemTemplate>
            
            <FooterStyle CssClass="editmod-hide" />
            <FooterTemplate>
                <asp:Label ID="lblAmoutOrder" runat="server" Text="Amount Order :"></asp:Label>
            </FooterTemplate>
            
        </asp:TemplateField>
        <asp:TemplateField HeaderText="FullName">
            <EditItemTemplate>
                <asp:TextBox ID="txtFullName" runat="server" Text='<%# Bind("Fullname") %>'></asp:TextBox>
            </EditItemTemplate>
            
            <FooterTemplate>
                &nbsp;<asp:TextBox ID="txtAmountOrder" runat="server" Width="90px"></asp:TextBox>
            </FooterTemplate>
            
            <ItemTemplate>
                <asp:Label ID="lblFullName" runat="server" Text='<%# Bind("Fullname") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Amount">
            <EditItemTemplate>
                <asp:TextBox ID="txtAmount" runat="server" Text='<%# Bind("Amount") %>'></asp:TextBox>
            </EditItemTemplate>
            
            <FooterTemplate>
                &nbsp;<asp:Label ID="lblAmountMoney" runat="server" Text="Amount Money :"></asp:Label>
            </FooterTemplate>
            
            <ItemTemplate>
                <asp:Label ID="lblAmount" runat="server" Text='<%# Bind("Amount") %>'></asp:Label>
            </ItemTemplate>            
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Created Date">        
            <EditItemTemplate>
                <asp:TextBox ID="txtCreatedDate" runat="server" Text='<%# Bind("Created_date") %>'></asp:TextBox>
            </EditItemTemplate>
            
             <ItemTemplate>
                <asp:Label ID="lblCreatedDate" runat="server" Text='<%# Bind("Created_date") %>'></asp:Label>
            </ItemTemplate>
            
            <FooterTemplate>
                <asp:TextBox ID="txtAmountMoney" runat="server" Width="90px"></asp:TextBox><br />
                <br />
                <asp:DropDownList ID="drlStatus" runat="server">
                </asp:DropDownList>
                
                <asp:Label ID="lblStatusId" runat="server" Text='<%# Bind("Status_id") %>' CssClass="editmod-hide" ></asp:Label>
                <asp:Label ID="lblStatus" runat="server" Text='<%# Bind("Status") %>'></asp:Label>
            </FooterTemplate>            
        </asp:TemplateField>                
        
    </Columns>
</asp:GridView>
