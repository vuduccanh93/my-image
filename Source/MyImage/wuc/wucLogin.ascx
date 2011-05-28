<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucLogin.ascx.cs" Inherits="wuc_wucLogin" %>
<div class="login_box">
    <div class="form">
        <table>
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="lblStatusLogin" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td style="height: 26px" align="right">
                    <asp:Label ID="lblUsername" runat="server" Text="Username : "></asp:Label></td>
                <td style="height: 26px">
                    <asp:TextBox ID="txtUsername" CssClass="inputfield" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 26px" align="right">
                    <asp:Label ID="lblPassword" runat="server" Text="Password : "></asp:Label></td>
                <td style="height: 26px" align="left">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="inputfield" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" align="right">
                    <asp:Button ID="btnLogin" CssClass="loginbutton" runat="server" CausesValidation="False"
                        UseSubmitBehavior="False" OnClick="btnLogin_Click" />
                </td>
            </tr>
        </table>
    </div>
</div>
