﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using Todays_Crafts.Class;
using MySql.Data.MySqlClient;

namespace Todays_Crafts
{
    public partial class inventorycontrol : UserControl
    {
        dbclass con = new dbclass(); // to be called in forms where you created your class create object
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        DataSet dt;


        public inventorycontrol()
        {
            InitializeComponent();
            DisplayData();
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.conDB.Open();
            DataSet ds = new DataSet();
            adapt = new MySqlDataAdapter("select * from inventory", con.conDB);
            adapt.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            con.conDB.Close();
        }

        //Clear Data  
        private void ClearData()
        {
           /* textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";*/
            
        }

        //Insert Data 
        private void button1_Click(object sender, EventArgs e)
        {
            /*if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "")
            {
                cmd = new MySqlCommand("insert into inventory(brand,serial_number,product_code,description,category,on_stock,out_of_stock,unit_price,wholesale_price,minimum_order,manufacturer,supplier_address,email,contact_no,date_of_purchase,remarks) values(@brand,@serial_number,@product_code,@description,@category,@on_stock,@out_of_stock,@unit_price,@wholesale_price,@minimum_order,@manufacturer,@supplier_address,@email,@contact_no,@date_of_purchase,@remarks)", con.conDB);
                con.conDB.Open();
                cmd.Parameters.AddWithValue("@brand", textBox2.Text);
                cmd.Parameters.AddWithValue("@serial_number", textBox3.Text);
                cmd.Parameters.AddWithValue("@product_code", textBox4.Text);
                cmd.Parameters.AddWithValue("@description", textBox5.Text);
                cmd.Parameters.AddWithValue("@category", textBox6.Text);
                cmd.Parameters.AddWithValue("@on_stock", textBox7.Text);
                cmd.Parameters.AddWithValue("@out_of_stock", textBox8.Text);
                cmd.Parameters.AddWithValue("@unit_price", textBox9.Text);
                cmd.Parameters.AddWithValue("@wholesale_price", textBox10.Text);
                cmd.Parameters.AddWithValue("@minimum_order", textBox11.Text);
                cmd.Parameters.AddWithValue("@manufacturer", textBox12.Text);
                cmd.Parameters.AddWithValue("@supplier_address", textBox13.Text);
                cmd.Parameters.AddWithValue("@email", textBox14.Text);
                cmd.Parameters.AddWithValue("@contact_no", textBox15.Text);
                cmd.Parameters.AddWithValue("@date_of_purchase", textBox16.Text);
                cmd.Parameters.AddWithValue("@remarks", textBox17.Text);
                cmd.ExecuteNonQuery();
                con.conDB.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }*/
        }

        //update data
        private void button2_Click(object sender, EventArgs e)
        {
           /* if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "")
            {
                cmd = new MySqlCommand("update inventory set brand = @brand,serial_number = @serial_number,product_code = @product_code,description = @description,category = @category,on_stock = @on_stock,out_of_stock = @out_of_stock,unit_price = @unit_price,wholesale_price = @wholesale_price,minimum_order = @minimum_order,manufacturer = @manufacturer,supplier_address = @supplier_address,email = @email,contact_no = @contact_no,date_of_purchase = @date_of_purchase,remarks = @remarks where id=@id", con.conDB);
                con.conDB.Open();
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@brand", textBox2.Text);
                cmd.Parameters.AddWithValue("@serial_number", textBox3.Text);
                cmd.Parameters.AddWithValue("@product_code", textBox4.Text);
                cmd.Parameters.AddWithValue("@description", textBox5.Text);
                cmd.Parameters.AddWithValue("@category", textBox6.Text);
                cmd.Parameters.AddWithValue("@on_stock", textBox7.Text);
                cmd.Parameters.AddWithValue("@out_of_stock", textBox8.Text);
                cmd.Parameters.AddWithValue("@unit_price", textBox9.Text);
                cmd.Parameters.AddWithValue("@wholesale_price", textBox10.Text);
                cmd.Parameters.AddWithValue("@minimum_order", textBox11.Text);
                cmd.Parameters.AddWithValue("@manufacturer", textBox12.Text);
                cmd.Parameters.AddWithValue("@supplier_address", textBox13.Text);
                cmd.Parameters.AddWithValue("@email", textBox14.Text);
                cmd.Parameters.AddWithValue("@contact_no", textBox15.Text);
                cmd.Parameters.AddWithValue("@date_of_purchase", textBox16.Text);
                cmd.Parameters.AddWithValue("@remarks", textBox17.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.conDB.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }*/
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
           /* textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            textBox12.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            textBox13.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            textBox14.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            textBox15.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            textBox16.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            textBox17.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();*/

        }

        private void inventorycontrol_Load(object sender, EventArgs e)
        {
            
        }


        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        //delete data
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.conDB.Open();
               // cmd = new MySqlCommand("DELETE FROM inventory WHERE id = '" + textBox1.Text + "'", con.conDB);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Selected Contact Details Deleted");
                adapt = new MySqlDataAdapter("SELECT * FROM employee ORDER BY id ", con.conDB);
                dt = new DataSet();
                adapt.Fill(dt);
                //dataGridView1.DataSource = dt.Tables[0];
                con.conDB.Close();
                DisplayData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inventorycontrol_Load_1(object sender, EventArgs e)
        {

            //label15.Text = dataGridView1.Rows.Count.ToString();\


            // adding item for combobox OrderType
            comboBox1.Items.Add("Fan");
            comboBox1.Items.Add("Lanyard");
            comboBox1.Items.Add("Mug");
            comboBox1.Items.Add("Pen");
            comboBox1.Items.Add("Plate");
            comboBox1.Items.Add("Tshirt");

        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            searchData(search_txt.Text);
        }

        public void searchData(string valueToFind)
        {
            string searchQuery = "SELECT * FROM inventory WHERE CONCAT (brand,serial_number) LIKE '%" + valueToFind + "%'";
            MySqlDataAdapter adapt = new MySqlDataAdapter(searchQuery, con.conDB);
            DataSet dt = new DataSet();
            adapt.Fill(dt);
            //dataGridView1.DataSource = dt.Tables[0];

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show usercontrol to purchase
            if (comboBox1.Text.Equals("Fan")) fans1();
            if (comboBox1.Text.Equals("Lanyard")) lanyards1();
            if (comboBox1.Text.Equals("Mug")) mugs1();
            if (comboBox1.Text.Equals("Pen")) pens1();
            if (comboBox1.Text.Equals("Plate")) plates1();
            if (comboBox1.Text.Equals("Tshirt")) shirt1();
        }

        void fans1()
        {
            fan_inventory1.BringToFront();
        }

        void lanyards1()
        {
            lanyard_inventory1.BringToFront();
        }

        void mugs1()
        {
            mug_inventory1.BringToFront();
        }

        void pens1()
        {
            pen_inventory1.BringToFront();
        }

        void plates1()
        {
            plate_inventory1.BringToFront();
        }

        void shirt1()

        {
            tshirt_inventory1.BringToFront();
        }

       
    }
    }

