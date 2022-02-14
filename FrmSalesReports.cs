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
    public partial class FrmSalesReports : Form
    {
        public FrmSalesReports()
        {
            InitializeComponent();
        }

        private void SalesReports_Load(object sender, EventArgs e)
        {
            rdCustomer.Checked = true;
            dgvSearchSale.DataSource = DB.GetData("select customer.customer_number,customer_name,item_name,item_price,installment_number,sale_date from customer,sales where sales.customer_number=customer.customer_number");
            dgvSearchSale.Columns["customer_number"].Visible = false;
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Search() {
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
                    strPatt="(sale_date >= #" + dateFrom.Value.ToString("yyyy/MM/dd 00:00") + "# and sale_date <= #" + dateTo.Value.ToString("yyyy/MM/dd 23:59") + "#)";
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
                }
                ((DataTable)dgvSearchSale.DataSource).DefaultView.RowFilter = strPatt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void txtCstomerSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
