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

public partial class _Default : System.Web.UI.Page
{
    String _Token = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        Main();
        addValueCLB();
    }
    public void LoadMenu()
    {
        String _Html = "<div class='nav'><ul> <li><a href='#'> Home </a></li>";

        if(Session["CusId"]==null)
        {
            _Html += "<li><a href='Default.aspx?t=login'> Login </a></li> ";
            _Html += "<li><a href='Default.aspx?t=register'> Register </a></li>";
        }
        else
        {
            _Html += "<li><a href = 'Default.aspx?t=order'> Order </a><em></em></li>";
            _Html += "<li><a href = 'Default.aspx?t=changeinfo'> Change Info </a><em></em></li>";
            _Html += "<li><a href = '#'> Logout </a><em></em></li>";
        }
        _Html += "</ul></div>";
        Response.Write(_Html);
    }
    public void Main()
    {
        if (Request.QueryString["t"] != null)
        {
            _Token = Request.QueryString["t"].ToString();
            switch (_Token)
            {
                case "register":
                    if (Request.QueryString["rs"] != null)
                        addControl(Request.ApplicationPath + @"/wuc/wucRegisterSuccess.ascx");
                    else
                        addControl(Request.ApplicationPath + @"/wuc/wucRegister.ascx");
                    break;
                case "login":
                    if (Request.QueryString["lg"] != null)
                        addControl(Request.ApplicationPath + @"/wuc/wucLoginSuccess.ascx");
                    else
                        addControl(Request.ApplicationPath + @"/wuc/wucLogin.ascx");
                    break;
                case "changeinfo":
                    if (Session["user"] != null)
                        addControl(Request.ApplicationPath + @"/wuc/wucChangeInfo.ascx");
                    break;

                case "order":
                    if (Request.QueryString["t"] != null && Request.QueryString["start"] != null &&
                        Request.QueryString["upload"] != null && Request.QueryString["content"] != null &&
                        Request.QueryString["payment"] != null && Request.QueryString["finish"]!=null)
                    {

                    }
                    else if (Request.QueryString["t"] != null && Request.QueryString["start"] != null &&
                                Request.QueryString["upload"] != null && Request.QueryString["content"] != null &&
                                Request.QueryString["payment"] != null)
                    {

                    }
                    else if (Request.QueryString["t"] != null && Request.QueryString["start"] != null &&
                                 Request.QueryString["upload"] != null && Request.QueryString["content"] != null)
                    {

                    }
                    else if (Request.QueryString["t"] != null && Request.QueryString["start"] != null &&
                        Request.QueryString["upload"] != null)
                    {
                        addControl(Request.ApplicationPath + @"/wuc/wucOrder_OrderDetails.ascx");
                    }
                    else if (Request.QueryString["t"]!= null && Request.QueryString["start"] != null)
                    {
                        addControl(Request.ApplicationPath + @"/wuc/wucOrder_Upload.ascx");
                    }
                    else if (Request.QueryString["t"] != null)
                    {
                        addControl(Request.ApplicationPath + @"/wuc/wucOrder_Start.ascx");
                    }

                    break;
            }
        }
    }
    private void addControl(String _Path)
    {
        Control wucCus = (Control)Page.LoadControl(_Path);
        PlaceHolderRight.Controls.Add(wucCus);
    }
    private void addValueCLB()
    {
        DataTable dt = UploadDAO.getImageByUId("12");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

        CheckBoxList drlStatus = (CheckBoxList)(grvMember.Rows[e.NewEditIndex].Cells[1].FindControl("CheckBoxList1"));
    }
}
