namespace WindowsFormsApp1
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.masterBandaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterJadwalPenerbanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterKodePromoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahStatusPenerbanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 88);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.menu_alt_72;
            this.button1.Location = new System.Drawing.Point(15, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 62);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(93, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Location = new System.Drawing.Point(-3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 370);
            this.panel2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.ImageKey = "(none)";
            this.button4.Location = new System.Drawing.Point(82, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 24);
            this.button4.TabIndex = 27;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.log_out_unselected_72;
            this.pictureBox1.Location = new System.Drawing.Point(15, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 57);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterBandaraToolStripMenuItem,
            this.masterMToolStripMenuItem,
            this.masterJadwalPenerbanganToolStripMenuItem,
            this.masterKodePromoToolStripMenuItem,
            this.ubahStatusPenerbanganToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(185, 370);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // masterBandaraToolStripMenuItem
            // 
            this.masterBandaraToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.map_unselected_72;
            this.masterBandaraToolStripMenuItem.Name = "masterBandaraToolStripMenuItem";
            this.masterBandaraToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterBandaraToolStripMenuItem.Text = "Master Bandara";
            this.masterBandaraToolStripMenuItem.Click += new System.EventHandler(this.masterBandaraToolStripMenuItem_Click);
            // 
            // masterMToolStripMenuItem
            // 
            this.masterMToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.plane_take_off_unselected_72;
            this.masterMToolStripMenuItem.Name = "masterMToolStripMenuItem";
            this.masterMToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterMToolStripMenuItem.Text = "Master Maskapai";
            // 
            // masterJadwalPenerbanganToolStripMenuItem
            // 
            this.masterJadwalPenerbanganToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.calendar_unselected_72;
            this.masterJadwalPenerbanganToolStripMenuItem.Name = "masterJadwalPenerbanganToolStripMenuItem";
            this.masterJadwalPenerbanganToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterJadwalPenerbanganToolStripMenuItem.Text = "Master Jadwal Penerbangan";
            // 
            // masterKodePromoToolStripMenuItem
            // 
            this.masterKodePromoToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.purchase_tag_alt_unselected_72;
            this.masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            this.masterKodePromoToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterKodePromoToolStripMenuItem.Text = "Master kode promo";
            // 
            // ubahStatusPenerbanganToolStripMenuItem
            // 
            this.ubahStatusPenerbanganToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.notepad_unselected_72;
            this.ubahStatusPenerbanganToolStripMenuItem.Name = "ubahStatusPenerbanganToolStripMenuItem";
            this.ubahStatusPenerbanganToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.ubahStatusPenerbanganToolStripMenuItem.Text = "Ubah status penerbangan";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem masterBandaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterJadwalPenerbanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterKodePromoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubahStatusPenerbanganToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
    }
}