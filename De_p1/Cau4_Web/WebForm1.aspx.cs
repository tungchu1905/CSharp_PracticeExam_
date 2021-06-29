using Cau4_Web.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cau4_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //dgvMain.DataSource = Database.getShow("select * from Table_Order");
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            
            lbl1.Text = "Tung Chu";
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}