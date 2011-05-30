<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucRegister.ascx.cs" Inherits="wuc_wucRegister" %>

<div>
<table>
    <tr>
        <td style="height: 26px; width: 98px;">Email</td> <td style="height: 26px; width: 208px;"> 
            <asp:TextBox ID="txtEmail" runat="server" Width="210px" MaxLength="40"></asp:TextBox></td> <td style="height: 26px"> 
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="Email is Fail" ValidationExpression="^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"></asp:RegularExpressionValidator>
            </td>
    </tr>
    
    <tr>
        <td style="width: 98px">First Name</td> <td style="width: 208px"> 
            <asp:TextBox ID="txtFirstname" runat="server" Width="210px" MaxLength="40"></asp:TextBox></td> <td> 
                <asp:RequiredFieldValidator ID="rfvFirstname" runat="server" ControlToValidate="txtFirstname"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revFirstname" runat="server" ControlToValidate="txtFirstname"
                    ErrorMessage="Fill 3  Charater " ValidationExpression="^[a-z0-9_-]{3,40}$"></asp:RegularExpressionValidator></td>
    </tr>
    <tr>
        <td style="width: 98px">Last Name</td> <td style="width: 208px"> 
            <asp:TextBox ID="txtLastname" runat="server" Width="210px" MaxLength="40"></asp:TextBox></td> <td> 
                <asp:RequiredFieldValidator ID="rfvLastname" runat="server" ControlToValidate="txtLastname"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revLastname" runat="server" ControlToValidate="txtLastname"
                    ErrorMessage="Fill 3  Charater " ValidationExpression="^[a-z0-9_-]{3,40}$"></asp:RegularExpressionValidator></td>
    </tr>
    <tr>
        <td style="height: 22px; width: 98px;">Gender</td> <td style="height: 22px; width: 208px;"> 
            <asp:RadioButton ID="rdbMale" runat="server" Checked="True" Text="Male" GroupName="Gender" />
            &nbsp; &nbsp; &nbsp; &nbsp;
            <asp:RadioButton ID="rdbFemale" runat="server" Text="Female" GroupName="Gender" /></td> <td style="height: 22px"> </td>
    </tr>
    <tr>
        <td style="width: 98px">BirthDay</td>
			<td><input id="txtBirthday" name="txtBirthday" type="text" maxlength="10" value="" readonly="readOnly"/>
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
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLastname"
                    ErrorMessage="*"></asp:RequiredFieldValidator></td>
        
    </tr>
    <tr>
        <td style="width: 98px; height: 26px;">Phone</td> <td style="width: 208px; height: 26px;"> 
            <asp:TextBox ID="txtPhone" runat="server" Width="210px" MaxLength="20"></asp:TextBox></td> <td style="height: 26px"> 
                 <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhone"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone"
                    ErrorMessage=" fill 9 numberic" ValidationExpression="^[0-9]{9,20}$"></asp:RegularExpressionValidator></td>
    </tr>
    <tr>
        <td style="width: 98px; height: 26px;">Address</td> <td style="width: 208px; height: 26px;"> 
            <asp:TextBox ID="txtAddress" runat="server" Width="210px" MaxLength="100"></asp:TextBox></td> <td style="height: 26px"> </td>
    </tr>
    <tr>
        <td colspan = "3" align ="center">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" /></td> 
            
    </tr>
</table>
</div>


