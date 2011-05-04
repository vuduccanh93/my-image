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

public partial class admin_wuc_Login : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        String _U = txtUsername.Text.Trim();
        String _P = txtPassword.Text.Trim();

        AccountModel _Acc = null;
        _Acc = AccountDAO.GetByU_P(_U, _P);
        if (_Acc != null)
        {
            Session["U"] = _Acc.Username;
            Session["P"] = _Acc.Password;
            Session["R"] = _Acc.Rid;
            Session["I"] = _Acc.ID;
            clearTextFields();

            lblError.Text = "Username/password is match!";
        }
        else
        {
            lblError.Text = "Username/password is not match!";
            clearTextFields();
        }
    }
    private void clearTextFields()
    {
        txtUsername.Text = "";
        txtPassword.Text = "";
    }
}
