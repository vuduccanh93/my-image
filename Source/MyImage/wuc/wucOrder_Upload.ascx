<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrder_Upload.ascx.cs" Inherits="wuc_wucUploadImage" %>
<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>

<asp:Label ID="Label1" runat="server"></asp:Label><br />
&nbsp;<br />

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

<asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add 10 Photo" CausesValidation="False" UseSubmitBehavior="False" />
<br />
<asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" />&nbsp;<br />
&nbsp; &nbsp; &nbsp;
