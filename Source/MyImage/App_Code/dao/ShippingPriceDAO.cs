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
/// Summary description for ShippingPriceDAO
/// </summary>
public class ShippingPriceDAO
{
    public static DataTable GetAll()
    {
        return DataUtil.executeStore("sp_ShippingPrice_GetAll", null);
    }
    public static Boolean Insert(ShippingPriceModel _Model)
    {
        SqlParameter[] param = new SqlParameter[3];
        int i = 0;
        param[i] = new SqlParameter("@SProvinceId", SqlDbType.Int);
        param[i++].Value = _Model.SProvinceId;
        param[i] = new SqlParameter("@ShippingTime", SqlDbType.VarChar);
        param[i++].Value = _Model.ShippingTime;
        param[i] = new SqlParameter("@Price", SqlDbType.Float);
        param[i++].Value = _Model.Price;
        return DataUtil.executeNonStore("sp_ShippingPrice_Insert", param);
    }
    public static Boolean Update(ShippingPriceModel _Model)
    {
        SqlParameter[] param = new SqlParameter[4];
        int i = 0;
        param[i] = new SqlParameter("@Id", SqlDbType.Int);
        param[i++].Value = _Model.ID;
        param[i] = new SqlParameter("@SProvinceId", SqlDbType.Int);
        param[i++].Value = _Model.SProvinceId;
        param[i] = new SqlParameter("@ShippingTime", SqlDbType.VarChar);
        param[i++].Value = _Model.ShippingTime;
        param[i] = new SqlParameter("@Price", SqlDbType.Float);
        param[i++].Value = _Model.Price;
        return DataUtil.executeNonStore("sp_ShippingPrice_Update", param);
    }
    public static DataTable GetAllBySPI(String s_Providers_id_)
    {
        SqlParameter[] param = new SqlParameter[1];
        int i = 0;
        param[i] = new SqlParameter("@s_Providers_id", SqlDbType.Int);
        param[i++].Value = s_Providers_id_;
        return DataUtil.executeStore("sp_ShippingPrices_GetAllBySPI", param);
    }
}
