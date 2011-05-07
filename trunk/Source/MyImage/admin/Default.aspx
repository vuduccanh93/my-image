<%@ Page Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" Title="Untitled Page" %>

<%@ Register Src="wuc/wucCustomer.ascx" TagName="wucCustomer" TagPrefix="uc1" %>
<%-- Add content controls here --%>
<asp:Content ID="ContentLeft" ContentPlaceHolderID="ContentPlaceHolderLeft" Runat="Server">
<% LoadMenu(Session["R"].ToString()); %>
</asp:Content>
<asp:Content ID="ContentRight" ContentPlaceHolderID="ContentPlaceHolderRight" Runat="Server">
    <uc1:wucCustomer ID="WucCustomer1" runat="server" />

</asp:Content>
