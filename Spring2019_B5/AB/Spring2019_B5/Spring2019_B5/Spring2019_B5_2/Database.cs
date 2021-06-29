using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Spring2019_B5_2
{
    public class Database
    {
        internal static SqlConnection getConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Spring19"].ToString();
            return new SqlConnection(strCon);
        }
        internal static DataTable getDataSql(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, getConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet(); // database Cache
            ds.Clear();
            da.Fill(ds);
            return ds.Tables[0];
        }
        internal static void Execute(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, getConnection());
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        internal static DataTable getRegion()
        {
            return getDataSql("select * from region");
        }
        internal static DataTable getCorpbyReNO(string no)
        {
            return getDataSql("select * from corporation where region_no = '"+no+"'");
        }
        internal static void Add(string lastname, string firstname, string region_no, string corpo_no) 
        {
            DateTime date = DateTime.Now;
            Execute("insert into member" +
                " values('"+lastname+"','"+firstname+"','','','','','','','','','"+ date.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss") + "','" + date.ToLocalTime().AddMonths(6).ToString("yyyy-MM-dd HH:mm:ss") + "','" + region_no+"','"+corpo_no+"','0.00','0.00','')");
        }
    }
}
//(lastname, firstname, street, issue_dt, expr_dt, region_no, corp_no)