using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Summer_2020_B5_DO
{
    class Database
    {
        internal static SqlConnection getConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Summer20"].ToString();
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

        internal static DataTable getAllBook()
        {
            return getDataSql("select * from Books");
        } 
        internal static DataTable getYear(string id)
        {
            return getDataSql("select * from Books where ID = '" + id + "'");
        }
        internal static DataTable getAllInfor(string id)
        {
            return getDataSql("select * from Books,Author_Book,Authors where Books.ID = Author_Book.BookID and Authors.ID = Author_Book.AuthorID and Books.ID = '" + id + "'");

        }
        internal static void Remove(string aid, string bid)
        {
            Execute("  delete Author_Book where AuthorID = '"+aid+ "' and BookID =  '" + bid + "' ");
        }
    }
}
