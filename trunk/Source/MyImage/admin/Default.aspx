<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" Title="Untitled Page" %>

<%@ Register Src="wuc/Login.ascx" TagName="Login" TagPrefix="uc1" %>
<asp:Content ID="ContentLeft" ContentPlaceHolderID="ContentPlaceHolderLeft" Runat="Server">
</asp:Content>
<asp:Content ID="ContentRight" ContentPlaceHolderID="ContentPlaceHolderRight" Runat="Server">
    <uc1:Login ID="Login1" runat="server" />
    
</asp:Content>

