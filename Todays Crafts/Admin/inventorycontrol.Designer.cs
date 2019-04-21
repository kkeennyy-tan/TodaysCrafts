namespace Todays_Crafts
{
    partial class inventorycontrol
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventorycontrol));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todaysCraftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todaysCrafts = new Todays_Crafts.TodaysCrafts();
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryTableAdapter = new Todays_Crafts.TodaysCraftsTableAdapters.inventoryTableAdapter();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tshirt_inventory1 = new Todays_Crafts.Inventory.tshirt_inventory();
            this.plate_inventory1 = new Todays_Crafts.Inventory.plate_inventory();
            this.pen_inventory1 = new Todays_Crafts.Inventory.pen_inventory();
            this.mug_inventory2 = new Todays_Crafts.Inventory.mug_inventory();
            this.mug_inventory1 = new Todays_Crafts.Inventory.mug_inventory();
            this.lanyard_inventory1 = new Todays_Crafts.Inventory.lanyard_inventory();
            this.fan_inventory1 = new Todays_Crafts.Inventory.fan_inventory();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.background11 = new Todays_Crafts.Inventory.background1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todaysCraftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todaysCrafts)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(88)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(26, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 66);
            this.panel1.TabIndex = 64;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(12, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 36);
            this.label15.TabIndex = 1;
            this.label15.Text = "0";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(16, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "TOTAL";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.todaysCraftsBindingSource;
            // 
            // todaysCraftsBindingSource
            // 
            this.todaysCraftsBindingSource.DataSource = this.todaysCrafts;
            this.todaysCraftsBindingSource.Position = 0;
            // 
            // todaysCrafts
            // 
            this.todaysCrafts.DataSetName = "TodaysCrafts";
            this.todaysCrafts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 57;
            this.label1.Text = "INVENTORY";
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.search_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.search_txt.Location = new System.Drawing.Point(687, 53);
            this.search_txt.Multiline = true;
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(200, 29);
            this.search_txt.TabIndex = 17;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(90)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.label21);
            this.panel3.Location = new System.Drawing.Point(925, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(76, 29);
            this.panel3.TabIndex = 66;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(11, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 18);
            this.label21.TabIndex = 49;
            this.label21.Text = "Search";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(779, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 67;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(684, 120);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 13);
            this.label22.TabIndex = 68;
            this.label22.Text = "Select Product:";
            // 
            // tshirt_inventory1
            // 
            this.tshirt_inventory1.Location = new System.Drawing.Point(18, 151);
            this.tshirt_inventory1.Name = "tshirt_inventory1";
            this.tshirt_inventory1.Size = new System.Drawing.Size(973, 421);
            this.tshirt_inventory1.TabIndex = 75;
            // 
            // plate_inventory1
            // 
            this.plate_inventory1.Location = new System.Drawing.Point(18, 151);
            this.plate_inventory1.Name = "plate_inventory1";
            this.plate_inventory1.Size = new System.Drawing.Size(973, 421);
            this.plate_inventory1.TabIndex = 74;
            // 
            // pen_inventory1
            // 
            this.pen_inventory1.Location = new System.Drawing.Point(18, 151);
            this.pen_inventory1.Name = "pen_inventory1";
            this.pen_inventory1.Size = new System.Drawing.Size(973, 421);
            this.pen_inventory1.TabIndex = 73;
            // 
            // mug_inventory2
            // 
            this.mug_inventory2.Location = new System.Drawing.Point(18, 151);
            this.mug_inventory2.Name = "mug_inventory2";
            this.mug_inventory2.Size = new System.Drawing.Size(973, 421);
            this.mug_inventory2.TabIndex = 72;
            // 
            // mug_inventory1
            // 
            this.mug_inventory1.Location = new System.Drawing.Point(18, 151);
            this.mug_inventory1.Name = "mug_inventory1";
            this.mug_inventory1.Size = new System.Drawing.Size(973, 421);
            this.mug_inventory1.TabIndex = 71;
            // 
            // lanyard_inventory1
            // 
            this.lanyard_inventory1.Location = new System.Drawing.Point(18, 151);
            this.lanyard_inventory1.Name = "lanyard_inventory1";
            this.lanyard_inventory1.Size = new System.Drawing.Size(973, 421);
            this.lanyard_inventory1.TabIndex = 70;
            // 
            // fan_inventory1
            // 
            this.fan_inventory1.Location = new System.Drawing.Point(18, 151);
            this.fan_inventory1.Name = "fan_inventory1";
            this.fan_inventory1.Size = new System.Drawing.Size(973, 421);
            this.fan_inventory1.TabIndex = 69;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(90)))), ((int)(((byte)(89)))));
            this.panel2.BackgroundImage = global::Todays_Crafts.Properties.Resources.search;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(891, 53);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(39, 29);
            this.panel2.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // background11
            // 
            this.background11.Location = new System.Drawing.Point(18, 151);
            this.background11.Name = "background11";
            this.background11.Size = new System.Drawing.Size(973, 421);
            this.background11.TabIndex = 76;
            // 
            // inventorycontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.background11);
            this.Controls.Add(this.tshirt_inventory1);
            this.Controls.Add(this.plate_inventory1);
            this.Controls.Add(this.pen_inventory1);
            this.Controls.Add(this.mug_inventory2);
            this.Controls.Add(this.mug_inventory1);
            this.Controls.Add(this.lanyard_inventory1);
            this.Controls.Add(this.fan_inventory1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "inventorycontrol";
            this.Size = new System.Drawing.Size(1025, 572);
            this.Load += new System.EventHandler(this.inventorycontrol_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todaysCraftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todaysCrafts)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private TodaysCrafts todaysCrafts;
        private TodaysCraftsTableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.BindingSource todaysCraftsBindingSource;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label22;
        private Inventory.fan_inventory fan_inventory1;
        private Inventory.lanyard_inventory lanyard_inventory1;
        private Inventory.mug_inventory mug_inventory1;
        private Inventory.mug_inventory mug_inventory2;
        private Inventory.pen_inventory pen_inventory1;
        private Inventory.plate_inventory plate_inventory1;
        private Inventory.tshirt_inventory tshirt_inventory1;
        private Inventory.background1 background11;
    }
}
