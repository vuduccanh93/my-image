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
/// Summary description for OrderModel
/// </summary>
public class OrderModel
{
    private String id;
    private String no;
    private String content;
    private String address;
    private String sProvinceId;
    private String sPrice;
    private String pPrice;
    private String amount;
    private String pMethodId;
    private String cCardId;
    private String customerId;
    private String status;
    private String createdDate;

    public String ID
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public String NO
    {
        get { return this.no; }
        set { this.no = value; }
    }
    public String Content
    {
        get { return this.content; }
        set { this.content = value; }
    }
    public String Address
    {
        get { return this.address; }
        set { this.address = value; }
    }
    public String SProvinceId
    {
        get { return this.sProvinceId; }
        set { this.sProvinceId = value; }
    }
    public String SPrice
    {
        get { return this.sPrice; }
        set { this.sPrice = value; }
    }
    public String PPrice
    {
        get { return this.pPrice; }
        set { this.pPrice = value; }
    }
    public String Amount
    {
        get { return this.amount; }
        set { this.amount = value; }
    }
    public String PMethodId
    {
        get { return this.pMethodId; }
        set { this.pMethodId = value; }
    }
    public String CCardId
    {
        get { return this.cCardId; }
        set { this.cCardId = value; }
    }
    public String CustomerId
    {
        get { return this.customerId; }
        set { this.customerId = value; }
    }
    public String Status
    {
        get { return this.status; }
        set { this.status = value; }
    }
    public String CreatedDate
    {
        get { return this.createdDate; }
        set { this.createdDate = value; }
    }

    public OrderModel()
    {
        id = "";
        no = "";
        content = "";
        address = "";
        sProvinceId = "";
        sPrice = "";
        pPrice = "";
        amount = "";
        pMethodId = "";
        cCardId = "";
        customerId = "";
        status = "";
        createdDate = "";
    }
    public OrderModel(String _Id, String _No,
                        String _Content, String _Address,
                        String _SProvince, String _SPrice,
                        String _PPrice, String _Amount,
                        String _PMethodId, String _CCardId,
                        String _CustomerId, String _Status,
                        String _CreatedDate)
    {
        id = _Id;
        no = _No;
        content = _Content;
        address = _Address;
        sProvinceId = _SProvince;
        sPrice = _SPrice;
        pPrice = _PPrice;
        amount = _Amount;
        pMethodId = _PMethodId;
        cCardId = _CCardId;
        customerId = _CustomerId;
        status = _Status;
        createdDate = _CreatedDate;
    }
}
