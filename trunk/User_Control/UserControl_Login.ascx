<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserControl_Login.ascx.cs" Inherits="UserControl_Login" %>
&nbsp;&nbsp;<table>
    <caption>
        &nbsp;</caption>
    <tr>
        <td align="center" colspan="2">
            <asp:Label ID="lblLogin" runat="server">LOGIN</asp:Label><br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td align="right" style="height: 26px">
            <asp:Label ID="lblUsername" runat="server" Text="Username : "></asp:Label></td>
        <td style="height: 26px; width: 159px;">
            <asp:TextBox ID="txtUsername" runat="server" Width="158px"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="right" style="height: 26px">
            <asp:Label ID="lblPassword" runat="server" Text="Password : "></asp:Label></td>
        <td align="right" style="height: 26px; width: 159px;">
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="156px"></asp:TextBox></td>
    </tr>
    <tr>
        <td align="center" colspan="2" style="height: 43px">
            <asp:LinkButton ID="lbtRegister" runat="server" OnClick="lbtRegister_Click">Register</asp:LinkButton>
            <asp:LinkButton ID="lbtChangePass" runat="server">Change Pass</asp:LinkButton><br />
            <asp:Button ID="btnOk" runat="server" CausesValidation="False" 
                Text="OK" UseSubmitBehavior="False" OnClick="btnOk_Click"  />
            <asp:Button ID="btnCancel" runat="server" CausesValidation="False" Text="Cancel" UseSubmitBehavior="False" OnClick="btnCancel_Click" /></td>
    </tr>
</table>


