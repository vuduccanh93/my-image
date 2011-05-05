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
            _Rs = DataUtil.executeStore("sp_Account_GetByU_P", param);
            if (_Rs != null)
            {
                foreach (DataRow row in _Rs.Rows)
                {
                    _Model = new MemberModel();
                    _Model.ID = row["Id"].ToString();
                    _Model.Username = row["Username"].ToString();
                    _Model.Password = row["Password"].ToString();
                    _Model.Rid = row["R_id"].ToString();
                    _Model.Status = row["Status"].ToString();
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        return _Model;
    }
}
