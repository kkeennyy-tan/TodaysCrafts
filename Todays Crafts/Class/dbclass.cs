using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Todays_Crafts.Class
{
    class dbclass
    {
        public MySqlConnection conDB; // call connection

        public dbclass()
        {
            string host = "localhost";
            string database = "todayscrafts";
            string username = "root";
            string password = "admin";
            string port = "3306";
            string connection_string = "datasource = " + host + "; database = " + database + ";port = " + port + ";username = " + username + ";password = " + password + "; SslMode = none;";

            conDB = new MySqlConnection(connection_string);
            //string con = @"Data Source=HP\SQLEXPRESS01;Initial Catalog=TodaysCrafts;Integrated Security=True";
            //string con = @"Data Source=CISCO-27\SQLEXPRESS;Initial Catalog=TodaysCrafts;Integrated Security=True";
            // conDB = new SqlConnection(con); //connection string
        }
   
    }
}
