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

public partial class admin_wuc_wucStatisticOrder : System.Web.UI.UserControl
{  
    protected void Page_Load(object sender, EventArgs e)
    {  
        if (!Page.IsPostBack)
            Main();
    }

    private void Main()
    {
        BindData();          
    }

    private void BindData()
    {
        grvStatisticOrder.DataSource = StatisticOrderDAO.GetAll();
        grvStatisticOrder.DataBind();
    }

    private void BindDRLStatus(int _RowIndex)
    {
        GridViewRow _Row = grvStatisticOrder.Rows[_RowIndex];
        DropDownList drlStatus = (DropDownList)(_Row.FindControl("drlStatus"));
        drlStatus.DataSource = OrderStatusDAO.GetAll();
        drlStatus.DataTextField = "Status";
        drlStatus.DataValueField = "ID";
        drlStatus.DataBind();
        BindData();

        String _Id = ((Label)_Row.FindControl("lblStatusId")).Text;
        drlStatus.SelectedValue = _Id;
    }
}
