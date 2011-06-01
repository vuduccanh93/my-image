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

public partial class wuc_wucOrderList : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != "")
        {

            if (!Page.IsPostBack)
            {
                CustomerModel model = (CustomerModel)Session["user"];
                GridView1.DataSource = OrderDAO.GetByCusId(model.ID);
                GridView1.DataBind();
            }
        }
        else
        {
            Response.Redirect("~");
        }
    }
}
