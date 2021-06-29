using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRN292_SU17_DO
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlMaName.DataSource = Database.getAllDummyMaster();
            ddlMaName.DataTextField = "master_name";
            ddlMaName.DataValueField = "master_id";
            ddlMaName.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Database.Insert(txtID.Text,txtDeName.Text, ddlMaName.SelectedValue);
            Response.Redirect("MainScreen.aspx");
        }
    }
}