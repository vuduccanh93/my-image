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
        if (Session["user"] != null) Response.Redirect(WEB_URL);
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        String Useranme = txtUsername.Text;
        String Password = txtPassword.Text;

        CustomerModel model = CustomerDAO.GetByU_P(Useranme,Password);
        if (model != null)
        {
            if (model.StatusId.Equals("0"))
            {
                Session["user"] = model;
                Response.Redirect(@"~");
                return;
            }
            else
            {
                lblStatusLogin.Text = "Username is banned";
            }
        }
        else
        {
            lblStatusLogin.Text = "Username/password is not match";
        }
    }
}
