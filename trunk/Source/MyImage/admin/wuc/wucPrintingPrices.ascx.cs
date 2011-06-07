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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Main();
            TextBox txtNewPrice = (TextBox)grvPrintingPrices.FooterRow.FindControl("txtNewPrice");
            txtNewPrice.Attributes.Add("onKeypress", "IsNumber(event);");
        }
    }

    private void Main()
    {       
        BindData();
    }

    private void BindData()
    {        
        grvPrintingPrices.DataSource = PrintingPriceDAO.GetAll();        
        grvPrintingPrices.DataBind();
    }
    protected void grvPrintingPrices_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grvPrintingPrices.EditIndex = -1;        
        BindData();        
    }  

    protected void grvPrintingPrices_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {           
        BindData();
    }

    protected void grvPrintingPrices_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvPrintingPrices.EditIndex = e.NewEditIndex;
        BindData();
        TextBox txtPrice = (TextBox)grvPrintingPrices.Rows[e.NewEditIndex].FindControl("txtPrice");
        txtPrice.Attributes.Add("onKeypress", "IsNumber(event);");
    }    
    protected void grvPrintingPrices_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow _Row = grvPrintingPrices.Rows[e.RowIndex];

        String _Id = (_Row.FindControl("txtId") as TextBox).Text;
        String _Size = (_Row.FindControl("txtSize") as TextBox).Text;
        String _Price = (_Row.FindControl("txtPrice") as TextBox).Text;   
    
        PrintingPriceModel _Model = new PrintingPriceModel(_Id, _Size, _Price);
        PrintingPriceDAO.Update(_Model);
        grvPrintingPrices.EditIndex = -1;
        BindData();        
    }    
    
    protected void grvPrintingPrices_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "NewInsert")
        {
            TextBox _PPSize = ((TextBox)grvPrintingPrices.FooterRow.FindControl("txtNewSize"));
            Label _PPSizeErr = ((Label)grvPrintingPrices.FooterRow.FindControl("lblNewSizeErr"));
            TextBox _PPrice = ((TextBox)grvPrintingPrices.FooterRow.FindControl("txtNewPrice"));
            Label _PPriceErr = ((Label)grvPrintingPrices.FooterRow.FindControl("lblPriceErr"));
            if (_PPSize != null && _PPSizeErr != null && _PPrice != null && _PPriceErr != null)
            {
                if (_PPSize.Text.Trim().Length < 3)
                {
                    _PPSizeErr.Text = "*";
                    _PPSize.Focus();
                    return;
                }
                int i = 0;
                if (!String.IsNullOrEmpty(_PPrice.Text.Trim()) || !int.TryParse(_PPrice.Text.Trim(), out i))
                {
                    _PPriceErr.Text = "*";
                    _PPriceErr.Focus();
                    return;
                }
                PrintingPriceModel _Model = new PrintingPriceModel("", _PPSize.Text, _PPrice.Text);
                PrintingPriceDAO.Insert(_Model);
                BindData();
            }
        }
    }
}
