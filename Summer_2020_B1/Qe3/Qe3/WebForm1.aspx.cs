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
            //DataTable dt = Database.getAll(ddlDistinctDate.SelectedValue);
            DataTable dtSlot = Database.getSlot();
            DataTable dtRommCode = Database.getRoomCode();


            StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table border = '1'>");
            html.Append("<tr>");

            //ROOMCODE
            foreach (DataColumn column in dtRommCode.Columns)
            {
                html.Append("<th>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }


            // GET ALL SLOT1,2,3,4,5
            foreach (DataRow row in dtSlot.Rows)
            {
                foreach (DataColumn column in dtSlot.Columns)
                {

                    html.Append("<th>");
                    html.Append("Slot " + row[column.ColumnName]);
                    html.Append("</th>");
                    //DataTable dtInstructor = Database.getInstructor(ddlDistinctDate.SelectedValue, row[column.ColumnName].ToString());
                    //foreach (DataRow rows in dtInstructor.Rows)
                    //{
                    //    //html.Append("<tr>");
                    //    foreach (DataColumn columns in dtInstructor.Columns)
                    //    {
                    //        html.Append("<td>");
                    //        html.Append(rows[columns.ColumnName]);
                    //        html.Append("</td>");
                    //    }
                    //    //html.Append("</tr>");
                    //}
                   
                }

            }


            // GET ROOM CODE ROWS
            foreach (DataRow row in dtRommCode.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dtRommCode.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);

                    html.Append("</td>");
                }
                html.Append("</tr>");
            }



            // GET SLOT NAME ROWS
            //foreach (DataRow row in dtInstructor.Rows)
            //{

            //    html.Append("<tr>");
            //    foreach (DataColumn column in dtInstructor.Columns)
            //    {
            //        html.Append("<td>");
            //        html.Append(row[column.ColumnName]);
            //        html.Append("</td>");
            //    }
            //    html.Append("</tr>");
            //}



            html.Append("</tr>");
            //Table end.
            html.Append("</table>");

            //Append the HTML string to Placeholder.
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
    }
}