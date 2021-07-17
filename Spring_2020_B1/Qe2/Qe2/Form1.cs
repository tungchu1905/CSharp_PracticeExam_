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
            cbFemale.Checked = true;
            cbMale.Checked = true;
            lbCity.SelectedIndex = 2;
            

        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {

            dgvReport.DataSource = getAll();
        }

        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {
            
            dgvReport.DataSource = getAll();
        }
        private string checkSex( )
        {
            if (cbFemale.Checked==true && cbMale.Checked==false) return "0";
            if (cbMale.Checked==true && cbFemale.Checked == false) return "1";
            if(cbFemale.Checked == true && cbMale.Checked == true) 
            return "";
            return "2";
        }
        
        private void lbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = getAll();
        }

        public DataTable getAll()
        {
            string sql = "select name,age,sex,nationality, province, " +
                "traveledfrom,confirmationdate from InfectedCases where sex like '%"+checkSex()+"%' and (province = '"+lbCity.SelectedValue.ToString()+"' ";
            foreach (DataRowView objDataRowView in lbCity.SelectedItems)
            {
                sql += "or province like '%" + objDataRowView["province"].ToString() + "%'";
            }
            sql += ")";
            return Database.getDataSql(sql);
            
        }

        private void lbCity_MouseClick(object sender, MouseEventArgs e)
        {
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
