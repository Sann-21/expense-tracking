using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracking
{
    class customer
    {
        private static int cusId;
        private static string user;
        dbConnection db = new dbConnection();

        public int getCusId()
        {
            return cusId;
        }
        public string getUsername()
        {
            return user;
        }

        //login the user into their account
        public bool loginUser(string username, string password)
        {
            try
            {
                db.OpenConection();
                string query = string.Format("select userId, username from user where username = '{0}' and password = '{1}'", username, password);
                
                MySqlCommand cmd = new MySqlCommand(query, db.con);
                object obj = cmd.ExecuteScalar();
                if (Convert.ToInt32(obj) > 0)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cusId = reader.GetInt32("userId");
                        user = reader.GetString("username");
                    }
                    return true;
                }
                db.CloseConnection();
                MessageBox.Show("login Failed");

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return false;
        }

        // validate and register new user
        public void registerUser(string username, string password)
        {
            try
            {
                db.OpenConection();
                string query = string.Format("INSERT INTO user (username,password) VALUES ('{0}','{1}')", username, password);

                int rowsAffected = db.ExecuteQueries(query);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User registered successfully!");
                }
                else
                {
                    MessageBox.Show("Registration failed.");
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
