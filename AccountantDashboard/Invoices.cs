using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;



namespace AccountantDashboard
{
    public partial class lblInvoices : Form
    {
        private Form dashboardForm;
        public lblInvoices(Form dashboardForm)
        {
            InitializeComponent();
            this.dashboardForm = dashboardForm;
        }
        private void LoadPayments()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(
                    @"Data Source=DESKTOP-MUKO65T\SQLEXPRESS;Initial Catalog=AccountantDB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT [Invoice ID], [Customer Name], [Rental ID], [Total Amount] FROM InvoiceTable", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvInvoice.DataSource = dt;
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIReturn_Click(object sender, EventArgs e)
        {
            dashboardForm.Show();
            this.Close();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print Successful");
        }

        private void lblInvoices_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInvoiceID.Text) ||
               string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
               string.IsNullOrWhiteSpace(txtRentalID.Text) ||
               string.IsNullOrWhiteSpace(txtTotalAmount.Text)) 
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            if (!int.TryParse(txtInvoiceID.Text, out int InvoiceId))
            {
                MessageBox.Show("Payment ID must be a valid number.");
                return;
            }
            if (!int.TryParse(txtRentalID.Text, out int RentalId))
            {
                MessageBox.Show("Rental ID must be a valid number.");
                return;
            }


            if (!decimal.TryParse(txtTotalAmount.Text, out decimal Totalamount))
            {
                MessageBox.Show("Amount must be a valid number.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MUKO65T\SQLEXPRESS;Initial Catalog=AccountantDB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO InvoiceTable ([Invoice ID], [Customer Name], [Rental ID], [Total Amount] ) " +
                        "VALUES (@InvoiceID, @CustomerName, @RentalID, @TotalAmount)", con);

                    cmd.Parameters.AddWithValue("@PaymentID", InvoiceId);
                    cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@RentalID", RentalId);
                    cmd.Parameters.AddWithValue("@Amount", Totalamount);



                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Payment added successfully!");
                    LoadPayments();


                    txtInvoiceID.Clear();
                    txtCustomerName.Clear();
                    txtRentalID.Clear();
                    txtTotalAmount.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClearInvoice_Click(object sender, EventArgs e)
        {
            txtInvoiceID.Clear();
            txtCustomerName.Clear();
            txtRentalID.Clear();
            txtTotalAmount.Clear();
            txtInvoiceID.Focus();
        }
    }
}
