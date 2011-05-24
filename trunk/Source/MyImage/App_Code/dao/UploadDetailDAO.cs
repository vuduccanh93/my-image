using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Upload
/// </summary>
public class UploadDetailDAO
{
    public static Boolean Insert(UploadDetailModel model)
    {
        SqlParameter[] param = new SqlParameter[2];
        int i = 0;
        param[i] = new SqlParameter("@U_id", SqlDbType.VarChar);
        param[i++].Value = model.U_id;
        param[i] = new SqlParameter("@Img", SqlDbType.VarChar);
        param[i++].Value = model.Img;
        return DataUtil.executeNonStore("sp_UploadDetail_Insert", param);
    }
}
