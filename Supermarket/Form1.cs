using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Form1 : Form
    {
        private Supermarket sm;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSupermarket(object sender, EventArgs e)
        {
            sm = new Supermarket(txtChain.Text, txtLocation.Text);
            lblChain.Text = $"Chain: {txtChain.Text}";
            lblLocation.Text = $"Location: {txtLocation.Text}";

            btnSupermarket.ToggleEnabled();
            txtChain.ToggleEnabled();
            txtLocation.ToggleEnabled();
            btnAddCustomer.ToggleEnabled();
            txtName.ToggleEnabled();
            txtSurname.ToggleEnabled();
        }

        private void BtnAddCustomer(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 && txtSurname.Text.Length > 0)
            {
                sm.AddCustomer(new Customer(txtName.Text, txtSurname.Text));
                dgvCustomers.DataSource = sm.CustomerList.ToArray();
                txtName.Clear();
                txtSurname.Clear();
            }
        }
    }
}