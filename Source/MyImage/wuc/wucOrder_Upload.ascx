<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wucOrder_Upload.ascx.cs" Inherits="wuc_wucUploadImage" %>
    <img id="Img3" src="~/inc/img/o_s2.png" runat="server" alt="" />
    <br />
<span style="float:right">
    <asp:Button ID="mbtNext" CssClass="cusbutton" runat="server" Text="Next" OnClick="mbtNext_Click" Enabled="False" /></span>
<br /><br /><br />
<asp:FileUpload ID="FileUpload1"  runat="server" class="multi" accept="jpeg|jpg" maxlength="5" />
<asp:Button ID="btnUpload" CssClass="cusbutton" runat="server" Text="Upload All" OnClick="btnUpload_Click" />
<br />
<asp:Label ID="lblMsgInf" runat="server" Text="">
</asp:Label>
<br />
<asp:Label ID="lblMsgErr" runat="server" Text="">
</asp:Label><br />
<div class="order_imgs-active">
    <div class="left">
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
        <asp:GridView BorderStyle="none" CssClass="o-imgs" ID="grvImages" runat="server" AutoGenerateColumns="False" OnRowCommand="grvImages_RowCommand">
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
                <asp:ImageField DataImageUrlField="Image" HeaderText="Image">
                    <ControlStyle Height="100px" Width="100px" />
                </asp:ImageField>
                <asp:ButtonField HeaderText="Remove" Text="X" CommandName="RemoveImg" >
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="Black" />
                </asp:ButtonField>
            </Columns>
        </asp:GridView>
    </div>
    <div class="right">
        <div class="tr">
            &nbsp;</div>
        <div class="mr">
            <a href="javascript:void(0)">
                <img id="Img1" src="~/inc/img/arr-show.png" runat="server" class="arr-show hide" alt="" /></a>
            <a href="javascript:void(0)">
                <img id="Img2" src="~/inc/img/arr-hide.png" runat="server" class="arr-hide" alt="" /></a>

            <script type="text/javascript">
                              $(function(  ){
                                $('.arr-show').bind('click',function(event) {
                                    $('.order_imgs-inactive').removeClass('order_imgs-inactive').addClass('order_imgs-active');
                                    $('.arr-show').hide();
                                    $('.arr-hide').show();
                                  });
                                $('.arr-hide').bind('click',function(event) {
                                    $('.order_imgs-active').removeClass('order_imgs-active').addClass('order_imgs-inactive');
                                    $('.arr-hide').hide();
                                    $('.arr-show').show();
                                  });
                              });
            </script>

        </div>
        <div class="br">
            &nbsp;</div>
    </div>
</div>