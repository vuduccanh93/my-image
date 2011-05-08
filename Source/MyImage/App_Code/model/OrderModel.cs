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
    private String sProvince;
    private String sPrice;
    private String pPrice;
    private String amount;
    private String pMethodId;
    private String pMethod;
    private String cCardId;
    private String cCard;
    private String customerId;
    private String customer;
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
    public String SProvince
    {
        get { return this.sProvince; }
        set { this.sProvince = value; }
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
    public String PMethod
    {
        get { return this.pMethod; }
        set { this.pMethod = value; }
    }
    public String CCardId
    {
        get { return this.cCardId; }
        set { this.cCardId = value; }
    }
    public String CCard
    {
        get { return this.cCard; }
        set { this.cCard = value; }
    }
    public String CustomerId
    {
        get { return this.customerId; }
        set { this.customerId = value; }
    }
    public String Customer
    {
        get { return this.customer; }
        set { this.customer = value; }
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
        this.id = "";
        this.no = "";
        this.content = "";
        this.address = "";
        this.sProvinceId = "";
        this.sProvince = "";
        this.sPrice = "";
        this.pPrice = "";
        this.amount = "";
        this.pMethodId = "";
        this.pMethod = "";
        this.cCardId = "";
        this.cCard = "";
        this.customerId = "";
        this.customer = "";
        this.status = "";
        this.createdDate = "";
    }
    public OrderModel(String _Id, String _No,
                        String _Content, String _Address, String _SProvinceId,
                        String _SProvince, String _SPrice,
                        String _PPrice, String _Amount,
                        String _PMethodId, String _PMethod, String _CCardId, String _CCard,
                        String _CustomerId, String _Customer, String _Status,
                        String _CreatedDate)
    {
        this.id = _Id;
        this.no = _No;
        this.content = _Content;
        this.address = _Address;
        this.sProvinceId = _SProvinceId;
        this.sProvince = _SProvince;
        this.sPrice = _SPrice;
        this.pPrice = _PPrice;
        this.amount = _Amount;
        this.pMethodId = _PMethodId;
        this.pMethod = _PMethod;
        this.cCardId = _CCardId;
        this.cCard = _CCard;
        this.customerId = _CustomerId;
        this.customer = _Customer;
        this.status = _Status;
        this.createdDate = _CreatedDate;
    }
}
