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

public partial class wuc_wucOrder_Payment : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["user"] == null)
            {
                Response.Redirect(@"~");
                return;
            }
            if (Session["order_order"] == null || !Session["order_order"].ToString().Equals("1"))
            {
                Response.Redirect("Default.aspx?t=order&start=true&upload=true");
                return;
            }
            else
            {
                Session["order_order"] = null;
            }
            String _html="";
            OrderModel model = (OrderModel)Session["order"];
            CustomerModel cusModel = (CustomerModel)Session["user"];
            if (model.PMethodId.Equals("1"))
            {
                _html = "<table><tr> <td align='right'> No : </td><td align='left'>" + model.NO + " </td></tr>";
                _html += "<tr> <td align='right'> Content : </td><td align='left'>" + model.Content + " </td></tr>";
                _html += "<tr> <td align='right'> Address : </td><td align='left'>" + model.Address + " </td></tr>";
                _html += "<tr> <td align='right'> State : </td><td align='left'>" + model.SProvince + " </td></tr>";
                _html += "<tr> <td align='right'> Content : </td><td align='left'>" + model.Content + " </td></tr>";
                _html += "<tr> <td align='right'> Shipping Price : </td><td align='left'>" + model.SPrice + " </td></tr>";
                _html += "<tr> <td align='right'> Printing Price : </td><td align='left'>" + model.PPrice + " </td></tr>";
                _html += "<tr> <td align='right'> Amount : </td><td align='left'>" + model.Amount + " </td></tr>";
                _html += "<tr> <td align='right'> Payment Method : </td><td align='left'>" + model.PMethod + " </td></tr>";
                _html += "<tr> <td align='right'> ShipTime : </td><td align='left'>" + model.ShipTime + " </td></tr>";
                _html += "<tr> <td align='right'> Customer : </td><td align='left'>" + cusModel.FName + " " + cusModel.LName + " </td></tr>";
                _html += "<tr> <td align='right' colspan='2'>  If Cash ,  </td></tr>";
                _html += "</table>";

            }
            else
            {
                _html = "<table><tr> <td align='right'> No : </td><td align='left'>" + model.NO + " </td></tr>";
                _html += "<tr> <td align='right'> Content : </td><td align='left'>" + model.Content + " </td></tr>";
                _html += "<tr> <td align='right'> Address : </td><td align='left'>" + model.Address + " </td></tr>";
                _html += "<tr> <td align='right'> State : </td><td align='left'>" + model.SProvince + " </td></tr>";
                _html += "<tr> <td align='right'> Content : </td><td align='left'>" + model.Content + " </td></tr>";
                _html += "<tr> <td align='right'> Shipping Price : </td><td align='left'>" + model.SPrice + " </td></tr>";
                _html += "<tr> <td align='right'> Printing Price : </td><td align='left'>" + model.PPrice + " </td></tr>";
                _html += "<tr> <td align='right'> Amount : </td><td align='left'>" + model.Amount + " </td></tr>";
                _html += "<tr> <td align='right'> Payment Method : </td><td align='left'>" + model.PMethod + " </td></tr>";
                _html += "<tr> <td align='right'> ShipTime : </td><td align='left'>" + model.ShipTime + " </td></tr>";
                _html += "<tr> <td align='right'> Customer : </td><td align='left'>" + cusModel.FName + " " + cusModel.LName + " </td></tr>";
                _html += "</table>";
            }
            lblContent.Text = _html;
        }
    }
}
