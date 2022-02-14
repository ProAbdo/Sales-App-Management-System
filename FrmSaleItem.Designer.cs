
namespace SalesApp
{
    partial class FrmSaleItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaleItem));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.firstPay = new System.Windows.Forms.TextBox();
            this.installmentNum = new System.Windows.Forms.ComboBox();
            this.installmentPerM = new System.Windows.Forms.TextBox();
            this.profit = new System.Windows.Forms.TextBox();
            this.total_installment = new System.Windows.Forms.TextBox();
            this.afterprofit = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCustomerSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CustomerForSale = new SalesApp.Customer();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "اختر اسم العميل :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "سعر المنتج :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "اسم المنتج :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "دفعة اولى :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "عدد الاقساط :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "قيمة القسط :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "المبلغ المضاف :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "اجمالى المبلغ بعد الربح  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = " المبلغ المقسط :";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(126, 104);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(369, 27);
            this.productName.TabIndex = 30;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(126, 162);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(369, 27);
            this.productPrice.TabIndex = 31;
            this.productPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productPrice_KeyPress);
            // 
            // firstPay
            // 
            this.firstPay.Location = new System.Drawing.Point(126, 216);
            this.firstPay.Name = "firstPay";
            this.firstPay.Size = new System.Drawing.Size(369, 27);
            this.firstPay.TabIndex = 32;
            this.firstPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstPay_KeyPress);
            // 
            // installmentNum
            // 
            this.installmentNum.BackColor = System.Drawing.SystemColors.Window;
            this.installmentNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.installmentNum.FormattingEnabled = true;
            this.installmentNum.ItemHeight = 19;
            this.installmentNum.Items.AddRange(new object[] {
            "10",
            "12",
            "15"});
            this.installmentNum.Location = new System.Drawing.Point(126, 274);
            this.installmentNum.Name = "installmentNum";
            this.installmentNum.Size = new System.Drawing.Size(369, 27);
            this.installmentNum.TabIndex = 33;
            // 
            // installmentPerM
            // 
            this.installmentPerM.BackColor = System.Drawing.Color.Orange;
            this.installmentPerM.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installmentPerM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.installmentPerM.Location = new System.Drawing.Point(158, 365);
            this.installmentPerM.Name = "installmentPerM";
            this.installmentPerM.ReadOnly = true;
            this.installmentPerM.Size = new System.Drawing.Size(139, 37);
            this.installmentPerM.TabIndex = 34;
            this.installmentPerM.Text = "0";
            this.installmentPerM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profit
            // 
            this.profit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.profit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.profit.Location = new System.Drawing.Point(486, 365);
            this.profit.Name = "profit";
            this.profit.ReadOnly = true;
            this.profit.Size = new System.Drawing.Size(139, 37);
            this.profit.TabIndex = 35;
            this.profit.Text = "0";
            this.profit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_installment
            // 
            this.total_installment.BackColor = System.Drawing.Color.Yellow;
            this.total_installment.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_installment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.total_installment.Location = new System.Drawing.Point(158, 438);
            this.total_installment.Name = "total_installment";
            this.total_installment.ReadOnly = true;
            this.total_installment.Size = new System.Drawing.Size(139, 37);
            this.total_installment.TabIndex = 36;
            this.total_installment.Text = "0";
            this.total_installment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // afterprofit
            // 
            this.afterprofit.BackColor = System.Drawing.Color.Lime;
            this.afterprofit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afterprofit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.afterprofit.Location = new System.Drawing.Point(486, 438);
            this.afterprofit.Name = "afterprofit";
            this.afterprofit.ReadOnly = true;
            this.afterprofit.Size = new System.Drawing.Size(139, 37);
            this.afterprofit.TabIndex = 37;
            this.afterprofit.Text = "0";
            this.afterprofit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.btnCustomerSave);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(189, 498);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 96);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "    التحكم  ";
            // 
            // btnCustomerSave
            // 
            this.btnCustomerSave.BackColor = System.Drawing.Color.White;
            this.btnCustomerSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomerSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCustomerSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSave.Image = global::SalesApp.Properties.Resources.save;
            this.btnCustomerSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerSave.Location = new System.Drawing.Point(62, 43);
            this.btnCustomerSave.Name = "btnCustomerSave";
            this.btnCustomerSave.Size = new System.Drawing.Size(102, 42);
            this.btnCustomerSave.TabIndex = 1;
            this.btnCustomerSave.Text = "حفظ";
            this.btnCustomerSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerSave.UseVisualStyleBackColor = false;
            this.btnCustomerSave.Click += new System.EventHandler(this.btnCustomerSave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::SalesApp.Properties.Resources.add_file1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(248, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "جديد";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SalesApp.Properties.Resources.shopping_bag;
            this.pictureBox2.Location = new System.Drawing.Point(516, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 264);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // CustomerForSale
            // 
            this.CustomerForSale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerForSale.Location = new System.Drawing.Point(126, 46);
            this.CustomerForSale.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerForSale.Name = "CustomerForSale";
            this.CustomerForSale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerForSale.Size = new System.Drawing.Size(369, 32);
            this.CustomerForSale.TabIndex = 39;
            // 
            // FrmSaleItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 588);
            this.Controls.Add(this.CustomerForSale);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.afterprofit);
            this.Controls.Add(this.total_installment);
            this.Controls.Add(this.profit);
            this.Controls.Add(this.installmentPerM);
            this.Controls.Add(this.installmentNum);
            this.Controls.Add(this.firstPay);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSaleItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيع منتج";
            this.Load += new System.EventHandler(this.FrmSaleItem_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.TextBox firstPay;
        private System.Windows.Forms.ComboBox installmentNum;
        private System.Windows.Forms.TextBox installmentPerM;
        private System.Windows.Forms.TextBox profit;
        private System.Windows.Forms.TextBox total_installment;
        private System.Windows.Forms.TextBox afterprofit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCustomerSave;
        private System.Windows.Forms.Button button1;
        private Customer CustomerForSale;
    }
}