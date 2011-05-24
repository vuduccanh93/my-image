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
/// Summary description for UploadDetailModel
/// </summary>
public class UploadDetailModel
{
	 private String id;
    private String u_id;
    private String img;

    public String ID
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public String U_id
    {
        get { return this.u_id; }
        set { this.u_id = value; }
    }

    public String Img
    {
        get { return this.img; }
        set { this.img = value; }
    }

    public UploadDetailModel()
	{
        id = "";
        u_id = "";
        img = "";
	}
}
