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
/// Summary description for PrintingPricesDAO
/// </summary>
public class PrintingPriceDAO
{
	public static DataTable GetAll()
    {
        return DataUtil.executeStore("sp_PrintingPrice_GetAll", null);
    }

    public static Boolean Update(PrintingPriceModel _Model)
    {
        SqlParameter[] param = new SqlParameter[3];
        int i = 0;
        param[i] = new SqlParameter("@Id", SqlDbType.Int);
        param[i++].Value = _Model.ID;
        param[i] = new SqlParameter("@Size", SqlDbType.VarChar);
        param[i++].Value = _Model.Size;
        param[i] = new SqlParameter("@Price", SqlDbType.Float);
        param[i++].Value = _Model.Price;

        return DataUtil.executeNonStore("sp_PrintingPrice_Update", param);
    }
    
    public static Boolean Insert(PrintingPriceModel _Model)
    {
        SqlParameter[] param = new SqlParameter[2];
        int i = 0;
        param[i] = new SqlParameter("@Size", SqlDbType.VarChar);
        param[i++].Value = _Model.Size;
        param[i] = new SqlParameter("@Price", SqlDbType.Float);
        param[i++].Value =_Model.Price;

        return DataUtil.executeNonStore("sp_PrintingPrice_Insert", param);
    }
    
}
