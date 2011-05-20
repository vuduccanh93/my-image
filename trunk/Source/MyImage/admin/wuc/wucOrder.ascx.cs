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

public partial class admin_wuc_wucOrder : System.Web.UI.UserControl
{
    private String WEB_URL = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Main();
            WEB_URL = Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/");
        }
        hplOrderStatistic.NavigateUrl = WEB_URL+@"admin/?t=or&sta=true";
    }
    public void Main()
    {
        if (Request.QueryString["t"] != null && Request.QueryString["t"].ToString().Equals("or") &&
            Request.QueryString["cusid"] != null)
        {
            BindData(Request.QueryString["cusid"].ToString());
        }
        else if (Request.QueryString["t"] != null && Request.QueryString["t"].ToString().Equals("or"))
        {
            BindData();
        }
    }
    private void BindData()
    {
        grvOrder.DataSource = OrderDAO.GetAll();
        grvOrder.DataBind();
    }

    private void BindData(String _CusId)
    {
        grvOrder.DataSource = OrderDAO.GetByCusId(_CusId);
        grvOrder.DataBind();
    }
}
