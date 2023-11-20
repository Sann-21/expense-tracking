using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Expense_Tracking
{
    public partial class barchart : UserControl
    {
        dbConnection db = new dbConnection();
        customer c = new customer();
        public barchart()
        {
            InitializeComponent();
        }

        public void insertData(int id)
        {
            
            db.CloseConnection();
            chart1.Titles.Clear();
            chart1.Titles.Add("Monthly Expense");
            chart1.ChartAreas[0].AxisX.Title = "months";
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Title = "total cost";
            chart1.Series.Clear();
            chart1.Series.Add("food");
            chart1.Series.Add("clothes");
            chart1.Series.Add("transport");
            chart1.Series.Add("education");


            // Fetch data from the MySQL table
            List<string> months = new List<string>();
            List<double> foodData = new List<double>();
            List<double> clothesData = new List<double>();
            List<double> transportData = new List<double>();
            List<double> educationData = new List<double>();

            db.OpenConection();
            string query = string.Format(" select month,food,clothes,transport,education from expense_pretty where userId={0} ORDER BY FIELD(month,'Jan','Feb','Mar', 'Apr', 'May', 'Jun', 'Jul' ,'Aug', 'Sep', 'Oct', 'Nov', 'Dec');", c.getCusId());
            MySqlCommand command = new MySqlCommand(query, db.con);


            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                months.Add(reader["month"].ToString());
                foodData.Add(Convert.ToDouble(reader["food"]));
                clothesData.Add(Convert.ToDouble(reader["clothes"]));
                transportData.Add(Convert.ToDouble(reader["transport"]));
                educationData.Add(Convert.ToDouble(reader["education"]));
            }


            // Add data to the chart
            for (int i = 0; i < months.Count; i++)
            {
                chart1.Series["food"].Points.AddXY(months[i], foodData[i]);
                chart1.Series["clothes"].Points.AddXY(months[i], clothesData[i]);
                chart1.Series["transport"].Points.AddXY(months[i], transportData[i]);
                chart1.Series["education"].Points.AddXY(months[i], educationData[i]);
            }

            // Add the chart to the form
            this.Controls.Add(chart1);
        }
    }
}
