using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Expense_Tracking
{
    public partial class regForm : Form
    {
        public regForm()
        {
            InitializeComponent();
        }
        register reg = new register();
        customer cus = new customer();

        private void linkLg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            main m = new main();
            m.Show();
        }

        private void reg_username_TextChanged(object sender, EventArgs e)
        {
            string reg_name = reg_username.Text;
            
            if(!reg.IsAlphaNumeric(reg_name))
            {
                lbwarn1.Visible = true;
            }
            else
            {
                lbwarn1.Visible = false;
            }

        }

        private void reg_password_TextChanged(object sender, EventArgs e)
        {
            string reg_pw = reg_password.Text;

            if (!reg.IsPasswordValid(reg_pw))
            {
                lbwarn2.Visible = true;
            }
            else
            {
                lbwarn2.Visible = false;
            }

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            cus.registerUser(reg_username.Text, reg_password.Text);
        }
    }
}
