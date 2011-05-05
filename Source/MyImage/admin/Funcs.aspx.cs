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

public partial class admin_Funcs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Main()
    {
        if (Request.QueryString["t"] != null)
        {
            String _Token = Request.QueryString["t"].ToString();
            switch (_Token)
            {
                case "cu":
                    LoadCustomers();
                    break;
            }
        }
    }

    private void LoadCustomers()
    {
        Response.Write("OK");
    }
}
