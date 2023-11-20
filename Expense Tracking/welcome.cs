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
    public partial class welcome : Form
    {
        
        addExpense addE = new addExpense();
        updateExpense upE = new updateExpense();
        barchart bc = new barchart();
        customer c = new customer();
        crudControl crud = new crudControl();

        public welcome()
        {
            InitializeComponent();
            

            pFcontrol.Controls.Add(addE);
            pFcontrol.Controls.Add(upE);
            pFcontrol.Controls.Add(bc);

            addE.Visible = false;
            upE.Visible = false;
            bc.Visible = false;

            labelUsername.Text = c.getUsername();

            //data table style
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 9);
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.AntiqueWhite;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        }
        

        private void btnfood_Click(object sender, EventArgs e)
        {
            addE.Visible = false;
            upE.Visible = false;
            bc.Visible = false;

            dataGridView1.Visible = true;
            dataGridView1.Enabled = true;

            labelCat.Text = "food";
            addE.cat = "food";
            int id = c.getCusId();

            dataGridView1.DataSource = crud.showData("food", id);
        }

        private void btnClothes_Click(object sender, EventArgs e)
        {
            addE.Visible = false;
            upE.Visible = false;
            bc.Visible = false;

            dataGridView1.Visible = true;
            dataGridView1.Enabled = true;

            labelCat.Text = "clothes";
            addE.cat = "clothes";

            int id = c.getCusId();

            dataGridView1.DataSource = crud.showData("clothes", id);

        }

        private void btnT_Click(object sender, EventArgs e)
        {
            addE.Visible = false;
            upE.Visible = false;
            bc.Visible = false;

            dataGridView1.Visible = true;
            dataGridView1.Enabled = true;

            labelCat.Text = "transport";
            addE.cat = "transport";

            int id = c.getCusId();

            dataGridView1.DataSource = crud.showData("transport", id);

        }

        private void btnEdu_Click(object sender, EventArgs e)
        {
            addE.Visible = false;
            upE.Visible = false;
            bc.Visible = false;

            dataGridView1.Visible = true;
            dataGridView1.Enabled = true;

            labelCat.Text = "education";
            addE.cat = "education";

            int id = c.getCusId();

            dataGridView1.DataSource = crud.showData("education", id);

        }

        //show addexpense form
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView1.Enabled = false;
            upE.Visible = false;
            bc.Visible = false;

            addE.Visible = true;
            addE.loadCat();
        }


        //to show the data when user first login
        private void welcome_Load(object sender, EventArgs e)
        {
            btnfood.PerformClick();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // A row is selected, proceed to get data
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                string expenseId = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

                int id = c.getCusId();
                int id2 = int.Parse(expenseId);

                var dia = MessageBox.Show($"Are you sure you want to delete from {labelCat.Text}", "Are you sure?", MessageBoxButtons.YesNo);

                if (dia  == DialogResult.Yes)
                {
                    crud.deleteData(labelCat.Text, id ,id2);
                }

            }
            else
            {
                // No row is selected, handle accordingly
                MessageBox.Show("Please select a row");

            }
            int cid = c.getCusId();
            dataGridView1.DataSource = crud.showData(labelCat.Text, cid);

        }

        // show update form
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView1.Enabled = false;
            addE.Visible = false;
            bc.Visible = false;

            upE.Visible = true;
            int id = c.getCusId();

            int rowIndex = dataGridView1.SelectedRows[0].Index;
            upE.expenseId = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            upE.category = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            upE.month = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            upE.cost = double.Parse(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString());
            upE.method = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            upE.desc = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            upE.userId = id;

            upE.displayData();
        }

        //show barchart to user
        private void btnBarchart_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView1.Enabled = false;
            addE.Visible = false;
            upE.Visible = false;

            bc.Visible = true;

            bc.insertData(c.getCusId());
        }

        //this is logout 
        private void linkLabelOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            main m = new main();
            m.Show();
        }
    }
}
