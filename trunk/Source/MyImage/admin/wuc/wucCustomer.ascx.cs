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

public partial class admin_wuc_wucCustomer : System.Web.UI.UserControl
{
    String _Token = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Main();
        }
    }

    public void Main()
    {
        if (Request.QueryString["t"] != null && Request.QueryString["t"].ToString().Equals("cu"))
        {
            _Token = Request.QueryString["t"].ToString();
            BindData();
        }
    }
    private void BindData()
    {
        grvCustomer.DataSource = CustomerDAO.GetAll();
        grvCustomer.DataBind();
    }
    protected void grvCustomer_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvCustomer.EditIndex = e.NewEditIndex;
        BindData();
    }
    protected void grvCustomer_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grvCustomer.EditIndex = -1;
        BindData();
    }
    protected void grvCustomer_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        BindData();
    }
    protected void grvCustomer_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow _Row = grvCustomer.Rows[e.RowIndex];
        String _ID = ((TextBox)_Row.FindControl("txtID")).Text;
        String _Username = ((TextBox)_Row.FindControl("txtUsername")).Text;
        String _F_name = ((TextBox)_Row.FindControl("txtF_name")).Text;
        String _L_name = ((TextBox)_Row.FindControl("txtL_name")).Text;
        String _P_no = ((TextBox)_Row.FindControl("txtP_no")).Text;
        String _Gender = ((CheckBox)_Row.FindControl("ckbGender")).Checked ? "1" : "0";
        String _Address = ((TextBox)_Row.FindControl("txtAddress")).Text;

        CustomerModel _Model = new CustomerModel(_ID, _Username, "", _F_name, _L_name, "", _Gender, _P_no, _Address);
        CustomerDAO.Upsdate(_Model);
        grvCustomer.EditIndex = -1;
        BindData();
    }
}
