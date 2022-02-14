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
    public partial class FrmActionEditSales : Form
    {
        string[] datainfo;
        public FrmActionEditSales()
        {
            InitializeComponent();
        }
        public FrmActionEditSales(string []datainfo)
        {
            this.datainfo = datainfo;
            InitializeComponent();
        }
        private void reload()
        {
            txtName.Text = datainfo[0];
            productName.Text=datainfo[1];
            productPrice.Text=datainfo[2];
            firstPay.Text=  datainfo[3];
            installment_numbers.Text=datainfo[4];

        }
        private void FrmActionEditSales_Load(object sender, EventArgs e)
        {
            reload();
        }
    }
}
