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
    public partial class Payments : Form
    {
        private Form dashboardForm;

        public Payments(Form dashboard)
        {
            InitializeComponent();
            dashboardForm = dashboard;
        }

        private void Payments_Load(object sender, EventArgs e)
        {
           
            cmbPaymentType.Items.Clear();
            cmbPaymentType.Items.Add("Cash");
            cmbPaymentType.Items.Add("Card");
            cmbPaymentType.Items.Add("Bank Transfer");
            cmbPaymentType.SelectedIndex = 0;
            LoadPayments();


        }

        private void btnPReturn_Click(object sender, EventArgs e)
        {
            dashboardForm.Show();
            this.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtPaymentID.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            
            if (!int.TryParse(txtPaymentID.Text, out int paymentId))
            {
                MessageBox.Show("Payment ID must be a valid number.");
                return;
            }

            
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
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
                        "INSERT INTO PaymentTable ([Payment ID], [Customer Name], [Amount], [Payment Date], [Payment Type]) " +
                        "VALUES (@PaymentID, @CustomerName, @Amount, @PaymentDate, @PaymentType)", con);

                    cmd.Parameters.AddWithValue("@PaymentID", paymentId);
                    cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@PaymentDate", dtpPaymentDate.Value);
                    cmd.Parameters.AddWithValue("@PaymentType", cmbPaymentType.SelectedItem.ToString());



                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Payment added successfully!");
                    LoadPayments();


                    txtPaymentID.Clear();
                    txtCustomerName.Clear();
                    txtAmount.Clear();
                    cmbPaymentType.SelectedIndex = 0;
                    dtpPaymentDate.Value = DateTime.Today;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtPaymentID.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(txtPaymentID.Text, out int paymentId))
            {
                MessageBox.Show("Payment ID must be a valid number.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
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
                        "UPDATE PaymentTable " +
                        "SET [Customer Name] = @CustomerName, [Amount] = @Amount, [Payment Date] = @PaymentDate, [Payment Type] = @PaymentType " +
                        "WHERE [Payment ID] = @PaymentID", con);

                    cmd.Parameters.AddWithValue("@PaymentID", paymentId);
                    cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@PaymentDate", dtpPaymentDate.Value);
                    cmd.Parameters.AddWithValue("@PaymentType", cmbPaymentType.SelectedItem.ToString());



                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Payment updated successfully!");
                        LoadPayments();
                    }
                    else
                    {
                        MessageBox.Show("Payment ID not found. Update failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtPaymentID.Text))
            {
                MessageBox.Show("Please enter the Payment ID to delete.");
                return;
            }

            if (!int.TryParse(txtPaymentID.Text, out int paymentId))
            {
                MessageBox.Show("Payment ID must be a valid number.");
                return;
            }

            
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete Payment ID {paymentId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MUKO65T\SQLEXPRESS;Initial Catalog=AccountantDB;Integrated Security=True;TrustServercertificate=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                       "DELETE FROM PaymentTable WHERE [Payment ID] = @PaymentID", con);

                    cmd.Parameters.AddWithValue("@PaymentID", paymentId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Payment deleted successfully!");
                        LoadPayments();


                        txtPaymentID.Clear();
                        txtCustomerName.Clear();
                        txtAmount.Clear();
                        cmbPaymentType.SelectedIndex = 0;
                        dtpPaymentDate.Value = DateTime.Today;
                    }
                    else
                    {
                        MessageBox.Show("Payment ID not found. Deletion failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClearPayments_Click(object sender, EventArgs e)
        {
            
            txtPaymentID.Clear();
            txtCustomerName.Clear();
            txtAmount.Clear();

            
            if (cmbPaymentType.Items.Count > 0)
                cmbPaymentType.SelectedIndex = 0;

           
            dtpPaymentDate.Value = DateTime.Today;

            
            txtPaymentID.Focus();
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPayments.Rows[e.RowIndex];

                txtPaymentID.Text = row.Cells["Payment ID"].Value.ToString();
                txtCustomerName.Text = row.Cells["Customer Name"].Value.ToString();
                txtAmount.Text = row.Cells["Amount"].Value.ToString();
                dtpPaymentDate.Value = Convert.ToDateTime(row.Cells["Payment Date"].Value);
                cmbPaymentType.SelectedItem = row.Cells["Payment Type"].Value.ToString();
            }
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
                        "SELECT [Payment ID], [Customer Name], [Amount], [Payment Date], [Payment Type] FROM PaymentTable", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPayments.DataSource = dt;
                    dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


    }
}


