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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["U"] == null)
        {
            Response.Redirect("~/admin/login/");
        }
        if (!Page.IsPostBack)
        {
            
            
        }
    }
    public void LoadMenu(String _Rid)
    {
        DataTable _MNTable = MenuDAO.GetByRoleId(_Rid);
        String _pHtml = "<ul>";
        foreach (DataRow _Dr in _MNTable.Rows)
        {
            _pHtml += "<li><a href='" + _Dr["Link"].ToString() + "'>" + _Dr["Name"].ToString() + "</a><em></em></li>";
        }
        _pHtml += "<li><a href=" +
                 Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/") +
                 @"admin/login/?logout=true" + ">Logout</a></li>";
        _pHtml += "</ul>";
        Response.Write(_pHtml);
    }
}
