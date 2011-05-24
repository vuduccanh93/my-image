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
/// Summary description for UploadModel
/// </summary>
public class UploadModel
{
    private String id;
    private String folder;
    private String uploaded;
    private String created_date;

    public String ID
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public String Folder
    {
        get { return this.folder; }
        set { this.folder = value; }
    }
    public String Uploaded
    {
        get { return this.uploaded; }
        set { this.uploaded = value; }
    }
    public String Created_Date
    {
        get { return this.created_date; }
        set { this.created_date = value; }
    }
	public UploadModel()
	{
        id = "";
        folder = "";
        uploaded = "";
        created_date = "";
	}
}
