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
using System.Data.SqlClient;

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
        BindDRLStatus();
    }

    private void BindData()
    {
        grvStatisticOrder.DataSource = StatisticOrderDAO.GetAll();
        grvStatisticOrder.DataBind();
    }

    private void BindDRLStatus()
    {       
        DropDownList drlStatus = (DropDownList)grvStatisticOrder.FooterRow.FindControl("drlStatus");
        drlStatus.DataSource = OrderStatusDAO.GetAll();
        drlStatus.DataValueField = "ID";
        drlStatus.DataTextField = "Status";        
        drlStatus.DataBind();
        BindData();
       
        String _Id = ((Label)grvStatisticOrder.FooterRow.FindControl("lblStatusId")).Text;
        drlStatus.SelectedValue = _Id;        
    }

    private void StatisticOrder()
    {        
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        grvStatisticOrder.DataSource = dt;
        dt = StatisticOrderDAO.GetAll();
        grvStatisticOrder.DataBind();
        String _AmountOrder = ((Label)grvStatisticOrder.FooterRow.FindControl("lblNo_Order")).Text;
        _AmountOrder = Convert.ToInt16(dt.Rows.Count);
    }
}
