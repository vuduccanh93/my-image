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
/// Summary description for PaymentMethodModel
/// </summary>
public class PaymentMethodModel
{
    private String id;
    private String name;

    public String ID
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public String Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
	public PaymentMethodModel()
	{
        this.id = "";
        this.name = "";
	}
    public PaymentMethodModel(String _Id, String _Name)
    {
        this.id = _Id;
        this.name = _Name;
    }
}
