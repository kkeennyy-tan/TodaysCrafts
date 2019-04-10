using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Todays_Crafts.Class
{
    class db
    {
        public MySqlConnection con;

        public string host { set; get; }

        public string username { set; get; }

        public string password { set; get; }

        public string port { set; get; }

        public string database { set; get; }

        public string connection_string;

        public void getdata()
        {
            string connection_string = "datasource = " + host + "; database = " + database + ";port = " + port + ";username = " + username + ";password = " + password + "; SslMode = none;";
            con = new MySqlConnection(connection_string);
        }




    }
}
