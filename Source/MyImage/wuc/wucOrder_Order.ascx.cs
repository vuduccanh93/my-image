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

public partial class wuc_wucOrder_Order : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["user"] == null)
            {
                Response.Redirect(@"~");
                return;
            }
            if (Session["order_orderdetails"] == null || !Session["order_orderdetails"].ToString().Equals("1"))
            {
                Response.Redirect("Default.aspx?t=order&start=true&upload=true");
                return;
            }
            else
            {
                Session["order_orderdetails"] = null;
            }
            OrderModel _Model = OrderDAO.GetById(((OrderModel)Session["order"]).ID);
        txtNo.Text = _Model.NO;

        drlStateProvince.DataSource = StateProvinceDAO.GetAll();
        drlStateProvince.DataTextField = "Name";
        drlStateProvince.DataValueField = "ID";
        drlStateProvince.DataBind();

        drlPaymenMethod.DataSource = PaymentMethodDAO.GetAll();
        drlPaymenMethod.DataTextField = "Name";
        drlPaymenMethod.DataValueField = "ID";
        drlPaymenMethod.DataBind();
        }



    }
}
