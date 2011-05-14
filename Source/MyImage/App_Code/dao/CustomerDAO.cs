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
/// Summary description for CustomeDAO
/// </summary>
public class CustomerDAO
{
    public static DataTable GetAll()
    {
        return DataUtil.executeStore("sp_Customer_GetAll", null);
    }
    public static Boolean Update(CustomerModel _Model)

    {
        SqlParameter[] param = new SqlParameter[10];
        int i = 0;
        param[i] = new SqlParameter("ID", SqlDbType.VarChar);
        param[i++].Value = _Model.ID;
        param[i] = new SqlParameter("Password", SqlDbType.VarChar);
        param[i++].Value = _Model.Password;
        param[i] = new SqlParameter("FName", SqlDbType.VarChar);
        param[i++].Value = _Model.FName;
        param[i] = new SqlParameter("LName", SqlDbType.VarChar);
        param[i++].Value = _Model.LName;
        param[i] = new SqlParameter("Dob", SqlDbType.VarChar);
        param[i++].Value = _Model.Dob;
        param[i] = new SqlParameter("Gender", SqlDbType.Int);
        param[i++].Value = _Model.Gender;
        param[i] = new SqlParameter("PNo", SqlDbType.VarChar);
        param[i++].Value = _Model.PNo;
        param[i] = new SqlParameter("Address", SqlDbType.VarChar);
        param[i++].Value = _Model.Address;
        param[i] = new SqlParameter("Email", SqlDbType.VarChar);
        param[i++].Value = _Model.Email;
        param[i] = new SqlParameter("Status", SqlDbType.Int);
        param[i++].Value = _Model.StatusId;
        return DataUtil.executeNonStore("sp_Customer_Update", param);
    }
    public static Boolean Insert(CustomerModel _Model)
    {
        SqlParameter[] param = new SqlParameter[9];
        int i = 0;
        param[i] = new SqlParameter("Username", SqlDbType.VarChar);
        param[i++].Value = _Model.Username;
        param[i] = new SqlParameter("Password", SqlDbType.VarChar);
        param[i++].Value = _Model.Password;
        param[i] = new SqlParameter("Email", SqlDbType.VarChar);
        param[i++].Value = _Model.Email;
        param[i] = new SqlParameter("FName", SqlDbType.VarChar);
        param[i++].Value = _Model.FName;
        param[i] = new SqlParameter("LName", SqlDbType.VarChar);
        param[i++].Value = _Model.LName;
        param[i] = new SqlParameter("Dob", SqlDbType.VarChar);
        param[i++].Value = "";
        param[i] = new SqlParameter("Gender", SqlDbType.VarChar);
        param[i++].Value = _Model.Gender;
        param[i] = new SqlParameter("PNo", SqlDbType.VarChar);
        param[i++].Value = _Model.PNo;
        param[i] = new SqlParameter("Address", SqlDbType.VarChar);
        param[i++].Value = _Model.Address;
        return DataUtil.executeNonStore("sp_Customer_Insert", param);
    }
    public static String GetUsername()
    {
        SqlParameter[] param = new SqlParameter[1];
        param[0] = new SqlParameter("@Username", SqlDbType.VarChar,40);
        param[0].Direction = ParameterDirection.Output;
        DataUtil.executeStore("sp_Customer_GetUsername", param);
        return param[0].Value.ToString();
    }
    public static String GetPassword()
    {
        SqlParameter[] param = new SqlParameter[1];
        param[0] = new SqlParameter("Password", SqlDbType.VarChar,10);
        param[0].Direction = ParameterDirection.Output;
        DataUtil.executeStore("sp_Customer_GetPassword", param);
        return param[0].Value.ToString();
    }
    public static CustomerModel GetByU_P(String _U, String _P)
    {
        CustomerModel _Model = null;
        DataTable _Rs = null;
        try
        {
            SqlParameter[] param = new SqlParameter[2];
            int i = 0;

            param[i] = new SqlParameter("U", SqlDbType.VarChar);
            param[i++].Value = _U;
            param[i] = new SqlParameter("P", SqlDbType.VarChar);
            param[i++].Value = _P;
            _Rs = DataUtil.executeStore("sp_Customers_GetByU_P", param);
            if (_Rs != null)
            {
                foreach (DataRow row in _Rs.Rows)
                {
                    _Model = new CustomerModel();
                    _Model.ID = row["Id"].ToString();
                    _Model.Username = row["Username"].ToString();
                    _Model.Password = row["Password"].ToString();
                    _Model.FName = row["F_name"].ToString();
                    _Model.LName = row["L_name"].ToString();
                    _Model.Gender = row["Gender"].ToString();
                    _Model.Dob = row["Dob"].ToString();
                    _Model.PNo = row["P_no"].ToString();
                    _Model.Email = row["Email"].ToString();
                    _Model.Address = row["Address"].ToString();
                    _Model.Status = row["Status_id"].ToString();
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
