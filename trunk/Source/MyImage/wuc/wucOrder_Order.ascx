<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrder_Order.ascx.cs"
    Inherits="wuc_wucOrder_Order" %>
    <img id="Img1" src="~/inc/img/o_s4.png" runat="server" alt="" />
<table>
    <caption>
        Infomation Of User
    </caption>
    <tr>
        <td align="right">
            No.
        </td>
        <td>
            <asp:TextBox CssClass="inputfield" ID="txtNo" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            Content</td>
        <td>
            <asp:TextBox CssClass="inputfield" Width="490px" Height="130px" ID="txtContent" runat="server" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right">
            Address:
        </td>
        <td style="width: 162px">
            <asp:TextBox CssClass="inputfield" ID="txtAddress" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right">
            State/province
        </td>
        <td>
            <asp:DropDownList ID="drlStateProvince" CssClass="dropdownfield" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drlStateProvince_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right">
            Ship Days
        </td>
        <td>
            <asp:DropDownList CssClass="dropdownfield" ID="drlShipDay" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drlShipDay_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right">
            Ship. :</td>
        <td style="width: 162px">
            <asp:TextBox CssClass="inputfield" ID="txtShippingPrice" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            Print.:
        </td>
        <td style="width: 162px">
            <asp:TextBox CssClass="inputfield" ID="txtPrintingPrice" runat="server" ReadOnly="True"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right">
            Amount:
        </td>
        <td style="width: 162px">
            <asp:TextBox CssClass="inputfield" ID="txtAmount" runat="server" ReadOnly="True"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right">
            Payment method:
        </td>
        <td style="width: 162px">
            <asp:DropDownList CssClass="dropdownfield" ID="drlPaymenMethod" runat="server" OnSelectedIndexChanged="drlPaymenMethod_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList></td>
    </tr>   
        <tr>
            <td></td>
         <td align="left" style="height: 21px" >
        <div runat="server" id="div2" visible="false">
                Expert date:<br />
            <asp:DropDownList ID="drlExpertDate_M" CssClass="dropdownfield" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="drlExpertDate_Y" CssClass="dropdownfield" runat="server">
            </asp:DropDownList>
                <br />
                 Credit card number:<br />
                <asp:TextBox CssClass="inputfield" ID="txtCCNumber" runat="server"></asp:TextBox><br />
                 CVV:<br />
                 <asp:TextBox CssClass="inputfield" ID="txtCVV" runat="server"></asp:TextBox><br />
                  Holder Name:<br />
                 <asp:TextBox  CssClass="inputfield" ID="txtHolderName" runat="server"></asp:TextBox>
        
         </div>          
        </td>
        
        
        </tr>
    
    <tr>
        <td align="center" colspan="2">
            <asp:Button ID="btnSubmit" CssClass="cusbutton" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
           
            <asp:Button ID="btnReset" CssClass="cusbutton" runat="server" Text="Reset" />
         
         </td>   
    </tr>
</table>
