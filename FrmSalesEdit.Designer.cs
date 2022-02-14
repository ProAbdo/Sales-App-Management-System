namespace SalesApp
{
    partial class FrmSalesEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dgvSearch = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdstate = new System.Windows.Forms.RadioButton();
            this.rdProduct = new System.Windows.Forms.RadioButton();
            this.rdDate = new System.Windows.Forms.RadioButton();
            this.rdSponsor = new System.Windows.Forms.RadioButton();
            this.rdCustomer = new System.Windows.Forms.RadioButton();
            this.customer_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstpay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_installment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.after_profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installment_per_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installment_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تعديل = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(68, 128);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(834, 27);
            this.txtSearch.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "الى :";
            this.label3.Visible = false;
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(68, 128);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.RightToLeftLayout = true;
            this.dateFrom.Size = new System.Drawing.Size(263, 27);
            this.dateFrom.TabIndex = 50;
            this.dateFrom.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "من :";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "بحث :";
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(387, 128);
            this.dateTo.Name = "dateTo";
            this.dateTo.RightToLeftLayout = true;
            this.dateTo.Size = new System.Drawing.Size(263, 27);
            this.dateTo.TabIndex = 52;
            this.dateTo.Visible = false;
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowCustomTheming = false;
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearch.ColumnHeadersHeight = 40;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_number,
            this.item_number,
            this.customer_name,
            this.item_name,
            this.item_price,
            this.firstpay,
            this.total_installment,
            this.profit,
            this.after_profit,
            this.installment_per_m,
            this.Column17,
            this.installment_number,
            this.تعديل});
            this.dgvSearch.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvSearch.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSearch.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSearch.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvSearch.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSearch.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvSearch.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvSearch.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSearch.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvSearch.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSearch.CurrentTheme.Name = null;
            this.dgvSearch.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSearch.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSearch.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSearch.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvSearch.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSearch.EnableHeadersVisualStyles = false;
            this.dgvSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvSearch.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSearch.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvSearch.HeaderForeColor = System.Drawing.Color.White;
            this.dgvSearch.Location = new System.Drawing.Point(0, 191);
            this.dgvSearch.Name = "dgvSearch";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSearch.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSearch.RowTemplate.Height = 40;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(1262, 449);
            this.dgvSearch.TabIndex = 55;
            this.dgvSearch.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentClick);
            this.dgvSearch.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SalesApp.Properties.Resources.cheque1;
            this.pictureBox2.Location = new System.Drawing.Point(965, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::SalesApp.Properties.Resources.search;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rdstate);
            this.groupBox1.Controls.Add(this.rdProduct);
            this.groupBox1.Controls.Add(this.rdDate);
            this.groupBox1.Controls.Add(this.rdSponsor);
            this.groupBox1.Controls.Add(this.rdCustomer);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 83);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "    نوع البحث";
            // 
            // rdstate
            // 
            this.rdstate.AutoSize = true;
            this.rdstate.Location = new System.Drawing.Point(123, 30);
            this.rdstate.Name = "rdstate";
            this.rdstate.Size = new System.Drawing.Size(61, 23);
            this.rdstate.TabIndex = 4;
            this.rdstate.TabStop = true;
            this.rdstate.Text = "الحالة";
            this.rdstate.UseVisualStyleBackColor = true;
            // 
            // rdProduct
            // 
            this.rdProduct.AutoSize = true;
            this.rdProduct.Location = new System.Drawing.Point(373, 30);
            this.rdProduct.Name = "rdProduct";
            this.rdProduct.Size = new System.Drawing.Size(88, 23);
            this.rdProduct.TabIndex = 3;
            this.rdProduct.TabStop = true;
            this.rdProduct.Text = "اسم المنتج";
            this.rdProduct.UseVisualStyleBackColor = true;
            // 
            // rdDate
            // 
            this.rdDate.AutoSize = true;
            this.rdDate.Location = new System.Drawing.Point(248, 30);
            this.rdDate.Name = "rdDate";
            this.rdDate.Size = new System.Drawing.Size(66, 23);
            this.rdDate.TabIndex = 2;
            this.rdDate.TabStop = true;
            this.rdDate.Text = "التاريخ";
            this.rdDate.UseVisualStyleBackColor = true;
            // 
            // rdSponsor
            // 
            this.rdSponsor.AutoSize = true;
            this.rdSponsor.Location = new System.Drawing.Point(520, 30);
            this.rdSponsor.Name = "rdSponsor";
            this.rdSponsor.Size = new System.Drawing.Size(94, 23);
            this.rdSponsor.TabIndex = 1;
            this.rdSponsor.TabStop = true;
            this.rdSponsor.Text = "اسم الضامن";
            this.rdSponsor.UseVisualStyleBackColor = true;
            // 
            // rdCustomer
            // 
            this.rdCustomer.AutoSize = true;
            this.rdCustomer.Location = new System.Drawing.Point(673, 30);
            this.rdCustomer.Name = "rdCustomer";
            this.rdCustomer.Size = new System.Drawing.Size(89, 23);
            this.rdCustomer.TabIndex = 0;
            this.rdCustomer.TabStop = true;
            this.rdCustomer.Text = "اسم العميل";
            this.rdCustomer.UseVisualStyleBackColor = true;
            // 
            // customer_number
            // 
            this.customer_number.DataPropertyName = "customer_number";
            this.customer_number.HeaderText = "رقم العميل";
            this.customer_number.Name = "customer_number";
            this.customer_number.ReadOnly = true;
            this.customer_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.customer_number.Visible = false;
            // 
            // item_number
            // 
            this.item_number.DataPropertyName = "item_number";
            this.item_number.HeaderText = "رقم المنتج";
            this.item_number.Name = "item_number";
            this.item_number.ReadOnly = true;
            this.item_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_number.Visible = false;
            // 
            // customer_name
            // 
            this.customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "اسم العميل";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            this.customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.customer_name.Width = 106;
            // 
            // item_name
            // 
            this.item_name.DataPropertyName = "item_name";
            this.item_name.HeaderText = "اسم المنتج";
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            this.item_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // item_price
            // 
            this.item_price.DataPropertyName = "item_price";
            this.item_price.HeaderText = "سعر المنتج";
            this.item_price.Name = "item_price";
            this.item_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // firstpay
            // 
            this.firstpay.DataPropertyName = "firstpay";
            this.firstpay.HeaderText = "دفعة اولى";
            this.firstpay.Name = "firstpay";
            this.firstpay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // total_installment
            // 
            this.total_installment.DataPropertyName = "total_installment";
            this.total_installment.HeaderText = "المبلغ المقسط";
            this.total_installment.Name = "total_installment";
            this.total_installment.ReadOnly = true;
            this.total_installment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // profit
            // 
            this.profit.DataPropertyName = "profit";
            this.profit.HeaderText = "المبلغ المضاف";
            this.profit.Name = "profit";
            this.profit.ReadOnly = true;
            this.profit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // after_profit
            // 
            this.after_profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.after_profit.DataPropertyName = "after_profit";
            this.after_profit.HeaderText = "اجمالى المبلغ بعد الربح ";
            this.after_profit.Name = "after_profit";
            this.after_profit.ReadOnly = true;
            this.after_profit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.after_profit.Width = 182;
            // 
            // installment_per_m
            // 
            this.installment_per_m.DataPropertyName = "installment_per_m";
            this.installment_per_m.HeaderText = "قيمة القسط";
            this.installment_per_m.Name = "installment_per_m";
            this.installment_per_m.ReadOnly = true;
            this.installment_per_m.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column17
            // 
            this.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column17.DataPropertyName = "sale_date";
            this.Column17.HeaderText = "تاريخ البيع";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column17.Width = 96;
            // 
            // installment_number
            // 
            this.installment_number.DataPropertyName = "installment_number";
            this.installment_number.HeaderText = "عدد الاقساط";
            this.installment_number.Name = "installment_number";
            this.installment_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // تعديل
            // 
            this.تعديل.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.تعديل.HeaderText = "";
            this.تعديل.Name = "تعديل";
            this.تعديل.Text = "تعديل";
            this.تعديل.UseColumnTextForButtonValue = true;
            // 
            // FrmSalesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 640);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTo);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSalesEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات بيع";
            this.Load += new System.EventHandler(this.FrmSalesEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdstate;
        private System.Windows.Forms.RadioButton rdProduct;
        private System.Windows.Forms.RadioButton rdDate;
        private System.Windows.Forms.RadioButton rdCustomer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdSponsor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTo;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstpay;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_installment;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn after_profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn installment_per_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn installment_number;
        private System.Windows.Forms.DataGridViewButtonColumn تعديل;
    }
}