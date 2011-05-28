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

public partial class wuc_wucHome : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //lblStateProvince.Text = LoadStateProvince();
        }
    }
    //public String LoadStateProvince()
    //{
    //    String _Html = "";
    //    DataTable _Dt = StateProvinceDAO.GetAllAvalable();
    //    foreach (DataRow _Dr in _Dt.Rows)
    //    {
    //        _Html += "<li><a href='javascript:void(0);'>" + _Dr["Name"].ToString() +"</a></li>";
    //    }
        
    //    return _Html;
    //}
}
