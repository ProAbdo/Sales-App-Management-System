namespace SalesApp
{
    partial class FrmEditInstallmentDetailed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEditInstallment = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dgvInfoPay = new System.Windows.Forms.DataGridView();
            this.customer_number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.رقم_القسط = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تعديلات = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.اجمالى_المدفوع = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الحالة = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.التعديلات = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditInstallment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoPay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEditInstallment
            // 
            this.dgvEditInstallment.AllowCustomTheming = false;
            this.dgvEditInstallment.AllowUserToAddRows = false;
            this.dgvEditInstallment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvEditInstallment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEditInstallment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEditInstallment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEditInstallment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEditInstallment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditInstallment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEditInstallment.ColumnHeadersHeight = 40;
            this.dgvEditInstallment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.رقم_القسط,
            this.Column1,
            this.Column2,
            this.Column4,
            this.تعديلات,
            this.اجمالى_المدفوع,
            this.الحالة,
            this.التعديلات});
            this.dgvEditInstallment.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvEditInstallment.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEditInstallment.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEditInstallment.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEditInstallment.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEditInstallment.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvEditInstallment.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEditInstallment.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEditInstallment.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvEditInstallment.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEditInstallment.CurrentTheme.Name = null;
            this.dgvEditInstallment.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEditInstallment.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEditInstallment.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEditInstallment.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEditInstallment.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditInstallment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEditInstallment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEditInstallment.EnableHeadersVisualStyles = false;
            this.dgvEditInstallment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEditInstallment.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEditInstallment.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEditInstallment.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEditInstallment.Location = new System.Drawing.Point(0, 204);
            this.dgvEditInstallment.Name = "dgvEditInstallment";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditInstallment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEditInstallment.RowHeadersVisible = false;
            this.dgvEditInstallment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEditInstallment.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEditInstallment.RowTemplate.Height = 40;
            this.dgvEditInstallment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditInstallment.Size = new System.Drawing.Size(972, 366);
            this.dgvEditInstallment.TabIndex = 66;
            this.dgvEditInstallment.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvEditInstallment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditInstallment_CellContentClick);
            this.dgvEditInstallment.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEditInstallment_CellFormatting);
            // 
            // dgvInfoPay
            // 
            this.dgvInfoPay.AllowUserToAddRows = false;
            this.dgvInfoPay.AllowUserToDeleteRows = false;
            this.dgvInfoPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoPay.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfoPay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInfoPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_number1,
            this.item_number1,
            this.customer_name,
            this.Column7,
            this.dataGridViewTextBoxColumn1,
            this.Column8,
            this.dataGridViewTextBoxColumn2});
            this.dgvInfoPay.EnableHeadersVisualStyles = false;
            this.dgvInfoPay.Location = new System.Drawing.Point(94, 41);
            this.dgvInfoPay.Name = "dgvInfoPay";
            this.dgvInfoPay.ReadOnly = true;
            this.dgvInfoPay.RowHeadersVisible = false;
            this.dgvInfoPay.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInfoPay.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInfoPay.RowTemplate.Height = 35;
            this.dgvInfoPay.Size = new System.Drawing.Size(695, 61);
            this.dgvInfoPay.TabIndex = 67;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "item_price";
            this.dataGridViewTextBoxColumn1.HeaderText = "سعر المنتج";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "rest_pay";
            this.dataGridViewTextBoxColumn2.HeaderText = "المبلغ المتبقى للسداد";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 14);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(695, 27);
            this.txtName.TabIndex = 68;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // رقم_القسط
            // 
            this.رقم_القسط.DataPropertyName = "installment_num";
            this.رقم_القسط.HeaderText = "رقم القسط";
            this.رقم_القسط.Name = "رقم_القسط";
            this.رقم_القسط.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "installment_date";
            this.Column1.HeaderText = "تاريخ الاستحقاق";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "pay_date";
            this.Column2.HeaderText = "تاريخ السداد";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "paid";
            this.Column4.HeaderText = "دفعة اولى";
            this.Column4.Name = "Column4";
            // 
            // تعديلات
            // 
            this.تعديلات.DataPropertyName = "cnt_paid";
            this.تعديلات.HeaderText = "تعديلات";
            this.تعديلات.Name = "تعديلات";
            // 
            // اجمالى_المدفوع
            // 
            this.اجمالى_المدفوع.DataPropertyName = "total_paid";
            this.اجمالى_المدفوع.HeaderText = "اجمالى المدفوع";
            this.اجمالى_المدفوع.Name = "اجمالى_المدفوع";
            // 
            // الحالة
            // 
            this.الحالة.DataPropertyName = "is_paid";
            this.الحالة.HeaderText = "الحالة";
            this.الحالة.Name = "الحالة";
            this.الحالة.ReadOnly = true;
            // 
            // التعديلات
            // 
            this.التعديلات.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.التعديلات.HeaderText = "";
            this.التعديلات.Name = "التعديلات";
            this.التعديلات.Text = "التعديلات";
            this.التعديلات.UseColumnTextForButtonValue = true;
            // 
            // FrmEditInstallmentDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 570);
            this.Controls.Add(this.dgvInfoPay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvEditInstallment);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditInstallmentDetailed";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditInstallmentDetailed";
            this.Load += new System.EventHandler(this.FrmEditInstallmentDetailed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditInstallment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvEditInstallment;
        private System.Windows.Forms.DataGridView dgvInfoPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_number1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_number1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn رقم_القسط;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn تعديلات;
        private System.Windows.Forms.DataGridViewTextBoxColumn اجمالى_المدفوع;
        private System.Windows.Forms.DataGridViewTextBoxColumn الحالة;
        private System.Windows.Forms.DataGridViewButtonColumn التعديلات;
    }
}