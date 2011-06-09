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

public partial class wuc_wucOrderList : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            loadOrder();
        }
    }
    private void loadOrder()
    {
        CustomerModel model = (CustomerModel)Session["user"];
        DataTable _Data = OrderDAO.GetByCusId(model.ID);
        if (_Data != null && _Data.Rows.Count > 0)
        {
            grvOrder.DataSource = OrderDAO.Customer_GetAll(model.ID);
            grvOrder.DataBind();
            EnableCancelButton();
        }
        else
        {
            lblInfo.Text = "<h2>No data found</h2>";
        }
    }
    protected void grvOrder_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cancel")
        {
            int _Index = Convert.ToInt32(e.CommandArgument);
            GridViewRow _Row = grvOrder.Rows[_Index];
            String _OrderNo = ((Label)_Row.FindControl("lblNo")).Text;
            String _OrderId = ((Label)_Row.FindControl("lblID")).Text;
            if (OrderDAO.UpdateStatus(_OrderId, "0"))
            {
                lblInfo.Text = "The order no." + _OrderNo + " has been deleted";
                loadOrder();
            }
            else
            {
                lblInfo.Text = "Error occour, could not delete the order no." + _OrderNo ;
            }
        }
    }
    protected void EnableCancelButton()
    {
        int _StatusId = -1;
        LinkButton _LbtnCancel;
        Label _LblDisableCancel;
        foreach (GridViewRow Row in grvOrder.Rows)
        {
            _StatusId = Convert.ToInt32(((Label)Row.FindControl("lblStatusId")).Text);
            _LbtnCancel = (LinkButton)Row.FindControl("lbtnCancel");
            _LblDisableCancel = (Label)Row.FindControl("lblCancelDisable");
            if (_StatusId == 1 || _StatusId == 2)
            {
                _LbtnCancel.Visible = true;
                _LblDisableCancel.Visible = false;
            }
            else
            {
                _LbtnCancel.Visible = false;
                _LblDisableCancel.Visible = true;
            }
        }
    }
    protected void grvOrder_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
}

