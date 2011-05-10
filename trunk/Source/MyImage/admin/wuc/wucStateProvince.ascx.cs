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

public partial class admin_wuc_wucStateProvince : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Main();
    }
    private void Main()
    {
        BindData();
    }

    private void BindData()
    {
        grvStateProvince.DataSource = StateProvinceDAO.GetAll();
        grvStateProvince.DataBind();
    }
    protected void grvStateProvince_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grvStateProvince.EditIndex = -1;
        BindData();
    }
    protected void grvStateProvince_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow _Row = grvStateProvince.Rows[e.RowIndex];
        String _Id = ((TextBox)_Row.FindControl("txtId")).Text;
        String _Name = ((TextBox)_Row.FindControl("txtName")).Text;
        if (StateProvinceDAO.IsAvailable(new StateProvinceModel(_Id, _Name)) == 0)
        {
            StateProvinceDAO.Update(new StateProvinceModel(_Id, _Name));
            grvStateProvince.EditIndex = -1;
            BindData();
        }
        else
        {
            Response.Write("<script>alert('" + _Name + " is NOT AVAILABLE!')</script>");
        }
        
    }
    protected void grvStateProvince_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        BindData();
    }
    protected void grvStateProvince_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvStateProvince.EditIndex = e.NewEditIndex;
        BindData();
    }
    protected void grvStateProvince_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "InsertNewSProvince")
        {
            TextBox _SPName = (TextBox)grvStateProvince.FooterRow.FindControl("txtNewSProvince");
            Label _SPError = (Label)grvStateProvince.FooterRow.FindControl("lblInsertError");
            if (StateProvinceDAO.IsAvailable(new StateProvinceModel("", _SPName.Text)) == 0)
            {
                StateProvinceDAO.Insert(new StateProvinceModel("", _SPName.Text));
                _SPError.Text = "";
                BindData();
            }
            else
            {
                Response.Write("<script>alert('" + _SPName.Text + " is NOT AVAILABLE!')</script>");
                _SPName.Text = "";
            }
        }
    }
}
