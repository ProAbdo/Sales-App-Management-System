using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("SalesApp").Count() > 1)
            {
                MessageBox.Show("لايمكن تشغيل اكتر من نسخة من البرنامج ");
                Application.Exit();
            }
            else
            {
                this.Icon = Icon.ExtractAssociatedIcon("SalesApp.exe");
                FrmLogin frm = new FrmLogin();
                frm.Icon = this.Icon;
                this.Hide();
                //frm.Show();
                DB.Open();
                //DataTable tbllate = DB.GetData("select customer_number,item_number,installment_num,installment_date from installment where installment_date<='" + DateTime.Now.ToString("yyyy/MM/dd") + "'and is_paid='" + "تحت السداد" + "'");
                //foreach (DataRow r in tbllate.Rows)
                //{
                //    DB.Run("update installment set is_paid='" + "متأخر" + "'where customer_number='" + r[0] + "'and item_number='" + r[1] + "'and installment_num='" + r[2] + "'");
                //    DB.Run("update sales set state='" + "متأخر" + "'where customer_number='" + r[0] + "'and item_number='" + r[1] + "'");
                //}
                //DataTable tblfullPay = DB.GetData("select installment.customer_number,installment.item_number,installment_number,is_paid,state from installment,sales where installment.customer_number=sales.customer_number and installment.item_number=sales.item_number and is_paid='" + "تم الدفع" + "'and state!='" + "تم الدفع" + "'group by installment.customer_number,installment.item_number,installment_number,is_paid,state having count(is_paid)=installment_number");
                //foreach (DataRow r in tblfullPay.Rows)
                //{
                //    DB.Run("update sales set state='" + "تم الدفع" + "'where customer_number='" + r[0] + "'and item_number='" + r[1] + "'");
                //}
                //DataTable tblStillPay = DB.GetData("select installment.customer_number,installment.item_number,installment_number,is_paid,state from installment,sales where installment.customer_number=sales.customer_number and installment.item_number=sales.item_number and is_paid!='" + "متأخر" + "'and state='" + "متأخر" + "'group by installment.customer_number,installment.item_number,installment_number,is_paid,state having count(is_paid)=installment_number");
                //foreach (DataRow r in tblStillPay.Rows)
                //{
                //    DB.Run("update sales set state='" + "تحت السداد" + "'where customer_number='" + r[0] + "'and item_number='" + r[1] + "'");
                //}
                new FrmMain().Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
