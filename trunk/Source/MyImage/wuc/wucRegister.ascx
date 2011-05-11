<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucRegister.ascx.cs" Inherits="wuc_wucRegister" %>

<div>
<table>
    <tr>
        <td style="height: 26px; width: 98px;">Email</td> <td style="height: 26px; width: 208px;"> 
            <asp:TextBox ID="txtEmail" runat="server" Width="210px"></asp:TextBox></td> <td style="height: 26px"> 
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="6 - 15" ValidationExpression="\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b"></asp:RegularExpressionValidator>
            </td>
    </tr>
    
    <tr>
        <td style="width: 98px">First Name</td> <td style="width: 208px"> 
            <asp:TextBox ID="txtFirstname" runat="server" Width="210px"></asp:TextBox></td> <td> 
                <asp:RequiredFieldValidator ID="rfvFirstname" runat="server" ControlToValidate="txtFirstname"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revFirstname" runat="server" ControlToValidate="txtFirstname"
                    ErrorMessage="3 - 15" ValidationExpression="^[a-z0-9_-]{3,15}$"></asp:RegularExpressionValidator></td>
    </tr>
    <tr>
        <td style="width: 98px">Last Name</td> <td style="width: 208px"> 
            <asp:TextBox ID="txtLastname" runat="server" Width="210px"></asp:TextBox></td> <td> 
                <asp:RequiredFieldValidator ID="rfvLastname" runat="server" ControlToValidate="txtLastname"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revLastname" runat="server" ControlToValidate="txtLastname"
                    ErrorMessage="3 - 15" ValidationExpression="^[a-z0-9_-]{3,15}$"></asp:RegularExpressionValidator></td>
    </tr>
    <tr>
        <td style="height: 22px; width: 98px;">Gender</td> <td style="height: 22px; width: 208px;"> 
            <asp:RadioButton ID="rdbMale" runat="server" Checked="True" Text="Male" GroupName="Gender" />
            &nbsp; &nbsp; &nbsp; &nbsp;
            <asp:RadioButton ID="rdbFemale" runat="server" Text="Female" GroupName="Gender" /></td> <td style="height: 22px"> </td>
    </tr>
    <tr>
        <td style="width: 98px">BirthDay</td>
			<td><input id="exampleI" name="dateI" type="text" maxlength="10" value="<%=ServerValue%>"/></td>
        
    </tr>
    <tr>
        <td style="width: 98px">Phone</td> <td style="width: 208px"> 
            <asp:TextBox ID="txtPhone" runat="server" Width="210px"></asp:TextBox></td> <td> 
                 <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhone"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone"
                    ErrorMessage="9-15" ValidationExpression="^[0-9]{9,15}$"></asp:RegularExpressionValidator></td>
    </tr>
    <tr>
        <td style="width: 98px">Address</td> <td style="width: 208px"> 
            <asp:TextBox ID="txtAddress" runat="server" Width="210px"></asp:TextBox></td> <td> </td>
    </tr>
    <tr>
        <td colspan = "3" align ="center">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CausesValidation="False" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" /></td> 
            
    </tr>
</table>
</div>


