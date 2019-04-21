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
        public MySqlConnection conDB;

        public string host { set; get; }

        public string database { set; get; }

        public string username { set; get; }

        public string password { set; get; }

        public string port { set; get; }

        

        //public string connection_string;

        public void getdata()
        {
            string connection_string = "datasource = " + host + "; database = " + database + ";username = " + username + ";password = " + password + ";port = " + port + "; SslMode = none;";
            conDB = new MySqlConnection(connection_string);
        }
        /*  public MySqlConnection conDB; // call connection

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
     */
    }
}
