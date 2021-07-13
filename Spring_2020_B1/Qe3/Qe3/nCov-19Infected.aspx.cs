using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qe3
{
    public partial class nCov_19Infected : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlNATION.DataSource = Database.getNation();
                ddlNATION.DataTextField = "nationality";
                ddlNATION.DataValueField = "nationality";
                ddlNATION.DataBind();
                ddlprovince.DataSource = Database.getProvince();
                ddlprovince.DataTextField = "province";
                ddlprovince.DataValueField = "province";
                ddlprovince.DataBind();


                ddlRelated.DataSource = Database.getAll();
                ddlRelated.DataTextField = "Name";
                ddlRelated.DataValueField = "Id";
                ddlRelated.DataBind();
                rbMale.Checked = true;
            }
        }
        private string checkSex()
        {
            if (rbFemale.Checked == true) return "0";
            return "1";
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            bool checkName = false;
            bool checkAge = false;
            //int age = 0;
            //age = int.Parse(txtAge.Text) ;

            if (txtName.Text.Trim().Equals(""))
            {
                lblcheckName.Text = "Name cannot be blank";
                lblcheckName.ForeColor = System.Drawing.Color.Red;
                checkName = false;
            }
            else
            {
                lblcheckName.Text = "";
                checkName = true;
            }
            //age > 120 ||
            if (txtAge.Text.Trim().Equals(""))
            {
                lblCheckAge.Text = "Age must be between 0 and 120";
                lblCheckAge.ForeColor = System.Drawing.Color.Red;
                checkAge = false;
            }
            else
            {
                lblCheckAge.Text = "";
                checkAge = true;
            }
            
            if(checkAge == true && checkName == true)
            {
                if (cbRelated.Checked==true)
                {
                    Database.InsertWhenRelateNull(txtName.Text, txtAge.Text, checkSex(), ddlNATION.SelectedValue, ddlprovince.SelectedValue, txtTravel.Text);

                }
                else
                {
                    Database.Insert(txtName.Text, txtAge.Text, checkSex(), ddlNATION.SelectedValue, ddlprovince.SelectedValue, txtTravel.Text, ddlRelated.SelectedValue);

                }
                lblSuccess.Text = "Add Success";
                lblSuccess.ForeColor = System.Drawing.Color.AliceBlue;
            }
        }

        protected void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked == true) rbFemale.Checked = false;
        }

        protected void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked == true) rbMale.Checked = false;
        }

        protected void cbTravel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTravel.Checked == true) txtTravel.Enabled = false;
            else txtTravel.Enabled = true;
        }

        protected void cbRelated_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRelated.Checked == true) { 
                ddlRelated.Enabled = false;  }
            else ddlRelated.Enabled = true;
        }
    }
}