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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    public void LoadMenu()
    {
        String _Html = "<ul><li><a href='#'>Home</a></li>";

        if (Session["C"] != null)
        {
            _Html += "<li><a href='#'>Logout</a></li>";
        }
        else
        {
            _Html += "<li><a href='#'>register</a></li>";
        }

        _Html += "</ul>";
        Response.Write(_Html);
    }
}
