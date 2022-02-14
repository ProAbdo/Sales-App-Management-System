
namespace SalesApp
{
    partial class FrmInstallmentReport
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
            this.dgvInstallmentReport = new System.Windows.Forms.DataGridView();
            this.customer_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstpay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_installment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installment_per_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rest_pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installment_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الحالة = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تفاصيل = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdState = new System.Windows.Forms.RadioButton();
            this.rdInstallment = new System.Windows.Forms.RadioButton();
            this.rdProduct = new System.Windows.Forms.RadioButton();
            this.rdDate = new System.Windows.Forms.RadioButton();
            this.rdSponsor = new System.Windows.Forms.RadioButton();
            this.rdCustomer = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallmentReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInstallmentReport
            // 
            this.dgvInstallmentReport.AllowUserToAddRows = false;
            this.dgvInstallmentReport.AllowUserToDeleteRows = false;
            this.dgvInstallmentReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInstallmentReport.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvInstallmentReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstallmentReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInstallmentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstallmentReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_number,
            this.item_number,
            this.customer_name,
            this.item_name,
            this.item_price,
            this.firstpay,
            this.total_installment,
            this.profit,
            this.installment_per_m,
            this.rest_pay,
            this.installment_number,
            this.sale_date,
            this.الحالة,
            this.تفاصيل});
            this.dgvInstallmentReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInstallmentReport.Location = new System.Drawing.Point(0, 241);
            this.dgvInstallmentReport.Name = "dgvInstallmentReport";
            this.dgvInstallmentReport.ReadOnly = true;
            this.dgvInstallmentReport.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInstallmentReport.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInstallmentReport.RowTemplate.Height = 35;
            this.dgvInstallmentReport.Size = new System.Drawing.Size(1431, 552);
            this.dgvInstallmentReport.TabIndex = 5;
            this.dgvInstallmentReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstallmentReport_CellContentClick);
            this.dgvInstallmentReport.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInstallmentReport_CellFormatting);
            // 
            // customer_number
            // 
            this.customer_number.DataPropertyName = "customer_number";
            this.customer_number.FillWeight = 96.74688F;
            this.customer_number.HeaderText = "رقم العميل";
            this.customer_number.MinimumWidth = 6;
            this.customer_number.Name = "customer_number";
            this.customer_number.ReadOnly = true;
            this.customer_number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // item_number
            // 
            this.item_number.DataPropertyName = "item_number";
            this.item_number.FillWeight = 96.74688F;
            this.item_number.HeaderText = "رقم المنتج";
            this.item_number.MinimumWidth = 6;
            this.item_number.Name = "item_number";
            this.item_number.ReadOnly = true;
            // 
            // customer_name
            // 
            this.customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.FillWeight = 139.0374F;
            this.customer_name.HeaderText = "اسم العميل";
            this.customer_name.MinimumWidth = 6;
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            this.customer_name.Width = 96;
            // 
            // item_name
            // 
            this.item_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.item_name.DataPropertyName = "item_name";
            this.item_name.FillWeight = 96.74688F;
            this.item_name.HeaderText = "اسم المنتج";
            this.item_name.MinimumWidth = 6;
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            this.item_name.Width = 95;
            // 
            // item_price
            // 
            this.item_price.DataPropertyName = "item_price";
            this.item_price.FillWeight = 96.74688F;
            this.item_price.HeaderText = "سعر المنتج";
            this.item_price.MinimumWidth = 6;
            this.item_price.Name = "item_price";
            this.item_price.ReadOnly = true;
            // 
            // firstpay
            // 
            this.firstpay.DataPropertyName = "firstpay";
            this.firstpay.FillWeight = 96.74688F;
            this.firstpay.HeaderText = "دفعة اولى";
            this.firstpay.MinimumWidth = 6;
            this.firstpay.Name = "firstpay";
            this.firstpay.ReadOnly = true;
            // 
            // total_installment
            // 
            this.total_installment.DataPropertyName = "total_installment";
            this.total_installment.FillWeight = 96.74688F;
            this.total_installment.HeaderText = "المبلغ المقسط";
            this.total_installment.MinimumWidth = 6;
            this.total_installment.Name = "total_installment";
            this.total_installment.ReadOnly = true;
            // 
            // profit
            // 
            this.profit.DataPropertyName = "profit";
            this.profit.FillWeight = 96.74688F;
            this.profit.HeaderText = "الفائدة المستحقة";
            this.profit.MinimumWidth = 6;
            this.profit.Name = "profit";
            this.profit.ReadOnly = true;
            // 
            // installment_per_m
            // 
            this.installment_per_m.DataPropertyName = "installment_per_m";
            this.installment_per_m.FillWeight = 96.74688F;
            this.installment_per_m.HeaderText = "قيمة القسط";
            this.installment_per_m.MinimumWidth = 6;
            this.installment_per_m.Name = "installment_per_m";
            this.installment_per_m.ReadOnly = true;
            // 
            // rest_pay
            // 
            this.rest_pay.DataPropertyName = "rest_pay";
            this.rest_pay.FillWeight = 96.74688F;
            this.rest_pay.HeaderText = "المتبقى للسداد";
            this.rest_pay.MinimumWidth = 6;
            this.rest_pay.Name = "rest_pay";
            this.rest_pay.ReadOnly = true;
            // 
            // installment_number
            // 
            this.installment_number.DataPropertyName = "installment_number";
            this.installment_number.FillWeight = 96.74688F;
            this.installment_number.HeaderText = "عدد الاقساط";
            this.installment_number.MinimumWidth = 6;
            this.installment_number.Name = "installment_number";
            this.installment_number.ReadOnly = true;
            // 
            // sale_date
            // 
            this.sale_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sale_date.DataPropertyName = "sale_date";
            this.sale_date.FillWeight = 96.74688F;
            this.sale_date.HeaderText = "تاريخ البيع";
            this.sale_date.MinimumWidth = 6;
            this.sale_date.Name = "sale_date";
            this.sale_date.ReadOnly = true;
            this.sale_date.Width = 87;
            // 
            // الحالة
            // 
            this.الحالة.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.الحالة.DataPropertyName = "state";
            this.الحالة.FillWeight = 96.74688F;
            this.الحالة.HeaderText = "الحالة";
            this.الحالة.MinimumWidth = 6;
            this.الحالة.Name = "الحالة";
            this.الحالة.ReadOnly = true;
            this.الحالة.Width = 68;
            // 
            // تفاصيل
            // 
            this.تفاصيل.HeaderText = "";
            this.تفاصيل.MinimumWidth = 6;
            this.تفاصيل.Name = "تفاصيل";
            this.تفاصيل.ReadOnly = true;
            this.تفاصيل.Text = "تفاصيل";
            this.تفاصيل.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "بحث :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(87, 166);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(785, 27);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "الى :";
            this.label3.Visible = false;
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(71, 166);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.RightToLeftLayout = true;
            this.dateFrom.Size = new System.Drawing.Size(363, 27);
            this.dateFrom.TabIndex = 29;
            this.dateFrom.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "من :";
            this.label2.Visible = false;
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(509, 166);
            this.dateTo.Name = "dateTo";
            this.dateTo.RightToLeftLayout = true;
            this.dateTo.Size = new System.Drawing.Size(363, 27);
            this.dateTo.TabIndex = 31;
            this.dateTo.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SalesApp.Properties.Resources.report;
            this.pictureBox2.Location = new System.Drawing.Point(1123, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(277, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::SalesApp.Properties.Resources.search;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rdState);
            this.groupBox1.Controls.Add(this.rdInstallment);
            this.groupBox1.Controls.Add(this.rdProduct);
            this.groupBox1.Controls.Add(this.rdDate);
            this.groupBox1.Controls.Add(this.rdSponsor);
            this.groupBox1.Controls.Add(this.rdCustomer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "    نوع البحث";
            // 
            // rdState
            // 
            this.rdState.AutoSize = true;
            this.rdState.Location = new System.Drawing.Point(154, 60);
            this.rdState.Name = "rdState";
            this.rdState.Size = new System.Drawing.Size(61, 23);
            this.rdState.TabIndex = 5;
            this.rdState.TabStop = true;
            this.rdState.Text = "الحالة";
            this.rdState.UseVisualStyleBackColor = true;
            // 
            // rdInstallment
            // 
            this.rdInstallment.AutoSize = true;
            this.rdInstallment.Location = new System.Drawing.Point(260, 60);
            this.rdInstallment.Name = "rdInstallment";
            this.rdInstallment.Size = new System.Drawing.Size(104, 23);
            this.rdInstallment.TabIndex = 4;
            this.rdInstallment.TabStop = true;
            this.rdInstallment.Text = " عدد الاقساط";
            this.rdInstallment.UseVisualStyleBackColor = true;
            // 
            // rdProduct
            // 
            this.rdProduct.AutoSize = true;
            this.rdProduct.Location = new System.Drawing.Point(422, 60);
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
            this.rdDate.Location = new System.Drawing.Point(41, 60);
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
            this.rdSponsor.Location = new System.Drawing.Point(562, 60);
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
            this.rdCustomer.Location = new System.Drawing.Point(710, 60);
            this.rdCustomer.Name = "rdCustomer";
            this.rdCustomer.Size = new System.Drawing.Size(89, 23);
            this.rdCustomer.TabIndex = 0;
            this.rdCustomer.TabStop = true;
            this.rdCustomer.Text = "اسم العميل";
            this.rdCustomer.UseVisualStyleBackColor = true;
            // 
            // FrmInstallmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1431, 793);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvInstallmentReport);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInstallmentReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الاقساط";
            this.Load += new System.EventHandler(this.FrmInstallmentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallmentReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdProduct;
        private System.Windows.Forms.RadioButton rdDate;
        private System.Windows.Forms.RadioButton rdSponsor;
        private System.Windows.Forms.RadioButton rdCustomer;
        private System.Windows.Forms.DataGridView dgvInstallmentReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rdState;
        private System.Windows.Forms.RadioButton rdInstallment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstpay;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_installment;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn installment_per_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn rest_pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn installment_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn الحالة;
        private System.Windows.Forms.DataGridViewButtonColumn تفاصيل;
    }
}