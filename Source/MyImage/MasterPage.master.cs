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

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /**
     * Session["user"] = user; ->null
     * Session["order_start"] = 1;->0
     * Session["order_upload"] = 1;->0
     * Session["order_orderdetails"] = 1
     * Session["upload_savepath"] = SavePath;->null
     * Session["upload_uploadmodel"] = ULModel;->null
     * Session["upload_uploaded"] = 1 -> null
     * 
     * */
}
