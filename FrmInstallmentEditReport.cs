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

    public partial class FrmInstallmentEditReport : Form
    {
        string customer_number, item_number,installment_num;

        public FrmInstallmentEditReport()
        {
            InitializeComponent();
        }
        public FrmInstallmentEditReport(string customer_number, string item_number,string installment_num)
        {
            this.customer_number = customer_number;
            this.item_number = item_number;
            this.installment_num= installment_num; 
            InitializeComponent();
        }
        private void FrmInstallmentEditReport_Load(object sender, EventArgs e)
        {
            try
            {
                dgvEditInstallmentInfo.DataSource = DB.GetData("select customer_name,item_name,item_price,ei.installment_num,count(ei.edit_installment) cnt " +
                    "from edit_installments ei,customer c,sales s,installment i " +
                    "where c.customer_number=s.customer_number " +
                    "and s.customer_number=i.customer_number " +
                    "and i.customer_number=ei.customer_number " +
                    "and s.item_number = i.item_number " +
                    "and i.item_number = ei.item_number " +
                    "and i.installment_num=ei.installment_num " +
                    "and ei.customer_number='" + customer_number + "'" +
                    "and ei.item_number='" + item_number + "'" +
                    "and ei.installment_num='" + installment_num + "'group by customer_name,item_name,item_price,ei.installment_num");


                dgvEditInstallment.DataSource = DB.GetData("select ei.edit_installment,ei.paid,ei.edit_installment_date " +
                    "from edit_installments ei,customer c,sales s,installment i " +
                    "where c.customer_number=s.customer_number " +
                    "and s.customer_number=i.customer_number " +
                    "and i.customer_number=ei.customer_number " +
                    "and s.item_number = i.item_number " +
                    "and i.item_number = ei.item_number " +
                    "and i.installment_num=ei.installment_num " +
                    "and ei.customer_number='"+customer_number+"'" +
                    "and ei.item_number='"+item_number+"'" +
                    "and ei.installment_num='"+installment_num+"'");
                txtName.Text = dgvEditInstallmentInfo.Rows[0].Cells["اسم_العميل"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
