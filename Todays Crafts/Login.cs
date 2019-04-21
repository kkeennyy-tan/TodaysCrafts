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
using Todays_Crafts.Class;
using MySql.Data.MySqlClient;



// dbclass connection string
namespace Todays_Crafts
{
    public partial class Login : Form
    {
        dbclass con = new dbclass(); // to be called in forms where you created your class create object 
        // dbclass= connection string
        
        public Login()
        {
            InitializeComponent();
        }

        //names of the variables to move the form
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void Uname_Click(object sender, EventArgs e)
        {
            uname.Clear();
            panel1.BackColor = Color.FromArgb(238, 96, 138);
            uname.ForeColor = Color.FromArgb(238, 96, 138);
            
            panel2.BackColor = Color.WhiteSmoke;
            password.ForeColor = Color.WhiteSmoke;
        }


        private void password_Click(object sender, EventArgs e)
        {
            password.Clear();
            panel2.BackColor = Color.FromArgb(238, 96, 138);
            password.ForeColor = Color.FromArgb(238, 96, 138);

            panel1.BackColor = Color.WhiteSmoke;
            uname.ForeColor = Color.WhiteSmoke;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Environment.Exit(0);
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            

                /*try
                {
                    con.conDB.Open();
                    label1.Text = "connected";
                    label1.ForeColor = Color.White;
                    con.conDB.Close();
                }
                catch
                {
                    label1.Text = "failed";
                }*/
             MySqlDataAdapter sda = new MySqlDataAdapter("SELECT status from employee WHERE username = '" + uname.Text + "' and password = '" + password.Text + "'", con.conDB);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             if(dt.Rows.Count==1)
             {
                 this.Hide();
                 if (dt.Rows[0][0].ToString()=="master")
                 {
                     Dashboard da = new Dashboard(dt.Rows[0][0].ToString());
                     da.Show();
                 }
                 else if (dt.Rows[0][0].ToString() == "user")
                 {
                     FrmEmployeeDashboard da= new FrmEmployeeDashboard (dt.Rows[0][0].ToString());
                     da.Show();
                 }
             } 
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label2.Text = FrmAppConfig.temp_host;
            this.KeyPreview = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmAppConfig sa = new FrmAppConfig();
            sa.Show();
            this.Hide();

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FrmAppConfig nn = new FrmAppConfig();
                nn.Show();
                this.Hide();
            }
        }

        private void sign_in_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            //for enter shortcut
            if (e.KeyCode == Keys.Enter)
            {
                sign_in.PerformClick();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //for a movable form
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //for a movable form
            mouseDown = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //for a movable form
            mouseDown = true;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            //for a movable form
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            //for a movable form
            mouseDown = false;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            //for a movable form
            mouseDown = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // change the value of the _verify for now reading the text file(.ini)
            FrmAppConfig._verify = "2";
            // back to the frmappconfig to modify connection
            this.Hide();
            FrmAppConfig f1 = new FrmAppConfig();
            f1.ShowDialog();
            
        }
    }
}
