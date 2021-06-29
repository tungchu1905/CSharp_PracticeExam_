using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Spring2019_B5_2
{
    public partial class Member_Screen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Region
                ddlRegion.DataSource = Database.getRegion();
                ddlRegion.DataTextField = "region_name";
                ddlRegion.DataValueField = "region_no";
                ddlRegion.DataBind();

                // Corporation
                ddlCorp.DataSource = Database.getCorpbyReNO(ddlRegion.SelectedValue.ToString());
                ddlCorp.DataTextField = "corp_name";
                ddlCorp.DataValueField = "corp_no";
                ddlCorp.DataBind();

                DateTime date = DateTime.Now;
                lblSuccess.Text = date.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");

            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtFirst.Text.Trim().Equals("") || txtLast.Text.Trim().Equals(""))
            {
                
            }
            else
            {
                Database.Add(txtLast.Text,txtFirst.Text,ddlRegion.SelectedValue.ToString(),ddlCorp.SelectedValue.ToString());
                lblSuccess.Text = "Added successful";
            }
        }

        protected void ddlRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCorp.DataSource = Database.getCorpbyReNO(ddlRegion.SelectedValue.ToString());
            ddlCorp.DataTextField = "corp_name";
            ddlCorp.DataValueField = "corp_no";
            ddlCorp.DataBind();
        }
    }
}