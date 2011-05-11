<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucRegisterSuccess.ascx.cs" Inherits="wuc_wucRegisterSuccess" %>
<table>
    <tr>
    <td align="right"> 
        <asp:Label ID="lblUsername" runat="server" Text="Username : "></asp:Label></td>
        <td style="width: 185px">
            <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td align="right"> 
        <asp:Label ID="lblPassword" runat="server" Text="Password :"></asp:Label></td>
        <td style="width: 185px">
            <asp:Label ID="lblPass" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td colspan ="2"> 
        <asp:Label ID="lblWarning" runat="server" BackColor="White" Text="Much Remmeber UserName and Password"></asp:Label></td>

    </tr>
</table>

