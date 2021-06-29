using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRN292_SU17_DO
{
    public partial class MainScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlMaster.DataSource = null;
                DataTable DummyMaster = Database.getAllDummyMaster();
                DataRow dr = DummyMaster.NewRow();
                ddlMaster.DataSource = Database.getAllDummyMaster();
                ddlMaster.DataTextField = "master_name";
                ddlMaster.DataValueField = "master_id";
                ddlMaster.DataBind();
                //ddlMaster.Items.Insert(0, new List("All", "0"));
                //new ListItem("-- all --", "0");
            }
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Equals(""))
            {
                //if(ddlMaster.SelectedIndex == 0)
                //{
                //gvDummy.DataSource = Database.getAll();
                //}
                //else
                //{
                    gvDummy.DataSource = Database.getAllByDummyMasterID(ddlMaster.SelectedValue.ToString());
                    gvDummy.DataBind();
                //}
                
            }
            else
            {
                gvDummy.DataSource = Database.getAllByDummyMasterIDAndName(ddlMaster.SelectedValue.ToString(),txtName.Text);
                gvDummy.DataBind();
            }

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert.aspx");
            
        }
    }
}