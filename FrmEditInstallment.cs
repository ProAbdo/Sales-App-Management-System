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
    public partial class FrmEditInstallment : Form
    {
        public FrmEditInstallment()
        {
            InitializeComponent();
        }
        private void reload()
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
        private void FrmEditInstallment_Load(object sender, EventArgs e)
        {
            reload();
            rdCustomer.Checked = true;
            rdCustomer.CheckedChanged += delegate
            {
                Search();
            };
            rdSponsor.CheckedChanged += delegate
            {
                Search();
            };
            rdDate.CheckedChanged += delegate
            {
                Search();
            };
            rdProduct.CheckedChanged += delegate
            {
                Search();
            };
            dateFrom.TextChanged += delegate
            {
                Search();
            };
            dateTo.TextChanged += delegate
            {
                Search();
            };
        }
        public void Search()
        {
            try
            {
                string strPatt = "";
                if (rdDate.Checked)
                {
                    label1.Visible = false;
                    txtSearch.Visible = false;
                    label2.Visible = true;
                    dateFrom.Visible = true;
                    label3.Visible = true;
                    dateTo.Visible = true;
                    strPatt = "(sale_date >= #" + dateFrom.Value.ToString("yyyy/MM/dd 00:00") + "# and sale_date <= #" + dateTo.Value.ToString("yyyy/MM/dd 23:59") + "#)";
                }
                else
                {
                    label1.Visible = true;
                    txtSearch.Visible = true;
                    label2.Visible = false;
                    dateFrom.Visible = false;
                    label3.Visible = false;
                    dateTo.Visible = false;
                    if (rdSponsor.Checked)
                    {
                        DataTable tblSp = DB.GetData("select customer.customer_number from customer ,sponsor where sponsor.customer_number=customer.customer_number and sponsor_name like'%" + txtSearch.Text + "%'");
                        if (tblSp.Rows.Count > 0)
                        {
                            string strNums = "   ";
                            foreach (DataRow r in tblSp.Rows)
                            {
                                strNums += r[0] + " , ";
                            }
                            strNums = strNums.Substring(0, strNums.Length - 3);
                            strPatt = "customer_number in(" + strNums + ")";

                        }
                        else strPatt = "customer_number=0";
                    }
                    else if (rdProduct.Checked)
                    {
                        strPatt = "item_name";
                        strPatt += " like'%" + txtSearch.Text + "%'";
                    }
                    else if (rdCustomer.Checked)
                    {
                        strPatt = "customer_name";
                        strPatt += " like'%" + txtSearch.Text + "%'";
                    }
                    else if (rdstate.Checked)
                    {
                        strPatt = "state";
                        strPatt += " like'%" + txtSearch.Text + "%'";
                    }
                }
                ((DataTable)dgvSearch.DataSource).DefaultView.RowFilter = strPatt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearch.Columns[e.ColumnIndex].Name == "تعديل")
            {
                string customer_number = dgvSearch.Rows[e.RowIndex].Cells[1].Value.ToString();
                string item_number = dgvSearch.Rows[e.RowIndex].Cells[2].Value.ToString();
                new FrmMain().OpenForm(new FrmActionEditInstallment(customer_number,item_number));
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
