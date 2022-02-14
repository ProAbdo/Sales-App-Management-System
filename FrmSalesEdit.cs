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
    public partial class FrmSalesEdit : Form
    {
        public FrmSalesEdit()
        {
            InitializeComponent();
        }
        private void FrmSalesEdit_Load(object sender, EventArgs e)
        {
            try
            {
                dgvSearch.DataSource = DB.GetData("select sales.customer_number,item_number,customer_name,item_name,item_price,firstpay,total_installment,profit,after_profit,installment_per_m,sale_date,installment_number " +
                    "from customer,sales " +
                    "where customer.customer_number=sales.customer_number");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        bool vaildFirstPay(int idx)
        {
            int firstPay = int.Parse(dgvSearch.Rows[idx].Cells[6].Value.ToString());
            string productPrice = dgvSearch.Rows[idx].Cells[5].Value.ToString();;
            return (firstPay <= int.Parse(productPrice) && firstPay >= Math.Round((double.Parse(productPrice) * 27.0 / 100), MidpointRounding.AwayFromZero));

        }
        void calculate_installment(int idx)
        {
            double parentage = 0;
            double installmentPerM, total_installment, profit, afterProfit;
            string installmentNum = dgvSearch.Rows[idx].Cells[12].Value.ToString();
            string productPrice = dgvSearch.Rows[idx].Cells[5].Value.ToString();
            string firstPay = dgvSearch.Rows[idx].Cells[6].Value.ToString();
            if (installmentNum == "10") parentage = 40;
            else if (installmentNum == "12") parentage = 45;
            else if (installmentNum == "15") parentage = 50;
            profit = Math.Round((double.Parse(productPrice) - double.Parse(firstPay)) * parentage / 100, MidpointRounding.AwayFromZero);
            total_installment = Math.Round(double.Parse(productPrice) - double.Parse(firstPay));
            afterProfit = total_installment + profit;
            installmentPerM = Math.Round(afterProfit / double.Parse(installmentNum), MidpointRounding.AwayFromZero);
            dgvSearch.Rows[idx].Cells[10].Value = installmentPerM;
            dgvSearch.Rows[idx].Cells[8].Value = profit;
            dgvSearch.Rows[idx].Cells[7].Value = total_installment;
            dgvSearch.Rows[idx].Cells[9].Value = afterProfit;

        }
        private void dgvSearch_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearch.Columns[e.ColumnIndex].Name == "دفعةاولى")
            {
                string firsPay = dgvSearch.Rows[e.RowIndex].Cells[6].Value.ToString();
                string productPrice = dgvSearch.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (vaildFirstPay(e.RowIndex)) calculate_installment(e.RowIndex);
                else
                {
                    MessageBox.Show(Math.Round((double.Parse(productPrice) * 27.0 / 100), MidpointRounding.AwayFromZero).ToString() + " : الحد الادنى للدفعة الاولى", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvSearch.Rows[e.RowIndex].Cells[6].Value = Math.Round((double.Parse(productPrice) * 27.0 / 100), MidpointRounding.AwayFromZero);
                }
            }
        }

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearch.Columns[e.ColumnIndex].Name == "تعديل")
            {
                string[] dataInfo = new string[]
                {
                    dgvSearch.Rows[e.RowIndex].Cells["customer_name"].Value.ToString(),
                    dgvSearch.Rows[e.RowIndex].Cells["item_name"].Value.ToString(),
                    dgvSearch.Rows[e.RowIndex].Cells["item_price"].Value.ToString(),
                    dgvSearch.Rows[e.RowIndex].Cells["firstpay"].Value.ToString(),
                    dgvSearch.Rows[e.RowIndex].Cells["installment_number"].Value.ToString(),
                    dgvSearch.Rows[e.RowIndex].Cells["total_installment"].Value.ToString(),
                    dgvSearch.Rows[e.RowIndex].Cells["profit"].Value.ToString(),
                    dgvSearch.Rows[e.RowIndex].Cells["after_profit"].Value.ToString(),
                    dgvSearch.Rows[e.RowIndex].Cells["installment_per_m"].Value.ToString(),
                };
                new FrmMain().OpenForm(new FrmActionEditSales(dataInfo));
            }
        }
    }
}
