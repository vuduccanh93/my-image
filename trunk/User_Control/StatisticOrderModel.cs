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
/// Summary description for StatisticOrderModel
/// </summary>
public class StatisticOrderModel
{	
    private String no;    
    private String amount;    
    private String createdDate;
        
    public String NO
    {
        get { return this.no; }
        set { this.no = value; }
    }    
    
    public String Amount
    {
        get { return this.amount; }
        set { this.amount = value; }
    }    
    
    public String CreatedDate
    {
        get { return this.createdDate; }
        set { this.createdDate = value; }
    }

    public StatisticOrderModel()
    {        
        this.no = "";        
        this.amount = "";        
        this.createdDate = "";
    }
    public StatisticOrderModel(String _No, String _Amount, String _CreatedDate)
    {        
        this.no = _No;        
        this.amount = _Amount;        
        this.createdDate = _CreatedDate;
    }

}
