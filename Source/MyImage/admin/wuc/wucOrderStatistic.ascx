<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrderStatistic.ascx.cs" Inherits="admin_wuc_wucStatisticOrder" %>
<table border="0" class='statistic-price'>
    <tr>
        <td style="height: 26px" align="right" valign="middle">
            Payment status:</td>
        <td style="height: 26px" valign="middle">
            <asp:DropDownList ID="drlOrderStatus" runat="server">
            </asp:DropDownList>
        </td>
        <td align="right" style="height: 26px" valign="middle">
            From:</td>
        <td style="height: 26px" valign="middle">
            <input id="txtFrom" name="txtFrom" type="text" readonly="readOnly" />
            <script type="text/javascript" language="javascript">
	            new tcal ({
		                'formname': 'aspnetForm',
		                'controlname': 'txtFrom'
	                });
	        </script>
        </td>
        <td align="right" style="height: 26px" valign="middle">
            To:</td>
        <td style="height: 26px" valign="middle">
            <input id="txtTo" name="txtTo" type="text" readonly="readOnly" />
            <script type="text/javascript" language="javascript">
	            new tcal ({
		                'formname': 'aspnetForm',
		                'controlname': 'txtTo'
	                });
	        </script>
        </td>
        <th style="height: 26px" valign="middle">
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </th>
    </tr>
    <tr>
        <th colspan="7" align="left">
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </th>
    </tr>
    <tr>
        <th colspan="3" align="left">
            Found:
            <asp:Label ID="lblRowCount" runat="server"></asp:Label>
            order(s)
        </th>
        <th colspan="4" align="left">
            Sum:
            <asp:Label ID="lblSum" runat="server"></asp:Label>
            USD
        </th>
    </tr>
</table>
<asp:Label ID="lblInfo" runat="server" Font-Bold="True" ForeColor="#C00000"></asp:Label><br />
<asp:GridView ID="grvStatisticOrder" runat="server" AutoGenerateColumns="False" CssClass="order" >
    <Columns>
        <asp:TemplateField HeaderText="No">
            <EditItemTemplate>
                <asp:TextBox ID="txtNo_Order" runat="server" Text='<%# Bind("No") %>'></asp:TextBox>
            </EditItemTemplate>     
            <ItemTemplate>
                <asp:Label ID="lblNo_Order" runat="server" Text='<%# Bind("No") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="FullName">
            <EditItemTemplate>
                <asp:TextBox ID="txtFullName" runat="server" Text='<%# Bind("Fullname") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblFullName" runat="server" Text='<%# Bind("Fullname") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Amount">
            <EditItemTemplate>
                <asp:TextBox ID="txtAmount" runat="server" Text='<%# Bind("Amount") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblAmount" runat="server" Text='<%# Bind("Amount") %>'></asp:Label>
            </ItemTemplate>            
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Date">        
            <EditItemTemplate>
                <asp:TextBox ID="txtCreatedDate" runat="server" Text='<%# Bind("Created_date") %>'></asp:TextBox>
            </EditItemTemplate>
             <ItemTemplate>
                <asp:Label ID="lblCreatedDate" runat="server" Text='<%# Bind("Created_date") %>'></asp:Label>
            </ItemTemplate>           
        </asp:TemplateField>                
    </Columns>
</asp:GridView>
