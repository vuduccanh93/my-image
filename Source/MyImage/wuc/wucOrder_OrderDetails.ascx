<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrder_OrderDetails.ascx.cs" Inherits="wuc_wucOrder_OrderDetails" %>
<img id="Img1" src="~/inc/img/o_s3.png" runat="server" alt="" />
<span style="float:right">
<asp:Button ID="mbtNext" CssClass="cusbutton" runat="server" Text="Next" OnClick="mbtNext_Click" Enabled="False" />
</span>

<br />
<asp:Label ID="lblAmount" runat="server" Text="Amount :"></asp:Label>
<asp:TextBox ID="txtTotal" CssClass="inputfield" runat="server" ReadOnly="True" Width="81px"></asp:TextBox>
<asp:Button ID="btnUpdatePrice" CssClass="cusbutton" runat="server" CausesValidation="False" OnClick="btnUpdatePrice_Click"
    Text="Update Price" UseSubmitBehavior="False" /><br />
<asp:GridView ID="grvUploadDetails" runat="server" AutoGenerateColumns="False" CssClass="upload_orderdetails" >
    <Columns>
        <asp:TemplateField HeaderText="ID">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
            </ItemTemplate>
            <ItemStyle CssClass="hide" />
            <HeaderStyle CssClass="hide" />
            <FooterStyle CssClass="hide" />
        </asp:TemplateField>
        <asp:ImageField DataImageUrlField="ImgLink" HeaderText="Image">
            <ControlStyle Height="100px" Width="100px" />
        </asp:ImageField>
        <asp:TemplateField HeaderText="Details">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:GridView ID="grvPrintingPrice" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:TemplateField>
                            <EditItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="ckbGet" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ID">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                            </ItemTemplate>
                                <ItemStyle CssClass="hide" />
                                <HeaderStyle CssClass="hide" />
                                <FooterStyle CssClass="hide" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Size">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Size") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblSize" runat="server" Text='<%# Bind("Size") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Price">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Price") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblPrice" runat="server" Text='<%# Bind("Price") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Quantity">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                            </ItemTemplate>
                            <ItemStyle CssClass="inputfield" />
                            <ControlStyle CssClass="inputfield" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Amount">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:TextBox ID="txtAmount" runat="server" ReadOnly="true"></asp:TextBox>
                            </ItemTemplate>
                            <ItemStyle CssClass="inputfield" />
                            <ControlStyle CssClass="inputfield" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </ItemTemplate>
        </asp:TemplateField>

    </Columns>
</asp:GridView>
&nbsp;

