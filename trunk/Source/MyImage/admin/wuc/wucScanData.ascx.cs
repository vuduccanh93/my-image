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
using System.IO;

public partial class admin_wuc_ScanData : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnScan_Click(object sender, EventArgs e)
    {
        StartScanData();
    }
    public void StartScanData()
    {
        DataTable _Dt = new DataTable();
        _Dt = OrderDAO.ScanData();

        if (_Dt.Rows.Count > 0)
        {
            int act;
            foreach (DataRow _Row in _Dt.Rows)
            {
                if (_Row["Act"] != null)
                {
                    try
                    {
                        act = int.Parse(_Row["Act"].ToString());
                        if (act < 0)
                        {
                            if (Directory.Exists(MapPath( _Row["Link"].ToString())))
                            {
                                Directory.Delete(MapPath(_Row["Link"].ToString()));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                    }


                }
            }
        }
    }
}
