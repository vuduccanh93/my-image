<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<%@ Register Src="wuc/wucMainMenu.ascx" TagName="wucMainMenu" TagPrefix="uc1" %>
<asp:Content ID="chmMenu" ContentPlaceHolderID="ContentPlaceMenu" runat="Server">
    <uc1:wucMainMenu ID="WucMainMenu1" runat="server" />
</asp:Content>
<asp:Content ID="chmLogin" ContentPlaceHolderID="ContentPlaceLogin" runat="Server">
    <asp:PlaceHolder ID="PlaceHolderLogin" runat="server"></asp:PlaceHolder>
</asp:Content>

<asp:Content ID="chmOrderImage" ContentPlaceHolderID="ContentPlaceHolderOrderImg" runat="Server">
    <asp:PlaceHolder ID="PlaceHolderOrderImg" runat="server"></asp:PlaceHolder>
</asp:Content>

<asp:Content ID="ContentRight" ContentPlaceHolderID="ContentPlaceHolderLeft" runat="Server">
    <div id="content_left">
        <asp:PlaceHolder ID="PlaceHolderLeft" runat="server"></asp:PlaceHolder>
    </div>
</asp:Content>
<asp:Content ID="ContentProvince" ContentPlaceHolderID="ContentPlaceHolderProvince" runat="Server">
    <asp:Label ID="lblSPV" runat="server" Text="Label"></asp:Label>
</asp:Content>
