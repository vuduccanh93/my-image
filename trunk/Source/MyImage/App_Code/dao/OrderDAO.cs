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
/// Summary description for OrderDAO
/// </summary>
public class OrderDAO
{
    public static DataTable GetAll()
    {
        return DataUtil.executeStore("sp_Order_GetAll", null);
    }
    public static DataTable GetByCusId(String _CusId)
    {
        SqlParameter[] param = new SqlParameter[1];
            int i = 0;
            param[i] = new SqlParameter("@CusId", SqlDbType.Int);
            param[i++].Value = _CusId;
            return DataUtil.executeStore("sp_Order_GetByCusId", param);
    }
    public static Boolean UpdateStatus(String _Id,String _Status)
    {
        SqlParameter[] param = new SqlParameter[2];
        int i = 0;
        param[i] = new SqlParameter("@ID", SqlDbType.Int);
        param[i++].Value = _Id;
        param[i] = new SqlParameter("@Status", SqlDbType.Int);
        param[i++].Value = _Status;
        return DataUtil.executeNonStore("sp_Order_UpdateStatus", param);
    }
    public static OrderModel GetById(String _Id)
    {
        OrderModel _Model = null;
        DataTable _Rs = null;
        try
        {
            SqlParameter[] param = new SqlParameter[1];
            int i = 0;
            param[i] = new SqlParameter("@ID", SqlDbType.Int);
            param[i++].Value = _Id;
            _Rs = DataUtil.executeStore("sp_Order_GetById", param);
            if (_Rs != null)
            {
                foreach (DataRow row in _Rs.Rows)
                {
                    _Model = new OrderModel(row["ID"].ToString(),
                                        row["No"].ToString(),
                                        row["Order_content"].ToString(),
                                        row["Address"].ToString(),
                                        row["S_provinces_id"].ToString(),
                                        row["S_provinces_name"].ToString(),
                                        row["Shipping_price"].ToString(),
                                        row["Printing_price"].ToString(),
                                        row["Amount"].ToString(),
                                        row["P_methods_id"].ToString(),
                                        row["P_methods_name"].ToString(),
                                        row["C_cards_id"].ToString(),
                                        row["C_cards_number"].ToString(),
                                        row["Customer_id"].ToString(),
                                        row["Customer_name"].ToString(),
                                        row["Status_id"].ToString(),
                                        row["Status_name"].ToString(),
                                        row["Created_date"].ToString());
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        return _Model;
    }

}