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

    protected void btnNext_Click(object sender, EventArgs e)
    {
        Session["order_upload"] = 1;
        Response.Redirect("Default.aspx?t=order&start=true&upload=true");
        return;
    }
}
