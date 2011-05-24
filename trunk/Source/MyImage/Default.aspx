<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="ContentLeft" ContentPlaceHolderID="ContentPlaceHolderLeft" Runat="Server">
    <% LoadMenu(); %>
</asp:Content>
<asp:Content ID="ContentRight" ContentPlaceHolderID="ContentPlaceHolderRight" Runat="Server">
    <asp:PlaceHolder ID="PlaceHolderRight" runat="server"></asp:PlaceHolder>
    <asp:GridView ID="GridView1" runat="server" OnRowEditing="GridView1_RowEditing">
        <Columns>
            <asp:ImageField DataImageUrlField="Image">
                <ControlStyle Height="100px" Width="100px" />
            </asp:ImageField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    </asp:CheckBoxList>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    
</asp:Content>

