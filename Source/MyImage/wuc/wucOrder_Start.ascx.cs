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
using System.IO;

public partial class wuc_wucOrder_Start : System.Web.UI.UserControl
{
    UploadModel ULModel;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect(@"~");
            return;
        }
    }
    protected void FileExists(String _Path)
    {
        if (!Directory.Exists(_Path)) Directory.CreateDirectory(_Path);
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        ULModel = new UploadModel();
        string SavePath = "";
        string Username = ((CustomerModel)Session["user"]).Username;
        ULModel.Created_Date = UtilDAO.GetDateTime();
        if (!String.IsNullOrEmpty(ULModel.Created_Date))
        {
            SavePath = Server.MapPath("~/Upload/" + Username + @"/" + ULModel.Created_Date + @"/");
            ULModel.Folder = "~/Upload/" + Username + @"/" + ULModel.Created_Date + @"/";
            ULModel.Uploaded = "0";
            ULModel.ID = UploadDAO.Insert(ULModel);
            FileExists(SavePath);
            Session["order_start"] = 1;
            Session["upload_savepath"] = SavePath;
            Session["upload_uploadmodel"] = ULModel;
            Response.Redirect("Default.aspx?t=order&start=true");
            return;
        }
    }
}
