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
    String _Token = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Main();
        }
    }
    public void Main()
    {
        if (Request.QueryString["t"] != null && Request.QueryString["t"].ToString().Equals("or"))
        {
            _Token = Request.QueryString["t"].ToString();
            BindData();
        }
    }
    private void BindData()
    {
        grvOrder.DataSource = OrderDAO.GetAll();
        grvOrder.DataBind();
    }
}
