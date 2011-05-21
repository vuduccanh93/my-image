<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucUploadImage.ascx.cs" Inherits="wuc_wucUploadImage" %>

<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add 10 Photo" CausesValidation="False" UseSubmitBehavior="False" />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" /><br />

<asp:FileUpload ID="FileUpload1" runat="server" /><br />
<asp:FileUpload ID="FileUpload2" runat="server" /><br />
<asp:FileUpload ID="FileUpload3" runat="server" /><br />
<asp:FileUpload ID="FileUpload4" runat="server" /><br />
<asp:FileUpload ID="FileUpload5" runat="server" /><br />

<div runat="server" id="div2" visible="false">
<asp:FileUpload ID="FileUpload6" runat="server" /><br />
<asp:FileUpload ID="FileUpload7" runat="server" /><br />
<asp:FileUpload ID="FileUpload8" runat="server" /><br />
<asp:FileUpload ID="FileUpload9" runat="server" /><br />
<asp:FileUpload ID="FileUpload10" runat="server" /><br />
</div>
<div runat="server" id="div3" visible="false">
<asp:FileUpload ID="FileUpload11" runat="server" /><br />
<asp:FileUpload ID="FileUpload12" runat="server" /><br />
<asp:FileUpload ID="FileUpload13" runat="server" /><br />
<asp:FileUpload ID="FileUpload14" runat="server" /><br />
<asp:FileUpload ID="FileUpload15" runat="server" /><br />
</div>
<div runat="server" id="div4" visible="false">
<asp:FileUpload ID="FileUpload16" runat="server" /><br />
<asp:FileUpload ID="FileUpload17" runat="server" /><br />
<asp:FileUpload ID="FileUpload18" runat="server" /><br />
<asp:FileUpload ID="FileUpload19" runat="server" /><br />
<asp:FileUpload ID="FileUpload20" runat="server" /><br />
</div>
<br />
<br />
<br />
<asp:Image ID="Image1" runat="server" />
<asp:Image ID="Image2" runat="server" />
<asp:Image ID="Image3" runat="server" />
<asp:Image ID="Image4" runat="server" />
<asp:Image ID="Image5" runat="server" />
