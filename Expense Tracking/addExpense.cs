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
    public partial class addExpense : UserControl
    {
        public string cat;
        public addExpense()
        {
            InitializeComponent();
            comboBoxMonth.SelectedIndex = 0;
            comboBoxMethod.SelectedIndex = 0;
        }

        private void addExpense_Load(object sender, EventArgs e)
        {
            textBoxCat.Text = cat;
        }

        public void loadCat()
        {
            textBoxCat.Text = cat;
            textBoxCost.Clear();
            richTextBoxDesc.Clear();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            int userId = c.getCusId();
            string category = textBoxCat.Text;
            string month = (string)comboBoxMonth.SelectedItem;
            double cost = double.Parse(textBoxCost.Text);
            string method = (string)comboBoxMethod.SelectedItem;
            string desc = richTextBoxDesc.Text;

            crudControl crud = new crudControl();
            crud.addData(userId, category, month, cost, method, desc);
            
            
        }
    }
}
