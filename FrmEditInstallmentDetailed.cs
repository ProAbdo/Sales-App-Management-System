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
    public partial class FrmEditInstallmentDetailed : Form
    {
        string customer_number, item_number;
        public FrmEditInstallmentDetailed()
        {
            InitializeComponent();
        }
        public FrmEditInstallmentDetailed(string customer_number,string item_number)
        {
            this.customer_number = customer_number;
            this.item_number = item_number;
            InitializeComponent();
        }
        public void reload()
        {
            try
            {
                dgvEditInstallment.DataSource = DB.GetData("select i.installment_num,i.installment_date,i.pay_date,i.paid,sum(ei.paid) cnt_paid,(i.paid+sum(ei.paid)) total_paid,i.is_paid " +
                    "from customer c " +
                    "inner join sales s " +
                    "on c.customer_number=s.customer_number " +
                    "inner join installment i " +
                    "on i.customer_number=s.customer_number and i.item_number=s.item_number  " +
                    "left outer join edit_installments ei " +
                    "on i.installment_num=ei.installment_num and i.customer_number=ei.customer_number and i.item_number=ei.item_number " +
                    "where i.customer_number='" + customer_number + "' and i.item_number='" + item_number + "' " +
                    "group by i.installment_num,i.installment_date,i.pay_date,i.paid,i.is_paid");
                dgvInfoPay.DataSource = DB.GetData("select sales.customer_number,sales.item_number,customer_name,item_name,item_price,installment_per_m,rest_pay from customer,sales where sales.customer_number=customer.customer_number and sales.customer_number='" + customer_number + "'and sales.item_number='" + item_number + "'");
                dgvInfoPay.DataSource = DB.GetData("select sales.customer_number,sales.item_number,customer_name,item_name,item_price,installment_per_m,rest_pay from customer,sales where sales.customer_number=customer.customer_number and sales.customer_number='" + customer_number + "'and sales.item_number='" + item_number + "'");
                txtName.Text = dgvInfoPay.Rows[0].Cells["customer_name"].FormattedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void dgvEditInstallment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEditInstallment.Columns[e.ColumnIndex].Name == "الحالة")
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
            }
        }

        private void dgvEditInstallment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEditInstallment.Columns[e.ColumnIndex].Name == "التعديلات")
            {
                string installment_num = dgvEditInstallment.Rows[e.RowIndex].Cells["رقم_القسط"].Value.ToString();
                new FrmMain().OpenForm(new FrmInstallmentEditReport(customer_number,item_number,installment_num));
            }
        }

        private void FrmEditInstallmentDetailed_Load(object sender, EventArgs e)
        {
            reload();
        }
    }
}
