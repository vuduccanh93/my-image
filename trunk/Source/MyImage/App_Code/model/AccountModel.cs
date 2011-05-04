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
/// Summary description for AccountModel
/// </summary>
public class AccountModel
{
    private String id;
    private String username;
    private String password;
    private String rid;
    private String status;

    public String ID
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public String Username
    {
        get { return this.username; }
        set { this.username = value; }
    }
    public String Password
    {
        get { return this.password; }
        set { this.password = value; }
    }
    public String Rid
    {
        get { return this.rid; }
        set { this.rid = value; }
    }
    public String Status
    {
        get { return this.status; }
        set { this.status = value; }
    }
    public AccountModel()
	{
        id = "";
        username = "";
        password = "";
        rid = "";
        status = "";
	}
}
