using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public SqlConnection GetSqlConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["OrderTableSchemaConnectionString"].ToString();
            return new SqlConnection(strCon);
        }
       public DataTable getList(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, GetSqlConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet(); // database Cache
            ds.Clear();
            da.Fill(ds);
            return ds.Tables[0];
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = getList("select * from Table_Order");
            GridView1.DataBind();
        }
    }
}