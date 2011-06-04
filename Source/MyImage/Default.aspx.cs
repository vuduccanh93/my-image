using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page
{
    String _Token = null;
    private String WEB_URL = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            WEB_URL = Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/");
        }
        Main();
        
    }
    public void Main()
    {
        if (Session["user"] == null)
        {
            addCtrl(PlaceHolderLogin, Request.ApplicationPath + @"/wuc/wucLogin.ascx");
        }
        else
        {

        }
        if (Request.QueryString["t"] != null)
        {
            _Token = Request.QueryString["t"].ToString();
            switch (_Token)
            {
                case "register":
                    if (Request.QueryString["rs"] != null)
                        addCtrl(PlaceHolderLeft,Request.ApplicationPath + @"/wuc/wucRegisterSuccess.ascx");
                    else
                        addCtrl(PlaceHolderLeft,Request.ApplicationPath + @"/wuc/wucRegister.ascx");
                    break;
                case "login":
                    if (Request.QueryString["logout"] != null)
                    {
                        Session["user"] = null;
                        Session["order_start"] = null;
                        Session["order_upload"] = null;
                        Session["upload_savepath"] = null;
                        Session["upload_uploadmodel"] = null;
                        Session["order_orderdetails"] = null;
                        Session["order"] = null;
                        Response.Redirect(WEB_URL);
                    }
                    break;
                case "changeinfo":
                    if (Session["user"] != null)
                        addCtrl(PlaceHolderLeft, Request.ApplicationPath + @"/wuc/wucChangeInfo.ascx");
                    
                    break;
                case "orderlist":
                    if (Session["user"] != null)
                        addCtrl(PlaceHolderLeft, Request.ApplicationPath + @"/wuc/wucOrderList.ascx");

                    break;

                case "order":
                    if (Session["user"] == null)
                    {
                        Response.Redirect("~");
                        return;
                    }
                    if (Request.QueryString["t"] != null && Request.QueryString["start"] != null &&
                        Request.QueryString["upload"] != null && Request.QueryString["content"] != null &&
                        Request.QueryString["payment"] != null && Request.QueryString["finish"] != null)
                    {

                    }
                    else if (Request.QueryString["t"] != null && Request.QueryString["start"] != null &&
                                Request.QueryString["upload"] != null && Request.QueryString["content"] != null &&
                                Request.QueryString["payment"] != null)
                    {
                        addCtrl(PlaceHolderLeft, Request.ApplicationPath + @"/wuc/wucOrder_Payment.ascx");
                    }
                    else if (Request.QueryString["t"] != null && Request.QueryString["start"] != null &&
                                 Request.QueryString["upload"] != null && Request.QueryString["content"] != null)
                    {
                        addCtrl(PlaceHolderLeft, Request.ApplicationPath + @"/wuc/wucOrder_Order.ascx");
                    }
                    else if (Request.QueryString["t"] != null && Request.QueryString["start"] != null &&
                        Request.QueryString["upload"] != null)
                    {
                        addCtrl(PlaceHolderLeft, Request.ApplicationPath + @"/wuc/wucOrder_OrderDetails.ascx");
                    }
                    else if (Request.QueryString["t"] != null && Request.QueryString["start"] != null)
                    {
                        addCtrl(PlaceHolderLeft, Request.ApplicationPath + @"/wuc/wucOrder_Upload.ascx");
                        
                    }
                    else if (Request.QueryString["t"] != null)
                    {
                        addCtrl(PlaceHolderLeft, Request.ApplicationPath + @"/wuc/wucOrder_Start.ascx");
                    }
                    break;
                default:
                    Response.Redirect("~");
                    break;
            }
        }
        else
        {
            addCtrl(PlaceHolderLeft, Request.ApplicationPath + @"/wuc/wucHome.ascx");
        }
    }
    private void addCtrl(Control ID, String _Path){
        ID.Controls.Add((Control)Page.LoadControl(_Path));
    }
    protected void Alert(String _Text)
    {
        Response.Write("<script>alert('" + _Text + "')</script>");
    }
}
