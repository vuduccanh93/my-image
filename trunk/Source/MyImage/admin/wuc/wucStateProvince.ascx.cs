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
        String _Avail = ((CheckBox)_Row.FindControl("ckbAvailable")).Checked ? "1" : "0";
        StateProvinceModel _Model = new StateProvinceModel(_Id, _Name, _Avail);
        if (StateProvinceDAO.IsAvailable(_Model) == 0)
        {
            StateProvinceDAO.Update(_Model);
            grvStateProvince.EditIndex = -1;
            BindData();
        }
        else
        {
            Alert(_Name + " is NOT AVAILABLE!");
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
            CheckBox _SPAvalable = (CheckBox)grvStateProvince.FooterRow.FindControl("ckbNewAvailable");
            StateProvinceModel _NewModel = null;
            if (String.IsNullOrEmpty(_SPName.Text.Trim()))
            {
                Alert("State/Province(s) is NOT NULL or EMPTY!");
            }
            else
            {
                _NewModel = new StateProvinceModel("", _SPName.Text, _SPAvalable.Checked ? "1" : "0");
                if (StateProvinceDAO.IsAvailable(_NewModel) == 0)
                {
                    StateProvinceDAO.Insert(_NewModel);
                    BindData();
                }
                else
                {
                    Alert(_SPName.Text +" is NOT AVAILABLE!");
                }
            }
        }
    }

    protected void Alert(String _Text)
    {
        Response.Write("<script>alert('" + _Text + "')</script>");
    }
    protected void grvStateProvince_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grvStateProvince.PageIndex = e.NewPageIndex;
        BindData();
    }
}
