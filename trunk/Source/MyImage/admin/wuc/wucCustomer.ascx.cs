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
    private void BindDRLStatus(int _RowIndex)
    {
        GridViewRow _Row = grvCustomer.Rows[_RowIndex];
        DropDownList drlStatus = (DropDownList)(_Row.FindControl("drlStatus"));
        drlStatus.DataSource = MemberStatusDAO.GetAll();
        drlStatus.DataTextField = "Status";
        drlStatus.DataValueField = "ID";
        drlStatus.DataBind();

        String _Id = ((Label)_Row.FindControl("lblStatusId")).Text;
        drlStatus.SelectedValue = _Id;
    }
    private int getIndex(GridView _Grv, String _HeaderText)
    {
        int index = -1;
        foreach (DataControlField col in _Grv.Columns)
        {
            if (col.HeaderText.Equals(_HeaderText))
            {
                index = _Grv.Columns.IndexOf(col);
                break;
            }
        }
        return index;
    }
    protected void grvCustomer_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvCustomer.EditIndex = e.NewEditIndex;
        BindData();
        BindDRLStatus(e.NewEditIndex);
        grvCustomer.Columns[getIndex(grvCustomer,"Username")].Visible = false;
    }
    protected void grvCustomer_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grvCustomer.EditIndex = -1;
        BindData();
        grvCustomer.Columns[getIndex(grvCustomer, "Username")].Visible = true;
    }
    protected void grvCustomer_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        BindData();
    }   
    protected void grvCustomer_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow _Row = grvCustomer.Rows[e.RowIndex];
        CustomerModel _Model = new CustomerModel();
        _Model.ID = ((TextBox)_Row.FindControl("txtID")).Text;
        _Model.Username = ((TextBox)_Row.FindControl("txtUsername")).Text;
        _Model.FName = ((TextBox)_Row.FindControl("txtF_name")).Text;
        _Model.LName = ((TextBox)_Row.FindControl("txtL_name")).Text;
        _Model.PNo = ((TextBox)_Row.FindControl("txtP_no")).Text;
        _Model.Gender = ((CheckBox)_Row.FindControl("ckbGender")).Checked ? "1" : "0";
        _Model.Address = ((TextBox)_Row.FindControl("txtAddress")).Text;
        _Model.Email = ((TextBox)_Row.FindControl("txtEmail")).Text;
        _Model.StatusId = ((DropDownList)(_Row.FindControl("drlStatus"))).SelectedValue.ToString(); ;
        CustomerDAO.Update(_Model);
        grvCustomer.EditIndex = -1;
        BindData();
        grvCustomer.Columns[getIndex(grvCustomer, "Username")].Visible = true;
    }
}
