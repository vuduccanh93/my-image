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
            }
            //if (Session["upload_uploaded"] == null || !Session["upload_uploaded"].ToString().Equals("1"))
            //{
            //    Response.Redirect(@"~");
            //}
            BindData();
            BindPrintingPrice();
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

    protected void txtQuantity_TextChanged(object sender, EventArgs e)
    {
        txtTotal.Text = "0"; 
        TextBox txtQuantity = ((TextBox)(sender));
        GridViewRow gvr = ((GridViewRow)(txtQuantity.NamingContainer));
        Label _Price = (Label)gvr.FindControl("lblPrice");
        double dblQuantity = String.IsNullOrEmpty(txtQuantity.Text) ? 0 : Convert.ToDouble(txtQuantity.Text);
        double dblPrice = Convert.ToDouble(_Price.Text);
        TextBox _Amount = (TextBox)gvr.FindControl("txtAmount");
        _Amount.Text = Convert.ToString(dblPrice * dblQuantity);
        foreach (GridViewRow _Dtr in grvUploadDetails.Rows)
        {
            GridView grvPrintingPrice = (GridView)_Dtr.FindControl("grvPrintingPrice");
            foreach (GridViewRow _DtrP in grvPrintingPrice.Rows)
            {
                CheckBox cbk = (CheckBox)_DtrP.FindControl("ckbGet");
                if (cbk.Checked)
                {
                    TextBox txtAmount = (TextBox)_DtrP.FindControl("txtAmount");
                    double Amount =  String.IsNullOrEmpty(txtAmount.Text) ? 0 : Convert.ToDouble(txtAmount.Text);
                    txtTotal.Text = Convert.ToString(Amount + Convert.ToDouble(txtTotal.Text));
                }
            }

        }
        
       
    }


    protected void ckbGet_CheckedChanged(object sender, EventArgs e)
    {
        txtTotal.Text = "0";
        CheckBox ckbGet = ((CheckBox)(sender));
        GridViewRow gvr = ((GridViewRow)(ckbGet.NamingContainer));
        TextBox txtQuantity = (TextBox)gvr.FindControl("txtQuantity");
        double dblQuantity = String.IsNullOrEmpty(txtQuantity.Text) ? 0 : Convert.ToDouble(txtQuantity.Text);
        foreach (GridViewRow _Dtr in grvUploadDetails.Rows)
        {
            GridView grvPrintingPrice = (GridView)_Dtr.FindControl("grvPrintingPrice");
            foreach (GridViewRow _DtrP in grvPrintingPrice.Rows)
            {
                CheckBox cbk = (CheckBox)_DtrP.FindControl("ckbGet");
                if (cbk.Checked)
                {
                    TextBox txtAmount = (TextBox)_DtrP.FindControl("txtAmount");
                    double Amount = String.IsNullOrEmpty(txtAmount.Text) ? 0 : Convert.ToDouble(txtAmount.Text);
                    txtTotal.Text = Convert.ToString(Amount + Convert.ToDouble(txtTotal.Text));
                }
            }

        }
    }
    protected void btnNext_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtTotal.Text) || txtTotal.Text.Equals("0"))
        {
            return;
        }
        else
        {
            OrderModel orderModel = new OrderModel();
            String orderId = OrderDAO.Insert(orderModel);
            Session["orderid"] = orderId;
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
                        OrderDetailModel model = new OrderDetailModel();
                        model.OrderId = orderId;
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
                    Alert("Insert error");
                }
            }
            else
            {
                Response.Redirect("Default.aspx?t=order&start=true&upload=true&content=true");
            }

        }
    }
    protected void Alert(String _Text)
    {
        Response.Write("<script>alert('" + _Text + "')</script>");
    }
}
