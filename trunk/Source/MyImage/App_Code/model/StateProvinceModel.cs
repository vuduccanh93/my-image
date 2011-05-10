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
    public StateProvinceModel()
	{
        id = "";
        name = "";
	}
    public StateProvinceModel(String _ID,String _Name)
    {
        id = _ID;
        name = _Name;
    }
}
