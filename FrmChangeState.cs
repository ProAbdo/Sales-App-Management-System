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
    public partial class FrmChangeState : Form
    {
        public FrmChangeState()
        {
            InitializeComponent();
        }
        private void reload()
        {
            dgvSearch.DataSource = DB.GetData("select customer.customer_number,item_number,customer_name,item_name,item_price,installment_number,sale_date ,state from customer,sales where sales.customer_number=customer.customer_number");
        }

        private void FrmChangeState_Load(object sender, EventArgs e)
        {
            rdCustomer.Checked = true;
            reload();
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
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dgvSearch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSearch.Columns[e.ColumnIndex].Name == "state")
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
                else if (e.Value.ToString() == "تم شكواه")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            for(int item = 0; item < dgvSearch.Rows.Count; item++)
            {
                string customer_num = dgvSearch.Rows[item].Cells["customer_number"].FormattedValue.ToString();
                string item_num = dgvSearch.Rows[item].Cells["item_number"].FormattedValue.ToString();
                string state= dgvSearch.Rows[item].Cells["state"].FormattedValue.ToString();
                DB.Run("update sales set state='" + state + "'where customer_number='" + customer_num + "'and item_number='" + item_num + "'");

            }
            MessageBox.Show("تم الحفظ","تم",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
