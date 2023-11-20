using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracking
{
    class crudControl
    {

        dbConnection db = new dbConnection();

        //show data with a table 
        public DataTable showData(string cat, int id)
        {
            db.CloseConnection();
            DataTable dt = new DataTable();
            try
            {
                db.OpenConection();
                string query = string.Format("select  expenseId, category, month, cost, method, description from expense where userId={0} and category ='{1}'", id, cat);
                MySqlCommand cmd = new MySqlCommand(query, db.con);
                MySqlDataReader reader = cmd.ExecuteReader();
                
                dt.Load(reader);
                db.CloseConnection();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }

        //delete the select data
        public void deleteData(string cat, int id, int eid)
        {
            db.CloseConnection();
            try
            {
                db.OpenConection();
                string query = string.Format("delete from expense where category = '{0}' and userId={1} and expenseId = {2}", cat, id, eid);
                int rowsAffected = db.ExecuteQueries(query);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Deleted successfully!");

                }
                else
                {
                    MessageBox.Show("failed.");
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        //add new data
        public void addData(int userId, string category, string month, double cost, string method, string desc)
        {
            db.CloseConnection();
            try
            {
                db.OpenConection();
                string query = string.Format("INSERT INTO expense (userId,category,month,cost,method,description) VALUES ({0},'{1}','{2}',{3},'{4}','{5}')", userId, category, month, cost, method, desc);

                int rowsAffected = db.ExecuteQueries(query);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Added successfully!");
                }
                else
                {
                    MessageBox.Show("failed.");
                }
                db.CloseConnection();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //update the existing data
        public void updateData(int expenseId, string category, string month, double cost, string method, string desc)
        {
            db.CloseConnection();
            try
            {
                db.OpenConection();
                string query = string.Format("update expense set category = '{0}', month ='{1}', cost = {2}, method = '{3}', description ='{4}' where expenseId = {5}; ", category, month, cost, method, desc, expenseId);
                Console.WriteLine(query);
                int rowsAffected = db.ExecuteQueries(query);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updated successfully!");
                }
                else
                {
                    MessageBox.Show("failed.");
                }
                db.CloseConnection();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
