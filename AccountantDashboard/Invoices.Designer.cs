namespace AccountantDashboard
{
    partial class lblInvoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
            this.btnIReturn = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.PnACDashboard = new System.Windows.Forms.Panel();
            this.btnClearInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.PnACDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceID.Location = new System.Drawing.Point(50, 70);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(150, 25);
            this.lblInvoiceID.TabIndex = 0;
            this.lblInvoiceID.Text = "Invoice ID";
            this.lblInvoiceID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceID.Location = new System.Drawing.Point(220, 70);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(230, 20);
            this.txtInvoiceID.TabIndex = 1;
            // 
            // txtRentalID
            // 
            this.txtRentalID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRentalID.Location = new System.Drawing.Point(220, 170);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(231, 20);
            this.txtRentalID.TabIndex = 4;
            // 
            // lblRentalID
            // 
            this.lblRentalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalID.Location = new System.Drawing.Point(50, 170);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(150, 25);
            this.lblRentalID.TabIndex = 3;
            this.lblRentalID.Text = "Rental ID";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(220, 120);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(231, 20);
            this.txtCustomerName.TabIndex = 6;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(50, 120);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(150, 25);
            this.lblCustomerName.TabIndex = 5;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnGenerateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateInvoice.Location = new System.Drawing.Point(734, 70);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(120, 40);
            this.btnGenerateInvoice.TabIndex = 7;
            this.btnGenerateInvoice.Text = "Generate";
            this.btnGenerateInvoice.UseVisualStyleBackColor = false;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // btnIReturn
            // 
            this.btnIReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnIReturn.FlatAppearance.BorderSize = 0;
            this.btnIReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIReturn.ForeColor = System.Drawing.Color.Black;
            this.btnIReturn.Location = new System.Drawing.Point(764, -1);
            this.btnIReturn.Name = "btnIReturn";
            this.btnIReturn.Size = new System.Drawing.Size(120, 40);
            this.btnIReturn.TabIndex = 8;
            this.btnIReturn.Text = "Return";
            this.btnIReturn.UseVisualStyleBackColor = false;
            this.btnIReturn.Click += new System.EventHandler(this.btnIReturn_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.Location = new System.Drawing.Point(734, 130);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(120, 40);
            this.btnPrintInvoice.TabIndex = 9;
            this.btnPrintInvoice.Text = "Print";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Location = new System.Drawing.Point(220, 220);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(231, 20);
            this.txtTotalAmount.TabIndex = 11;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(50, 220);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(150, 25);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(54, 299);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(800, 220);
            this.dgvInvoice.TabIndex = 16;
            // 
            // PnACDashboard
            // 
            this.PnACDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.PnACDashboard.Controls.Add(this.btnIReturn);
            this.PnACDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnACDashboard.Location = new System.Drawing.Point(0, 0);
            this.PnACDashboard.Name = "PnACDashboard";
            this.PnACDashboard.Size = new System.Drawing.Size(884, 39);
            this.PnACDashboard.TabIndex = 17;
            // 
            // btnClearInvoice
            // 
            this.btnClearInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnClearInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnClearInvoice.Location = new System.Drawing.Point(734, 191);
            this.btnClearInvoice.Name = "btnClearInvoice";
            this.btnClearInvoice.Size = new System.Drawing.Size(120, 40);
            this.btnClearInvoice.TabIndex = 18;
            this.btnClearInvoice.Text = "Clear";
            this.btnClearInvoice.UseVisualStyleBackColor = false;
            this.btnClearInvoice.Click += new System.EventHandler(this.btnClearInvoice_Click);
            // 
            // lblInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(884, 531);
            this.Controls.Add(this.btnClearInvoice);
            this.Controls.Add(this.PnACDashboard);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.btnGenerateInvoice);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtRentalID);
            this.Controls.Add(this.lblRentalID);
            this.Controls.Add(this.txtInvoiceID);
            this.Controls.Add(this.lblInvoiceID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lblInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Invoice";
            this.Load += new System.EventHandler(this.lblInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.PnACDashboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnGenerateInvoice;
        private System.Windows.Forms.Button btnIReturn;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Panel PnACDashboard;
        private System.Windows.Forms.Button btnClearInvoice;
    }
}