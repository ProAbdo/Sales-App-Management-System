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
    
    public partial class FrmInstallmentReport : Form
    {
        public FrmInstallmentReport()
        {
            InitializeComponent();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void FrmInstallmentReport_Load(object sender, EventArgs e)
        {
            dgvInstallmentReport.DataSource= DB.GetData("select * from sales_view");
            dgvInstallmentReport.Columns["customer_number"].Visible = false;
            dgvInstallmentReport.Columns["item_number"].Visible = false;
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
        private void Search()
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
                }
                ((DataTable)dgvInstallmentReport.DataSource).DefaultView.RowFilter = strPatt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void OpenForm(Form form)
        {
            form.BackColor = this.BackColor;
            form.Font = new Font(this.Font.Name, this.Font.Size, this.Font.Style);
            form.WindowState = FormWindowState.Normal;
            form.Icon = this.Icon;
            form.Show();
        }
        private void dgvInstallmentReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInstallmentReport.Columns[e.ColumnIndex].Name == "تفاصيل")
            {
                int customer_num=int.Parse(dgvInstallmentReport.Rows[e.RowIndex].Cells["customer_number"].FormattedValue.ToString());
                int item_num=int.Parse(dgvInstallmentReport.Rows[e.RowIndex].Cells["item_number"].FormattedValue.ToString());
                OpenForm(new FrmDetailedInstallment(customer_num, item_num));
            }
        }
        private void dgvInstallmentReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvInstallmentReport.Columns[e.ColumnIndex].Name == "الحالة")
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
    }
}
