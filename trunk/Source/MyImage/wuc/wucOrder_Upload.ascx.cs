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
using System.Security.Cryptography;
using System.Text;
using System.IO;

public partial class wuc_wucUploadImage : System.Web.UI.UserControl
{
    String SavePath, MsgErr, MsgInf = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect(@"~");
        }
        if (Session["upload_start"] == null || !Session["upload_start"].ToString().Equals("1"))
        {
            Response.Redirect("Default.aspx?t=order");
        }
    }
    private string GetFileExtension(string filePath)
    {
        FileInfo fi = new FileInfo(filePath);
        return fi.Extension;
    }
    private string GetFileName(string filePath)
    {
        FileInfo fi = new FileInfo(filePath);
        return fi.Name;
    }
    private bool IsValidFile(string filePath)
    {
        bool isValid = false;

        string[] fileExtensions = { ".BMP", ".JPG", ".PNG", ".GIF", ".JPEG" };

        for (int i = 0; i < fileExtensions.Length; i++)
        {
            if (filePath.ToUpper().Contains(fileExtensions[i]))
            {
                isValid = true; break;
            }
        }
        return isValid;
    }
    private string ValidateImage(HttpPostedFile myFile)
    {
        string msg = null;
        int FileMaxSize = 1024*1024;
        //int FileMaxSize = Convert.ToInt32(ConfigurationManager.AppSettings["FileUploadSizeLimit"].ToString());
        //Check Length of File is Valid or Not.
        if (myFile.ContentLength > FileMaxSize)
        {
            msg = msg + "File Size is Too Large.";
        }
        //Check File Type is Valid or Not.
        if (!IsValidFile(myFile.FileName))
        {
            msg = msg + "Invalid File Type.";
        }
        return msg;
    }
    private bool ServerSideValidation()
    {
        string errorMsg = string.Empty, temp = null;
        bool errorFlag = true;

        // Get the HttpFileCollection
        HttpFileCollection hfc = Request.Files;
        for (int i = 0; i < hfc.Count; i++)
        {
            HttpPostedFile hpf = hfc[i];
            if (hpf.ContentLength > 0)
            {
                temp = ValidateImage(hpf);
                if (temp != null)
                {
                    errorMsg += GetFileName(hpf.FileName.ToString()) + " has error : " + temp;
                    temp = null;
                }
            }
        }

        if (errorMsg != "")
        {
            lblMsgInf.Text = errorMsg;
            errorFlag = false;
        }
        return errorFlag;
    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (ServerSideValidation() == true)
        {
            SavePath = Session["upload_savepath"].ToString();
            
            HttpFileCollection hfc = Request.Files;
            String FileName;
            UploadDetailModel ULDModel;
            for (int i = 0; i < hfc.Count; i++)
            {
                HttpPostedFile hpf = hfc[i];
                if (hpf.ContentLength > 0)
                {
                    ULDModel = new UploadDetailModel();
                    FileName = GetUniqueKey() + GetFileExtension(hpf.FileName);
                    try
                    {
                        hpf.SaveAs(SavePath + FileName);
                        ULDModel.Img = FileName;
                        ULDModel.U_id = ((UploadModel)Session["upload_uploadmodel"]).ID;
                        UploadDetailDAO.Insert(ULDModel);
                        MsgInf += GetFileName(hpf.FileName.ToString()) + " , ";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        MsgErr += GetFileName(hpf.FileName.ToString()) + " , ";
                    }
                }
            }
            lblMsgInf.Text = MsgInf + " Uploaded Successfully.";
            lblMsgErr.Text = MsgErr + " Failed.";
        }
    }
    private string GetUniqueKey()
    {
        int maxSize = 8;
        char[] chars = new char[62];
        string a;

        a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        chars = a.ToCharArray();

        int size = maxSize;
        byte[] data = new byte[1];

        RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();

        crypto.GetNonZeroBytes(data);
        size = maxSize;
        data = new byte[size];
        crypto.GetNonZeroBytes(data);
        StringBuilder result = new StringBuilder(size);

        foreach (byte b in data)
        {
            result.Append(chars[b % (chars.Length - 1)]);
        }

        return result.ToString();
    }
    //protected boolean validuploadfile(httpfilecollection _files)
    //{
    //    httppostedfile file;
    //    if (_files != null && _files.count == 0)
    //    {
    //        lblerr.text = "choose 1 file at least";
    //        return true;
    //    }
    //    for (int i = 0; i < _files.count; i++)
    //    {
    //        file = _files[i];
    //        if (file.contentlength > (1024 * 1024))
    //        {
    //            lblerr.text = "file size is too large";
    //            return true;
    //        }
    //    }
    //    return false;
    //}
    //protected void btnupload_click(object sender, eventargs e)
    //{
    //    httpfilecollection uploadfilcol = request.files;
    //    if (validuploadfile(uploadfilcol))
    //    {
    //        return;
    //    }
    //    if (validuploadfile(uploadfilcol))
    //    {
    //        return;
    //    }
    //    string username = (string)session["cusname"];
    //    string path = server.mappath("~/upload/" + username);
    //    fileexists(path);
    //    string datetime = utildao.getdatetime();
    //    fileexists(path + @"/" + datetime);
    //    uploadmodel model = new uploadmodel();
    //    model.folder = @"/upload/" + username + @"/" + datetime;
    //    session["uploadid"] = uploaddao.insert(model);

    //    for (int i = 0; i < uploadfilcol.count; i++)
    //    {
    //        httppostedfile file = uploadfilcol[i];

    //        string fileext = path.getextension(file.filename).tolower();
    //        string filename = file.filename;


    //        if (!string.isnullorempty(filename))
    //        {
    //            try
    //            {
    //                if (fileext == ".jpg" || fileext == ".jpeg")
    //                {
    //                    try
    //                    {
    //                        file.saveas(path + @"/" + datetime + @"/" + session["uploaded"].tostring() + fileext);
    //                        uploaddetailmodel udmodel = new uploaddetailmodel();
    //                        udmodel.u_id = (string)session["uploadid"];
    //                        udmodel.img = session["uploaded"].tostring() + fileext;
    //                        uploaddetaildao.insert(udmodel);
    //                        session["uploaded"] = (int)session["uploaded"] + 1;


    //                    }
    //                    catch (exception iex)
    //                    {
    //                        throw iex;
    //                    }
    //                }

    //            }
    //            catch (exception ex)
    //            {
    //                throw ex;
    //            }
    //        }

    //    }
    //    response.redirect("default.aspx?t=order&start=true&upload=true");

    //}
    //protected void btnadd_click(object sender, eventargs e)
    //{
    //    if (btnadd.text == "add 10 photo")
    //    {
    //        div2.visible = true;
    //        btnadd.text = "add 5 photo";
    //    }
    //    else if (btnadd.text == "add 5 photo")
    //    {
    //        div2.visible = false;
    //        btnadd.text = "add 10 photo";
    //    }
    //}

}
