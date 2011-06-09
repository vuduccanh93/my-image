using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for PaymentMethodDAO
/// </summary>
public class PaymentMethodDAO
{
    /**
     * get all payment methods in database
     * 
     * */
    public static DataTable GetAll()
    {
        return DataUtil.executeStore("sp_PaymentMethod_GetAll", null);
    }
}
