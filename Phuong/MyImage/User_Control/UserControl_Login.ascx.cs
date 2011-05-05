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
    protected void btnOK_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = conn;
        cmd.CommandText = "sp_Login";        
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text); 
        //DataTable dt = new DataTable();
        //SqlDataAdapter da = new SqlDataAdapter(cmd);        
        //da.Fill(dt);

        String user = Convert.ToString(cmd.ExecuteScalar());
        //conn.Close();
        //conn.Dispose();
        if (user != "")
        {
            Session["Login"] = user;
            Response.Redirect("default2.aspx");
        }
        else
        {
            lblMessage.Text = ("Username or password is error!");
        }
    }
}
