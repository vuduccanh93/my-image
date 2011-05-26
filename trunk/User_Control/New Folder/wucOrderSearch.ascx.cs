using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class admin_wuc_wucOrderSearch : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {        
    }
    
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string OrderNo = Request.QueryString["OrderNo"];
        string ProName = Request.QueryString["ProName"];
        string CusName = Request.QueryString["CusName"];

         if ((txtNo.Text != "") || (txtProvince.Text == "") || (txtCustomer.Text == ""))
        {            
            grvOrder.DataSource = OrderDAO.GetByNo(OrderNo);
            grvOrder.DataBind();
        }
        else if ((txtNo.Text == "") || (txtProvince.Text != "") || (txtCustomer.Text == ""))
        {            
            grvOrder.DataSource = OrderDAO.GetByProvinceName(ProName);
            grvOrder.DataBind();
        }
        else if ((txtNo.Text == "") || (txtProvince.Text == "") || (txtCustomer.Text != ""))
        {            
            grvOrder.DataSource = OrderDAO.GetByCusName(CusName);
            grvOrder.DataBind();
        }
        else if ((txtNo.Text != "") || (txtProvince.Text != "") || (txtCustomer.Text != ""))
        {            
            grvOrder.DataSource = OrderDAO.GetBySearch(OrderNo, ProName, CusName);
            grvOrder.DataBind();
        }
        else if((txtNo.Text == "") || (txtProvince.Text == "") || (txtCustomer.Text == ""))
        {
            grvOrder.DataSource = OrderDAO.GetAll();
            grvOrder.DataBind();
        }
    }
}

    
    //private void BindData()
    //{
    //    grvOrder.DataSource = OrderDAO.GetAll();
    //    grvOrder.DataBind();
    //}

    //private void BindData(String _No
    //   // ,String _Province, String _CusName
    //    )
    //{
        //grvOrder.DataSource = OrderDAO.GetByNo(_No);
        //grvOrder.DataSource = OrderDAO.GetByProvinceName(_Province);
        //grvOrder.DataSource = OrderDAO.GetByCusName(_CusName);
    //    grvOrder.DataBind();
    //}

    //public void Main()
    //{
    //    if (txtNo.Text != "" || txtProvince.Text == "" || txtCustomer.Text == "")
    //    {           
    //        BindData();           
            //grvOrder.DataSource = " AND No LIKE N'%" + txtNo.Text.Trim() + "%'";
       // }
        //else if (txtNo.Text == "" || txtProvince.Text != "" || txtCustomer.Text == "")
        //{
        //    Province_Name(Request.QueryString["Province"].ToString());
        //    //grvOrder.DataSource = " AND C.Name LIKE N'%" + txtProvince.Text.Trim() + "%'";
        //}
        //else if (txtNo.Text == "" || txtProvince.Text == "" || txtCustomer.Text != "")
        //{
        //    Customer_Name(Request.QueryString["CusName"].ToString());
        //    //grvOrder.DataSource = " AND (E.F_name + ' ' +  E.L_name) LIKE N'%" + txtCustomer.Text.Trim() + "%'";
        //} 
        //else
        //{
        //    BindData();
        //}
   // }

    //private void No_Order(String _No)
    //{
    //    grvOrder.DataSource = OrderDAO.GetByNo(_No);
    //    grvOrder.DataBind();
    //}

    //private void Province_Name(String _ProvinceName)
    //{
    //    grvOrder.DataSource = OrderDAO.GetByProvinceName(_ProvinceName);
    //    grvOrder.DataBind();
    //}

    //private void Customer_Name(String _CusName)
    //{
    //    grvOrder.DataSource = OrderDAO.GetByCusName(_CusName);
    //    grvOrder.DataBind();
    //}
  
