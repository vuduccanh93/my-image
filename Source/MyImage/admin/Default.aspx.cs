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

public partial class admin_Default : System.Web.UI.Page
{
    public static int USER_MENU = 0;
    public static int STAFF_MENU = USER_MENU + 1;
    public static int ORDER_MENU = USER_MENU + 2;

    public String WEB_URL = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["U"] == null)
        {
            Response.Redirect("~/admin/login/");
            return;
        }
        if (!Page.IsPostBack)
        {
            WEB_URL = Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/");
            
        }
    }
    public void LoadMenu(String _Rid)
    {
        DataTable _MNTable = MenuDAO.GetByRoleId(_Rid);
        String _pHtml = "<ul>";
        foreach (DataRow _Dr in _MNTable.Rows)
        {
            _pHtml += "<li><a href='javascript:void(0)' onClick=sendRequest('" +
                WEB_URL +
                @"admin/Funcs.aspx" +
                _Dr["Link"].ToString() +
                "'," +
                "'content-main'" +
                ")>" +
                _Dr["Name"].ToString() +
                "</a><em></em></li>";
        }
        _pHtml += "<li><a href=" +
                 WEB_URL +
                 @"admin/login/?logout=true" + ">Logout</a></li>";
        _pHtml += "</ul>";
        Response.Write(_pHtml);
    }













}
