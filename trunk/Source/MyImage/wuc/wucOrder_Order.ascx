<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrder_Order.ascx.cs"
    Inherits="wuc_wucOrder_Order" %>
<table>
    <caption>
        Infomation Of User
    </caption>
    <tr>
        <td align="right">
            No.
        </td>
        <td>
            <asp:TextBox ID="txtNo" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            Content</td>
        <td>
            <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right">
            Address:
        </td>
        <td style="width: 162px">
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right">
            State/province
        </td>
        <td>
            <asp:DropDownList ID="drlStateProvince" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drlStateProvince_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right">
            Ship Days
        </td>
        <td>
            <asp:DropDownList ID="drlShipDay" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drlShipDay_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right">
            Ship. :</td>
        <td style="width: 162px">
            <asp:TextBox ID="txtShippingPrice" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            Print.:
        </td>
        <td style="width: 162px">
            <asp:TextBox ID="txtPrintingPrice" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right">
            Amount:
        </td>
        <td style="width: 162px">
            <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right">
            Payment method:
        </td>
        <td style="width: 162px">
            <asp:DropDownList ID="drlPaymenMethod" runat="server" OnSelectedIndexChanged="drlPaymenMethod_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList></td>
    </tr>   
        <tr>
         <td align="right" style="height: 21px" colspan="2">
        <div runat="server" id="div2" visible="false">        
                Expert date:
                <asp:TextBox ID="txtExpertDate" runat="server"></asp:TextBox><br />
                 Credit card number:
                <asp:TextBox ID="txtCCNumber" runat="server"></asp:TextBox><br />
                 CVV:
                 <asp:TextBox ID="txtCVV" runat="server"></asp:TextBox><br />
                  Holder Name:
                 <asp:TextBox ID="txtHolderName" runat="server"></asp:TextBox>
        
         </div>          
        </td>
        
        
        </tr>
    
    <tr>
        <td align="center" colspan="2">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
           
            <asp:Button ID="btnReset" runat="server" Text="Reset" />
         
         </td>   
    </tr>
</table>
