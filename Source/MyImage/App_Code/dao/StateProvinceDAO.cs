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
    /**
     * get all state/provinces (admin page)
     * 
     * */
    public static DataTable GetAll()
    {
        return DataUtil.executeStore("sp_StateProvince_GetAll", null);
    }
    /**
     * get available state/province (customer page)
     * 
     * */
    public static DataTable GetAllAvalable()
    {
        return DataUtil.executeStore("sp_StateProvince_GetAllAvalable", null);
    }
    /**
     * update by id
     * 
     * */
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
    /**
     * check avalable state/province's name
     * 
     * */
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
    /**
     * insert new
     * 
     * */
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
