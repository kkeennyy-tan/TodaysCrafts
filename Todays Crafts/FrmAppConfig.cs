using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Todays_Crafts.Class;
using System.IO;

namespace Todays_Crafts
{
    public partial class FrmAppConfig : Form
    {
        db connect = new db();
        public FrmAppConfig()
        {
            InitializeComponent();
        }

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
                connect.con.Open();
                MessageBox.Show("Connected");
                connect.con.Close();
            }
            catch
            {
                MessageBox.Show("Check your configuration");
            }
        }
        private void WRITE_TEXT()
        {
            FileStream create = File.Open(txtPath.Text, FileMode.Create);
            //FileStream create = File.Open(@"C:\Users\ADMIN\Desktop\todays crafts\TodaysCrafts-master\db\db.ini ", FileMode.Create);
            using (StreamWriter newtask = new StreamWriter(create))
            {
                newtask.WriteLine(txtHost.Text);
                newtask.WriteLine(txtDatabase.Text);
                newtask.WriteLine(txtUsername.Text);
                newtask.WriteLine(txtPassword.Text);
                newtask.WriteLine(txtPort.Text);
                
            }
        }

        

        private void FrmAppConfig_Load(object sender, EventArgs e)
        {

            /*cboServer.Items.Add(".");
            cboServer.Items.Add("(local)");
            cboServer.Items.Add(@".\SQLEXPRESS01");
            cboServer.Items.Add(string.Format(@"{0}\SQLEXPRESS01", Environment.MachineName));
            cboServer.SelectedIndex = 3;*/


        }

        private void button1_Click(object sender, EventArgs e)
        {

            INPUT_CONNECTION();
            WRITE_TEXT();
           /* string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password{3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                FrmSqlHelper helper = new FrmSqlHelper(connectionString);
                if (helper.IsConnection)
                    MessageBox.Show("Test Connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login da = new Login();
            da.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password{3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                FrmSqlHelper helper = new FrmSqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    FrmAppSetting setting = new FrmAppSetting();
                    setting.SaveConnectionString("con", connectionString);
                    MessageBox.Show("Your Connection string has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPath_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "+++SELECT FOLDER+++";
            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath + "\\db.ini";
            }
        }
    }
}
