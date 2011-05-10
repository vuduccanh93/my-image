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
                drlStatus.DataSource = OrderStatusDAO.GetAll();
                drlStatus.DataTextField = "Status";
                drlStatus.DataValueField = "ID";
                drlStatus.DataBind();
                drlStatus.SelectedValue = Model.StatusId;
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
            }
        }
    }
    protected void btnSaveStatus_Click(object sender, EventArgs e)
    {
        OrderDAO.UpdateStatus(Model.ID,drlStatus.SelectedValue.ToString());
    }
}
