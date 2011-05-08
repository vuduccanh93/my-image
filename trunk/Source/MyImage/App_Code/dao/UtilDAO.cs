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
/// Summary description for UtilDAO
/// </summary>
public class UtilDAO
{
    public static String OrderStatusFormat(String _Status)
    {
        String _Rs = "";
        SqlParameter[] param = new SqlParameter[2];
        int i = 0;
        param[i] = new SqlParameter("@Status", SqlDbType.Int);
        param[i++].Value = _Status;
        param[i] = new SqlParameter("@Output", SqlDbType.VarChar,15);
        param[i].Direction = ParameterDirection.Output;
        DataUtil.executeNonStore("sp_Util_OrderStatusFormat", param);
        _Rs = param[i].Value.ToString();
        return _Rs;
    }
}
