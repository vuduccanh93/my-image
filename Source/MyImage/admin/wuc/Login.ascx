<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="admin_wuc_Login" %>
<table>
    <tr>
        <th colspan="2"><asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red" /></th>
    </tr>
    <tr>
        <td>Username:</td>
        <td>
            <asp:TextBox ID="txtUsername" runat="server" />
        </td>
    </tr>
    <tr>
        <td >Password:</td>
        <td >
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" />
        </td>
    </tr>
    <tr>
        <th colspan="2">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="submit_Click" />
        </th>
    </tr>
</table>