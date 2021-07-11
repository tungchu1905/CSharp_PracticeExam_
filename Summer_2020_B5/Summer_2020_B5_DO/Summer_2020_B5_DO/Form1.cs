using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Summer_2020_B5_DO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRN292_Sum2020_B5DataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.pRN292_Sum2020_B5DataSet.Books);
            cbbook.DataSource = null;
            cbbook.DataSource = Database.getAllBook();
            cbbook.DisplayMember = "Title";
            cbbook.ValueMember = "ID";
            //ArrayList year = new ArrayList();
            for (int i = 2000; i <= 2010; i++)
            {
                //string s = i.ToString();
                //year.Add(s);
                cbYear.Items.Add(i.ToString());
            }

        }

        private void cbbook_SelectedValueChanged(object sender, EventArgs e)
        {
            //cbYear.DataSource = Database.getYear(cbbook.SelectedValue.ToString());
            //cbYear.DisplayMember = "Year";
            //cbYear.ValueMember = "Year";

            //listAuthor.DataSource = Database.getAllInfor(cbbook.SelectedValue.ToString());
            //listAuthor.DisplayMember = "Name";
            //listAuthor.ValueMember = "AuthorID";

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You really want to delete this", "???", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            switch (dialog)
            {
                case DialogResult.Yes:
                    Database.Remove(listAuthor.SelectedValue.ToString(), cbbook.SelectedValue.ToString());
                    break;
                case DialogResult.No:
                    break;
            }
           
        }

        private void cbbook_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Show(object sender, EventArgs e)
        {

        }

        private void cbbook_DropDownStyleChanged(object sender, EventArgs e)
        {

           
        }

        private void cbbook_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listAuthor_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void cbbook_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void cbbook_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbYear.DataSource = Database.getYear(cbbook.SelectedValue.ToString());
            cbYear.DisplayMember = "Year";
            cbYear.ValueMember = "Year";

            listAuthor.DataSource = Database.getAllInfor(cbbook.SelectedValue.ToString());
            listAuthor.DisplayMember = "Name";
            listAuthor.ValueMember = "AuthorID";
        }
    }
}
