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
    /**
     * insert a new one
     * 
     * */
    public static Boolean Insert(UploadDetailModel model)
    {
        SqlParameter[] param = new SqlParameter[2];
        int i = 0;
        param[i] = new SqlParameter("@U_id", SqlDbType.Int);
        param[i++].Value = model.U_id;
        param[i] = new SqlParameter("@Img", SqlDbType.VarChar);
        param[i++].Value = model.Img;
        return DataUtil.executeNonStore("sp_UploadDetail_Insert", param);
    }
    /**
     * get by upload id
     * 
     * */
    public static DataTable GetByUploadId(String UploadId)
    {
        DataTable _Rs = null;
        SqlParameter[] param = new SqlParameter[1];
        int i = 0;
        param[i] = new SqlParameter("@UploadId", SqlDbType.Int);
        param[i++].Value = UploadId;
        try
        {
            _Rs = DataUtil.executeStore("sp_UploadDetails_GetByUploadId", param);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        return _Rs;
    }
    /**
     * get by id
     * 
     * */
    public static UploadDetailModel GetById(String Id)
    {
        UploadDetailModel _Model = new UploadDetailModel();
        SqlParameter[] param = new SqlParameter[1];
        int i = 0;
        param[i] = new SqlParameter("@Id", SqlDbType.Int);
        param[i++].Value = Id;
        DataTable dt = DataUtil.executeStore("sp_UploadDetail_GetById", param);
        if (dt != null && dt.Rows.Count > 0)
        {
            foreach(DataRow _Dr in dt.Rows ){
            _Model.ID = _Dr["ID"].ToString();
            _Model.Img = _Dr["Image"].ToString();
            _Model.U_id = _Dr["U_id"].ToString();
            }
        }
        return _Model;
    }
    /**
     * delete from database by id
     * 
     * */
    public static Boolean DeleteById(UploadDetailModel _Model)
    {
        SqlParameter[] param = new SqlParameter[1];
        int i = 0;
        param[i] = new SqlParameter("@ID", SqlDbType.Int);
        param[i++].Value = _Model.ID;
        return DataUtil.executeNonStore("sp_UploadDetail_DeleteById", param);
    }
}
