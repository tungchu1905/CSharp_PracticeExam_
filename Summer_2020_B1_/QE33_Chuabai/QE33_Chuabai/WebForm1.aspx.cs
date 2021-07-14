using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QE33_Chuabai
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlDate.DataSource = Database.getAllDate();
                ddlDate.DataTextField = "teachingdate";
                ddlDate.DataValueField = "teachingdate";
                ddlDate.DataTextFormatString = "{0:MM-dd-yyyy}";
                ddlDate.DataBind();

                // THIET LAP date mac dinh la 07-23-2011
                DateTime date = new DateTime(2011, 07, 23);
                // load du lieu theo date mac dinh
                GetInstructor(date);
            }

        }



        // HAM SE TRICH SUAT DU LIEU CUA ROOMCODE, Instructor, Slot
        private void GetInstructor(DateTime teachingdate)
        {
            DataTable slot = Database.getSlot();
            StringBuilder html = new StringBuilder();
            html.Append("<table border='1px' style='width:100%'>");

            html.Append("<tr><th> RoomCode </th>");

            //"<th> Slot1 </th><th> Slot2 </th><th> Slot3 </th><th> Slot4 </th><th> Slot5 </th><th> Slot6 </th>");
            foreach (DataRow rowslot in slot.Rows)
            {

                html.Append("<th> Slot" + rowslot["slot"].ToString() + "</th>");

            }
            html.Append("</tr>");
            // lay toan bo cac Roomcode
            DataTable roomcode = Database.getRoomCode();
            foreach (DataRow row in roomcode.Rows)
            {
                //int roomID = Convert.ToInt32(row["roomcode"].ToString());
                html.Append("<tr>");
                html.Append("<td>" + row["roomcode"].ToString() + "</td>");
                foreach (DataRow rowslot in slot.Rows)
                {
                  
                    html.Append("<td>" + Database.getInstructor(teachingdate, Convert.ToInt32(row["roomid"].ToString()), Convert.ToInt32( rowslot["slot"].ToString())) + "</td>");
                   
                }
                html.Append("</tr>");
            }
            html.Append("</table>");
            //them doi tuong html vao Placehoder
            phTeachingSchedule.Controls.Add(new Literal { Text = html.ToString() });
        }
        protected void ddlDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetInstructor( Convert.ToDateTime( ddlDate.SelectedValue.ToString()));
        }
    }
}