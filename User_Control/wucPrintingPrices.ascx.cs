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
       // if (!Page.IsPostBack)
        Main();
    }

    private void Main()
    {
        //if (!Page.IsPostBack)
        //{
        //    txtSizePP.Text = "";
        //    txtPricePP.Text = "";
        //    Page.SetFocus(txtSizePP);
        //}
        
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
    }  

    protected void grvPrintingPrices_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {           
        BindData();
    }

    protected void grvPrintingPrices_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvPrintingPrices.EditIndex = e.NewEditIndex;
        BindData();           
    }    
    protected void grvPrintingPrices_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow _Row = grvPrintingPrices.Rows[e.RowIndex];

        String _Id = (_Row.FindControl("txtId") as TextBox).Text;
        String _Size = (_Row.FindControl("txtSize") as TextBox).Text;
        String _Price = (_Row.FindControl("txtPrice") as TextBox).Text;   
    
        PrintingPricesModel _Model = new PrintingPricesModel(_Id, _Size, _Price);
        PrintingPricesDAO.Update(_Model);
        grvPrintingPrices.EditIndex = -1;
        BindData();
        Main();
    }
    
    protected void btnAdd_Click(object sender, EventArgs e)
    {        
        String _Size = txtSizePP.Text;
        String _Price = txtPricePP.Text;
        PrintingPricesModel _Model = new PrintingPricesModel("",  _Size, _Price);
        PrintingPricesDAO.Insert(_Model);
        //grvPrintingPrices.EditIndex = -1;
       // BindData();
        Main();       
    }
}
