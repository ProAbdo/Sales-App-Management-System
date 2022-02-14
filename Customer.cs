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
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Resize(object sender, EventArgs e)
        {
            cbxCust.Left = 0;
            cbxCust.Width = this.Width;
        }
        public void Cust_Load()
        {
            if (!this.DesignMode)
            {
                DataTable tblCust = DB.GetData("select customer_number,customer_name from customer");
                cbxCust.DataSource = tblCust;
                cbxCust.ValueMember = "customer_number";
                cbxCust.DisplayMember = "customer_name";
                cbxCust.Text = "";
            }
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            Cust_Load();
        }
        public ComboBox GetItems()
        {
            return cbxCust;
        }
        public bool IsSelected()
        {
            return ((cbxCust.SelectedIndex < 0) ? false : true);
        }
        public int GetIndex()
        {
            return cbxCust.SelectedIndex;
        }
        public void SetIndex(int index)
        {
            cbxCust.SelectedIndex = index;
        }
        public object GetValue()
        {
            return cbxCust.SelectedValue;
        }
    }
}
