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

public partial class admin_wuc_wucOrderDetail : System.Web.UI.UserControl
{
    OrderModel Model;
    protected void Page_Load(object sender, EventArgs e)
    {
        Main();
    }

    private void Main()
    {
        if (Request.QueryString["t"] != null &&
            Request.QueryString["t"].ToString().Equals("or")
            && Request.QueryString["oid"] != null)
        {
            Model = OrderDAO.GetById(Request.QueryString["oid"]);
            if (Model != null)
            {
                lblNo.Text = Model.NO;
                lblDate.Text = Model.CreatedDate;
             
                lblCustomer.Text = Model.Customer;
                lblPayment.Text = Model.PMethod;
                lblCC.Text = Model.CCard;
                lblPPrice.Text = Model.PPrice;
                lblPState.Text = Model.SProvince;
                lblSPrice.Text = String.Format("{0:0,0}", Model.SPrice);
                lblAmount.Text = Model.Amount;
                lblContent.Text = Model.Content;
                grvOrderDetail.DataSource = OrderDetailDAO.GetByOrderId(Model.ID);
                grvOrderDetail.DataBind();
                if (Model.StatusId.Equals("5"))
                {
                    drlStatus.Visible = false;
                    lblStatus.Visible = true;
                    lblStatus.Text = Model.Status;
                    btnSaveStatus.Visible = false;
                    int f =0;
                    foreach (GridViewRow _Dtr in grvOrderDetail.Rows)
                    {
                        Image Image = (Image)_Dtr.FindControl("Image");
                        Image.Visible = false;
                        HyperLink hyperLink = (HyperLink)_Dtr.FindControl("HyperLink");
                        hyperLink.Visible = false;
                        Label lblImage = (Label)_Dtr.FindControl("lblImage");
                        lblImage.Visible = true;
                        Label lblLink = (Label)_Dtr.FindControl("lblLink");
                        lblLink.Visible = true;
                        if (f == grvOrderDetail.Rows.Count)
                            if (Directory.Exists(MapPath(lblLink.Text)))
                            {
                                Directory.Delete(MapPath(lblLink.Text), true);
                                Response.Redirect("?t=or&oid=" + Model.ID);
                            }
                        f++;
                        lblLink.Text = "Null";
                       
                    }
                   
                       
                }
                else
                {
                    drlStatus.DataSource = OrderStatusDAO.GetAll();
                    drlStatus.DataTextField = "Status";
                    drlStatus.DataValueField = "ID";
                    drlStatus.DataBind();
                    drlStatus.SelectedValue = Model.StatusId;
                    foreach (GridViewRow _Dtr in grvOrderDetail.Rows)
                    {
                        Image Image = (Image)_Dtr.FindControl("Image");
                        Image.Width = 100;
                        Image.Height = 100;
                        
                        
                    }
                }
                
            }
        }
    }
    protected void btnSaveStatus_Click(object sender, EventArgs e)
    {
        OrderDAO.UpdateStatus(Model.ID,drlStatus.SelectedValue.ToString());
        Main(); 
    }
    protected void grvOrderDetail_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grvOrderDetail.PageIndex = e.NewPageIndex;
        grvOrderDetail.DataSource = OrderDetailDAO.GetByOrderId(Model.ID);
        grvOrderDetail.DataBind();
    }
}
