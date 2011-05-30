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

public partial class admin_wuc_wucMember : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Main();
    }
    public void Main()
    {
        BindData();
    }
    private void BindData()
    {
        grvMember.DataSource = MemberDAO.GetWithOutId(Session["I"].ToString());
        grvMember.DataBind();
    }
    protected void grvMember_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grvMember.EditIndex = -1;
        BindData();
    }
    protected void grvMember_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        MemberModel _Model = new MemberModel();
        GridViewRow _Row = grvMember.Rows[e.RowIndex];
        _Model.ID = ((Label)_Row.FindControl("lblId")).Text;
        _Model.Username = ((TextBox)_Row.FindControl("txtUsername")).Text;
        _Model.Password = ((TextBox)_Row.FindControl("txtPassword")).Text;
        _Model.Rid = ((DropDownList)(_Row.FindControl("drlRole"))).SelectedValue.ToString();
        _Model.StatusId = ((DropDownList)(_Row.FindControl("drlStatus"))).SelectedValue.ToString();
        MemberDAO.Update(_Model);
        grvMember.EditIndex = -1;
        BindData();
    }
    protected void grvMember_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        
        BindData();
    }
    protected void grvMember_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvMember.EditIndex = e.NewEditIndex;
        BindData();

        DropDownList drlStatus = (DropDownList)(grvMember.Rows[e.NewEditIndex].FindControl("drlStatus"));
        drlStatus.DataSource = MemberStatusDAO.GetAll();
        drlStatus.DataTextField = "Status";
        drlStatus.DataValueField = "ID";
        drlStatus.DataBind();
        Label lblStatus = (Label)(grvMember.Rows[e.NewEditIndex].FindControl("lblStatus"));
        drlStatus.SelectedValue = lblStatus.Text;

        DropDownList drlRole = (DropDownList)(grvMember.Rows[e.NewEditIndex].FindControl("drlRole"));
        drlRole.DataSource = RoleDAO.GetAll();
        drlRole.DataTextField = "Name";
        drlRole.DataValueField = "ID";
        drlRole.DataBind();
        Label lblRole = (Label)(grvMember.Rows[e.NewEditIndex].Cells[1].FindControl("lblRole"));
        drlRole.SelectedValue = lblRole.Text;

    }
    public String ToStart(String _S)
    {
        String _Output = "";
        for (int i = 0; i < _S.Length; i++)
        {
            _Output += "*";
        }
        return _Output;
    }
}
