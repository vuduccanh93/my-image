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
/// Summary description for CreditCardDAO
/// </summary>
public class CreditCardDAO
{
    public static String Insert(CreditCardModel model)
    {
        SqlParameter[] param = new SqlParameter[5];
        int i = 0;
        param[i] = new SqlParameter("@Number", SqlDbType.VarChar);
        param[i++].Value = model.Number;
        param[i] = new SqlParameter("@Exp_date", SqlDbType.VarChar);
        param[i++].Value = model.Exp_date;
        param[i] = new SqlParameter("@Holder_name", SqlDbType.VarChar);
        param[i++].Value = model.Holder_name;
        param[i] = new SqlParameter("@L_three_letter", SqlDbType.VarChar);
        param[i++].Value = model.L_three_letter;
        param[i] = new SqlParameter("@Output", SqlDbType.Int, 10);
        param[i].Direction = ParameterDirection.Output;
        DataUtil.executeNonStore("sp_CreditCard_Insert", param);
        return param[i].Value.ToString();
    }
}
