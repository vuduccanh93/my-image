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
        if (!Page.IsPostBack)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("?");
            }
            if (Session["order_start"] == null || !Session["order_start"].ToString().Equals("1"))
            {
                Response.Redirect("Default.aspx?t=order");
                return;
            }
            else
            {
                Session["order_start"] = null;
            }
        }
        loadImage();
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

        string[] fileExtensions = { ".JPG", ".JPEG" };

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
            msg = msg + "File size is too large.Please try again!";
        }
        //Check File Type is Valid or Not.
        if (!IsValidFile(myFile.FileName))
        {
            msg = msg + "Invalid file fype.";
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
            //lblMsgInf.Text = "Uploaded:" + MsgInf ;
            //lblMsgErr.Text = "Failed:" + MsgErr;
            loadImage();
            enableNext();
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

    private void loadImage()
    {
        UploadModel ULModel = ((UploadModel)Session["upload_uploadmodel"]);
        DataTable _Dt = UploadDAO.getImageByUId(ULModel.ID);
        if (_Dt.Rows.Count > 0)
        {
            grvImages.DataSource = _Dt;
            grvImages.DataBind();
        }
        else
        {
            grvImages.DataSource = _Dt;
            grvImages.DataBind();
            lblInfo.Text = "";
        }
    }
    protected void grvImages_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "RemoveImg":
                int _Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow _Row = grvImages.Rows[_Index];

                UploadDetailModel _Model = new UploadDetailModel();
                _Model = UploadDetailDAO.GetById(((Label)_Row.FindControl("lblID")).Text);
                if (!String.IsNullOrEmpty(_Model.ID))
                {
                    try
                    {
                        String _Path = MapPath("~") + _Model.Img.Replace("~", "").Replace("/", "\\");
                        FileInfo _File = new FileInfo(_Path);
                        if (_File.Exists)
                        {
                            if (UploadDetailDAO.DeleteById(_Model))
                                File.Delete(_Path);
                        }
                    }
                    catch (FileNotFoundException fnfe)
                    {
                        Console.WriteLine(fnfe.StackTrace);
                        lblInfo.Text = "Could not delete img, please try again!";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        lblInfo.Text = "Could not delete img, please try again!";
                    }
                }
                loadImage();
                enableNext();
                break;
        }
    }
    protected void enableNext()
    {
        UploadModel ULModel = ((UploadModel)Session["upload_uploadmodel"]);
        DataTable _Dt = UploadDAO.getImageByUId(ULModel.ID);
        if (_Dt.Rows.Count > 0)
        {
            mbtNext.Enabled = true;
        }
        else
        {
            mbtNext.Enabled = false;
        }
    }
    protected void mbtNext_Click(object sender, EventArgs e)
    {
        Session["order_upload"] = 1;
        Response.Redirect("Default.aspx?t=order&start=true&upload=true");
        return;
    }
}
