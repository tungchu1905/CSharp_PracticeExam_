using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Qe22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSubject.DataSource = Database.getAllSubject();
            cbSubject.DisplayMember = "SubjectName";
            cbSubject.ValueMember = "SubjectId";

            listBoxInstructor.DataSource = Database.getFullnameInstructor();
            listBoxInstructor.DisplayMember = "fullname";
            listBoxInstructor.ValueMember = "InstructorId";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //  @"^(HE|SE)\d{6}$"          -----------  @"^[a-zA-Z\s]{2}\d{6}$"    /// ^[a-zA-Z]+\d+$ 
            Regex regex = new Regex(@"^(\w+)+$");
            if (!regex.IsMatch(txtCode.Text.Trim()))
            {
                MessageBox.Show("Khong the insert", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.InsertCourse(txtCode.Text,txtDescription.Text,cbSubject.SelectedValue.ToString(),listBoxInstructor.SelectedValue.ToString());
                MessageBox.Show("Insert Successfull", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
