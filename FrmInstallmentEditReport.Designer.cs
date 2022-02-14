namespace SalesApp
{
    partial class FrmInstallmentEditReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEditInstallment = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.رقم_التعديل = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.المبلغ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.التاريخ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEditInstallmentInfo = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.اسم_العميل = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.اسم_المنتج = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.سعر_المنتج = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.رقم_القسط = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.عدد_التعديلات = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditInstallment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditInstallmentInfo)).BeginInit();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditInstallment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEditInstallment.ColumnHeadersHeight = 40;
            this.dgvEditInstallment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.رقم_التعديل,
            this.المبلغ,
            this.التاريخ});
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvEditInstallment.Location = new System.Drawing.Point(0, 220);
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
            this.dgvEditInstallment.Size = new System.Drawing.Size(952, 366);
            this.dgvEditInstallment.TabIndex = 67;
            this.dgvEditInstallment.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // رقم_التعديل
            // 
            this.رقم_التعديل.DataPropertyName = "edit_installment";
            this.رقم_التعديل.HeaderText = "رقم التعديل";
            this.رقم_التعديل.Name = "رقم_التعديل";
            // 
            // المبلغ
            // 
            this.المبلغ.DataPropertyName = "paid";
            this.المبلغ.HeaderText = "المبلغ";
            this.المبلغ.Name = "المبلغ";
            // 
            // التاريخ
            // 
            this.التاريخ.DataPropertyName = "edit_installment_date";
            this.التاريخ.HeaderText = "التاريخ";
            this.التاريخ.Name = "التاريخ";
            // 
            // dgvEditInstallmentInfo
            // 
            this.dgvEditInstallmentInfo.AllowCustomTheming = false;
            this.dgvEditInstallmentInfo.AllowUserToAddRows = false;
            this.dgvEditInstallmentInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvEditInstallmentInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEditInstallmentInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEditInstallmentInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEditInstallmentInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEditInstallmentInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditInstallmentInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEditInstallmentInfo.ColumnHeadersHeight = 40;
            this.dgvEditInstallmentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.اسم_العميل,
            this.اسم_المنتج,
            this.سعر_المنتج,
            this.رقم_القسط,
            this.عدد_التعديلات});
            this.dgvEditInstallmentInfo.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvEditInstallmentInfo.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEditInstallmentInfo.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEditInstallmentInfo.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEditInstallmentInfo.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEditInstallmentInfo.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvEditInstallmentInfo.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEditInstallmentInfo.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEditInstallmentInfo.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvEditInstallmentInfo.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEditInstallmentInfo.CurrentTheme.Name = null;
            this.dgvEditInstallmentInfo.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEditInstallmentInfo.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEditInstallmentInfo.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEditInstallmentInfo.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEditInstallmentInfo.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditInstallmentInfo.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEditInstallmentInfo.EnableHeadersVisualStyles = false;
            this.dgvEditInstallmentInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEditInstallmentInfo.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEditInstallmentInfo.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEditInstallmentInfo.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEditInstallmentInfo.Location = new System.Drawing.Point(104, 50);
            this.dgvEditInstallmentInfo.Name = "dgvEditInstallmentInfo";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditInstallmentInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEditInstallmentInfo.RowHeadersVisible = false;
            this.dgvEditInstallmentInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEditInstallmentInfo.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEditInstallmentInfo.RowTemplate.Height = 40;
            this.dgvEditInstallmentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditInstallmentInfo.Size = new System.Drawing.Size(772, 80);
            this.dgvEditInstallmentInfo.TabIndex = 68;
            this.dgvEditInstallmentInfo.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 24);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(772, 27);
            this.txtName.TabIndex = 69;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // اسم_العميل
            // 
            this.اسم_العميل.DataPropertyName = "customer_name";
            this.اسم_العميل.HeaderText = "اسم العميل";
            this.اسم_العميل.Name = "اسم_العميل";
            this.اسم_العميل.ReadOnly = true;
            this.اسم_العميل.Visible = false;
            // 
            // اسم_المنتج
            // 
            this.اسم_المنتج.DataPropertyName = "item_name";
            this.اسم_المنتج.HeaderText = "اسم المنتج";
            this.اسم_المنتج.Name = "اسم_المنتج";
            this.اسم_المنتج.ReadOnly = true;
            // 
            // سعر_المنتج
            // 
            this.سعر_المنتج.DataPropertyName = "item_price";
            this.سعر_المنتج.HeaderText = "سعر المنتج";
            this.سعر_المنتج.Name = "سعر_المنتج";
            this.سعر_المنتج.ReadOnly = true;
            // 
            // رقم_القسط
            // 
            this.رقم_القسط.DataPropertyName = "installment_num";
            this.رقم_القسط.HeaderText = "رقم القسط";
            this.رقم_القسط.Name = "رقم_القسط";
            this.رقم_القسط.ReadOnly = true;
            // 
            // عدد_التعديلات
            // 
            this.عدد_التعديلات.DataPropertyName = "cnt";
            this.عدد_التعديلات.HeaderText = "عدد التعديلات";
            this.عدد_التعديلات.Name = "عدد_التعديلات";
            this.عدد_التعديلات.ReadOnly = true;
            // 
            // FrmInstallmentEditReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 586);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvEditInstallmentInfo);
            this.Controls.Add(this.dgvEditInstallment);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmInstallmentEditReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInstallmentEditReport";
            this.Load += new System.EventHandler(this.FrmInstallmentEditReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditInstallment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditInstallmentInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvEditInstallment;
        private System.Windows.Forms.DataGridViewTextBoxColumn رقم_التعديل;
        private System.Windows.Forms.DataGridViewTextBoxColumn المبلغ;
        private System.Windows.Forms.DataGridViewTextBoxColumn التاريخ;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvEditInstallmentInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn اسم_العميل;
        private System.Windows.Forms.DataGridViewTextBoxColumn اسم_المنتج;
        private System.Windows.Forms.DataGridViewTextBoxColumn سعر_المنتج;
        private System.Windows.Forms.DataGridViewTextBoxColumn رقم_القسط;
        private System.Windows.Forms.DataGridViewTextBoxColumn عدد_التعديلات;
    }
}