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
    public static String Insert(OrderModel model)
    {
        SqlParameter[] param = new SqlParameter[13];
        int i = 0;
        param[i] = new SqlParameter("@No", SqlDbType.VarChar);
        param[i++].Value = model.NO;
        param[i] = new SqlParameter("@Content", SqlDbType.VarChar);
        param[i++].Value = model.Content;
        param[i] = new SqlParameter("@Address", SqlDbType.VarChar);
        param[i++].Value = model.Address;
        param[i] = new SqlParameter("@S_provinces_id", SqlDbType.VarChar);
        param[i++].Value = model.SProvinceId;
        param[i] = new SqlParameter("@Shipping_price", SqlDbType.VarChar);
        param[i++].Value = model.SPrice;
        param[i] = new SqlParameter("@Printing_price", SqlDbType.VarChar);
        param[i++].Value = model.PPrice;
        param[i] = new SqlParameter("@Amount", SqlDbType.VarChar);
        param[i++].Value = model.Amount;
        param[i] = new SqlParameter("@P_methods_id", SqlDbType.VarChar);
        param[i++].Value = model.PMethodId;
        param[i] = new SqlParameter("@C_cards_id", SqlDbType.VarChar);
        param[i++].Value = model.CCardId;
        param[i] = new SqlParameter("@C_id", SqlDbType.VarChar);
        param[i++].Value = model.CustomerId;
        param[i] = new SqlParameter("@Status_id", SqlDbType.VarChar);
        param[i++].Value = model.StatusId;
        param[i] = new SqlParameter("@Created_date", SqlDbType.VarChar);
        param[i++].Value = model.CreatedDate;
        param[i] = new SqlParameter("@Output", SqlDbType.Int, 10);
        param[i].Direction = ParameterDirection.Output;
        DataUtil.executeNonStore("sp_Order_Insert", param);
        return param[i].Value.ToString();
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
                    _Model = new OrderModel();
                    _Model.ID = row["ID"].ToString();
                    _Model.NO = row["No"].ToString();
                    _Model.Content = row["Content"].ToString();
                    _Model.Address = row["Address"].ToString();
                    _Model.SProvinceId = row["S_provinces_id"].ToString();
                    _Model.SProvince = row["S_provinces_name"].ToString();
                    _Model.SPrice = row["Shipping_price"].ToString();
                    _Model.PPrice = row["Printing_price"].ToString();
                    _Model.Amount = row["Amount"].ToString();
                    _Model.PMethodId = row["P_methods_id"].ToString();
                    _Model.PMethod = row["P_methods_name"].ToString();
                    _Model.CCardId = row["C_cards_id"].ToString();
                    _Model.CCard = row["C_cards_number"].ToString();
                    _Model.CustomerId = row["Customer_id"].ToString();
                    _Model.CustomerId = row["Customer_name"].ToString();
                    _Model.StatusId = row["Status_id"].ToString();
                    _Model.Status = row["Status_name"].ToString();
                    _Model.CreatedDate = row["Created_date"].ToString();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        return _Model;
    }
    public static DataTable Status_GetAll()
    {
        return DataUtil.executeStore("sp_Order_Status_GetAll", null);
    }
    public static DataTable Statistic_GetByFromTo(String _Opt,String _From,String _To)
    {
        SqlParameter[] param = new SqlParameter[3];
        int i = 0;
        param[i] = new SqlParameter("@Opt", SqlDbType.Int);
        param[i++].Value = _Opt;
        param[i] = new SqlParameter("@From", SqlDbType.VarChar);
        param[i++].Value = _From;
        param[i] = new SqlParameter("@To", SqlDbType.VarChar);
        param[i++].Value = _To;
        return DataUtil.executeStore("sp_Order_Statistic_GetByFromTo", param);
    }
}
