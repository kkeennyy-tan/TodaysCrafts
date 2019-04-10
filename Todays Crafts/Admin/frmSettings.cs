using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todays_Crafts.Admin
{
    public partial class frmSettings : UserControl
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pricelistSettings1.BringToFront();
        }

        private void pricelistSettings1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            salesSettings1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cashadvanceSettings1.BringToFront();
            
        }

        private void pricelistSettings1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
