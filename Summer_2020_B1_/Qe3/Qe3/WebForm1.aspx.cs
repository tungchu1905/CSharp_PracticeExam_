using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qe3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlDistinctDate.DataSource = Database.getAllDate();
                ddlDistinctDate.DataTextField = "teachingDate";
                ddlDistinctDate.DataValueField = "teachingDate";
                ddlDistinctDate.DataBind();
            }
        }

        protected void btnLoad_Click(object sender, EventArgs e)
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

                    html.Append("<td>" + Database.getInstructor( Convert.ToDateTime( ddlDistinctDate.SelectedValue.ToString()), Convert.ToInt32(row["roomid"].ToString()), Convert.ToInt32(rowslot["slot"].ToString())) + "</td>");

                }
                html.Append("</tr>");
            }
            html.Append("</table>");
            //them doi tuong html vao Placehoder
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
    }
}