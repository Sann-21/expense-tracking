using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Expense_Tracking
{
    public class dbConnection
    {
        // change to your database here
        public MySqlConnection con = new MySqlConnection("server=localhost;uid=root;" + "pwd=####;database=adi");

        public void OpenConection()
        {
            con.Open();
            
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public int ExecuteQueries(string Query_)
        {
            MySqlCommand cmd = new MySqlCommand(Query_, con);
            int r = cmd.ExecuteNonQuery();
            return r;
        }

        public void check_connection()
        {
            bool result = false;

            try
            {
                con.Open();
                con.Close();
                result = true;
            }

            catch
            {
                result = false;
            }

            Console.WriteLine(result);
        }

        
    }
}
