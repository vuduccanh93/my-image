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
    protected void Page_Load(object sender, EventArgs e)
    {
        Main();
    }
    public void LoadMenu()
    {
        String _Html = "<ul> <li><a href='#'> Home </a></li>";

        if(Session["CusId"]==null)
        {
            _Html += "<li><a href='Default.aspx?t=login'> Login </a></li> ";
            _Html += "<li><a href='Default.aspx?t=register'> Register </a></li>";
        }
        else
        {
            _Html += "<li><a href = '#'> Order </a><em></em></li>";
            _Html += "<li><a href = 'Default.aspx?t=changeinfo'> Change Info </a><em></em></li>";
            _Html += "<li><a href = '#'> Logout </a><em></em></li>";
        }
        _Html += "</ul>";
        Response.Write(_Html);
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
                    if (Request.QueryString["lg"] != null)
                        addControl(Request.ApplicationPath + @"/wuc/wucLoginSuccess.ascx");
                    else
                        addControl(Request.ApplicationPath + @"/wuc/wucLogin.ascx");
                    break;
                case "changeinfo":
                    if (Session["user"] != null)
                        addControl(Request.ApplicationPath + @"/wuc/wucChangeInfo.ascx");

                case "order":
                    if (Request.QueryString("t") != null && Request.QueryString("start") != null &&
                        Request.QueryString("upload") != null && Request.QueryString("content") != null &&
                        Request.QueryString("payment") != null && Request.QueryString("finish"))
                    {

                    }
                    else if (Request.QueryString("t") != null && Request.QueryString("start") != null &&
                                Request.QueryString("upload") != null && Request.QueryString("content") != null &&
                                Request.QueryString("payment") != null)
                    {

                    }
                    else if (Request.QueryString("t") != null && Request.QueryString("start") != null &&
                                 Request.QueryString("upload") != null && Request.QueryString("content") != null)
                    {

                    }
                    else if (Request.QueryString("t") != null && Request.QueryString("start") != null &&
                        Request.QueryString("upload") != null)
                    {

                    }
                    else if (Request.QueryString("t") != null && Request.QueryString("start") != null)
                    {

                    }
                    else if (Request.QueryString("t") != null)
                    {

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
