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
/// Summary description for AccountDAO
/// </summary>
public class MemberDAO
{
    public static DataTable GetWithOutId(String _Id)
    {
        SqlParameter[] param = new SqlParameter[1];
        int i = 0;
        param[i] = new SqlParameter("@Id", SqlDbType.VarChar);
        param[i++].Value = _Id;
        return DataUtil.executeStore("sp_Members_GetWithOutId", param);
    }
    public static MemberModel GetByU_P(String _U, String _P)
    {

        MemberModel _Model = null;
        DataTable _Rs = null;
        try

        {
            SqlParameter[] param = new SqlParameter[2];
            int i = 0;

            param[i] = new SqlParameter("U", SqlDbType.VarChar);
            param[i++].Value = _U;
            param[i] = new SqlParameter("P", SqlDbType.VarChar);
            param[i++].Value = _P;
            _Rs = DataUtil.executeStore("sp_Members_GetByU_P", param);
            if (_Rs != null)
            {
                foreach (DataRow row in _Rs.Rows)
                {
                    _Model = new MemberModel();
                    _Model.ID = row["Id"].ToString();
                    _Model.Username = row["Username"].ToString();
                    _Model.Password = row["Password"].ToString();
                    _Model.Rid = row["R_id"].ToString();
                    _Model.Status = row["Status_id"].ToString();
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        return _Model;
    }
    public static Boolean Update(MemberModel _Model)
    {
        SqlParameter[] param = new SqlParameter[5];
        int i = 0;
        param[i] = new SqlParameter("@ID", SqlDbType.Int);
        param[i++].Value = _Model.ID;
        param[i] = new SqlParameter("@Username", SqlDbType.VarChar);
        param[i++].Value = _Model.Username;
        param[i] = new SqlParameter("@Password", SqlDbType.VarChar);
        param[i++].Value = _Model.Password;
        param[i] = new SqlParameter("@RId", SqlDbType.Int);
        param[i++].Value = _Model.Rid;
        param[i] = new SqlParameter("@StatusId", SqlDbType.Int);
        param[i++].Value = _Model.StatusId;
        return DataUtil.executeNonStore("sp_Member_Update", param);
    }
    public static Boolean ChangePassword(String Id,String password )
    {
        SqlParameter[] param = new SqlParameter[2];
        int i = 0;
        param[i] = new SqlParameter("@ID", SqlDbType.Int);
        param[i++].Value = Id;
        param[i] = new SqlParameter("@Password", SqlDbType.VarChar);
        param[i++].Value = password;
        return DataUtil.executeNonStore("sp_Member_ChangePassword", param);
    }
}
