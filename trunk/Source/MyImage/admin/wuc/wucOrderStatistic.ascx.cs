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
    String _TxtFrom = "";
    String _TxtTo = "";
    protected void Page_Load(object sender, EventArgs e)
    {  
        if (!Page.IsPostBack)
            Main();
    }

    private void Main()
    {
        
        BindDRLStatus();
    }

    private void BindData(String _Opt, String _From, String _To)
    {
        DataTable _Result = OrderDAO.Statistic_GetByFromTo(_Opt, _From, _To);
        if (_Result == null || _Result.Rows.Count == 0)
        {
            lblError.Text = "No data found";
            return;
        }
        grvStatisticOrder.DataSource = _Result;
        grvStatisticOrder.DataBind();
        lblRowCount.Text = _Result.Rows.Count.ToString();
        lblSum.Text = TotalAmound(_Result).ToString();
        lblInfo.Text = "Search orders from " + _TxtFrom + " to " + _TxtTo;
    }

    private void BindDRLStatus()
    {       
        drlOrderStatus.DataSource = OrderDAO.Status_GetAll();
        drlOrderStatus.DataValueField = "ID";
        drlOrderStatus.DataTextField = "Status";
        drlOrderStatus.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        _TxtFrom = Request.Form["txtFrom"];
        _TxtTo = Request.Form["txtTo"];
        String fromDay = _TxtFrom.Substring(0, 4) + _TxtFrom.Substring(5, 2) + _TxtFrom.Substring(8, 2) + "000000";
        String toDay = _TxtTo.Substring(0, 4) + _TxtTo.Substring(5, 2) + _TxtTo.Substring(8, 2) + "000000";
        if (Convert.ToDouble(fromDay) > Convert.ToDouble(toDay))
        {
            lblError.Text = "To date cant font of from date ";
            lblInfo.Text = "";
            grvStatisticOrder.Visible = false;
        }
        else
        {
            if (String.IsNullOrEmpty(_TxtFrom) || String.IsNullOrEmpty(_TxtTo))
            {
                lblError.Text = "From/to date is not null!";
                lblInfo.Text = "";
                grvStatisticOrder.Visible = false;
                return;
            }
            String _From = _TxtFrom.Substring(0, 4) + _TxtFrom.Substring(5, 2) + _TxtFrom.Substring(8, 2) + " 000000";
            String _To = _TxtTo.Substring(0, 4) + _TxtTo.Substring(5, 2) + _TxtTo.Substring(8, 2) + " 000000";
            string _Opt = drlOrderStatus.SelectedValue.ToString();
            grvStatisticOrder.Visible = true;
            BindData(_Opt, _From, _To);
        }
    }
    private float TotalAmound(DataTable _Dt)
    {
        float sum = 0;
        foreach (DataRow _Dr in _Dt.Rows)
        {
            sum += float.Parse(_Dr["Amount"].ToString().Trim());
        }
        return sum;
    }
}
