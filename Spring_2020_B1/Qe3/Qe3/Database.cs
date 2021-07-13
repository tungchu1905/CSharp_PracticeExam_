using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Qe3
{
    public class Database
    {
        internal static SqlConnection getConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Spring2020_B1"].ToString();
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
        internal static DataTable getNation()
        {
            return getDataSql("select distinct nationality from InfectedCases");
        }
        internal static DataTable getProvince()
        {
            return getDataSql("select distinct province from InfectedCases");
        }
        internal static DataTable getAll()
        {
            return getDataSql("select * from InfectedCases");
        }
        internal static void Insert(string name, string age, string sex, string nation, string province, string traveled, string related)
        {
            DateTime date = DateTime.Now;
            Execute("insert into InfectedCases values('"+name+"','"+age+"','"+sex+"','"+nation+"','"+province+"','"+traveled+"','','"+related+"','" + date.ToLocalTime().ToString("yyyy-MM-dd")+"')");
        }
        internal static void InsertWhenRelateNull(string name, string age, string sex, string nation, string province, string traveled)
        {
            DateTime date = DateTime.Now;
            Execute("insert into InfectedCases(name,age,sex,nationality,province,traveledfrom, confirmationdate) values('" + name + "','" + age + "','" + sex + "','" + nation + "','" + province + "','" + traveled + "','" + date.ToLocalTime().ToString("yyyy-MM-dd") + "')");
        }
    }
}