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
        if (Request.QueryString["t"] != null)
        {
            _Token = Request.QueryString["t"].ToString();
            switch (_Token)
            {
                case "register":
                    if (Request.QueryString["rs"] != null)
                        addControl(Request.ApplicationPath + @"/wuc/wucRegisterSuccess.ascx");
                    else
                        addControl(Request.ApplicationPath + @"/wuc/wucRegister.ascx");
                    break;
                case "login":
                    if (Request.QueryString["logout"] != null)
                    {
                        Session["user"] = null;
                        Session["upload_start"] = null;
                        Session["upload_uploaded"] = null;
                        Response.Redirect(WEB_URL);
                    }
                    else
                        addControl(Request.ApplicationPath + @"/wuc/wucLogin.ascx");
                    break;
                case "changeinfo":
                    if (Session["user"] != null)
                        addControl(Request.ApplicationPath + @"/wuc/wucChangeInfo.ascx");
                    break;

                case "order":
                    if (Request.QueryString["t"] != null && Request.QueryString["start"] != null &&
                        Request.QueryString["upload"] != null && Request.QueryString["content"] != null &&
                        Request.QueryString["payment"] != null && Request.QueryString["finish"]!=null)
                    {

                    }
                    else if (Request.QueryString["t"] != null && Request.QueryString["start"] != null &&
                                Request.QueryString["upload"] != null && Request.QueryString["content"] != null &&
                                Request.QueryString["payment"] != null)
                    {

                    }
                    else if (Request.QueryString["t"] != null && Request.QueryString["start"] != null &&
                                 Request.QueryString["upload"] != null && Request.QueryString["content"] != null)
                    {

                    }
                    else if (Request.QueryString["t"] != null && Request.QueryString["start"] != null &&
                        Request.QueryString["upload"] != null)
                    {
                        addControl(Request.ApplicationPath + @"/wuc/wucOrder_OrderDetails.ascx");
                    }
                    else if (Request.QueryString["t"]!= null && Request.QueryString["start"] != null)
                    {
                        addControl(Request.ApplicationPath + @"/wuc/wucOrder_Upload.ascx");
                    }
                    else if (Request.QueryString["t"] != null)
                    {
                        addControl(Request.ApplicationPath + @"/wuc/wucOrder_Start.ascx");
                    }

                    break;
            }
        }
    }
    private void addControl(String _Path)
    {
        Control wucCus = (Control)Page.LoadControl(_Path);
        PlaceHolderRight.Controls.Add(wucCus);
    }

}
