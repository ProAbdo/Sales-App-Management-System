namespace SalesApp
{
    partial class FrmActionEditSales
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.installment_numbers = new Bunifu.UI.WinForms.BunifuDropdown();
            this.productName = new System.Windows.Forms.TextBox();
            this.firstPay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox3 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox4 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox5 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = global::SalesApp.Properties.Resources.info;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.installment_numbers);
            this.groupBox1.Controls.Add(this.productName);
            this.groupBox1.Controls.Add(this.firstPay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.productPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(39, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "    تعديل بيانات بيع :";
            // 
            // installment_numbers
            // 
            this.installment_numbers.BackColor = System.Drawing.Color.White;
            this.installment_numbers.BorderRadius = 11;
            this.installment_numbers.Color = System.Drawing.Color.Black;
            this.installment_numbers.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.installment_numbers.DisabledColor = System.Drawing.Color.Gray;
            this.installment_numbers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.installment_numbers.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.installment_numbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.installment_numbers.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Right;
            this.installment_numbers.FillDropDown = false;
            this.installment_numbers.FillIndicator = false;
            this.installment_numbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installment_numbers.ForeColor = System.Drawing.Color.Purple;
            this.installment_numbers.FormattingEnabled = true;
            this.installment_numbers.Icon = null;
            this.installment_numbers.IndicatorColor = System.Drawing.Color.Black;
            this.installment_numbers.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Left;
            this.installment_numbers.ItemBackColor = System.Drawing.Color.White;
            this.installment_numbers.ItemBorderColor = System.Drawing.Color.White;
            this.installment_numbers.ItemForeColor = System.Drawing.Color.Purple;
            this.installment_numbers.ItemHeight = 22;
            this.installment_numbers.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.installment_numbers.Items.AddRange(new object[] {
            "10",
            "12",
            "15"});
            this.installment_numbers.Location = new System.Drawing.Point(158, 193);
            this.installment_numbers.Name = "installment_numbers";
            this.installment_numbers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.installment_numbers.Size = new System.Drawing.Size(369, 28);
            this.installment_numbers.TabIndex = 31;
            this.installment_numbers.Text = null;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(159, 26);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(369, 27);
            this.productName.TabIndex = 38;
            // 
            // firstPay
            // 
            this.firstPay.Location = new System.Drawing.Point(159, 136);
            this.firstPay.Name = "firstPay";
            this.firstPay.Size = new System.Drawing.Size(369, 27);
            this.firstPay.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "سعر المنتج :";
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(159, 81);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(369, 27);
            this.productPrice.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "اسم المنتج :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "دفعة اولى :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "عدد الاقساط :";
            // 
            // txtName
            // 
            this.txtName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtName.BorderThickness = 3;
            this.txtName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(179, 15);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(370, 49);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "عبدالرحمن حسين مصطفى";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderThickness = 3;
            this.bunifuMetroTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Enabled = false;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(171, 368);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox2.MaxLength = 32767;
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(174, 49);
            this.bunifuMetroTextbox2.TabIndex = 4;
            this.bunifuMetroTextbox2.Text = "0";
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMetroTextbox3
            // 
            this.bunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox3.BorderThickness = 3;
            this.bunifuMetroTextbox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox3.Enabled = false;
            this.bunifuMetroTextbox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3.isPassword = false;
            this.bunifuMetroTextbox3.Location = new System.Drawing.Point(505, 368);
            this.bunifuMetroTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox3.MaxLength = 32767;
            this.bunifuMetroTextbox3.Name = "bunifuMetroTextbox3";
            this.bunifuMetroTextbox3.Size = new System.Drawing.Size(175, 49);
            this.bunifuMetroTextbox3.TabIndex = 5;
            this.bunifuMetroTextbox3.Text = "0";
            this.bunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMetroTextbox4
            // 
            this.bunifuMetroTextbox4.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox4.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuMetroTextbox4.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox4.BorderThickness = 3;
            this.bunifuMetroTextbox4.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMetroTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox4.Enabled = false;
            this.bunifuMetroTextbox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox4.isPassword = false;
            this.bunifuMetroTextbox4.Location = new System.Drawing.Point(170, 426);
            this.bunifuMetroTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox4.MaxLength = 32767;
            this.bunifuMetroTextbox4.Name = "bunifuMetroTextbox4";
            this.bunifuMetroTextbox4.Size = new System.Drawing.Size(174, 49);
            this.bunifuMetroTextbox4.TabIndex = 6;
            this.bunifuMetroTextbox4.Text = "0";
            this.bunifuMetroTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMetroTextbox5
            // 
            this.bunifuMetroTextbox5.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox5.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuMetroTextbox5.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox5.BorderThickness = 3;
            this.bunifuMetroTextbox5.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMetroTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox5.Enabled = false;
            this.bunifuMetroTextbox5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox5.isPassword = false;
            this.bunifuMetroTextbox5.Location = new System.Drawing.Point(505, 425);
            this.bunifuMetroTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox5.MaxLength = 32767;
            this.bunifuMetroTextbox5.Name = "bunifuMetroTextbox5";
            this.bunifuMetroTextbox5.Size = new System.Drawing.Size(175, 49);
            this.bunifuMetroTextbox5.TabIndex = 7;
            this.bunifuMetroTextbox5.Text = "0";
            this.bunifuMetroTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "اجمالى المبلغ بعد الربح  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = " المبلغ المقسط :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "المبلغ المضاف :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "قيمة القسط :";
            // 
            // FrmActionEditSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 523);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuMetroTextbox5);
            this.Controls.Add(this.bunifuMetroTextbox4);
            this.Controls.Add(this.bunifuMetroTextbox3);
            this.Controls.Add(this.bunifuMetroTextbox2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmActionEditSales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات بيع ";
            this.Load += new System.EventHandler(this.FrmActionEditSales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox firstPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox3;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox4;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox5;
        private Bunifu.UI.WinForms.BunifuDropdown installment_numbers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}