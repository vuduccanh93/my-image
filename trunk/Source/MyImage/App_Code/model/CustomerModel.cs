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
/// Summary description for CustomerModel
/// </summary>
public class CustomerModel
{
	private String id;
    private String username;
    private String password;
    private String email;
    private String fName;
    private String lName;
    private String dob;
    private String gender;
    private String pNo;
    private String address;
    private String statusId;
    private String status;
    public String ID
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public String Username
    {
        get { return this.username; }
        set { this.username = value; }
    }
    public String Password
    {
        get { return this.password; }
        set { this.password = value; }
    }
    public String Email
    {
        get { return this.email; }
        set { this.email = value; }
    }
    public String FName
    {
        get { return this.fName; }
        set { this.fName = value; }
    }
    public String LName
    {
        get { return this.lName; }
        set { this.lName = value; }
    }
    public String Dob
    {
        get { return this.dob; }
        set { this.dob = value; }
    }
    public String Gender
    {
        get { return this.gender; }
        set { this.gender = value; }
    }
    public String PNo
    {
        get { return this.pNo; }
        set { this.pNo = value; }
    }
    public String Address
    {
        get { return this.address; }
        set { this.address = value; }
    }
    public String StatusId
    {
        get { return this.statusId; }
        set { this.statusId = value; }
    }
    public String Status
    {
        get { return this.status; }
        set { this.status = value; }
    }
    public CustomerModel()
	{
        id = "";
        username = "";
        password = "";
        email = "";
        fName = "";
        lName = "";
        dob = "";
        gender = "";
        pNo = "";
        address = "";
        statusId = "";
        status = "";
	}
    public CustomerModel(String _ID,String _Username,
                        String _Password,String _FName,
                        String _LName,String _Dob,
                        String _Gender,String _PNo,String _Address,
                        String _Email,String _StatusId,String _Status)
    {
        this.id = _ID;
        this.username = _Username;
        this.password = _Password;
        this.fName = _FName;
        this.lName = _LName;
        this.dob = _Dob;
        this.gender = _Gender;
        this.pNo = _PNo;
        this.address = _Address;
        this.email = _Email;
        this.statusId = _StatusId;
        this.status = _Status;
    }
}
