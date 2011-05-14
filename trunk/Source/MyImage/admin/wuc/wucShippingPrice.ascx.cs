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

public partial class admin_wuc_wucShippingPrice : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindData();
        }
    }
    private void BindData()
    {
        BindDataGrv();
        BindDRLNewStateProvince();
    }
    private void BindDataGrv()
    {
        grvPrintingPrice.DataSource = ShippingPriceDAO.GetAll();
        grvPrintingPrice.DataBind();
    }
    private void BindDRLNewStateProvince()
    {
        DropDownList _NewDrl = (DropDownList)grvPrintingPrice.FooterRow.FindControl("drlNewSProvince");
        _NewDrl.DataSource = StateProvinceDAO.GetAllAvalable();
        _NewDrl.DataTextField = "Name";
        _NewDrl.DataValueField = "ID";
        _NewDrl.DataBind();
    }
    private void BindDRLStateProvince(int _RowIndex)
    {
        DropDownList drlStateProvince = (DropDownList)(grvPrintingPrice.Rows[_RowIndex].FindControl("drlStateProvince"));
        drlStateProvince.DataSource = StateProvinceDAO.GetAllAvalable();
        drlStateProvince.DataTextField = "Name";
        drlStateProvince.DataValueField = "ID";
        drlStateProvince.DataBind();

        GridViewRow _Row = grvPrintingPrice.Rows[_RowIndex];
        String _Id = ((TextBox)_Row.FindControl("txtSpId")).Text;
        drlStateProvince.SelectedValue = _Id;
    }
    protected void grvPrintingPrice_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvPrintingPrice.EditIndex = e.NewEditIndex;
        BindData();
        BindDRLStateProvince(e.NewEditIndex);
    }
    protected void grvPrintingPrice_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow _Row = grvPrintingPrice.Rows[e.RowIndex];
        String _Id = ((TextBox)_Row.FindControl("txtId")).Text.ToString();
        String _SPId = ((DropDownList)_Row.FindControl("drlStateProvince")).SelectedValue.ToString();
        String _STime = ((TextBox)_Row.FindControl("txtShippingTime")).Text;
        String _Price = ((TextBox)_Row.FindControl("txtPrice")).Text;
        ShippingPriceModel _UpdateModel = null;
        if (String.IsNullOrEmpty(_STime) || String.IsNullOrEmpty(_Price))
        {
            Alert("Shipping time/Price is NOT NULL or EMPTY!");
            BindDRLStateProvince(e.RowIndex);
        }
        else
        {
            _UpdateModel = new ShippingPriceModel(_Id, _SPId, "", _STime, _Price, "");
            ShippingPriceDAO.Update(_UpdateModel);
            grvPrintingPrice.EditIndex = -1;
            BindData();

        }
    }
    protected void grvPrintingPrice_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        BindData();
    }

    protected void grvPrintingPrice_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grvPrintingPrice.EditIndex = -1;
        BindData();
    }
    protected void grvPrintingPrice_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "NewInsert")
        {
            String _SProvinceId = ((DropDownList)grvPrintingPrice.FooterRow.FindControl("drlNewSProvince")).SelectedValue.ToString();
            String _STime = ((TextBox)grvPrintingPrice.FooterRow.FindControl("txtNewShippingTime")).Text.ToString();
            String _Price = ((TextBox)grvPrintingPrice.FooterRow.FindControl("txtNewPrice")).Text.ToString();
            ShippingPriceModel _NewModel = null;
            if (String.IsNullOrEmpty(_STime) || String.IsNullOrEmpty(_Price))
            {
                Alert("ShippingTime/Price is NOT NULL or EMPTY!");
            }
            else
            {
                _NewModel = new ShippingPriceModel("", _SProvinceId, "", _STime, _Price, "");
                ShippingPriceDAO.Insert(_NewModel);
                BindData();
            }
        }
    }
    protected void Alert(String _Text)
    {
        Response.Write("<script>alert('" + _Text + "')</script>");
    }
    protected void grvPrintingPrice_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grvPrintingPrice.PageIndex = e.NewPageIndex;
        BindData();
    }
}
