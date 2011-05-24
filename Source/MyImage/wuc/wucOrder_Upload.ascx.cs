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

public partial class wuc_wucUploadImage : System.Web.UI.UserControl
{
    private Boolean flag;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void FileExists(String _Path)
    {
        if (!Directory.Exists(_Path)) Directory.CreateDirectory(_Path);
    }
    protected Boolean ValidUploadFile(HttpFileCollection _Files)
    {
         flag = true;
        for (int i = 0; i < _Files.Count; i++)
        {
            HttpPostedFile file = _Files[i];
            if (file.ContentLength > 0)
            {
                flag = false;
            }

            if (file.ContentLength > (1024 * 1024))
            {
                Label1.Text = "File size is too large";
                return true;
            }
        }
        return false;
    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        HttpFileCollection uploadFilCol = Request.Files;
        if (ValidUploadFile(uploadFilCol))
        {
            return;
        }
        if (flag == true)
        {
            return;
        }
            string UserName = (String)Session["cusname"];
            string path = Server.MapPath("~/Upload/"+UserName);
            FileExists(path);
            String datetime = UtilDAO.GetDateTime();
            FileExists(path + @"/" + datetime);
            UploadModel model = new UploadModel();
            model.Folder = @"/Upload/"+ UserName + @"/" + datetime; 
            Session["uploadid"] =UploadDAO.Insert(model);

        for (int i = 0; i < uploadFilCol.Count; i++)
        {
            HttpPostedFile file = uploadFilCol[i];

            string fileExt = Path.GetExtension(file.FileName).ToLower();
            String fileName = file.FileName;

             
             if (!String.IsNullOrEmpty(fileName))
             {
                     try
                     {
                         if (fileExt == ".jpg" || fileExt == ".jpeg")
                         {
                             try
                             {
                                 file.SaveAs(path + @"/" + datetime + @"/" + Session["uploaded"].ToString() + fileExt);
                                 UploadDetailModel udModel = new UploadDetailModel();
                                 udModel.U_id = (String)Session["uploadid"];
                                 udModel.Img = Session["uploaded"].ToString() + fileExt;
                                 UploadDetailDAO.Insert(udModel);
                                 Session["uploaded"] = (int)Session["uploaded"] + 1;
                                 
                                 
                             }
                             catch (Exception iex)
                             {
                                 throw iex;
                             }
                         }

                     }
                     catch (Exception ex)
                     {
                         throw ex;
                     }         
             }
             
        }
        Response.Redirect("Default.aspx?t=order&start=true&upload=true");

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (btnAdd.Text == "Add 10 Photo")
        {
            div2.Visible = true;
            btnAdd.Text = "Add 5 Photo";
        }
        else if (btnAdd.Text == "Add 5 Photo")
        {
            div2.Visible = false;
            btnAdd.Text = "Add 10 Photo";
        }
    }

}
