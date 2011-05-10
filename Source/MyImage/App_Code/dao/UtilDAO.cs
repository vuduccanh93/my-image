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
    public static String DateTimeFormat(String _DateTime, String _Format)
    {
        SqlParameter[] param = new SqlParameter[3];
        int i = 0;
        param[i] = new SqlParameter("@Input", SqlDbType.VarChar);
        param[i++].Value = _DateTime;
        param[i] = new SqlParameter("@Format", SqlDbType.VarChar);
        param[i++].Value = _Format;
        param[i] = new SqlParameter("@Output", SqlDbType.VarChar, 19);
        param[i].Direction = ParameterDirection.Output;
        DataUtil.executeNonStore("sp_Util_DateTimeFormat", param);
        return param[i].Value.ToString();
    }
}
