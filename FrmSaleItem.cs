using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class FrmSaleItem : Form
    {
        int idx = -1;
        public FrmSaleItem()
        {
            InitializeComponent();
        }
        public FrmSaleItem(int idx)
        {
            InitializeComponent();
            this.idx = idx;
        }
        void calculate_installment()
        {
            double parentage=0;
            double installmentPerM, total_installment, profit, afterProfit;
            if (installmentNum.SelectedItem.ToString() == "10") parentage = 40;
            else if(installmentNum.SelectedItem.ToString() == "12") parentage = 45;
            else if (installmentNum.SelectedItem.ToString() == "15") parentage = 50;
            profit = Math.Round((double.Parse(productPrice.Text) - double.Parse(firstPay.Text))*parentage/100,MidpointRounding.AwayFromZero);
            total_installment = Math.Round(double.Parse(productPrice.Text) - double.Parse(firstPay.Text));
            afterProfit = total_installment + profit;
            installmentPerM =Math.Round(afterProfit / double.Parse(installmentNum.Text),MidpointRounding.AwayFromZero);
            this.installmentPerM.Text = installmentPerM.ToString();
            this.profit.Text = profit.ToString();
            this.total_installment.Text = total_installment.ToString();
            this.afterprofit.Text = afterProfit.ToString();
        }
        private void FrmSaleItem_Load(object sender, EventArgs e)
        {
            CustomerForSale.SetIndex(idx);
            CustomerForSale.Select();
            installmentNum.SelectedIndex = -1;
            productPrice.TextChanged += delegate
            {
                if(productPrice.Text!="")firstPay.Text = Math.Round((double.Parse(productPrice.Text)*27.0/100),MidpointRounding.AwayFromZero).ToString();
                firstPay.ForeColor = Color.Green;
                if(installmentNum.Text != "" &&firstPay.Text!=""&&productPrice.Text!="")calculate_installment(); 
            };
            firstPay.TextChanged += delegate
            {
                if (productPrice.Text != ""&&firstPay.Text!="")
                {
                    int limit = int.Parse(firstPay.Text);
                    if (limit<=int.Parse(productPrice.Text)&&limit >= Math.Round((double.Parse(productPrice.Text) *27.0 / 100),MidpointRounding.AwayFromZero)) firstPay.ForeColor = Color.Green;
                    else firstPay.ForeColor = Color.Red;
                }
                if (installmentNum.Text != "" && firstPay.Text != "" && productPrice.Text != "") calculate_installment();
            };
            installmentNum.SelectedValueChanged += delegate
            {
                if(installmentNum.Text!=""&& firstPay.Text != "" && productPrice.Text != "") calculate_installment();
            };
        }

        private void productPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
        private void firstPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
        private void ClearAndAuto()
        {
            CustomerForSale.SetIndex(-1);
            installmentNum.SelectedIndex=-1;
            productName.Clear();
            productPrice.Clear();
            firstPay.Clear();
            profit.Clear();
            installmentPerM.Clear();
            afterprofit.Clear();
            total_installment.Clear();
            CustomerForSale.Select();
        }
        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            if (!CustomerForSale.IsSelected())
            {
                MessageBox.Show("لم يتم اختيار اسم العميل");
                CustomerForSale.GetItems().Select();
            }
            else if (productName.Text == "")
            {
                MessageBox.Show("لم يتم ادخال اسم المنتج");
                productName.Select();
            }
            else if (productPrice.Text == "")
            {
                MessageBox.Show("لم يتم ادخال سعر المنتج");
                productPrice.Select();
            }
            else if (firstPay.Text == "")
            {
                MessageBox.Show("لم يتم ادخال الدفعة الاولى ");
                firstPay.Select();
            }
            else if (firstPay.ForeColor == Color.Red)
            {
                MessageBox.Show(Math.Round((double.Parse(productPrice.Text) * 27.0 / 100),MidpointRounding.AwayFromZero).ToString()+" : الحد الادنى للدفعة الاولى","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                firstPay.Text = Math.Round((double.Parse(productPrice.Text) * 27.0 / 100),MidpointRounding.AwayFromZero).ToString();
                firstPay.Select();
            }
            else if (installmentNum.SelectedIndex < 0)
            {
                MessageBox.Show("اختر عدد اشهر التقسيط","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                installmentNum.Select();
            }
            else
            {
                try
                {
                    bool found = DB.exist("select customer_number from sales", CustomerForSale.GetValue().ToString());
                    string max_item = "1";
                    if (found) max_item = DB.GetData("select max(item_number)+1 from sales where customer_number=" + CustomerForSale.GetValue()).Rows[0][0].ToString();
                    DB.Run("insert into sales values(" + CustomerForSale.GetValue().ToString().Replace("'", "") + ",'" + max_item.Replace("'", "") + "','" + productName.Text.Replace("'", "") + "','" + productPrice.Text.Replace("'", "") + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "','" + installmentNum.SelectedItem.ToString() + "','" + installmentPerM.Text.Replace("'", "") + "','" + firstPay.Text.Replace("'", "") + "','" + profit.Text.Replace("'", "") + "','" + total_installment.Text.Replace("'", "") + "','" + afterprofit.Text.Replace("'", "")+"','"+total_installment.Text.Replace("'", "")+"','"+"تحت السداد" + "')");
                    int total = int.Parse(total_installment.Text);
                    for(int i = 1; i <= int.Parse(installmentNum.SelectedItem.ToString()); i++)
                    {
                        string Date = DateTime.Now.AddMonths(i).ToString("yyyy/MM/dd");
                        int amount = int.Parse(installmentPerM.Text);
                        if (i == int.Parse(installmentNum.SelectedItem.ToString())) amount = total;
                        DB.Run("insert into installment(customer_number, item_number, installment_num,installment_amount,paid,installment_date,is_paid) Values('" + CustomerForSale.GetValue().ToString()+"','"+max_item+"','"+i.ToString()+"','"+amount+"','"+""+"','"+Date+"','"+"تحت السداد"+"')");
                        total -= amount;
                    }
                    MessageBox.Show("تمت الاضافة بنجاح","تم",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ClearAndAuto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }
    }
}