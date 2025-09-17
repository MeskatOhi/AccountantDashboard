using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountantDashboard
{
    public partial class lblAcDashboard : Form
    {
        public lblAcDashboard()
        {
            InitializeComponent();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Payments paymentForm = new Payments(this);
            paymentForm.Show();
            this.Hide();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            lblInvoices invoiceForm  = new lblInvoices(this);
            invoiceForm.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reportForm = new Reports(this);
            reportForm.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
