<%@ Page Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_login_Default" Title="Untitled Page" %>

<%@ Register Src="../wuc/Login.ascx" TagName="Login" TagPrefix="uc1" %>
<%-- Add content controls here --%>
<asp:Content ID="ContentLeft" ContentPlaceHolderID="ContentPlaceHolderLeft" Runat="Server">
</asp:Content>
<asp:Content ID="ContentRight" ContentPlaceHolderID="ContentPlaceHolderRight" Runat="Server">
    <uc1:Login ID="Login1" runat="server" />
</asp:Content>