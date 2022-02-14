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
    public partial class FrmCustomerEdit : Form
    {
        public FrmCustomerEdit()
        {
            InitializeComponent();
        }
        private void ShowCust()
        {
            if (CustomerForEdit.IsSelected())
            {
                DataTable tblCust = DB.GetData("select * from customer where customer_number=" + CustomerForEdit.GetValue());
                DataTable tblSpon = DB.GetData("select * from sponsor where customer_number=" + CustomerForEdit.GetValue());
                txtCustNum.Text = tblCust.Rows[0][0].ToString();
                txtCustName.Text = tblCust.Rows[0][1].ToString();
                txtCustPhone.Text = tblCust.Rows[0][2].ToString();
                txtCustAddress.Text = tblCust.Rows[0][3].ToString();
                txtCustID.Text = tblCust.Rows[0][4].ToString();
                StartDate.Text = tblCust.Rows[0][5].ToString();
                txtSponName.Text = tblSpon.Rows[0][1].ToString();
                txtSponPhone.Text = tblSpon.Rows[0][2].ToString();
                txtSponAddress.Text = tblSpon.Rows[0][3].ToString();
                txtSponID.Text = tblSpon.Rows[0][4].ToString();
                btnSaveCust.Enabled = true;
                btnremove.Enabled = true;
            }
            else
            {
                btnSaveCust.Enabled = false;
                btnremove.Enabled = false;
            }
        }
        private void FrmCustomerEdit_Load(object sender, EventArgs e)
        {
            CustomerForEdit.Select();
            CustomerForEdit.GetItems().SelectedValueChanged+= delegate
            {
                ShowCust();
            };
            CustomerForEdit.SetIndex(-1);
        }
        private void ClearAndAuto() 
        {
            txtCustNum.Clear();
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
            StartDate.Text = "";
        }
        private void btnSaveCust_Click(object sender, EventArgs e)
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
            else if (!CustomerForEdit.IsSelected())
            {
                MessageBox.Show("رجاء اختر اسم العميل");
                CustomerForEdit.GetItems().Select();
            }
            else
            {
                DB.Run("update customer set customer_name ='" + txtCustName.Text.Replace("'", "") + "',phone='" + txtCustPhone.Text.Replace("'", "") + "',address= '" + txtCustAddress.Text.Replace("'", "") + "',national_id='" + txtCustID.Text.Replace("'", "") + "',start_date='" + StartDate.Value.ToString("yyyy/MM/dd") + "' where customer_number="+ txtCustNum.Text.Replace("'", ""));
                DB.Run("update sponsor set sponsor_name ='" + txtSponName.Text.Replace("'", "") + "',phone='" + txtSponPhone.Text.Replace("'", "") + "',address='" + txtSponAddress.Text.Replace("'", "") + "',national_id='" + txtSponID.Text.Replace("'", "") + "' where customer_number=" + txtCustNum.Text.Replace("'", ""));
                MessageBox.Show("تم تعديل العميل");
                CustomerForEdit.Cust_Load();
                CustomerForEdit.SetIndex(-1);
                ClearAndAuto();
            }
        }
        private void btnremove_Click(object sender, EventArgs e)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("هل تريد الحذف العميل نهائياً ؟؟", "حذف العميل", button,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DB.Run("delete from sponsor where customer_number=" + CustomerForEdit.GetValue());
                DB.Run("delete from customer where customer_number=" + CustomerForEdit.GetValue());
                MessageBox.Show("تم حذف العميل بنجاح");
                CustomerForEdit.Cust_Load();
                CustomerForEdit.SetIndex(-1);
                ClearAndAuto();
            }
        }
    }
}
