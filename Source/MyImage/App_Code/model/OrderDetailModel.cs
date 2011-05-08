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
/// Summary description for OrderDetailModel
/// </summary>
public class OrderDetailModel
{
    private String id;
    private String orderId;
    private String uploadDetailId;
    private String price;
    private String size;
    private String quantity;
    private String amount;

    public String ID
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public String OrderId
    {
        get { return this.orderId; }
        set { this.orderId = value; }
    }
    public String UploadDetailId
    {
        get { return this.uploadDetailId; }
        set { this.uploadDetailId = value; }
    }
    public String Price
    {
        get { return this.price; }
        set { this.price = value; }
    }
    public String Size
    {
        get { return this.size; }
        set { this.size = value; }
    }
    public String Quantity
    {
        get { return this.quantity; }
        set { this.quantity = value; }
    }
    public String Amount
    {
        get { return this.amount; }
        set { this.amount = value; }
    }
	public OrderDetailModel()
	{
        this.id = "";
        this.orderId = "";
        this.uploadDetailId = "";
        this.price = "";
        this.size = "";
        this.quantity = "";
        this.amount = "";
	}
    public OrderDetailModel(String _Id,
                            String _OrderId,
                            String _UploadDetailId,
                            String _Price,
                            String _Size,
                            String _Quantity,
                            String _Amount)
    {
        this.id = _Id;
        this.orderId = _OrderId;
        this.uploadDetailId = _UploadDetailId;
        this.price = _Price;
        this.size = _Size;
        this.quantity = _Quantity;
        this.amount = _Amount;
    }
}
