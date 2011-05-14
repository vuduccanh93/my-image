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
/// Summary description for StateProvinceModel
/// </summary>
public class StateProvinceModel
{
    private String id;
    private String name;
    private String available;

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
    public String Available
    {
        get { return this.available; }
        set { this.available = value; }
    }
    public StateProvinceModel()
	{
        id = "";
        name = "";
        available = "";
	}
    public StateProvinceModel(String _ID,String _Name,String _Available)
    {
        id = _ID;
        name = _Name;
        available = _Available;
    }
}
