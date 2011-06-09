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
/// Summary description for MenuDAO
/// </summary>
public class MenuDAO
{
    /**
     * Get menu item by role id
     * */
	public static DataTable GetByRoleId(String _Rid){
        DataTable _Rs = null;
        try
        {
            SqlParameter[] param = new SqlParameter[1];
            int i = 0;

            param[i] = new SqlParameter("Rid", SqlDbType.Int);
            param[i++].Value = _Rid;
            _Rs = DataUtil.executeStore("sp_Menu_GetByRoleId", param);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        return _Rs;
    }
}
