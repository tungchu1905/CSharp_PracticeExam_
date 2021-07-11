
namespace Summer_2020_B5_DO
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbook = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.listAuthor = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pRN292_Sum2020_B5DataSet = new Summer_2020_B5_DO.PRN292_Sum2020_B5DataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Summer_2020_B5_DO.PRN292_Sum2020_B5DataSetTableAdapters.BooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_Sum2020_B5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Authors";
            // 
            // cbbook
            // 
            this.cbbook.FormattingEnabled = true;
            this.cbbook.Location = new System.Drawing.Point(151, 36);
            this.cbbook.Name = "cbbook";
            this.cbbook.Size = new System.Drawing.Size(215, 21);
            this.cbbook.TabIndex = 3;
            this.cbbook.SelectedIndexChanged += new System.EventHandler(this.cbbook_SelectedIndexChanged);
            this.cbbook.SelectionChangeCommitted += new System.EventHandler(this.cbbook_SelectionChangeCommitted);
            this.cbbook.DropDownStyleChanged += new System.EventHandler(this.cbbook_DropDownStyleChanged);
            this.cbbook.SelectedValueChanged += new System.EventHandler(this.cbbook_SelectedValueChanged);
            this.cbbook.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cbbook_MouseDoubleClick);
            this.cbbook.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbbook_MouseDown);
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(151, 75);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(215, 21);
            this.cbYear.TabIndex = 4;
            // 
            // listAuthor
            // 
            this.listAuthor.FormattingEnabled = true;
            this.listAuthor.Location = new System.Drawing.Point(151, 135);
            this.listAuthor.Name = "listAuthor";
            this.listAuthor.Size = new System.Drawing.Size(215, 186);
            this.listAuthor.TabIndex = 5;
            this.listAuthor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listAuthor_MouseDown);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(151, 351);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(215, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove Selected Author";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pRN292_Sum2020_B5DataSet
            // 
            this.pRN292_Sum2020_B5DataSet.DataSetName = "PRN292_Sum2020_B5DataSet";
            this.pRN292_Sum2020_B5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.pRN292_Sum2020_B5DataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 395);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listAuthor);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbbook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_Sum2020_B5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbook;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ListBox listAuthor;
        private System.Windows.Forms.Button btnRemove;
        private PRN292_Sum2020_B5DataSet pRN292_Sum2020_B5DataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private PRN292_Sum2020_B5DataSetTableAdapters.BooksTableAdapter booksTableAdapter;
    }
}

