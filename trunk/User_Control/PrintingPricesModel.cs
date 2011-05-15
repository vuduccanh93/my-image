using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for PrintingPricesModel
/// </summary>
public class PrintingPricesModel
{
	private String id;
    private String size;
    private String price;

    public String ID
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public String Size
    {
        get { return this.size; }
        set { this.size = value; }
    }

    public String Price
    {
        get { return this.price; }
        set { this.price = value; }
    }
    public PrintingPricesModel()
    {
        id = "";
        size = "";
        price = "";
    }
    
    public PrintingPricesModel(String _ID,String _Size, String _Price)
    {
       this.id = _ID;
       this.size = _Size;
       this.price = _Price;
    }
}
