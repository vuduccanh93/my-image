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
public class PrintingPricesDAO
{
	public static DataTable GetAll()
    {
        return DataUtil.executeStore("sp_PrintingPrices_GetAll", null);
    }

    public static Boolean Update(PrintingPricesModel _Model)
    {
        SqlParameter[] param = new SqlParameter[2];
        int i = 0;        
        param[i] = new SqlParameter("@Size", SqlDbType.VarChar);
        param[i++].Value = _Model.Size;
        param[i] = new SqlParameter("@Price", SqlDbType.VarChar);
        param[i++].Value = _Model.Price;

        return DataUtil.executeNonStore("sp_PrintingPrices_Update", param);
    }
    
    public static Boolean Insert(PrintingPricesModel _Model)
    {
        SqlParameter[] param = new SqlParameter[2];
        int i = 0;
        param[i] = new SqlParameter("@Size", SqlDbType.VarChar);
        param[i++].Value = _Model.Size;
        param[i] = new SqlParameter("@Price", SqlDbType.VarChar);
        param[i++].Value = _Model.Price;

        return DataUtil.executeNonStore("PrintingPrices_Insert", param);
    }
}
