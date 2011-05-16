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
    public string ServerValue = String.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerModel model = (CustomerModel)Session["user"];
        txtEmail.Text = model.Email;
        txtFName.Text = model.FName;
        txtLName.Text = model.LName;
        ServerValue = model.Dob;
        txtPhone.Text = model.PNo;
        txtAddress.Text = model.Address;
        if (model.Gender.Equals("False"))
        {
            rdbFemale.Checked = true;
        }
        else if (model.Gender.Equals("True"))
        {
           
            rdbMale.Checked = true;
        }
        
    }

    protected void btnAccept_Click(object sender, EventArgs e)
    {
         CustomerModel model = (CustomerModel)Session["user"];
         if (txtOldPassword.Text.Equals(""))
         {
             CustomerModel cusModel = new CustomerModel();
             cusModel.ID = model.ID;
             cusModel.Email = txtEmail.Text;
             cusModel.FName =txtFName.Text; 
             cusModel.LName = txtLName.Text; 
             cusModel.PNo = txtPhone.Text ;
             cusModel.Address = txtAddress.Text;
             cusModel.Password = model.Password;
             cusModel.Gender = rdbFemale.Checked ? "1" : "0";
             cusModel.Status = model.Status;
             if (CustomerDAO.Update(cusModel))
             {
                 Session["user"] = CustomerDAO.GetByU_P(model.Username, model.Password);
                 Response.Redirect("~/?t=changeinfo&rs=success");
             }
         }
         else 
         {
             if (txtOldPassword.Text.Equals(model.Password))
             {
                 if (txtNewPassword.Text.Equals(txtCofPassword.Text))
                 {
                     CustomerModel cusModel = new CustomerModel();
                     cusModel.ID = model.ID;
                     cusModel.Email = txtEmail.Text;
                     cusModel.FName = txtFName.Text;
                     cusModel.LName = txtLName.Text;
                     cusModel.Dob = model.Dob;
                     cusModel.PNo = txtPhone.Text;
                     cusModel.Address = txtAddress.Text;
                     cusModel.Gender = rdbFemale.Checked ? "0" : "1";
                     cusModel.Password = txtNewPassword.Text.Trim();
                     if (CustomerDAO.Update(cusModel))
                     {
                         Response.Redirect("~/?t=changeinfo&rs=success");
                     }
                 }
                 else
                 {
                     Label1.Text = "New Password and Cof Password are not match";
                 }
             }
             else
             {
                 Label1.Text = "Old Password is incorrect";
             }
         }
    }
}
