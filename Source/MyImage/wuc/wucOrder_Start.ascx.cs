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

public partial class wuc_wucOrder_Start : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnStart_Click(object sender, EventArgs e)
    {
        
        Session["start"] = false;
        Session["uploaded"] = 0;
        Response.Redirect("Default.aspx?t=order&start=true");

    }
}
