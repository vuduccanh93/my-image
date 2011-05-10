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
/// Summary description for ShippingPrice
/// </summary>
public class ShippingPriceModel
{

	private String id;
    private String sProvinceId;
    private String sProvinceName;
    private String shippingTime;
    private String price;
    private String lastModified;
    
    public String ID
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public String SProvinceId
    {
        get { return this.sProvinceId; }
        set { this.sProvinceId = value; }
    }
    public String SProvinceName
    {
        get { return this.sProvinceName; }
        set { this.sProvinceName = value; }
    }
    public String ShippingTime
    {
        get { return this.shippingTime; }
        set { this.shippingTime = value; }
    }
    public String Price
    {
        get { return this.price; }
        set { this.price = value; }
    }
    public String LastModified
    {
        get { return this.lastModified; }
        set { this.lastModified = value; }
    }
    public ShippingPriceModel()
	{
        id = "";
        sProvinceId = "";
        sProvinceName = "";
        shippingTime = "";
        price = "";
        lastModified = "";
	}
    public ShippingPriceModel(String _ID, String _SProvinceId, String _SProvinceName, String _ShippingTime, String _Price, String _LastModified)
    {
        id = _ID;
        sProvinceId = _SProvinceId;
        sProvinceName = _SProvinceName;
        shippingTime = _ShippingTime;
        price = _Price;
        lastModified = _LastModified;
    }
}
