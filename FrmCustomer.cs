using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        private void ClearAndAuto()
        {
            txtCustNum.Text = DB.GetData("select max(customer_number)+1 from customer").Rows[0][0].ToString();
            if (txtCustNum.Text == "") txtCustNum.Text = "1";
            txtCustName.Clear();
            txtCustAddress.Clear();
            txtCustPhone.Clear();
            txtCustAddress.Clear();
            txtCustID.Clear();
            txtSponName.Clear();
            txtSponAddress.Clear();
            txtSponPhone.Clear();
            txtSponAddress.Clear();
            txtSponID.Clear();
            StartDate.Value = DateTime.Now;
            txtCustName.Select();
        }
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            ClearAndAuto();
        }
        private void ClearData(object sender, EventArgs e)
        {
            ClearAndAuto();
        }

        private void SaveClick(object sender, EventArgs e)
        {
            if (txtCustName.Text.Trim() == "")
            {
                MessageBox.Show("لم يتم ادخال اسم العميل");
                txtCustName.Select();
            }
            else if (txtCustAddress.Text.Trim() == "")
            {
                MessageBox.Show("لم يتم ادخال عنوان العميل");
                txtCustAddress.Select();
            }
            else if (txtCustPhone.Text.Trim() == "")
            {
                MessageBox.Show("لم يتم ادخال رقم هاتف العميل");
                txtCustPhone.Select();
            }
            else if (txtCustID.Text.Trim() == "")
            {
                MessageBox.Show("لم يتم ادخال رقم بطاقة العميل");
                txtCustID.Select();
            }
            else if (txtSponName.Text.Trim() == "")
            {
                MessageBox.Show("لم يتم ادخال اسم الضامن");
                txtSponName.Select();

            }
            else if (txtSponAddress.Text.Trim() == "")
            {
                MessageBox.Show("لم يتم ادخال عنوان الضامن");
                txtSponAddress.Select();
            }
            else if (txtSponPhone.Text.Trim() == "")
            {
                MessageBox.Show("لم يتم ادخال رقم هاتف الضامن");
                txtSponPhone.Select();
            }
            else if (txtSponID.Text.Trim() == "")
            {
                MessageBox.Show("لم يتم ادخال رقم بطاقة الضامن");
                txtSponID.Select();
            }
            else
            {
                try
                {
                    DB.Run("insert into customer" +
                        " values(" + txtCustNum.Text.Replace("'", "") 
                        + ",'" + txtCustName.Text.Replace("'", "") 
                        + "','" + txtCustPhone.Text.Replace("'", "") 
                        + "','" + txtCustAddress.Text.Replace("'", "") 
                        + "','" + txtCustID.Text.Replace("'", "")
                        +"','"+StartDate.Value.ToString("yyyy/MM/dd")+"')");
                    DB.Run("insert into sponsor values(" + txtCustNum.Text.Replace("'", "") + ",'" + txtSponName.Text.Replace("'", "") + "','" + txtSponPhone.Text.Replace("'", "") + "','" + txtSponAddress.Text.Replace("'", "") + "','" + txtSponID.Text.Replace("'", "") + "')");
                    MessageBox.Show("تم اضافة العميل","تم",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
                ClearAndAuto();
            }
        }
        private void OpenForm(Form form)
        {
            var frrm = Application.OpenForms[form.Name];
            if (frrm != null)
            {
                frrm.Activate();
                return;
            }
            form.BackColor = this.BackColor;
            form.Font = new Font(this.Font.Name, this.Font.Size, this.Font.Style);
            form.WindowState = FormWindowState.Normal;
            form.Icon = this.Icon;
            form.Show();
        }
        private void SaleClick(object sender, EventArgs e)
        {
            int idx1= int.Parse(txtCustNum.Text) - 2;
            btnCustomerSave.PerformClick();
            int idx2 = int.Parse(txtCustNum.Text) - 2;
            if (idx1 != idx2)
            {
                this.Close();
                OpenForm(new FrmSaleItem(idx2));
            }
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
