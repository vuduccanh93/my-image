<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucLogin.ascx.cs" Inherits="wuc_wucLogin" %>
<table>
    <caption> Login Form </caption>
    <tr>
        <td colspan="2" align="center"><asp:Label ID="lblStatusLogin" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td style="height: 26px" align="right">
            <asp:Label ID="lblUsername" runat="server" Text="Username : "></asp:Label></td>
        <td style="height: 26px">
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td style="height: 26px" align="right">
            <asp:Label ID="lblPassword" runat="server" Text="Password : "></asp:Label></td>
        <td style="height: 26px" align="right">
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td colspan ="2" align="center">
            <asp:Button ID="btnLogin" runat="server" CausesValidation="False" Text="Login" UseSubmitBehavior="False" OnClick="btnLogin_Click" />
            <asp:Button ID="btnReset" runat="server" CausesValidation="False" Text="Reset" UseSubmitBehavior="False" /></td>
    </tr>
</table>