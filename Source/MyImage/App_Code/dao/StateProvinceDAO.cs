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
/// Summary description for StateProvinceDAO
/// </summary>
public class StateProvinceDAO
{
    public static DataTable GetAll()
    {
        return DataUtil.executeStore("sp_StateProvince_GetAll", null);
    }
    public static DataTable GetAllAvalable()
    {
        return DataUtil.executeStore("sp_StateProvince_GetAllAvalable", null);
    }
    public static Boolean Update(StateProvinceModel _Model)
    {
        SqlParameter[] param = new SqlParameter[3];
        int i = 0;
        param[i] = new SqlParameter("@Id", SqlDbType.Int);
        param[i++].Value = _Model.ID;
        param[i] = new SqlParameter("@Name", SqlDbType.VarChar);
        param[i++].Value = _Model.Name;
        param[i] = new SqlParameter("@Available", SqlDbType.Int);
        param[i++].Value = _Model.Available;

        return DataUtil.executeNonStore("sp_StateProvince_Update", param);
    }
    public static int IsAvailable(StateProvinceModel _Model)
    {
        SqlParameter[] param = new SqlParameter[2];
        int i = 0;
        param[i] = new SqlParameter("@Id", SqlDbType.Int);
        param[i++].Value = _Model.ID.Equals("") ? "-1" : _Model.ID;
        param[i] = new SqlParameter("@Name", SqlDbType.VarChar);
        param[i++].Value = _Model.Name;
        return DataUtil.executeStore("sp_StateProvince_IsAvailable", param).Rows.Count;
    }
    public static Boolean Insert(StateProvinceModel _Model)
    {
        SqlParameter[] param = new SqlParameter[2];
        int i = 0;
        param[i] = new SqlParameter("@Name", SqlDbType.VarChar);
        param[i++].Value = _Model.Name;
        param[i] = new SqlParameter("@Available", SqlDbType.Int);
        param[i++].Value = _Model.Available;

        return DataUtil.executeNonStore("sp_StateProvince_Insert", param);
    }
}
