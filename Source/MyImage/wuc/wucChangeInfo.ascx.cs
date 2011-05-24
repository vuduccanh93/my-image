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

public partial class wuc_wucChangeInfo : System.Web.UI.UserControl
{
    public string ServerValue = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            CustomerModel model = (CustomerModel)Session["user"];
            txtEmail.Text = model.Email;
            txtFName.Text = model.FName;
            txtLName.Text = model.LName;
            ServerValue = UtilDAO.DateTimeFormat(model.Dob, Constants.DATE_FORMAT_YYYY_MM_DD_S2);
            txtPhone.Text = model.PNo;
            txtAddress.Text = model.Address;
            if (model.Gender.Equals("0"))
            {
                rdbFemale.Checked = true;
            }
            else
            {
                rdbMale.Checked = true;
            }
        }
    }

    protected void btnAccept_Click(object sender, EventArgs e)
    {
        CustomerModel model = (CustomerModel)Session["user"];
        model.ID = model.ID;
        model.Email = txtEmail.Text;
        model.FName = txtFName.Text;
        model.LName = txtLName.Text;
        model.PNo = txtPhone.Text;
        model.Address = txtAddress.Text;
        model.Gender = rdbFemale.Checked ? "0" : "1";
        model.StatusId = model.StatusId;
        model.Dob = Request.Form["txtBirthday"].Substring(0, 4) + Request.Form["txtBirthday"].Substring(5, 2) + Request.Form["txtBirthday"].Substring(8, 2) + " 000000";
        ServerValue = Request.Form["txtBirthday"];
        if (!String.IsNullOrEmpty(txtOldPassword.Text.Trim()))
        {
            if (txtOldPassword.Text.Equals(model.Password))
            {
                if (txtNewPassword.Text.Equals(txtCofPassword.Text))
                {
                    model.Password = txtNewPassword.Text.Trim();
                }
                else
                {
                    lblErr.Text = "New password is not match";
                    return;
                }
            }
            else
            {
                lblErr.Text = "Old password is not correct";
                return;
            }
        }
        if (CustomerDAO.Update(model))
        {
            Session["user"] = model;
            Response.Redirect("~/?t=changeinfo&rs=success");
        }
        else lblErr.Text = "Update failed.Please try again later";
    }



}
