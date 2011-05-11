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
using System.Data.SqlClient;

public partial class UserControl_Login : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Login"] = "";
    }    

    protected void btnOk_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        string dbProviderName = ConfigurationManager.ConnectionStrings["ConnectionString"].ProviderName;
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = conn;
        cmd.CommandText = "sp_Login";
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);

        String user = Convert.ToString(cmd.ExecuteScalar());
        // conn.Close();
        //conn.Dispose();
        if (user != "")
        {
            Session["Login"] = user;
            Response.Write("Successful!!!");
        }
        else
        {
            lblLogin.Text = ("Username or password is error!");
        }
    } 
   
    protected void  btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }

    protected void  lbtRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register .aspx");
    }
}
