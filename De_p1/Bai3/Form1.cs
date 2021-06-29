using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public SqlConnection getConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Orders"].ToString();
            return new SqlConnection(strCon); 
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList() {listBox1.SelectedItem.ToString(),dateTimePicker1.Text, txtAddress.Text};
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Dia chi khong duoc de trong", "thong bao2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //dao.add("insert into Table_Order values('" + listBox1.SelectedItem.ToString() + "','" + dateTimePicker1.Text + "','" + txtAddress.Text + "')");
                dao.insertOrder(list);
                MessageBox.Show("Them sinh vien thanh cong", "thong bao2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
