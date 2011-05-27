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
using System.Collections;
using System.Collections.Generic;

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
    public static Boolean Insert(OrderDetailModel model)
    {
        SqlParameter[] param = new SqlParameter[6];
        int i = 0;
        param[i] = new SqlParameter("@O_id", SqlDbType.VarChar);
        param[i++].Value = model.OrderId;
        param[i] = new SqlParameter("@U_details_id", SqlDbType.VarChar);
        param[i++].Value = model.UploadDetailId;
        param[i] = new SqlParameter("@Price", SqlDbType.VarChar);
        param[i++].Value = model.Price;
        param[i] = new SqlParameter("@Size", SqlDbType.VarChar);
        param[i++].Value = model.Size;
        param[i] = new SqlParameter("@Quantity", SqlDbType.VarChar);
        param[i++].Value = model.Quantity;
        param[i] = new SqlParameter("@Amount", SqlDbType.VarChar);
        param[i++].Value = model.Amount;
        return DataUtil.executeNonStore("sp_OrderDetails_Insert", param);
    }
    public static Boolean MultiInsert(List<OrderDetailModel> _List)
    {
        bool _Rs = false;
        List<QueryModel> _ListQuery = new List<QueryModel>();
        QueryModel _Query;
        SqlParameter[] param;
        int i = 0;
        foreach (OrderDetailModel _Model in _List)
        {
            i = 0;
            param = new SqlParameter[6];
            param[i] = new SqlParameter("@O_id", SqlDbType.VarChar);
            param[i++].Value = _Model.OrderId;
            param[i] = new SqlParameter("@U_details_id", SqlDbType.VarChar);
            param[i++].Value = _Model.UploadDetailId;
            param[i] = new SqlParameter("@Price", SqlDbType.VarChar);
            param[i++].Value = _Model.Price;
            param[i] = new SqlParameter("@Size", SqlDbType.VarChar);
            param[i++].Value = _Model.Size;
            param[i] = new SqlParameter("@Quantity", SqlDbType.VarChar);
            param[i++].Value = _Model.Quantity;
            param[i] = new SqlParameter("@Amount", SqlDbType.VarChar);
            param[i++].Value = _Model.Amount;
            _Query = new QueryModel("sp_OrderDetails_Insert", param);
            _ListQuery.Add(_Query);
        }
        if (_ListQuery.Count > 0)
        {
            _Rs = DataUtil.executeMultiNonStore(_ListQuery);
        }
        return _Rs;
    }
}
