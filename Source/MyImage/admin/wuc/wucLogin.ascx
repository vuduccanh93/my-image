<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucLogin.ascx.cs" Inherits="admin_wuc_Login" %>
<div id="login">

<table>
    <tr class="loginicon">
        <th rowspan="6" valign="top">
            
        </th>
    </tr>
    <tr>
        <th colspan="2">
            <h3 style="text-align:center;font-size:20px;">Login Form</h3>
        </th>
    </tr>
    <tr>
        <th colspan="2"><asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red" /></th>
    </tr>
    <tr>
        <td>Username:</td>
        <td>
            <asp:TextBox ID="txtUsername" runat="server" >admin</asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Password:</td>
        <td >
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" >admin</asp:TextBox>
        </td>
    </tr>
    <tr>
        <th colspan="2">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="submit_Click" />
            
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
        </th>
    </tr>
</table>
</div>