<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserControl_Login.ascx.cs" Inherits="UserControl_Login" %>
&nbsp;&nbsp;<asp:Panel ID="pnlLogin" runat="server" Height="228px" Width="539px" HorizontalAlign="Center" BackColor="#CCCCFF">
    <br />
    <asp:Label ID="lblLogin" runat="server" Text="LOGIN" Font-Bold Font-Size = "30" ></asp:Label><br />
    <br />
<asp:Label ID="lblUsername" Font-Size = "15" runat="server" Text="Username :"></asp:Label>
    &nbsp;
    <asp:TextBox ID="txtUsername" runat="server" Width="230px"></asp:TextBox><br />
<asp:Label ID="lblPassword" Font-Size = "15" runat="server" Text="Password :"></asp:Label>
    &nbsp;
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="230px"></asp:TextBox><br />
    <br />
    <asp:Button ID="btnOK" runat="server" Text="OK" Height="30px" Width="81px" OnClick="btnOK_Click" />
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" Height="30px" Width="81px" />
    <asp:Label ID="lblMessage" runat="server" Enabled="False" Text="Label"></asp:Label><br />
    <br />
    <asp:LinkButton ID="lbtRegister" runat="server">Register</asp:LinkButton>
    <asp:LinkButton ID="lbtChangePass" runat="server">Change Password</asp:LinkButton></asp:Panel>


