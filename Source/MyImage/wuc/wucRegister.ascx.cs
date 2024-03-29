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


public partial class wuc_wucRegister : System.Web.UI.UserControl
{
    
       
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            txtPhone.Attributes.Add("onKeypress", "IsNumber(event);");
        }
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       
        
        CustomerModel model = new CustomerModel();
        model.Username = CustomerDAO.GetUsername();
        model.Password = CustomerDAO.GetPassword();
        model.FName = txtFirstname.Text;
        model.LName = txtLastname.Text;
        String Dob = Request.Form["txtBirthday"];
        model.Dob = Dob.Substring(0, 4) + Dob.Substring(5, 2) + Dob.Substring(8, 2);
        model.Gender = rdbFemale.Checked ? "0" : "1";
        model.PNo = txtPhone.Text;
        model.Address = txtAddress.Text;
        model.Email = txtEmail.Text;
        if (CustomerDAO.Insert(model))
        {
            Session["tempUsername"] = model.Username;
            Session["tempPassword"] = model.Password;
            Response.Redirect("~/?t=register&rs=success");
        }
        else
        {
            Response.Write("Fails");
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}
