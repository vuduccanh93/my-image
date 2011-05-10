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
        //update member
    }
    protected void grvMember_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        BindData();
    }
    protected void grvMember_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvMember.EditIndex = e.NewEditIndex;
        BindData();

        DropDownList drlStatus = (DropDownList)(grvMember.Rows[e.NewEditIndex].Cells[2].FindControl("drlStatus"));
        DataTable asd = MemberStatusDAO.GetAll();
        drlStatus.DataSource = MemberStatusDAO.GetAll();
        drlStatus.DataTextField = "Status";
        drlStatus.DataValueField = "ID";
        drlStatus.DataBind();
        Label lblStatus = (Label)(grvMember.Rows[e.NewEditIndex].Cells[2].FindControl("lblStatus"));
        drlStatus.SelectedValue = lblStatus.Text;

        DropDownList drlRole = (DropDownList)(grvMember.Rows[e.NewEditIndex].Cells[1].FindControl("drlRole"));
        drlRole.DataSource = RoleDAO.GetAll();
        drlRole.DataTextField = "Name";
        drlRole.DataValueField = "ID";
        drlRole.DataBind();
        Label lblRole = (Label)(grvMember.Rows[e.NewEditIndex].Cells[1].FindControl("lblRole"));
        drlRole.SelectedValue = lblRole.Text;

    }
}
