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
/// Summary description for MD5
/// </summary>
public class MD5
{
	public static byte[] encrypt(string _D)
    {
        System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
        System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
        return md5Hasher.ComputeHash(encoder.GetBytes(_D));
    }
}
