namespace WaterWise
{
    partial class LihatKeluhan
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
            panel1 = new Panel();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            lblstatuskluhan = new Label();
            lbltglkeluhan = new Label();
            lblkeluhan = new Label();
            label1 = new Label();
            lbldeskripsikeluhan = new Label();
            lblnamakeluhan = new Label();
            panel3 = new Panel();
            btnlogout = new Button();
            btnhistory = new Button();
            btnlihatdata = new Button();
            btnkelolauser = new Button();
            btnubahlimit = new Button();
            btnlihatkeluhan = new Button();
            btneditprofile = new Button();
            lblmenukeluhan = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 451);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(maskedTextBox2);
            panel2.Controls.Add(maskedTextBox1);
            panel2.Controls.Add(lblstatuskluhan);
            panel2.Controls.Add(lbltglkeluhan);
            panel2.Controls.Add(lblkeluhan);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lbldeskripsikeluhan);
            panel2.Controls.Add(lblnamakeluhan);
            panel2.Location = new Point(179, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 451);
            panel2.TabIndex = 16;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(215, 288);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Disetujui";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(215, 237);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(215, 159);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(361, 27);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(215, 111);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(361, 27);
            maskedTextBox1.TabIndex = 7;
            // 
            // lblstatuskluhan
            // 
            lblstatuskluhan.AutoSize = true;
            lblstatuskluhan.Location = new Point(71, 288);
            lblstatuskluhan.Name = "lblstatuskluhan";
            lblstatuskluhan.Size = new Size(117, 20);
            lblstatuskluhan.TabIndex = 6;
            lblstatuskluhan.Text = "Status Keluhan : ";
            // 
            // lbltglkeluhan
            // 
            lbltglkeluhan.AutoSize = true;
            lbltglkeluhan.Location = new Point(71, 242);
            lbltglkeluhan.Name = "lbltglkeluhan";
            lbltglkeluhan.Size = new Size(129, 20);
            lbltglkeluhan.TabIndex = 5;
            lbltglkeluhan.Text = "Tanggal Keluhan : ";
            // 
            // lblkeluhan
            // 
            lblkeluhan.AutoSize = true;
            lblkeluhan.Font = new Font("Segoe UI", 14F);
            lblkeluhan.Location = new Point(71, 25);
            lblkeluhan.Name = "lblkeluhan";
            lblkeluhan.Size = new Size(159, 32);
            lblkeluhan.TabIndex = 4;
            lblkeluhan.Text = "Lihat Keluhan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 159);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 1;
            label1.Text = "Deskripsi Keluhan : ";
            // 
            // lbldeskripsikeluhan
            // 
            lbldeskripsikeluhan.AutoSize = true;
            lbldeskripsikeluhan.Location = new Point(71, 159);
            lbldeskripsikeluhan.Name = "lbldeskripsikeluhan";
            lbldeskripsikeluhan.Size = new Size(137, 20);
            lbldeskripsikeluhan.TabIndex = 1;
            lbldeskripsikeluhan.Text = "Deskripsi Keluhan : ";
            // 
            // lblnamakeluhan
            // 
            lblnamakeluhan.AutoSize = true;
            lblnamakeluhan.Location = new Point(71, 111);
            lblnamakeluhan.Name = "lblnamakeluhan";
            lblnamakeluhan.Size = new Size(60, 20);
            lblnamakeluhan.TabIndex = 0;
            lblnamakeluhan.Text = "Nama : ";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnlogout);
            panel3.Controls.Add(btnhistory);
            panel3.Controls.Add(btnlihatdata);
            panel3.Controls.Add(btnkelolauser);
            panel3.Controls.Add(btnubahlimit);
            panel3.Controls.Add(btnlihatkeluhan);
            panel3.Controls.Add(btneditprofile);
            panel3.Controls.Add(lblmenukeluhan);
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(173, 451);
            panel3.TabIndex = 17;
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(38, 401);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(85, 29);
            btnlogout.TabIndex = 23;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = true;
            // 
            // btnhistory
            // 
            btnhistory.Location = new Point(29, 267);
            btnhistory.Name = "btnhistory";
            btnhistory.Size = new Size(136, 31);
            btnhistory.TabIndex = 22;
            btnhistory.Text = "History Pengguna";
            btnhistory.UseVisualStyleBackColor = true;
            // 
            // btnlihatdata
            // 
            btnlihatdata.Location = new Point(29, 232);
            btnlihatdata.Name = "btnlihatdata";
            btnlihatdata.Size = new Size(114, 29);
            btnlihatdata.TabIndex = 21;
            btnlihatdata.Text = "Lihat Data";
            btnlihatdata.UseVisualStyleBackColor = true;
            // 
            // btnkelolauser
            // 
            btnkelolauser.Location = new Point(29, 197);
            btnkelolauser.Name = "btnkelolauser";
            btnkelolauser.Size = new Size(94, 29);
            btnkelolauser.TabIndex = 20;
            btnkelolauser.Text = "Kelola User";
            btnkelolauser.UseVisualStyleBackColor = true;
            // 
            // btnubahlimit
            // 
            btnubahlimit.Location = new Point(29, 162);
            btnubahlimit.Name = "btnubahlimit";
            btnubahlimit.Size = new Size(114, 29);
            btnubahlimit.TabIndex = 19;
            btnubahlimit.Text = "Ubah Limit";
            btnubahlimit.UseVisualStyleBackColor = true;
            // 
            // btnlihatkeluhan
            // 
            btnlihatkeluhan.Location = new Point(29, 127);
            btnlihatkeluhan.Name = "btnlihatkeluhan";
            btnlihatkeluhan.Size = new Size(114, 29);
            btnlihatkeluhan.TabIndex = 18;
            btnlihatkeluhan.Text = "Lihat Keluhan";
            btnlihatkeluhan.UseVisualStyleBackColor = true;
            // 
            // btneditprofile
            // 
            btneditprofile.Location = new Point(29, 92);
            btneditprofile.Name = "btneditprofile";
            btneditprofile.Size = new Size(94, 29);
            btneditprofile.TabIndex = 17;
            btneditprofile.Text = "Edit Profil";
            btneditprofile.UseVisualStyleBackColor = true;
            // 
            // lblmenukeluhan
            // 
            lblmenukeluhan.AutoSize = true;
            lblmenukeluhan.Font = new Font("Segoe UI", 14F);
            lblmenukeluhan.Location = new Point(29, 25);
            lblmenukeluhan.Name = "lblmenukeluhan";
            lblmenukeluhan.Size = new Size(77, 32);
            lblmenukeluhan.TabIndex = 16;
            lblmenukeluhan.Text = "Menu";
            // 
            // LihatKeluhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "LihatKeluhan";
            Text = "LihatKeluhan";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label lblstatuskluhan;
        private Label lbltglkeluhan;
        private Label lblkeluhan;
        private Label label1;
        private Label lbldeskripsikeluhan;
        private Label lblnamakeluhan;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private Panel panel3;
        private Button btnlogout;
        private Button btnhistory;
        private Button btnlihatdata;
        private Button btnkelolauser;
        private Button btnubahlimit;
        private Button btnlihatkeluhan;
        private Button btneditprofile;
        private Label lblmenukeluhan;
    }
}