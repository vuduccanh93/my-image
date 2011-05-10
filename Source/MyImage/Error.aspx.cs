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

public partial class Error : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HandleError();
    }

    private void HandleError()
    {
        if (Request.QueryString["r"] != null)
        {
            switch (Request.QueryString["r"])
            {
                case "404":
                    lblError.Text = "Error 404";
                    break;
                case "500":
                    lblError.Text = "Error 404";
                    break;
            }


        }
        else
        {
            lblError.Text = "Unknow Error !!!";
        }
    }
}
