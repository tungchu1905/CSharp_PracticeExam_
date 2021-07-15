using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Qe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbCity.DataSource = Database.getAllInfecte();
            lbCity.DisplayMember = "province";
            lbCity.ValueMember = "province";
        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(cbFemale.Checked == true && cbMale.Checked == true)
            {
                lbCity.SelectedIndex = 2;
            }
            if (checkBoth() == false)
            {
                dgvReport.DataSource = Database.getAll(lbCity.SelectedValue.ToString(), checkSex());

            }
            else
            {
                dgvReport.DataSource = Database.getAll(lbCity.SelectedValue.ToString());

            }
        }

        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFemale.Checked == true && cbMale.Checked == true)
            {
                lbCity.SelectedIndex = 2;

            }
            if (checkBoth() == false)
            {
                dgvReport.DataSource = Database.getAll(lbCity.SelectedValue.ToString(), checkSex());

            }
            else
            {
                dgvReport.DataSource = Database.getAll(lbCity.SelectedValue.ToString());

            }

        }
        private string checkSex( )
        {
            if (cbFemale.Checked) return "0";
            if (cbMale.Checked) return "1";
            return "";
        }
        private bool checkBoth()
        {
            if (cbFemale.Checked == true && cbMale.Checked == true) return true;
            //if (cbMale.Checked == true || cbFemale.Checked == true) return false;
            return false;
        }
        private void lbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoth() == false)
            {
                dgvReport.DataSource = Database.getAll(lbCity.SelectedValue.ToString(), checkSex());

            }
            else
            {
                dgvReport.DataSource = Database.getAll(lbCity.SelectedValue.ToString());

            }

        }
    }
}
