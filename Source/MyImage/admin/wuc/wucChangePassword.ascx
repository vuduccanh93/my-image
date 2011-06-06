<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucChangePassword.ascx.cs" Inherits="admin_wuc_wucChangePassword" %>
<table>
    <caption>  Change Password </caption>
    <tr>
        <td colspan="2" align="center">
            <asp:Label ID="lblLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td style="height: 28px" align="right">
            Password :
        </td>
        <td style="height: 28px">
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
    </tr>
     <tr>
        <td align="right">
            New password :
        </td>
        <td>
            <asp:TextBox ID="txtNewpassword" runat="server" TextMode="Password"></asp:TextBox></td>
    </tr>
     <tr>
        <td align="right">
            Cof. password :
        </td>
        <td>
            <asp:TextBox ID="txtCofpassword" runat="server" TextMode="Password"></asp:TextBox></td>
    </tr>
    <tr>
        <td colspan="2" align="center">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnReset" runat="server" Text="Reset" /></td>
    </tr>
</table>