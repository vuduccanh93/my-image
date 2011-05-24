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
/// Summary description for UploadDAO
/// </summary>
public class UploadDAO
{
	public static String Insert(UploadModel model)
	{
        SqlParameter[] param = new SqlParameter[4];
        int i = 0;
        param[i] = new SqlParameter("@Folder", SqlDbType.VarChar);
        param[i++].Value = model.Folder;
        param[i] = new SqlParameter("@Uploaded", SqlDbType.VarChar);
        param[i++].Value = 0;
        param[i] = new SqlParameter("@Created_date", SqlDbType.VarChar);
        param[i++].Value = model.Created_Date;
        param[i] = new SqlParameter("@Output", SqlDbType.Int,10);
        param[i].Direction = ParameterDirection.Output;
        DataUtil.executeNonStore("sp_Upload_Insert", param);
        return param[i].Value.ToString();
	}
    public static DataTable getImageByUId(String id)
    {
        SqlParameter[] param = new SqlParameter[1];
        int i = 0;
        param[i] = new SqlParameter("@U_id", SqlDbType.VarChar);
        param[i++].Value = id;
        return DataUtil.executeStore("sp_Upload_GetImageByUId", param);
    }
}
