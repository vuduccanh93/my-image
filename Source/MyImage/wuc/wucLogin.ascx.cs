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

public partial class wuc_wucLogin : System.Web.UI.UserControl
{
    String WEB_URL = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            WEB_URL = Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/");
        }

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        String Useranme = txtUsername.Text;
        String Password = txtPassword.Text;

        CustomerModel model = CustomerDAO.GetByU_P(Useranme,Password);
        if (model != null)
        {
            if (model.Status.Equals("0"))
            {
                lblStatusLogin.Text ="User is block";
            }
            else if (model.Status.Equals("1"))
            {
                Session["CusId"] = model.ID;
                Session["user"] = model;
                Response.Redirect(@"~/?t=login&lg=success");
            }
        }
        else
        {
            lblStatusLogin.Text = "Username or Password is not match";
        }
    }
}
