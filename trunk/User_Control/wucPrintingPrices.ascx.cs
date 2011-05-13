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

public partial class admin_wuc_wucPrintingPrices : System.Web.UI.UserControl
{
    private String size;
    private String price;
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
        grvPrintingPrices.DataSource = PrintingPricesDAO.GetAll();
        grvPrintingPrices.DataBind();
    }
    protected void grvPrintingPrices_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grvPrintingPrices.EditIndex = -1;        
        BindData();

        btnAdd.Visible = true;
        btnAdd.Enabled = true;
    }
    protected void grvPrintingPrices_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow _Row = grvPrintingPrices.Rows[e.RowIndex];
        String _Id = ((TextBox)_Row.FindControl("txtId")).Text;
        String _Size = ((TextBox)_Row.FindControl("txtSize")).Text;
        String _Price = ((TextBox)_Row.FindControl("txtPrice")).Text;
        
            PrintingPricesDAO.Update(new PrintingPricesModel( _Size, _Price));
            grvPrintingPrices.EditIndex = -1;
            BindData();

            btnAdd.Visible = true;
            btnAdd.Enabled = true;
    }

    protected void grvPrintingPrices_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        BindData();
    }
    protected void grvPrintingPrices_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvPrintingPrices.EditIndex = e.NewEditIndex;
        BindData();        
        btnAdd.Visible = false;
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
       
    }

}
