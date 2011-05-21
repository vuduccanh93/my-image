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
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void FileExists(String _Path)
    {
        if (!Directory.Exists(_Path)) Directory.CreateDirectory(_Path);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpFileCollection uploadFilCol = Request.Files;

        for (int i = 0; i < uploadFilCol.Count; i++)
        {

            HttpPostedFile file = uploadFilCol[i];

            if (file.ContentLength > 250) return;

            string fileExt = Path.GetExtension(file.FileName).ToLower();
            string fileName = Path.GetFileName(file.FileName);
            string UserName = (String)Session["cusname"];
            string path = Server.MapPath("~/Upload/"+UserName);
             String datetime = UtilDAO.GetDateTime();
             if (fileName != string.Empty)
             {
                 FileExists(path);

                 FileExists(path + @"/" + datetime);
                     try
                     {
                         if (fileExt == ".jpg" || fileExt == ".jpeg")
                         {
                             file.SaveAs(path + @"/" + datetime + @"/" + i + fileExt);
                             if (i == 0)
                             {
                                 Image1.ImageUrl = path + @"/" + datetime + i + fileExt;
                             }
                         }

                     }
                     catch (Exception ex)
                     {
                         throw ex;
                     }
                 //}
                 //else
                 //{
                 //    Directory.CreateDirectory(path + "\\" + datetime);
                 //    try
                 //    {
                 //        if (fileExt == ".jpg" || fileExt == ".jpeg")
                 //        {
                 //            file.SaveAs(path + "\\" + datetime + UserName + i + fileExt);
                 //            if (i == 0)
                 //            {
                 //                Image1.ImageUrl = path + "\\" + datetime + UserName + i + fileExt;
                 //            }
                 //        }

                 //    }
                 //    catch (Exception ex)
                 //    {
                 //        throw ex;
                 //    }
                 //}
                 ///////

                 //}
                 //else
                 //{
                 //    Directory.CreateDirectory(path);
                 //    /// create folder name and datetime 
                 //    if (Directory.Exists(path + "\\"+datetime))
                 //    {
                 //        try
                 //        {
                 //            if (fileExt == ".jpg" || fileExt == ".jpeg")
                 //            {
                 //                file.SaveAs(path + "\\" + datetime + UserName + i + fileExt);
                 //                if (i == 0)
                 //                {
                 //                    Image1.ImageUrl = path + "\\" + datetime + UserName + i + fileExt;
                 //                }
                 //            }

                 //        }
                 //        catch (Exception ex)
                 //        {
                 //            throw ex;
                 //        }
                 //    }
                 //    else
                 //    {
                 //        Directory.CreateDirectory(path +"\\" +datetime);
                 //        try
                 //        {
                 //            if (fileExt == ".jpg" || fileExt == ".jpeg")
                 //            {
                 //                file.SaveAs(path + "\\" + datetime + UserName + i + fileExt);
                 //                if (i == 0)
                 //                {
                 //                    Image1.ImageUrl = path + "\\" + datetime + UserName + i + fileExt;
                 //                }
                 //            }

                 //        }
                 //        catch (Exception ex)
                 //        {
                 //            throw ex;
                 //        }
                 //    }
                 //    ///////


                 //}
             }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Button2.Text == "Add 10 Photo")
        {
            div2.Visible = true;
            Button2.Text = "Add 15 Photo";
        }
        else if (Button2.Text == "Add 15 Photo")
        {
            div3.Visible = true;
            Button2.Text = "Add 20 Photo";
        }
        else if (Button2.Text == "Add 20 Photo")
        {
            div4.Visible = true;
            Button2.Text = "Add 5 Photo";
        }
        else if (Button2.Text == "Add 5 Photo")
        {
            div2.Visible = false;
            div3.Visible = false;
            div4.Visible = false;
            Button2.Text = "Add 10 Photo";
        }
    }

    public void createUserFolder(String Path)
    {
        
    }
}
