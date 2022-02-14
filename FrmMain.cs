using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void OpenForm(Form form)
        {
            var frrm = Application.OpenForms[form.Name];
            if (frrm != null)
            {
                frrm.Activate();
                return;
            }
            //form.BackColor = this.BackColor;
            form.Font = new Font(this.Font.Name, this.Font.Size, this.Font.Style);
            form.WindowState = FormWindowState.Normal;
            form.Icon = this.Icon;
            form.Show();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            tsBasic.BackColor = default(Color);
            tsEdit.BackColor = default(Color);
            tsReports.BackColor = default(Color);
        }

        private void tsbAddCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCustomer());
        }
        private void T_Time_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString("HH:mm:ss") == "00:00:00")
            {
                DataTable tbllate = DB.GetData("select customer_number,item_number,installment_num,installment_date from installment where installment_date<='" + DateTime.Now.ToString("yyyy/MM/dd") + "'and is_paid='" + "تحت السداد" + "'");
                foreach (DataRow r in tbllate.Rows)
                {
                    DB.Run("update installment set is_paid='" + "متأخر" + "'where customer_number='" + r[0] + "'and item_number='" + r[1] + "'and installment_num='" + r[2] + "'");
                    DB.Run("update sales set state='" + "متأخر" + "'where customer_number='" + r[0] + "'and item_number='" + r[1] + "'");
                }
            }
            string day = DateTime.Now.DayOfWeek.ToString();
            if (day == "Saturday") tslDay.Text = "اليوم : السبت";
            if (day == "Sunday") tslDay.Text = "اليوم : الأحد";
            if (day == "Monday") tslDay.Text = "اليوم : الأثنين";
            if (day == "Tuesday") tslDay.Text = "اليوم : الثلاثاء";
            if (day == "Wednesday") tslDay.Text = "اليوم : الأربعاء";
            if (day == "Thursday") tslDay.Text = "اليوم : الخميس";
            if (day == "Friday") tslDay.Text = "اليوم : الجمعة";
            tslTime.Text = DateTime.Now.ToString("الساعة :");
            tslTime.Text += DateTime.Now.ToString(" hh:mm:ss");
            tslDate.Text = "الموافق :";
            tslDate.Text += DateTime.Now.ToString(" yyyy-MM-dd");
        }
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCustomerEdit());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmSaleItem());
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmSalesReports());
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmInstallmentReport());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmInstallmentPayment());
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmChangeState());
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmSalesEdit());
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmEditInstallment());
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmEditInstallmentReport());

        }
    }
}
