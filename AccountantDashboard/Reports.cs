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
    public partial class Reports : Form
    {
        private Form dashboardForm; 

        
        public Reports(Form dashboard)
        {
            InitializeComponent();
            dashboardForm = dashboard; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardForm.Show(); 
            this.Close();         
        }
    }
}