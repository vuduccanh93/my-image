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
using System.IO;
using System.Drawing;
using System.Collections.Generic;

public partial class wuc_wucOrder_OrderDetails : System.Web.UI.UserControl
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
            if (Session["order_upload"] == null || !Session["order_upload"].ToString().Equals("1"))
            {
                Response.Redirect("Default.aspx?t=order&start=true&upload=true");
                return;
            }
            else
            {
                Session["order_upload"] = null;
            }
            BindData();
            BindPrintingPrice();
            foreach (GridViewRow _Dtr in grvUploadDetails.Rows)
            {
                GridView grvPrintingPrice = (GridView)_Dtr.FindControl("grvPrintingPrice");
                foreach (GridViewRow _DtrP in grvPrintingPrice.Rows)
                {
                    TextBox txtQuantity = (TextBox)_DtrP.FindControl("txtQuantity");
                    txtQuantity.Attributes.Add("onKeypress", "IsNumber(event);");

                }
            }
        }
    }
    protected void BindData()
    {
        grvUploadDetails.DataSource = UploadDetailDAO.GetByUploadId(((UploadModel)Session["upload_uploadmodel"]).ID); ;
        grvUploadDetails.DataBind();
    }
    
    public void BindPrintingPrice()
    {
        foreach (GridViewRow _Dtr in grvUploadDetails.Rows)
        {
            GridView grv = (GridView)_Dtr.FindControl("grvPrintingPrice");
            DataTable dt= PrintingPriceDAO.GetAll();
            grv.DataSource = dt;
            grv.DataBind();
        }
    }
    protected void Alert(String _Text)
    {
        Response.Write("<script>alert('" + _Text + "')</script>");
    }

    protected void btnUpdatePrice_Click(object sender, EventArgs e)
    {
        double Total=0;
        foreach (GridViewRow _Dtr in grvUploadDetails.Rows)
        {
            GridView grvPrintingPrice = (GridView)_Dtr.FindControl("grvPrintingPrice");
            foreach (GridViewRow _DtrP in grvPrintingPrice.Rows)
            {
                CheckBox cbk = (CheckBox)_DtrP.FindControl("ckbGet");
                if (cbk.Checked)
                {
                    Label lblPrice = (Label)_DtrP.FindControl("lblPrice");
                    TextBox txtQuantity = (TextBox)_DtrP.FindControl("txtQuantity");
                    TextBox txtAmount = (TextBox)_DtrP.FindControl("txtAmount");
                    double dblQuantity = String.IsNullOrEmpty(txtQuantity.Text) ? 0 : Convert.ToDouble(txtQuantity.Text);
                    txtAmount.Text = Convert.ToString( (dblQuantity * Convert.ToDouble(lblPrice.Text)));
                    Total += dblQuantity * Convert.ToDouble(lblPrice.Text);
                }
            }

        }
        txtTotal.Text = Convert.ToString(Total);
        enableNext();
    }
    protected void enableNext()
    {
        if (String.IsNullOrEmpty(txtTotal.Text) || txtTotal.Text.Equals("0"))
        {
            mbtNext.Enabled = false;
        }
        else
        {
            mbtNext.Enabled = true;
        }
    }
    protected void mbtNext_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtTotal.Text) || txtTotal.Text.Equals("0"))
        {
            return;
        }
        else
        {
            OrderModel orderModel = new OrderModel();
            orderModel.ID = OrderDAO.Insert(orderModel);
            orderModel.CustomerId = ((CustomerModel)Session["user"]).ID;
            Session["order"] = orderModel;
            List<OrderDetailModel> _listModel = new List<OrderDetailModel>();
            foreach (GridViewRow _Dtr in grvUploadDetails.Rows)
            {
                GridView grvPrintingPrice = (GridView)_Dtr.FindControl("grvPrintingPrice");
                Label Id = (Label)_Dtr.FindControl("lblID");
                foreach (GridViewRow _DtrP in grvPrintingPrice.Rows)
                {
                    CheckBox cbk = (CheckBox)_DtrP.FindControl("ckbGet");
                    Label lblPrice = (Label)_DtrP.FindControl("lblPrice");
                    Label lblSize = (Label)_DtrP.FindControl("lblSize");
                    TextBox txtQuantity = (TextBox)_DtrP.FindControl("txtQuantity");
                    TextBox txtAmount = (TextBox)_DtrP.FindControl("txtAmount");
                    if (cbk.Checked)
                    {
                        if (String.IsNullOrEmpty(txtQuantity.Text.Trim()) || txtQuantity.Text.Trim().Equals("0"))
                            continue;
                        OrderDetailModel model = new OrderDetailModel();
                        model.OrderId = orderModel.ID;
                        model.UploadDetailId = Id.Text;
                        model.Price = lblPrice.Text;
                        model.Size = lblSize.Text;
                        model.Quantity = txtQuantity.Text;
                        model.Amount = txtAmount.Text;
                        _listModel.Add(model);

                    }
                }
            }
            if (_listModel.Count > 0)
            {
                if (!OrderDetailDAO.MultiInsert(_listModel))
                {
                    Alert("Error accour.Please try again later!");
                }
                else
                {
                    OrderModel xx = ((OrderModel)Session["order"]);
                    Session["order_orderdetails"] = 1;
                    Session["total"] = txtTotal.Text;
                    Response.Redirect("?t=order&start=true&upload=true&content=true");
                    return;
                }
            }
            else
            {
                //
            }

        }
    }
}
