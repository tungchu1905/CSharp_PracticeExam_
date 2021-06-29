using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Bai3
{
    class dao
    {
        string cusname;
        string redate;
        string shipAddress;

        public string Cusname { get => cusname; set => cusname = value; }
        public string Redate { get => redate; set => redate = value; }
        public string ShipAddress { get => shipAddress; set => shipAddress = value; }

        public dao(string cusname, string redate, string shipAddress)
        {
            this.Cusname = cusname;
            this.Redate = redate;
            this.ShipAddress = shipAddress;
        }

        internal static SqlConnection getConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Orders"].ToString();
            return new SqlConnection(strCon);
        }

        internal static void Execute(string sql, params SqlParameter[] sqlParameters)
        {
            SqlCommand cmd = new SqlCommand(sql, getConnection());
            cmd.Parameters.AddRange(sqlParameters);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        internal static void add(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, getConnection());
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        internal static void insertOrder(ArrayList list)
        {
            string sql = "insert into Table_Order values(@cusname, @redate, @shipAddress)";
            SqlParameter[] parameter = new SqlParameter[]
            {

                new SqlParameter("@cusname",SqlDbType.NVarChar),
                new SqlParameter("@redate",SqlDbType.NVarChar),
                new SqlParameter("@shipAddress",SqlDbType.NVarChar)
            };
            for (int i = 0; i < list.Count; i++)
            {
                parameter[i].Value = list[i];
            }
            Execute(sql, parameter);
        }

    }
}
