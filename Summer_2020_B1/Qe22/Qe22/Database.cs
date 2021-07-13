using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Qe22
{
    class Database
    {
        internal static SqlConnection getConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Summer2020_B1"].ToString();
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
        internal static DataTable getAllSubject()
        {
            return getDataSql("select * from subjects");
        }internal static DataTable getFullnameInstructor()
        {
            return getDataSql("  select InstructorId, InstructorFirstName + ' ' +InstructorMidName + ' ' + InstructorLastName as fullname  from [INSTRUCTORS]");
        }

        internal static void InsertCourse(string code, string des, string subject, string instructor )
        {
            Execute("insert into COURSES values ('"+code+"','"+des+"','"+subject+"','"+instructor+"','5','1')");
        }
    }
}
