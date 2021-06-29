using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRN292_SU17_DO
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Validation.RequireField("title", "You must enter a title");
                txtID.Text = Request.Params["id"];
                ddlMaName.DataSource = null;
                DataTable DummyMaster = Database.getAllDummyMaster();
                DataRow dr = DummyMaster.NewRow();
                ddlMaName.DataSource = Database.getAllDummyMaster();
                ddlMaName.DataTextField = "master_name";
                ddlMaName.DataValueField = "master_id";
                ddlMaName.DataBind();
                ddlMaName.SelectedValue = Database.getAllDetailbyID(txtID.Text).Rows[0]["master_id"].ToString();
                txtDeName.Text = Database.getAllDetailbyID(txtID.Text).Rows[0]["detail_name"].ToString();
            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string deid = txtID.Text;
            string dename = txtDeName.Text;

            string maid = ddlMaName.SelectedValue;
            //Label1.Text = maid;

            Database.Update(dename, maid, deid);
            Response.Redirect("MainScreen.aspx");
        }
    }
}