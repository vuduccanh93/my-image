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
/// Summary description for OrderStatusDAO
/// </summary>
public class OrderStatusDAO
{
    public static DataTable GetAll()
    {
        return DataUtil.executeStore("sp_OrderStatus_GetAll", null);
    }
}
