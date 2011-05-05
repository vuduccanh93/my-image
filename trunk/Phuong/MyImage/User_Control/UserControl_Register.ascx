<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserControl_Register.ascx.cs" Inherits="UserControl_Register" %>
<asp:Panel ID="pnlRegister" runat="server" BackColor="#CCCCFF" Height="352px" Width="573px" HorizontalAlign="Center">
    <br />
<asp:Label ID="lblRegister" runat="server" Font-Bold="True" Font-Size="30pt" Text="REGISTER"></asp:Label><br />
    &nbsp;<br />
    &nbsp;<asp:Label ID="lblUsername" runat="server" Font-Size="15pt" Text="Username :"
        Width="100px"></asp:Label>&nbsp;
    <asp:TextBox ID="txtUsername" runat="server" Width="230px"></asp:TextBox>&nbsp;
    <span style="color: #ff0000">*</span>&nbsp;
    <br />
<asp:Label ID="lblPassword" runat="server" Font-Size="15pt" Text="Password :" Width="100px"></asp:Label>&nbsp;
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="230px"></asp:TextBox>&nbsp;
    <span style="color: #ff0000">*</span><br />
    <asp:Label ID="lblFname" runat="server" Font-Size="15pt" Text="First Name :" Width="100px"></asp:Label>&nbsp;
    <asp:TextBox ID="txtFname" runat="server" Width="230px"></asp:TextBox>&nbsp; <span
        style="color: #ff0000">*</span><br />
    <asp:Label ID="lblLname" runat="server" Font-Size="15pt" Text="Last Name :" Width="100px"></asp:Label>&nbsp;
    <asp:TextBox ID="txtLname" runat="server" Width="230px"></asp:TextBox>&nbsp; <span
        style="color: #ff0000">*</span><br />
    <asp:Label ID="lblBirth" runat="server" Font-Size="15pt" Text="BirthDay :" Width="100px"></asp:Label>&nbsp;
    <asp:TextBox ID="txtBirth" runat="server" Width="230px"></asp:TextBox>&nbsp; <span
        style="color: #ff0000">*<br />
    </span>
    <asp:Label ID="lblGender" runat="server" Font-Size="15pt" Text="Gender :" Width="100px"></asp:Label>
    &nbsp;<asp:TextBox ID="txtGender" runat="server" Width="230px"></asp:TextBox>&nbsp;
    <span style="color: #ff0000">*<br />
    </span>
    <asp:Label ID="lblPhone" runat="server" Font-Size="15pt" Text="Phone :" Width="100px"></asp:Label>
    &nbsp;<asp:TextBox ID="txtPhone" runat="server" Width="230px"></asp:TextBox>&nbsp;
    <span style="color: #ff0000">*</span><br />
    <asp:Label ID="lblAddress" runat="server" Font-Size="15pt" Text="Address :" Width="100px"></asp:Label>&nbsp;
    <asp:TextBox ID="txtAddress" runat="server" Width="230px"></asp:TextBox>&nbsp; <span
        style="color: #ff0000">*</span><br />
    <br />
<asp:Button ID="btnOK" runat="server" Height="30px" Text="OK" Width="81px"  />
    <asp:Button
    ID="btnCancel" runat="server" Height="30px" Text="Cancel" Width="81px" /></asp:Panel>
