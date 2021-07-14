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
        internal static DataTable getAllDate()
        {
            return getDataSql("SELECT distinct teachingdate FROM [COURSE_SCHEDULES] order by teachingdate");
        }
        internal static DataTable getAll(string date)
        {
            return getDataSql("  select  TeachingDate,RoomCode, Slot, InstructorFirstName + ' ' +InstructorMidName + ' ' + InstructorLastName as fullname from COURSES,COURSE_SCHEDULES,INSTRUCTORS, ROOMS " +
                "where COURSES.InstructorId = INSTRUCTORS.InstructorId " +
                "and COURSES.CourseId = COURSE_SCHEDULES.CourseId " +
                "and COURSE_SCHEDULES.RoomId = ROOMS.RoomId and TeachingDate = '" + date + "' ");
        }
        internal static DataTable getSlot()
        {
            return getDataSql("  select distinct Slot from COURSES,COURSE_SCHEDULES,INSTRUCTORS, ROOMS " +
               "where COURSES.InstructorId = INSTRUCTORS.InstructorId " +
               "and COURSES.CourseId = COURSE_SCHEDULES.CourseId " +
               "and COURSE_SCHEDULES.RoomId = ROOMS.RoomId");
        }

        internal static DataTable getRoomCode()
        {
            return getDataSql("  select * from rooms ");
        }

        internal static string getInstructor(DateTime date, int roomid, int slot)
        {
            string sql = "  select InstructorFirstName + ' ' +InstructorMidName + ' ' + InstructorLastName as fullname from COURSES,COURSE_SCHEDULES,INSTRUCTORS" +
                "  where COURSES.InstructorId = INSTRUCTORS.InstructorId " +
                " and COURSES.CourseId = COURSE_SCHEDULES.CourseId  and TeachingDate = '" + date + "' and roomid = '" + roomid + "' and slot = '" + slot + "'";
            if (getDataSql(sql).Rows.Count == 0)
            {
                return "";
            }
            else
            {
                return getDataSql(sql).Rows[0]["fullname"].ToString();
            }

        }
    }
}