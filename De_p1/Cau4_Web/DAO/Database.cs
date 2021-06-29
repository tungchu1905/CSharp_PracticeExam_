using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Cau4_Web.DAO
{
    public class Database
    {
        //internal static SqlConnection GetSqlConnection()
        //{
        //    string strCon = ConfigurationManager.ConnectionStrings["Orders"].ToString();
        //    return new SqlConnection(strCon);
        //}
        //internal static DataTable getShow(string sql)
        //{
        //    SqlCommand cmd = new SqlCommand(sql, GetSqlConnection());
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    DataSet ds = new DataSet(); // database Cache
        //    ds.Clear();
        //    da.Fill(ds);
        //    return ds.Tables[0];
        //}
    }
}