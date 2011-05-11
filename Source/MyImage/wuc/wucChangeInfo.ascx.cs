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
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerModel model = (CustomerModel)Session["User"];
        txtEmail.Text = model.Email;
        txtFName.Text = model.FName;
        txtLName.Text = model.LName;
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
         CustomerModel model = (CustomerModel)Session["User"];
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
             if (CustomerDAO.Upsdate(cusModel))
             {
                 Response.Redirect("~/?t=changeinfo&rs=success");
                 Session["User"] = CustomerDAO.GetByU_P(model.Username,model.Password);
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
                     if (CustomerDAO.Upsdate(cusModel))
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
