using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracking
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            dbConnection dbConnection = new dbConnection();
            dbConnection.check_connection();
        }

        private void linkReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            regForm regForm = new regForm();
            regForm.Show();
        }

        private void btnLg_Click(object sender, EventArgs e)
        {
            customer cus = new customer();
            bool flag = cus.loginUser(username.Text, password.Text);
            if(flag == true)
            {
                welcome w = new welcome();
                w.Show();
                this.Hide();

            }
        }
    }
}
