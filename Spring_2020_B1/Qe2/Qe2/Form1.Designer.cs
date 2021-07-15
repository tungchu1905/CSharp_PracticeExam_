
namespace Qe2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.ListBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sex";
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Location = new System.Drawing.Point(25, 63);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(49, 17);
            this.cbMale.TabIndex = 1;
            this.cbMale.Text = "Male";
            this.cbMale.UseVisualStyleBackColor = true;
            this.cbMale.CheckedChanged += new System.EventHandler(this.cbMale_CheckedChanged);
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.Location = new System.Drawing.Point(25, 86);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(60, 17);
            this.cbFemale.TabIndex = 2;
            this.cbFemale.Text = "Female";
            this.cbFemale.UseVisualStyleBackColor = true;
            this.cbFemale.CheckedChanged += new System.EventHandler(this.cbFemale_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Province";
            // 
            // lbCity
            // 
            this.lbCity.FormattingEnabled = true;
            this.lbCity.Location = new System.Drawing.Point(25, 180);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(143, 173);
            this.lbCity.TabIndex = 4;
            this.lbCity.SelectedIndexChanged += new System.EventHandler(this.lbCity_SelectedIndexChanged);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(216, 34);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(599, 319);
            this.dgvReport.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 375);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFemale);
            this.Controls.Add(this.cbMale);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.CheckBox cbFemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbCity;
        private System.Windows.Forms.DataGridView dgvReport;
    }
}

