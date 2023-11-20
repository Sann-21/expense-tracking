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
    public partial class updateExpense : UserControl
    {
        public int expenseId { get; set; }
        public string category { get; set; }
        public string month { get; set; }
        public double cost { get; set; }
        public string method { get; set; }
        public string desc { get; set; }
        public int userId { get; set; }

        crudControl crud = new crudControl();

        public updateExpense()
        {
            InitializeComponent();
        }

        //show the existing data to update
        public void displayData()
        {
            textBoxCat.Text = category;
            comboBoxMonth.Text = month;
            textBoxCost.Text = cost.ToString();
            comboBoxMethod.Text = method;
            richTextBoxDesc.Text = desc;
        }

        private void btnUpdateExpense_Click(object sender, EventArgs e)
        {
            string category1 = textBoxCat.Text;
            string month1 = comboBoxMonth.Text;
            double cost1 = double.Parse(textBoxCost.Text);
            string method1 = comboBoxMethod.Text;
            string desc1 = richTextBoxDesc.Text;

           
        }

       
    }
}
