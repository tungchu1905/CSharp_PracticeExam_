using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A_Color
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnGE_Click(object sender, EventArgs e)
        {
            txtSID.Text = "TungCTHE141487";
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            //// Sets the initial color select to the current text color.
            //MyDialog.Color = txtColor.ForeColor;
            MyDialog.AnyColor = true;
            MyDialog.SolidColorOnly = false;
            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                txtColor.BackColor = MyDialog.Color;

            }


        }
        int count = 1;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //int Y = 1;
            if (txtLabel.Text.Trim().Equals("") || txtSID.Text.Equals(""))
            {
                MessageBox.Show("Label cannot blank");
            }
            else
            {
                //for (int i = 0; i < count; i++)
                //{
                Button btn = new Button();
                btn.Text = txtLabel.Text;
                btn.Name = txtLabel.Text;
                btn.Size = new Size(75, 23);
                //btn.Location = new Point(40, 200 + Y);
                //Y+=30;
                btn.BackColor = txtColor.BackColor;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += new EventHandler(button_click);
                
                //}
                //count++;
            }
        }
        List<Button> button = new List<Button>();
        private void button_click(object sender, EventArgs e)
        {
            foreach (Button btn in button)
            {
                if (btn.Focused)
                {
                    MessageBox.Show("Label:" + txtLabel.Text + "\nColor: RGB(" + btn.BackColor.R + "," + btn.BackColor.G + "," + btn.BackColor.B + ")");
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            txtSID.Enabled = false;
        }

        private void txtLabel_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void txtLabel_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtLabel_MouseLeave(object sender, EventArgs e)
        {
            txtLabel.BackColor = Color.White;
        }

        private void txtLabel_MouseEnter(object sender, EventArgs e)
        {
            txtLabel.BackColor = Color.Black;
        }
    }
}
