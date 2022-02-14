using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private bool Pre_Close = true;
        private void button2_Click(object sender, EventArgs e)
        {
            Pre_Close = false;
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DB.Open();
            DataTable tbllate = DB.GetData("select customer_number,item_number,installment_num,installment_date from installment where installment_date<='" + DateTime.Now.ToString("yyyy/MM/dd") + "'and is_paid='" + "تحت السداد" + "'");
            foreach (DataRow r in tbllate.Rows)
            {
                DB.Run("update installment set is_paid='" + "متأخر" + "'where customer_number='" + r[0] + "'and item_number='" + r[1] + "'and installment_num='" + r[2] + "'");
                DB.Run("update sales set state='" + "متأخر" + "'where customer_number='" + r[0] + "'and item_number='" + r[1] + "'");
            }
        }
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (txtuser.Text == "admin" && txtpass.Text == "admin")
            {
                this.Close();
                FrmMain frm = new SalesApp.FrmMain();
                frm.Icon = this.Icon;
                frm.Show();
                Pre_Close = false;
                this.Close();
            }
            else MessageBox.Show("Error");
        }
        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnlogin.PerformClick();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = Pre_Close;
        }
    }
}