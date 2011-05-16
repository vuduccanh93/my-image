<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucChangeInfo.ascx.cs" Inherits="wuc_wucChangeInfo" %>

<table>
    <caption>Infomation Of User</caption>
    <tr>
        <td colspan="2" align="center"> 
            <asp:Label ID="Label1" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td align="right">
            Email
        </td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </td>
    </tr>
    
    <tr>
        <td align="right">
            First Name
        </td>
        <td>
            <asp:TextBox ID="txtFName" runat="server"></asp:TextBox></td>
    </tr>
    
    <tr>
        <td align="right">
            Last Name
        </td>
        <td>
            <asp:TextBox ID="txtLName" runat="server"></asp:TextBox></td>
    </tr>
    
    <tr>
        <td align="right">
            Birth Day
        </td>
        <td>
            <input id="txtBirthday" name="txtBirthday" type="text" maxlength="10" value="<% =ServerValue %>"/>
			<script type="text/javascript" language="javascript">
	                new tcal ({
		                // form name
		                'formname': 'aspnetForm',
		                // input name
		                'controlname': 'txtBirthday'
	                });
	        </script>
        </td>
    </tr>
    
    <tr>
        <td align="right">
            Gender
        </td>
        <td>
            &nbsp;&nbsp;<asp:RadioButton ID="rdbFemale" runat="server" Text="Female" GroupName="Gender" />
            &nbsp; &nbsp;&nbsp;
            <asp:RadioButton ID="rdbMale" runat="server" Text="Male" GroupName="Gender" /></td>
    </tr>
    
    <tr>
        <td align="right">
            Phone
        </td>
        <td>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
    </tr>
    
    <tr>
        <td align="right">
            Address
        </td>
        <td>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
    </tr>
    
    <tr>
            <td colspan="2" align="center">Change Passwrod</td>
    </tr>  
            <tr>
                <td align="right">
                    Old Password
                </td>
                <td>
                    <asp:TextBox ID="txtOldPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            
            <tr>
                <td align="right">
                    New Password
                </td>
                <td>
                    <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            
            <tr>
                <td align="right">
                    Cof Password
                </td>
                <td>
                    <asp:TextBox ID="txtCofPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            
        <tr>
        <td align="center" colspan="2">
            <asp:Button ID="btnAccept" runat="server" Text="accept" Width="100px" OnClick="btnAccept_Click" /></td>
        
    </tr>
</table>