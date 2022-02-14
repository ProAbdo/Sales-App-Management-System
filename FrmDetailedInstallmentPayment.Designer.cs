
namespace SalesApp
{
    partial class FrmDetailedInstallmentPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPayInstallment = new System.Windows.Forms.DataGridView();
            this.customer_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installment_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الحالة = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.سداد = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvInfoPay = new System.Windows.Forms.DataGridView();
            this.customer_number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayInstallment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoPay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPayInstallment
            // 
            this.dgvPayInstallment.AllowUserToAddRows = false;
            this.dgvPayInstallment.AllowUserToDeleteRows = false;
            this.dgvPayInstallment.AllowUserToResizeColumns = false;
            this.dgvPayInstallment.AllowUserToResizeRows = false;
            this.dgvPayInstallment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayInstallment.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPayInstallment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayInstallment.ColumnHeadersHeight = 40;
            this.dgvPayInstallment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_number,
            this.item_number,
            this.installment_num,
            this.Column3,
            this.Column4,
            this.paid,
            this.الحالة,
            this.سداد});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayInstallment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayInstallment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPayInstallment.EnableHeadersVisualStyles = false;
            this.dgvPayInstallment.Location = new System.Drawing.Point(0, 156);
            this.dgvPayInstallment.Name = "dgvPayInstallment";
            this.dgvPayInstallment.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPayInstallment.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayInstallment.RowTemplate.Height = 35;
            this.dgvPayInstallment.Size = new System.Drawing.Size(737, 412);
            this.dgvPayInstallment.TabIndex = 9;
            this.dgvPayInstallment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayInstallment_CellContentClick);
            this.dgvPayInstallment.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPayInstallment_CellFormatting);
            this.dgvPayInstallment.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPayInstallment_EditingControlShowing);
            // 
            // customer_number
            // 
            this.customer_number.DataPropertyName = "customer_number";
            this.customer_number.FillWeight = 96.74688F;
            this.customer_number.HeaderText = "رقم العميل";
            this.customer_number.MinimumWidth = 6;
            this.customer_number.Name = "customer_number";
            this.customer_number.ReadOnly = true;
            this.customer_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.customer_number.Visible = false;
            // 
            // item_number
            // 
            this.item_number.DataPropertyName = "item_number";
            this.item_number.FillWeight = 96.74688F;
            this.item_number.HeaderText = "رقم المنتج";
            this.item_number.MinimumWidth = 6;
            this.item_number.Name = "item_number";
            this.item_number.ReadOnly = true;
            this.item_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_number.Visible = false;
            // 
            // installment_num
            // 
            this.installment_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.installment_num.DataPropertyName = "installment_num";
            this.installment_num.HeaderText = "رقم القسط";
            this.installment_num.MinimumWidth = 6;
            this.installment_num.Name = "installment_num";
            this.installment_num.ReadOnly = true;
            this.installment_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.installment_num.Width = 77;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "installment_date";
            this.Column3.HeaderText = "تاريخ الاستحقاق";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.DataPropertyName = "pay_date";
            this.Column4.HeaderText = "تاريخ السداد";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 86;
            // 
            // paid
            // 
            this.paid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paid.DataPropertyName = "paid";
            this.paid.HeaderText = "المدفوع";
            this.paid.MinimumWidth = 6;
            this.paid.Name = "paid";
            this.paid.ReadOnly = true;
            this.paid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // الحالة
            // 
            this.الحالة.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.الحالة.DataPropertyName = "is_paid";
            this.الحالة.HeaderText = "الحالة";
            this.الحالة.MinimumWidth = 6;
            this.الحالة.Name = "الحالة";
            this.الحالة.ReadOnly = true;
            this.الحالة.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.الحالة.Width = 49;
            // 
            // سداد
            // 
            this.سداد.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.سداد.DefaultCellStyle = dataGridViewCellStyle2;
            this.سداد.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.سداد.HeaderText = "";
            this.سداد.MinimumWidth = 6;
            this.سداد.Name = "سداد";
            this.سداد.Text = "سداد القسط";
            this.سداد.UseColumnTextForButtonValue = true;
            this.سداد.Width = 6;
            // 
            // dgvInfoPay
            // 
            this.dgvInfoPay.AllowUserToAddRows = false;
            this.dgvInfoPay.AllowUserToDeleteRows = false;
            this.dgvInfoPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoPay.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfoPay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInfoPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_number1,
            this.item_number1,
            this.customer_name,
            this.Column7,
            this.Column2,
            this.Column8,
            this.Column1});
            this.dgvInfoPay.EnableHeadersVisualStyles = false;
            this.dgvInfoPay.Location = new System.Drawing.Point(21, 42);
            this.dgvInfoPay.Name = "dgvInfoPay";
            this.dgvInfoPay.ReadOnly = true;
            this.dgvInfoPay.RowHeadersVisible = false;
            this.dgvInfoPay.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInfoPay.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInfoPay.RowTemplate.Height = 35;
            this.dgvInfoPay.Size = new System.Drawing.Size(695, 61);
            this.dgvInfoPay.TabIndex = 10;
            // 
            // customer_number1
            // 
            this.customer_number1.DataPropertyName = "customer_number";
            this.customer_number1.HeaderText = "رقم العميل";
            this.customer_number1.MinimumWidth = 6;
            this.customer_number1.Name = "customer_number1";
            this.customer_number1.ReadOnly = true;
            this.customer_number1.Visible = false;
            // 
            // item_number1
            // 
            this.item_number1.DataPropertyName = "item_number";
            this.item_number1.HeaderText = "رقم المنتج";
            this.item_number1.MinimumWidth = 6;
            this.item_number1.Name = "item_number1";
            this.item_number1.ReadOnly = true;
            this.item_number1.Visible = false;
            // 
            // customer_name
            // 
            this.customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "اسم العميل";
            this.customer_name.MinimumWidth = 6;
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            this.customer_name.Visible = false;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "item_name";
            this.Column7.HeaderText = "اسم المنتج";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "item_price";
            this.Column2.HeaderText = "سعر المنتج";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "installment_per_m";
            this.Column8.HeaderText = "قيمة القسط";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "rest_pay";
            this.Column1.HeaderText = "المبلغ المتبقى للسداد";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(21, 15);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(695, 27);
            this.txtName.TabIndex = 11;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmDetailedInstallmentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 568);
            this.Controls.Add(this.dgvPayInstallment);
            this.Controls.Add(this.dgvInfoPay);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDetailedInstallmentPayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سداد قسط";
            this.Load += new System.EventHandler(this.FrmDetailedInstallmentPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayInstallment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPayInstallment;
        private System.Windows.Forms.DataGridView dgvInfoPay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn installment_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn الحالة;
        private System.Windows.Forms.DataGridViewButtonColumn سداد;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_number1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_number1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}