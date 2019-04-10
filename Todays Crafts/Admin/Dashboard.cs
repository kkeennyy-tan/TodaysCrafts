using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todays_Crafts
{
    public partial class Dashboard : Form
    {
        Timer t = new Timer();

        public Dashboard(string status)
        {
            InitializeComponent();
            lblstatus.Text = status;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login da = new Login();
            da.Show();
        }


        private void purchasebtn_Click(object sender, EventArgs e)
        {
            purchasecontrol1.BringToFront();
            homebtn.BackColor = Color.FromArgb(58, 69, 88);
            inventorybtn.BackColor = Color.FromArgb(58, 69, 88);
            purchasebtn.BackColor = Color.FromArgb(147,170,255);
            infobtn.BackColor = Color.FromArgb(58, 69, 88);
            employeebtn.BackColor = Color.FromArgb(58, 69, 88);
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            inventorycontrol2.BringToFront();
            homebtn.BackColor = Color.FromArgb(58, 69, 88);
            inventorybtn.BackColor = Color.FromArgb(255,190,190);
            purchasebtn.BackColor = Color.FromArgb(58, 69, 88);
            infobtn.BackColor = Color.FromArgb(58, 69, 88);
            employeebtn.BackColor = Color.FromArgb(58, 69, 88);
        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            infocontrol2.BringToFront();
            homebtn.BackColor = Color.FromArgb(58, 69, 88);
            inventorybtn.BackColor = Color.FromArgb(58, 69, 88);
            purchasebtn.BackColor = Color.FromArgb(58, 69, 88);
            infobtn.BackColor = Color.FromArgb(255,153,220);
            employeebtn.BackColor = Color.FromArgb(58, 69, 88);
        }

        private void employeebtn_Click(object sender, EventArgs e)
        {
            employeecontrol2.BringToFront();
            homebtn.BackColor = Color.FromArgb(58, 69, 88);
            inventorybtn.BackColor = Color.FromArgb(58, 69, 88);
            purchasebtn.BackColor = Color.FromArgb(58, 69, 88);
            infobtn.BackColor = Color.FromArgb(58, 69, 88);
            employeebtn.BackColor = Color.FromArgb(213,173,255);
            button3.BackColor = Color.FromArgb(58, 69, 88);
            
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            homecontrol3.BringToFront();
            homebtn.BackColor = Color.FromArgb(238, 96, 138);
            inventorybtn.BackColor = Color.FromArgb(58, 69, 88);
            purchasebtn.BackColor = Color.FromArgb(58, 69, 88);
            infobtn.BackColor = Color.FromArgb(58, 69, 88);
            employeebtn.BackColor = Color.FromArgb(58, 69, 88);
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.todaysCrafts);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'todaysCrafts.employee' table. You can move, or remove it, as needed.
            // this.employeeTableAdapter.Fill(this.todaysCrafts.employee);

            // Real time clock
            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();

            if (DateTime.UtcNow.AddHours(8).Hour < 12)
            {
                lblGreeting.Text = "Good Morning";
            }
            else if (DateTime.UtcNow.AddHours(8).Hour < 17)
            {
                lblGreeting.Text = "Good Afternoon"; 
            }
            else
            {
                lblGreeting.Text = "Good Evening";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void homecontrol2_Load(object sender, EventArgs e)
        {

        }
    }
}
