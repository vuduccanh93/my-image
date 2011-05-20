<%@ Page Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" Title="Untitled Page" %>
<%-- Add content controls here --%>
<asp:Content ID="ContentLeft" ContentPlaceHolderID="ContentPlaceHolderLeft" Runat="Server">
<% LoadMenu(Session["R"].ToString()); %>
</asp:Content>
<asp:Content ID="ContentRight" ContentPlaceHolderID="ContentPlaceHolderRight" Runat="Server">
    <asp:PlaceHolder ID="PlaceHolderRight" runat="server"></asp:PlaceHolder>
</asp:Content>
