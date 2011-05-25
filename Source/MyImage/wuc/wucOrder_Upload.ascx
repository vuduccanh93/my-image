<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrder_Upload.ascx.cs"
    Inherits="wuc_wucUploadImage" %>
<asp:FileUpload ID="FileUpload1" runat="server" class="multi" accept="gif|jpeg|bmp|png|jpg"
    maxlength="5" />
<br />
<asp:Button ID="btnUpload" runat="server" Text="Upload All" OnClick="btnUpload_Click" />
<br />
<asp:Label ID="lblMsgInf" runat="server" Text="">
</asp:Label>
<br />
<asp:Label ID="lblMsgErr" runat="server" Text="">
</asp:Label><br />
<asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next" />