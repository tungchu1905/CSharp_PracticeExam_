using Spring2019_B5.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spring2019_B5
{
    public partial class FrmUpdate : Form
    {
        public FrmUpdate(string id)
        {
            InitializeComponent();
            lblID.Text = id;
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            //ArrayList list = new ArrayList() {"", "", "", "" };
            //CorporationDAO.LoadDataByName(list, txtName.Text);
            //lblID.Text = list[0].ToString();
            //txtName.Text = list[1].ToString();
            //txtStreet.Text = list[2].ToString();
            //dateTime.Value = Convert.ToDateTime(list[3].ToString());

            DataTable da = CorporationDAO.LoadDataByName(lblID.Text);
            txtName.Text= da.Rows[0]["corp_name"].ToString();
            txtStreet.Text = da.Rows[0]["street"].ToString();
            dateTime.Value = Convert.ToDateTime( da.Rows[0]["expr_dt"].ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CorporationDAO.Update(txtName.Text,txtStreet.Text,dateTime.Value,lblID.Text);
            this.Hide();
            CorporationScreen co = new CorporationScreen();
            co.ShowDialog();
            this.Close();
        }
    }
}
