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
/// Summary description for CreditCardModel
/// </summary>
public class CreditCardModel
{
    private String id;
    private String number;
    private String exp_date;
    private String holder_name;
    private String l_three_letter;

    public String ID
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public String Number
    {
        get { return this.number; }
        set { this.number = value; }
    }
    public String Exp_date
    {
        get { return this.exp_date; }
        set { this.exp_date = value; }
    }
    public String Holder_name
    {
        get { return this.holder_name; }
        set { this.holder_name = value; }
    }
    public String L_three_letter
    {
        get { return this.l_three_letter; }
        set { this.l_three_letter = value; }
    }
	public CreditCardModel()
	{
        id = "";
        number = "";
        exp_date = "";
        holder_name = "";
        l_three_letter = "";
	}
}
