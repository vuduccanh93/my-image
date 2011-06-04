<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucChangeInfo.ascx.cs"
    Inherits="wuc_wucChangeInfo" %>
<table>
    <caption>
        <h3>CUSTOMER'S INFO</h3></caption>
    <tr>
        <td colspan="3" align="center">
            <asp:Label ID="lblErr" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td align="right" style="height: 26px">
            Email
        </td>
        <td style="height: 26px">
            <asp:TextBox CssClass="inputfield" ID="txtEmail" runat="server" MaxLength="40"></asp:TextBox>
        </td>
        <td style="height: 26px">
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                ErrorMessage="*"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="revEmail"
                    runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid email" ValidationExpression="^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"></asp:RegularExpressionValidator></td>
    </tr>
    <tr>
        <td align="right" style="height: 26px">
            First Name
        </td>
        <td style="height: 26px">
            <asp:TextBox CssClass="inputfield" ID="txtFName" runat="server" MaxLength="40"></asp:TextBox></td>
        <td style="height: 26px">
            <asp:RequiredFieldValidator ID="rfvFirstname" runat="server" ControlToValidate="txtFName"
                ErrorMessage="*"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="revFirstname"
                    runat="server" ControlToValidate="txtFName" ErrorMessage="Three chars at least!"
                    ValidationExpression="^[a-z0-9_-]{3,40}$"></asp:RegularExpressionValidator></td>
    </tr>
    <tr>
        <td align="right" style="height: 26px">
            Last Name
        </td>
        <td style="height: 26px">
            <asp:TextBox CssClass="inputfield" ID="txtLName" runat="server" MaxLength="40"></asp:TextBox></td>
        <td style="height: 26px">
            <asp:RequiredFieldValidator ID="rfvLastname" runat="server" ControlToValidate="txtLName"
                ErrorMessage="*"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="revLastname"
                    runat="server" ControlToValidate="txtLName" ErrorMessage="Three chars at least!"
                    ValidationExpression="^[a-z0-9_-]{3,40}$"></asp:RegularExpressionValidator></td>
    </tr>
    <tr>
        <td align="right">
            Birth Day
        </td>
        <td>
            <input class="inputfield" id="txtBirthday" name="txtBirthday" type="text" maxlength="10"
                value="<% =ServerValue %>" />

            <script type="text/javascript" language="javascript">
	                new tcal ({
		                // form name
		                'formname': 'aspnetForm',
		                // input name
		                'controlname': 'txtBirthday'
	                });
	        </script>

        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td align="right">
            Gender
        </td>
        <td>
            <asp:RadioButton ID="rdbFemale" runat="server" Text="Female" GroupName="Gender" />
            <asp:RadioButton ID="rdbMale" runat="server" Text="Male" GroupName="Gender" /></td>
        <td>
        </td>
    </tr>
    <tr>
        <td align="right">
            Phone
        </td>
        <td>
            <asp:TextBox CssClass="inputfield" ID="txtPhone" runat="server" MaxLength="20"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhone"
                ErrorMessage="*"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="revPhone"
                    runat="server" ControlToValidate="txtPhone" ErrorMessage="Number only" ValidationExpression="^[0-9]{9,20}$"></asp:RegularExpressionValidator></td>
    </tr>
    <tr>
        <td align="right">
            Address
        </td>
        <td>
            <asp:TextBox CssClass="inputfield" ID="txtAddress" runat="server" MaxLength="100"></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td colspan="3" align="center">
            Change Passwrod</td>
    </tr>
    <tr>
        <td align="right">
            Old Password
        </td>
        <td>
            <asp:TextBox CssClass="inputfield" ID="txtOldPassword" runat="server" TextMode="Password"
                MaxLength="40"></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td align="right">
            New Password
        </td>
        <td>
            <asp:TextBox CssClass="inputfield" ID="txtNewPassword" runat="server" TextMode="Password"
                MaxLength="40"></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td align="right">
            Cof Password
        </td>
        <td>
            <asp:TextBox CssClass="inputfield" ID="txtCofPassword" runat="server" TextMode="Password"
                MaxLength="40"></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td align="center" colspan="2">
            <asp:Button ID="btnAccept" runat="server" CssClass="cusbutton" Text="accept" Width="100px"
                OnClick="btnAccept_Click" /></td>
        <td>
        </td>
    </tr>
</table>
