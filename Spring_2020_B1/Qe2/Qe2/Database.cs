using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Qe2
{
    class Database
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
        internal static DataTable getAllInfecte()
        {
            return getDataSql("select distinct province from InfectedCases");
        }
        internal static DataTable getAll(string province,string sex)
        {
            return getDataSql("select name,age,sex,nationality, province, traveledfrom,confirmationdate from InfectedCases where province ='"+province+"' and sex like '%"+sex+"%'");
        }
        
    }
}
