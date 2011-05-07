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
/// Summary description for CustomeDAO
/// </summary>
public class CustomerDAO
{
    public static DataTable GetAll()
    {
        return DataUtil.executeStore("sp_Customer_GetAll", null);
    }
    public static DataTable Upsdate(CustomerModel _Model)
    {
        SqlParameter[] param = new SqlParameter[8];
        int i = 0;
        param[i] = new SqlParameter("ID", SqlDbType.VarChar);
        param[i++].Value = _Model.ID;
        param[i] = new SqlParameter("Username", SqlDbType.VarChar);
        param[i++].Value = _Model.Username;
        param[i] = new SqlParameter("FName", SqlDbType.VarChar);
        param[i++].Value = _Model.FName;
        param[i] = new SqlParameter("LName", SqlDbType.VarChar);
        param[i++].Value = _Model.LName;
        param[i] = new SqlParameter("Dob", SqlDbType.VarChar);
        param[i++].Value = _Model.Dob;
        param[i] = new SqlParameter("Gender", SqlDbType.Int);
        param[i++].Value = _Model.Gender;
        param[i] = new SqlParameter("PNo", SqlDbType.VarChar);
        param[i++].Value = _Model.PNo;
        param[i] = new SqlParameter("Address", SqlDbType.VarChar);
        param[i++].Value = _Model.Address;
        return DataUtil.executeStore("sp_Customer_Update", param);
    }
}
