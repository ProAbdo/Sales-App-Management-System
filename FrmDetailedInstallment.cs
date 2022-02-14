using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class FrmDetailedInstallment : Form
    {
        int customer_num = 0, item_num = 0;
        public FrmDetailedInstallment(int customer_num, int item_num)
        {
            InitializeComponent();
            this.customer_num = customer_num;
            this.item_num = item_num;
        }

        private void dgvInstallmentReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvInstallmentReport1.Columns[e.ColumnIndex].Name=="الحالة")
            {
                if (e.Value.ToString() == "تحت السداد")
                {
                    e.CellStyle.BackColor = Color.DarkGray;
                }
                else if (e.Value.ToString() == "تم الدفع")
                {
                    e.CellStyle.BackColor = Color.Green;
                }
                else if (e.Value.ToString() == "متأخر")
                {
                    e.CellStyle.BackColor = Color.Orange;
                }
                else if (e.Value.ToString() == "تم شكواه")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void FrmDetailedInstallment_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInstallmentReport1.DataSource = DB.GetData("select sales.customer_number,sales.item_number,installment_num,installment_date,paid,pay_date,is_paid from customer,sales,installment where installment.customer_number=sales.customer_number and installment.item_number=sales.item_number and sales.customer_number=customer.customer_number and installment.customer_number='" + customer_num.ToString() + "'and installment.item_number='" + item_num.ToString() + "'");
                dgvInfo.DataSource = DB.GetData("select sales.customer_number,sales.item_number,customer_name,item_name,item_price,installment_per_m,rest_pay from customer,sales where sales.customer_number=customer.customer_number and sales.customer_number='" + customer_num.ToString() + "'and sales.item_number='" + item_num.ToString() + "'");
                dgvInfo.Columns["customer_number1"].Visible = false;
                dgvInfo.Columns["item_number1"].Visible = false;
                dgvInfo.Columns["customer_name"].Visible = false;
                txtName.Text = dgvInfo.Rows[0].Cells["customer_name"].FormattedValue.ToString();
                dgvInstallmentReport1.Columns["customer_number"].Visible = false;
                dgvInstallmentReport1.Columns["item_number"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
