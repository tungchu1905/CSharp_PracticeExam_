using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PRN292_SU17_DO
{
    public class Database
    {
        internal static SqlConnection GetSqlConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Dummy"].ToString();
            return new SqlConnection(strCon);
        }
        internal static DataTable getDataSql(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, GetSqlConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet(); // database Cache
            ds.Clear();
            da.Fill(ds);
            return ds.Tables[0];
        }
        internal static void Execute(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, GetSqlConnection());
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        internal static DataTable getAll()
        {
            return getDataSql(" select detail_id,detail_name,master_name  from DummyDetail,DummyMaster " +
                "where DummyDetail.master_id = DummyMaster.master_id ");
        }  
        internal static DataTable getAllByDummyMasterID(string id)
        {
            return getDataSql(" select detail_id,detail_name,master_name  from DummyDetail,DummyMaster " +
                "where DummyDetail.master_id = DummyMaster.master_id and DummyMaster.master_id = '"+id+"' ");
        }
        internal static DataTable getAllByDummyMasterIDAndName(string id,string name)
        {
            return getDataSql(" select detail_id,detail_name,master_name  from DummyDetail,DummyMaster " +
                "where DummyDetail.master_id = DummyMaster.master_id and DummyMaster.master_id = '" + id + "' and detail_name like '%"+name+"%'");
        }
        internal static DataTable getAllDummyMaster()
        {
            return getDataSql("select * from DummyMaster");
        }
        internal static DataTable getAllDetailbyID(string id)
        {
            return getDataSql("select * from DummyDetail where detail_id = '" + id + "'");
        }
        internal static void Update(string name, string master_id, string detail_id)
        {
             Execute("update DummyDetail set detail_name = '"+name+"', " +
                 "master_id = '"+master_id+"' where detail_id = '"+detail_id+"'");
        }
        internal static void Insert(string de_id, string de_name, string ma_id)
        {
            Execute("insert into DummyDetail values('"+de_id+"','"+de_name+"','"+ma_id+"')");
        }
    }
}