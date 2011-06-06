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

public partial class admin_wuc_wucChangePassword : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
            if (!Page.IsPostBack)
            {
               
            }
        
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        MemberModel model = (MemberModel)Session["admin"];
        if (model.Password.Trim().ToLower().Equals(txtPassword.Text.Trim().ToLower()))
        {
            if (!String.IsNullOrEmpty(txtNewpassword.Text.Trim()))
            {
                if (txtNewpassword.Text.Trim().ToLower().Equals(txtCofpassword.Text.Trim().ToLower()))
                {
                    model.Password = txtNewpassword.Text.Trim().ToLower();
                    if (MemberDAO.ChangePassword(model.ID, model.Password))
                    {
                        Session["admin"] = MemberDAO.GetByU_P(model.Username,model.Password);
                        lblLabel.Text = "Change password successful";
                        
                    }
                    else
                    {
                        lblLabel.Text = "Failed";
                    }
                }
                else
                {
                    lblLabel.Text = "New password is not match";
                }
            }
            else
            {
                lblLabel.Text ="New password can not be null";
            }
        }
        else
        {
            lblLabel.Text ="Old password incorrect";
        }
    }
    protected void Alert(String _Text)
    {
        Response.Write("<script>alert('" + _Text + "')</script>");
    }
}
