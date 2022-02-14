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
    public partial class FrmAddEditInstallment : Form
    {
        string customer_number, item_number,installment_num;
        public FrmAddEditInstallment()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FrmAddEditInstallment(string customer_number, string item_number, string installment_num)
        {
            this.customer_number = customer_number;
            this.item_number = item_number;
            this.installment_num = installment_num;
            InitializeComponent();
        }
        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (txtEditAppInstall.Text != "")
            {
                try
                {
                    string mx_edit="";
                    mx_edit = DB.GetData("select max(edit_installment)+1 from edit_installments where customer_number='" + customer_number + "'and item_number='" + item_number + "'and installment_num='" + installment_num + "'").Rows[0][0].ToString();
                    if (mx_edit == "") mx_edit = "1";
                    DB.Run("insert into edit_installments values('"+customer_number+"','"+item_number+"','"+installment_num+"','"+mx_edit+"','"+txtEditAppInstall.Text+"','"+ DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "')");
                    DB.Run("update sales set rest_pay=rest_pay-'" + txtEditAppInstall.Text + "'where customer_number = '" + customer_number + "'and item_number = '" + item_number + "'");
                    FrmActionEditInstallment obj = (FrmActionEditInstallment)Application.OpenForms["FrmActionEditInstallment"];
                    MessageBox.Show("تم الدفع بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obj.reload();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("!!! لم يتم ادخال قيمة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
