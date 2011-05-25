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
            PlaceHolder Holder = (PlaceHolder)_Dtr.FindControl("phlPrintingPrice");
            if (Holder != null)
            {

                CheckBox _ckbGet;
                Label _lblID;
                Label _lblSize;
                Label _lblPrice;
                TextBox _txtQuantity;
                int i = 0;
                Holder.Controls.Add(new LiteralControl("<table border='1'>"));
                Holder.Controls.Add(new LiteralControl("<tr><td></td>"));
                Holder.Controls.Add(new LiteralControl("<td>Size</td>"));
                Holder.Controls.Add(new LiteralControl("<td>Price</td>"));
                Holder.Controls.Add(new LiteralControl("<td>Quantity</td></tr>"));

                foreach (DataRow _Dr in PrintingPriceDAO.GetAll().Rows)
                {
                    i = 0;
                    _ckbGet = new CheckBox();
                    _ckbGet.ID = "ckbGet" + i;

                    _lblID = new Label();
                    _lblID.Text = _Dr["ID"].ToString();
                    _lblID.ID = "lblID" + i;

                    _lblSize = new Label();
                    _lblSize.Text = _Dr["Size"].ToString();
                    _lblSize.ID = "lblSize" + i;

                    _lblPrice = new Label();
                    _lblPrice.Text = _Dr["Price"].ToString();
                    _lblPrice.ID = "lblPrice" + i;

                    _txtQuantity = new TextBox();
                    _txtQuantity.ID = "txtQuantity" + i;
                    _txtQuantity.Text = "";

                    Holder.Controls.Add(new LiteralControl("<tr>"));
                    Holder.Controls.Add(new LiteralControl("<td>"));
                    Holder.Controls.Add(_ckbGet);
                    Holder.Controls.Add(_lblID);           
                    Holder.Controls.Add(new LiteralControl("</td>"));
                    Holder.Controls.Add(new LiteralControl("<td>"));
                    Holder.Controls.Add(_lblSize);
                    Holder.Controls.Add(new LiteralControl("</td>"));
                    Holder.Controls.Add(new LiteralControl("<td>"));
                    Holder.Controls.Add(_lblPrice);
                    Holder.Controls.Add(new LiteralControl("</td>"));
                    Holder.Controls.Add(new LiteralControl("<td>"));
                    Holder.Controls.Add(_txtQuantity);
                    Holder.Controls.Add(new LiteralControl("</td>"));
                    Holder.Controls.Add(new LiteralControl("</tr>"));
                    i++;
                }
                Holder.Controls.Add(new LiteralControl("</table>"));
            }
        }
    }
}
