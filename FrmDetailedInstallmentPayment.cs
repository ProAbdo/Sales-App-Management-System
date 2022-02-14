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
    public partial class FrmDetailedInstallmentPayment : Form
    {
        string mustPay="";
        int customer_num=0, item_num = 0;
        public FrmDetailedInstallmentPayment()
        {
            InitializeComponent();
        }
        public FrmDetailedInstallmentPayment(int customer_num, int item_num)
        {
            this.customer_num = customer_num;
            this.item_num = item_num;
            InitializeComponent();
        }
        private void dgvPayInstallment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPayInstallment.Columns[e.ColumnIndex].Name == "الحالة")
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
            if (dgvPayInstallment.Columns[e.ColumnIndex].Name == "سداد")
            {
                if (mustPay != "")
                {
                    if (e.RowIndex == int.Parse(mustPay)-1)
                    {
                        e.CellStyle.BackColor = Color.Blue;
                        e.CellStyle.SelectionBackColor = Color.BlueViolet;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.Gray;
                        e.CellStyle.SelectionBackColor = Color.Gray;
                    }
                }
                else
                {
                    e.CellStyle.BackColor = Color.Gray;
                    e.CellStyle.SelectionBackColor = Color.Gray;
                }
            }
        }
        private void payMehtod(string payAmount) 
        {
            DB.Run("update installment set paid='" + payAmount + "',is_paid='" + "تم الدفع" + "',pay_date='" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "'where customer_number='" + customer_num + "'and item_number='" + item_num + "'and installment_num='" + mustPay + "'");
            DB.Run("update sales set rest_pay=rest_pay-'" + int.Parse(payAmount) + "'where customer_number='" + customer_num + "'and item_number='" + item_num + "'");
            DataTable tblStillPay = DB.GetData("select installment.customer_number,installment.item_number,installment_number from installment,sales where installment.customer_number=sales.customer_number and installment.item_number=sales.item_number and installment.is_paid !='" + "متأخر" + "'and sales.state!='" + "تحت السداد" + "'and sales.state!='" + "تم الدفع" + "'group by installment.customer_number,installment.item_number,installment_number having count(is_paid)=installment_number");
            foreach (DataRow r in tblStillPay.Rows)
            {
                DB.Run("update sales set state='" + "تحت السداد" + "'where customer_number='" + r[0] + "'and item_number='" + r[1] + "'");
            }
            
            FrmInstallmentPayment obj = (FrmInstallmentPayment)Application.OpenForms["FrmInstallmentPayment"];
            MessageBox.Show("تم الدفع بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reload();
            if (int.Parse(dgvInfoPay.Rows[0].Cells[6].Value.ToString()) <= 0)
            {
                    DB.Run("update sales set state='" + "تم الدفع" + "'where customer_number='" + customer_num.ToString() + "'and item_number='" + item_num.ToString() + "'");                  
            }
            obj.reload();
        }
        private void dgvPayInstallment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPayInstallment.Columns[e.ColumnIndex].Name == "سداد")
            {
                if (dgvPayInstallment.Rows[e.RowIndex].Cells["الحالة"].Value.ToString() == "تم الدفع")
                {
                    MessageBox.Show("تم دفع هذا القسط من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (e.RowIndex == int.Parse(mustPay) - 1)
                {
                    ///PAY BUTTON HERE ---------------------------------- :)
                    try
                    {
                        string payAmount = dgvPayInstallment.Rows[e.RowIndex].Cells["paid"].Value.ToString();
                      
                        if (payAmount == "0")
                        {
                            MessageBox.Show("لم يتم ادخال القيمة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else if (mustPay == dgvPayInstallment.Rows.Count.ToString())
                        {
                            if (int.Parse(payAmount) < int.Parse(dgvInfoPay.Rows[0].Cells[6].Value.ToString()))
                            {
                                MessageBox.Show("المبلغ غير كامل");
                            }
                            else payMehtod(payAmount);
                        }
                        else payMehtod(payAmount);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                }
                else MessageBox.Show("لم يتم دفع الاقساط السابقة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void reload()
        {
            try
            {
                dgvPayInstallment.DataSource = DB.GetData("select installment.customer_number,installment.item_number,installment_num,installment_date,pay_date,paid,is_paid from customer,sales,installment where installment.customer_number=sales.customer_number and installment.item_number=sales.item_number and sales.customer_number=customer.customer_number and installment.customer_number='" + customer_num.ToString() + "'and installment.item_number='" + item_num.ToString() + "'");
                dgvInfoPay.DataSource = DB.GetData("select sales.customer_number,sales.item_number,customer_name,item_name,item_price,installment_per_m,rest_pay from customer,sales where sales.customer_number=customer.customer_number and sales.customer_number='" + customer_num.ToString() + "'and sales.item_number='" + item_num.ToString() + "'");
                txtName.Text = dgvInfoPay.Rows[0].Cells["customer_name"].FormattedValue.ToString();
                /// Get Must pay
                mustPay = DB.GetData("select min(installment_num) from customer,sales,installment where installment.is_paid!='" + "تم الدفع" + "' and installment.customer_number=sales.customer_number and installment.item_number=sales.item_number and sales.customer_number=customer.customer_number and installment.customer_number='" + customer_num.ToString() + "'and installment.item_number='" + item_num.ToString() + "'").Rows[0][0].ToString();
                dgvPayInstallment.Columns["paid"].ReadOnly = true;
                if (mustPay != "")
                {
                    dgvPayInstallment.Rows[int.Parse(mustPay) - 1].Cells["paid"].ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void dgvPayInstallment_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvPayInstallment.CurrentCell.ColumnIndex == 6)
            {
                if(e.Control is TextBox && e.Control != null)
                {
                    e.Control.KeyPress += delegate(object Mysender , KeyPressEventArgs Mye)
                    {
                        if ((!char.IsNumber(Mye.KeyChar)) && (!char.IsControl(Mye.KeyChar)))
                            Mye.Handled = true;
                    };
                }
            }
        }

        private void FrmDetailedInstallmentPayment_Load(object sender, EventArgs e)
        {
            reload();
        }
    }
}
