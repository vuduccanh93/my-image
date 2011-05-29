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

public partial class admin_wuc_wucOrderSearch : System.Web.UI.UserControl
{
    String _TxtNo = "";
    String _TxtProvince = "";
    String _TxtCustomer = "";

    protected void Page_Load(object sender, EventArgs e)
    {        
    }

    private void BindData()
    {
        DataTable _Result = OrderDAO.GetAll();
        grvOrder.DataSource = _Result;
        grvOrder.DataBind();
    }    

    private void BindData(String _OrderNo, String _ProName, String _CusName)
    {
        DataTable _Result = OrderDAO.GetBySearch(_OrderNo, _ProName, _CusName);
        grvOrder.DataSource = _Result;
        grvOrder.DataBind();
    }
    
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        String _OrderNo = txtNo.Text.ToString();
        String _ProName = txtProvince.Text.ToString();
        String _CusName = txtCustomer.Text.ToString();

        if ((txtNo.Text != "") || (txtProvince.Text != "") || (txtCustomer.Text != ""))
        {
            BindData(_OrderNo, _ProName, _CusName);
        }
        else
        {
            BindData();
        }
    }
}

    
  
