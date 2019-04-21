using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Todays_Crafts.Class;
using System.IO;

namespace Todays_Crafts
{
    public partial class FrmAppConfig : Form
    {
        dbclass connect = new dbclass();
        public List<string> mylist = new List<string>();

        //create temporary connection
        private string temp_database;
        private string temp_username;
        private string temp_password;
        private string temp_port;

        public static string temp_host;
        public static string _verify = "1";

        public FrmAppConfig()
        {
            InitializeComponent();
        }

        //names of the variables to move the form
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void INPUT_CONNECTION()
        {
            connect.host = txtHost.Text;
            connect.database = txtDatabase.Text;
            connect.username = txtUsername.Text;
            connect.password = txtPassword.Text;
            connect.port = txtPort.Text;
            
            connect.getdata();
            try
            {
                connect.conDB.Open();
                MessageBox.Show("Connected");
                connect.conDB.Close();
            }
            catch
            {
                MessageBox.Show("Check your configuration");
            }
        }
        private void WRITE_TEXT()
        {
            //FileStream create = File.Open(txtPath.Text, FileMode.Create);
            FileStream create = File.Open(@"C:\Users\ADMIN\Desktop\todays crafts\super updated\TodaysCrafts-master\db\db.ini", FileMode.Create);
            using (StreamWriter newtask = new StreamWriter(create))
            {
                newtask.WriteLine(txtHost.Text);
                newtask.WriteLine(txtDatabase.Text);
                newtask.WriteLine(txtUsername.Text);
                newtask.WriteLine(txtPassword.Text);
                newtask.WriteLine(txtPort.Text);
                
            }
        }

        public void LOAD_FROMTEXT_TEMP()
        {
            try
            {
                var fileStream = new FileStream(@"C:\Users\ADMIN\Desktop\todays crafts\super updated\TodaysCrafts-master\db\db.ini ", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while((line = streamReader.ReadLine())!=null)
                    {
                        mylist.Add(line);
                    }
                    temp_host = mylist[0].ToString();
                    temp_database = mylist[1].ToString();
                    temp_username = mylist[2].ToString();
                    temp_password = mylist[3].ToString();
                    temp_port = mylist[4].ToString();

                }
            }
            catch (Exception )
            {
                MessageBox.Show("no connection");
            }
        }

        private void FrmAppConfig_Load(object sender, EventArgs e)
        {

            if(_verify == "1")
            {
                LOAD_FROMTEXT_TEMP();
                connect.host = temp_host;
                connect.database = temp_database;
                connect.username = temp_username;
                connect.password = temp_password;
                connect.port = temp_port;
                connect.getdata();
                try
                {
                    connect.conDB.Open();
                    MessageBox.Show("connected");
                    connect.conDB.Close();
                    // If connected show the login form
                    this.Hide();
                    Login f2 = new Login();
                    f2.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("check the connection!1");
                }
            }
            else
            {
                MessageBox.Show("Input your connection");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INPUT_CONNECTION();
            WRITE_TEXT();
            // if write text is done
            // change the verify to 1 again for automate the reading the config file
            _verify = "1";
            Application.Restart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FrmAppConfig_MouseMove(object sender, MouseEventArgs e)
        {
            //for a movable form
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void FrmAppConfig_MouseUp(object sender, MouseEventArgs e)
        {
            //for a movable form
            mouseDown = false;
        }

        private void FrmAppConfig_MouseDown(object sender, MouseEventArgs e)
        {
            //for a movable form
            mouseDown = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "+++SELECT FOLDER+++";
            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath + "\\db.ini";
            } */
        }
    }
}
