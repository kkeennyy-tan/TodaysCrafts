using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todays_Crafts
{
    public partial class purchasecontrol : UserControl
    {
        public purchasecontrol()
        {
            InitializeComponent();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void purchasecontrol_Load(object sender, EventArgs e)
        {
            // adding item for combobox OrderType
            comboBox1.Items.Add("Fan");
            comboBox1.Items.Add("Lanyard");
            comboBox1.Items.Add("Mug");
            comboBox1.Items.Add("Pen");
            comboBox1.Items.Add("Plate");
            comboBox1.Items.Add("Tshirt");

            // generating automatic Os No.
            


            

           


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //show usercontrol to purchase
            if (comboBox1.Text.Equals("Fan")) fans();
            if (comboBox1.Text.Equals("Lanyard")) lanyards ();
            if (comboBox1.Text.Equals("Mug")) mugs();
            if (comboBox1.Text.Equals("Pen")) pens();
            if (comboBox1.Text.Equals("Plate")) plates();
            if (comboBox1.Text.Equals("Tshirt")) shirt();

        }
        void fans()
        {
            fan1.BringToFront();

        }
        void shirt()
        {
            tshirt1.BringToFront();
            
        }
        void lanyards()
        {
            lanyard1.BringToFront();
        }
        void mugs()
        {
            mug1.BringToFront();
        }
        void pens()
        {
            pen1.BringToFront();
        }
        void plates()
        {
            plate1.BringToFront();
        }


        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void background2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)comboBox1.SelectedItem;

            //string key = kvp.Key.ToString();
            //string value = kvp.Value.ToString();

            //label29.Text = key + " " + value;

            //comboBox1.SelectedItem.ToString.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*if (comboBox1.Text.Equals("tshirt")) tshirt();
            if (comboBox1.Text.Equals("fan")) fan();
            if (comboBox1.Text.Equals("lanyard")) lanyard();*/
        }
        void tshirt()
        {
           // tshirt1.BringToFront();
        }
        void fan()
        {
            //fan1.BringToFront();

        }
        void lanyard()
        {
           // lanyard1.BringToFront();
            

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
