namespace WindowsFormsApp1
{
    partial class Form7
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.masterBandaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMaskapaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterJadwalPenerbanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterKodePromoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahStatusPenerbanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMaskapaiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masterJadwalPenerbanganToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masterKodePromoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahStatusPenerbanganToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(82, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Master Kode Promo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "semua kode promo yang terdaftar akan muncul di sini";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(205, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PresentaseDiskon";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MaksimumDiskon";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "BerlakuSampai";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Deskripsi";
            this.Column6.Name = "Column6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kode Promo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Berlaku sampai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Presentase Diskon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Maksimum Diskon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Deskripsi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(285, 358);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(189, 20);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(285, 323);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(285, 386);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(189, 20);
            this.numericUpDown2.TabIndex = 23;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(549, 298);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 75);
            this.textBox2.TabIndex = 24;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 24);
            this.button1.TabIndex = 25;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(-1, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 385);
            this.panel2.TabIndex = 27;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterBandaraToolStripMenuItem,
            this.masterMaskapaiToolStripMenuItem1,
            this.masterJadwalPenerbanganToolStripMenuItem1,
            this.masterKodePromoToolStripMenuItem1,
            this.ubahStatusPenerbanganToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(184, 385);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.log_out_unselected_72;
            this.pictureBox2.Location = new System.Drawing.Point(13, 313);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // masterBandaraToolStripMenuItem
            // 
            this.masterBandaraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterMaskapaiToolStripMenuItem,
            this.masterJadwalPenerbanganToolStripMenuItem,
            this.masterKodePromoToolStripMenuItem,
            this.ubahStatusPenerbanganToolStripMenuItem});
            this.masterBandaraToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.map_unselected_72;
            this.masterBandaraToolStripMenuItem.Name = "masterBandaraToolStripMenuItem";
            this.masterBandaraToolStripMenuItem.Size = new System.Drawing.Size(177, 20);
            this.masterBandaraToolStripMenuItem.Text = "master bandara";
            // 
            // masterMaskapaiToolStripMenuItem
            // 
            this.masterMaskapaiToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.plane_take_off_unselected_72;
            this.masterMaskapaiToolStripMenuItem.Name = "masterMaskapaiToolStripMenuItem";
            this.masterMaskapaiToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.masterMaskapaiToolStripMenuItem.Text = "master maskapai";
            // 
            // masterJadwalPenerbanganToolStripMenuItem
            // 
            this.masterJadwalPenerbanganToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.calendar_unselected_72;
            this.masterJadwalPenerbanganToolStripMenuItem.Name = "masterJadwalPenerbanganToolStripMenuItem";
            this.masterJadwalPenerbanganToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.masterJadwalPenerbanganToolStripMenuItem.Text = "master jadwal penerbangan";
            // 
            // masterKodePromoToolStripMenuItem
            // 
            this.masterKodePromoToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.purchase_tag_alt_selected_72;
            this.masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            this.masterKodePromoToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.masterKodePromoToolStripMenuItem.Text = "master kode promo";
            // 
            // ubahStatusPenerbanganToolStripMenuItem
            // 
            this.ubahStatusPenerbanganToolStripMenuItem.Name = "ubahStatusPenerbanganToolStripMenuItem";
            this.ubahStatusPenerbanganToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.ubahStatusPenerbanganToolStripMenuItem.Text = "ubah status penerbangan";
            // 
            // masterMaskapaiToolStripMenuItem1
            // 
            this.masterMaskapaiToolStripMenuItem1.Image = global::WindowsFormsApp1.Properties.Resources.plane_take_off_unselected_72;
            this.masterMaskapaiToolStripMenuItem1.Name = "masterMaskapaiToolStripMenuItem1";
            this.masterMaskapaiToolStripMenuItem1.Size = new System.Drawing.Size(177, 20);
            this.masterMaskapaiToolStripMenuItem1.Text = "Master maskapai";
            // 
            // masterJadwalPenerbanganToolStripMenuItem1
            // 
            this.masterJadwalPenerbanganToolStripMenuItem1.Image = global::WindowsFormsApp1.Properties.Resources.calendar_unselected_721;
            this.masterJadwalPenerbanganToolStripMenuItem1.Name = "masterJadwalPenerbanganToolStripMenuItem1";
            this.masterJadwalPenerbanganToolStripMenuItem1.Size = new System.Drawing.Size(177, 20);
            this.masterJadwalPenerbanganToolStripMenuItem1.Text = "Master jadwal penerbangan";
            // 
            // masterKodePromoToolStripMenuItem1
            // 
            this.masterKodePromoToolStripMenuItem1.Image = global::WindowsFormsApp1.Properties.Resources.purchase_tag_alt_selected_721;
            this.masterKodePromoToolStripMenuItem1.Name = "masterKodePromoToolStripMenuItem1";
            this.masterKodePromoToolStripMenuItem1.Size = new System.Drawing.Size(177, 20);
            this.masterKodePromoToolStripMenuItem1.Text = "Master kode promo";
            // 
            // ubahStatusPenerbanganToolStripMenuItem1
            // 
            this.ubahStatusPenerbanganToolStripMenuItem1.Image = global::WindowsFormsApp1.Properties.Resources.notepad_unselected_721;
            this.ubahStatusPenerbanganToolStripMenuItem1.Name = "ubahStatusPenerbanganToolStripMenuItem1";
            this.ubahStatusPenerbanganToolStripMenuItem1.Size = new System.Drawing.Size(177, 20);
            this.ubahStatusPenerbanganToolStripMenuItem1.Text = "Ubah Status Penerbangan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.menu_alt_72;
            this.pictureBox1.Location = new System.Drawing.Point(16, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.ImageKey = "(none)";
            this.button4.Location = new System.Drawing.Point(76, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 24);
            this.button4.TabIndex = 28;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem masterBandaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterMaskapaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterJadwalPenerbanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterKodePromoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubahStatusPenerbanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterMaskapaiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem masterJadwalPenerbanganToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem masterKodePromoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ubahStatusPenerbanganToolStripMenuItem1;
        private System.Windows.Forms.Button button4;
    }
}