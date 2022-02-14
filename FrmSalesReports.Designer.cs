
namespace SalesApp
{
    partial class FrmSalesReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSearchSale = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdProduct = new System.Windows.Forms.RadioButton();
            this.rdDate = new System.Windows.Forms.RadioButton();
            this.rdSponsor = new System.Windows.Forms.RadioButton();
            this.rdCustomer = new System.Windows.Forms.RadioButton();
            this.customer_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSearchSale
            // 
            this.dgvSearchSale.AllowUserToAddRows = false;
            this.dgvSearchSale.AllowUserToDeleteRows = false;
            this.dgvSearchSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchSale.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvSearchSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_number,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.sale_date});
            this.dgvSearchSale.Location = new System.Drawing.Point(0, 183);
            this.dgvSearchSale.Name = "dgvSearchSale";
            this.dgvSearchSale.ReadOnly = true;
            this.dgvSearchSale.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSearchSale.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchSale.RowTemplate.Height = 30;
            this.dgvSearchSale.Size = new System.Drawing.Size(889, 298);
            this.dgvSearchSale.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "بحث :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(71, 123);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(582, 32);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtCstomerSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "من :";
            this.label2.Visible = false;
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(63, 123);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.RightToLeftLayout = true;
            this.dateFrom.Size = new System.Drawing.Size(263, 32);
            this.dateFrom.TabIndex = 25;
            this.dateFrom.Visible = false;
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(390, 123);
            this.dateTo.Name = "dateTo";
            this.dateTo.RightToLeftLayout = true;
            this.dateTo.Size = new System.Drawing.Size(263, 32);
            this.dateTo.TabIndex = 27;
            this.dateTo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "الى :";
            this.label3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SalesApp.Properties.Resources.data_analytics;
            this.pictureBox2.Location = new System.Drawing.Point(669, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::SalesApp.Properties.Resources.search;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rdProduct);
            this.groupBox1.Controls.Add(this.rdDate);
            this.groupBox1.Controls.Add(this.rdSponsor);
            this.groupBox1.Controls.Add(this.rdCustomer);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "    نوع البحث";
            // 
            // rdProduct
            // 
            this.rdProduct.AutoSize = true;
            this.rdProduct.Location = new System.Drawing.Point(161, 27);
            this.rdProduct.Name = "rdProduct";
            this.rdProduct.Size = new System.Drawing.Size(106, 28);
            this.rdProduct.TabIndex = 3;
            this.rdProduct.TabStop = true;
            this.rdProduct.Text = "اسم المنتج";
            this.rdProduct.UseVisualStyleBackColor = true;
            // 
            // rdDate
            // 
            this.rdDate.AutoSize = true;
            this.rdDate.Location = new System.Drawing.Point(22, 27);
            this.rdDate.Name = "rdDate";
            this.rdDate.Size = new System.Drawing.Size(79, 28);
            this.rdDate.TabIndex = 2;
            this.rdDate.TabStop = true;
            this.rdDate.Text = "التاريخ";
            this.rdDate.UseVisualStyleBackColor = true;
            this.rdDate.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdSponsor
            // 
            this.rdSponsor.AutoSize = true;
            this.rdSponsor.Location = new System.Drawing.Point(327, 27);
            this.rdSponsor.Name = "rdSponsor";
            this.rdSponsor.Size = new System.Drawing.Size(114, 28);
            this.rdSponsor.TabIndex = 1;
            this.rdSponsor.TabStop = true;
            this.rdSponsor.Text = "اسم الضامن";
            this.rdSponsor.UseVisualStyleBackColor = true;
            this.rdSponsor.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdCustomer
            // 
            this.rdCustomer.AutoSize = true;
            this.rdCustomer.Location = new System.Drawing.Point(501, 27);
            this.rdCustomer.Name = "rdCustomer";
            this.rdCustomer.Size = new System.Drawing.Size(109, 28);
            this.rdCustomer.TabIndex = 0;
            this.rdCustomer.TabStop = true;
            this.rdCustomer.Text = "اسم العميل";
            this.rdCustomer.UseVisualStyleBackColor = true;
            this.rdCustomer.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // customer_number
            // 
            this.customer_number.DataPropertyName = "customer_number";
            this.customer_number.HeaderText = "رقم العميل";
            this.customer_number.MinimumWidth = 6;
            this.customer_number.Name = "customer_number";
            this.customer_number.ReadOnly = true;
            this.customer_number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "customer_name";
            this.Column1.HeaderText = "اسم العميل";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "item_name";
            this.Column2.HeaderText = "اسم المنتج";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "item_price";
            this.Column3.HeaderText = "سعر المنتج";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "installment_number";
            this.Column5.HeaderText = "عدد الاقساط";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // sale_date
            // 
            this.sale_date.DataPropertyName = "sale_date";
            this.sale_date.HeaderText = "تاريخ البيع";
            this.sale_date.MinimumWidth = 6;
            this.sale_date.Name = "sale_date";
            this.sale_date.ReadOnly = true;
            // 
            // FrmSalesReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 481);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSearchSale);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSalesReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقاير مبيعات";
            this.Load += new System.EventHandler(this.SalesReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearchSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDate;
        private System.Windows.Forms.RadioButton rdSponsor;
        private System.Windows.Forms.RadioButton rdCustomer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_date;
    }
}