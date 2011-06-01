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

public partial class wuc_wucMainMenu : System.Web.UI.UserControl
{
    String _Html = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMenu.Text = LoadMenu();
    }
    public String LoadMenu()
    {
        _Html = "<div class='nav'><ul> <li><a href='Default.aspx'> HOME </a></li>";

        if (Session["user"] == null)
        {
            _Html += "<li><a href='Default.aspx?t=register'> REGISTER </a></li>";
        }
        else
        {
            _Html += "<li><a href = 'Default.aspx?t=order'> ORDER </a><em></em></li>";
            _Html += "<li><a href = 'Default.aspx?t=orderlist'> MY ORDER </a><em></em></li>";
            _Html += "<li><a href = 'Default.aspx?t=changeinfo'> CHANGE INFO </a><em></em></li>";
            _Html += "<li><a href = 'Default.aspx?t=login&logout=true'> LOGOUT </a><em></em></li>";
        }
        _Html += "<li><a href='Default.aspx?t=contact'> CONTACT </a></li>";
        _Html += "</ul></div>";
        return _Html;
    }
}
