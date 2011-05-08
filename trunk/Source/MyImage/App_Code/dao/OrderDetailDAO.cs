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
/// Summary description for OrderDetailDAO
/// </summary>
public class OrderDetailDAO
{
	public static DataTable GetByOrderId(String _OId)
	{
        DataTable _Rs = null;
        try
        {
            SqlParameter[] param = new SqlParameter[1];
            int i = 0;
            param[i] = new SqlParameter("@OId", SqlDbType.Int);
            param[i++].Value = _OId;
            _Rs = DataUtil.executeStore("sp_OrderDetail_GetByOrderId", param);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        return _Rs;
	}
}
