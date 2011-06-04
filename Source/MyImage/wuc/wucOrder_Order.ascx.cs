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

        drlShipDay.DataSource = ShippingPriceDAO.GetAllBySPI(drlStateProvince.SelectedValue.ToString());
        drlShipDay.DataTextField = "Ship_time";
        drlShipDay.DataValueField = "Price";
        DataBind();

        txtPrintingPrice.Text = (String)Session["total"];
        txtShippingPrice.Text = drlShipDay.SelectedValue;
        txtAmount.Text = Convert.ToString(Convert.ToDouble(txtPrintingPrice.Text) + Convert.ToDouble(txtShippingPrice.Text));
        bindDateTime();
        }



    }
    protected void drlPaymenMethod_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (drlPaymenMethod.SelectedIndex == 1)
            div2.Visible = true;
        else
            div2.Visible = false;
        
    }
    protected void drlStateProvince_SelectedIndexChanged(object sender, EventArgs e)
    {
       drlShipDay.DataSource= ShippingPriceDAO.GetAllBySPI(drlStateProvince.SelectedValue.ToString());
       drlShipDay.DataTextField = "Ship_time";
       drlShipDay.DataValueField = "Price";
       DataBind();
       txtShippingPrice.Text = drlShipDay.SelectedValue;
       txtAmount.Text = Convert.ToString(Convert.ToDouble(txtPrintingPrice.Text) + Convert.ToDouble(txtShippingPrice.Text));
    }
    protected void drlShipDay_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtShippingPrice.Text = drlShipDay.SelectedValue;
        txtAmount.Text = Convert.ToString(Convert.ToDouble(txtPrintingPrice.Text) + Convert.ToDouble(txtShippingPrice.Text));
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        OrderModel model = (OrderModel)Session["order"];

        model.NO = txtNo.Text;
        model.Content = txtContent.Text;
        model.Address = txtAddress.Text;
        model.PMethodId = drlPaymenMethod.SelectedIndex.ToString();
        model.PMethod = drlPaymenMethod.SelectedItem.ToString();
        model.SProvinceId = drlStateProvince.SelectedIndex.ToString();
        model.SProvince = drlStateProvince.SelectedItem.ToString();
        if (model.PMethodId.Equals("1"))
        {
            CreditCardModel ccModel = new CreditCardModel();
            ccModel.L_three_letter = txtCVV.Text;
            ccModel.Holder_name = txtHolderName.Text;
            ccModel.Number = txtCCNumber.Text;
            ccModel.Exp_date = drlExpertDate_Y + "/" + drlExpertDate_M;
            model.CCardId = CreditCardDAO.Insert(ccModel);
        }
        model.ShipTime = drlShipDay.SelectedItem.ToString();
        model.PPrice = txtPrintingPrice.Text;
        model.SPrice = txtShippingPrice.Text;
        model.Amount = txtAmount.Text;
        model.Status = "0";
        model.CreatedDate = UtilDAO.GetDateTime();
       
        if (OrderDAO.Update(model))
        {
            Session["order"] = model;
            Session["order_order"] = 1;
            Response.Redirect("?t=order&start=true&upload=true&content=true&payment=true");
        }
        else
        {
            Alert("Fails");
        }
    }
    protected void Alert(String _Text)
    {
        Response.Write("<script>alert('" + _Text + "')</script>");
    }
    protected void bindDateTime()
    {
        int y = DateTime.Now.Year;
        for (int i = y; i < (y + 10); i++)
        {
            drlExpertDate_Y.Items.Add(new ListItem(i.ToString(),i.ToString()));
        }
        for (int i = 1; i <= 12; i++)
        {
            drlExpertDate_M.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
    }
}
