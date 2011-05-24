<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<%@ Register Src="wuc/wucMainMenu.ascx" TagName="wucMainMenu" TagPrefix="uc1" %>

<asp:Content ID="ContentLeft" ContentPlaceHolderID="ContentPlaceHolderLeft" Runat="Server">
    <uc1:wucMainMenu ID="WucMainMenu1" runat="server" />
</asp:Content>
<asp:Content ID="ContentRight" ContentPlaceHolderID="ContentPlaceHolderRight" Runat="Server">
    <asp:PlaceHolder ID="PlaceHolderRight" runat="server"></asp:PlaceHolder>
    
</asp:Content>

