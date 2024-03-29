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
    public String _Token = null;
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
        Main();
    }
    /**
     * use user role id to load menu item
     * 
     * */
    public void LoadMenu(String _Rid)
    {
        DataTable _MNTable = MenuDAO.GetByRoleId(_Rid);
        String _pHtml = "";
        foreach (DataRow _Dr in _MNTable.Rows)
        {
            _pHtml += "<li><a href='" +
                _Dr["Link"].ToString() + 
                "'>" +
                _Dr["Name"].ToString() +
                "</a><em></em></li>";
        }
        _pHtml += "<li><a href=" +
                 WEB_URL +
                 @"admin/?t=scan" + ">Scan</a><em></em></li>";
        _pHtml += "<li class='last'><a href=" +
                 WEB_URL +
                 @"admin/login/?logout=true" + ">Logout</a></li>";
        Response.Write(_pHtml);
    }
    public void Main(){
        if (Request.QueryString["t"] != null)
        {
            _Token = Request.QueryString["t"].ToString();
            switch (_Token){
                case "cu":
                    addControl(Request.ApplicationPath + @"/admin/wuc/wucCustomer.ascx");
                    break;
                case "me":
                    addControl(Request.ApplicationPath + @"/admin/wuc/wucMember.ascx");
                    break;
                case "or":
                    if (Request.QueryString["oid"] != null)
                    {
                        
                        addControl(Request.ApplicationPath + @"/admin/wuc/wucOrderDetail.ascx");
                    }
                    else if (Request.QueryString["sta"] != null)
                    {
                        addControl(Request.ApplicationPath + @"/admin/wuc/wucOrderStatistic.ascx");
                    }
                    else
                    {
                        addControl(Request.ApplicationPath + @"/admin/wuc/wucOrder.ascx");
                    }
                    break;
                case "sp":
                    addControl(Request.ApplicationPath + @"/admin/wuc/wucStateProvince.ascx");
                    break;
                case "sh":
                    addControl(Request.ApplicationPath + @"/admin/wuc/wucShippingPrice.ascx");
                    break;
                case "pp":
                    addControl(Request.ApplicationPath + @"/admin/wuc/wucPrintingPrices.ascx");
                    break;
                case "scan":
                    addControl(Request.ApplicationPath + @"/admin/wuc/wucScanData.ascx");
                    break;
                case "cf":
                    addControl(Request.ApplicationPath + @"/admin/wuc/wucChangePassword.ascx");
                    break;
            }
        }
    }
    /**
     * add web user control to another control
     * 
     * */
    private void addControl(String _Path)
    {
        Control wucCus = (Control)Page.LoadControl(_Path);
        PlaceHolderRight.Controls.Add(wucCus);
    }
}














