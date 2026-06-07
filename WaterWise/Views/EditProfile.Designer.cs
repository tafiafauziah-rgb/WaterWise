namespace WaterWise.Views
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            panel1 = new Panel();
            panel3 = new Panel();
            lblaktif = new Label();
            btnsimpan = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            tbEmail = new TextBox();
            tbUsername = new TextBox();
            tbNama = new TextBox();
            panel2 = new Panel();
            button2 = new Button();
            btnlogout = new Button();
            btnhistory = new Button();
            btnlihatdata = new Button();
            btnubahlimit = new Button();
            btnlihatkeluhan = new Button();
            btnkelolauser = new Button();
            btneditprofile = new Button();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 451);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(lblaktif);
            panel3.Controls.Add(btnsimpan);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(tbEmail);
            panel3.Controls.Add(tbUsername);
            panel3.Controls.Add(tbNama);
            panel3.Location = new Point(181, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(614, 396);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // lblaktif
            // 
            lblaktif.AutoSize = true;
            lblaktif.BackColor = Color.Transparent;
            lblaktif.Location = new Point(69, 103);
            lblaktif.Name = "lblaktif";
            lblaktif.Size = new Size(44, 20);
            lblaktif.TabIndex = 23;
            lblaktif.Text = "value";
            lblaktif.Click += lblaktif_Click;
            // 
            // btnsimpan
            // 
            btnsimpan.BackColor = Color.Transparent;
            btnsimpan.FlatAppearance.BorderSize = 0;
            btnsimpan.FlatStyle = FlatStyle.Flat;
            btnsimpan.Location = new Point(16, 333);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(575, 25);
            btnsimpan.TabIndex = 21;
            btnsimpan.UseVisualStyleBackColor = false;
            btnsimpan.Click += btnsimpan_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(16, 284);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 27);
            textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(316, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 27);
            textBox1.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(348, 407);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(16, 224);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(259, 27);
            tbEmail.TabIndex = 18;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.White;
            tbUsername.Location = new Point(316, 176);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(259, 27);
            tbUsername.TabIndex = 17;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(16, 176);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(259, 27);
            tbNama.TabIndex = 16;
            tbNama.TextChanged += tbNama_TextChanged;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnlogout);
            panel2.Controls.Add(btnhistory);
            panel2.Controls.Add(btnlihatdata);
            panel2.Controls.Add(btnubahlimit);
            panel2.Controls.Add(btnlihatkeluhan);
            panel2.Controls.Add(btnkelolauser);
            panel2.Controls.Add(btneditprofile);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(-13, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 451);
            panel2.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(33, 119);
            button2.Name = "button2";
            button2.Size = new Size(112, 29);
            button2.TabIndex = 21;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.Transparent;
            btnlogout.BackgroundImage = (Image)resources.GetObject("btnlogout.BackgroundImage");
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Location = new Point(25, 411);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(169, 41);
            btnlogout.TabIndex = 28;
            btnlogout.UseVisualStyleBackColor = false;
            // 
            // btnhistory
            // 
            btnhistory.BackColor = Color.Transparent;
            btnhistory.BackgroundImage = (Image)resources.GetObject("btnhistory.BackgroundImage");
            btnhistory.FlatAppearance.BorderSize = 0;
            btnhistory.FlatStyle = FlatStyle.Flat;
            btnhistory.Location = new Point(22, 294);
            btnhistory.Name = "btnhistory";
            btnhistory.Size = new Size(151, 31);
            btnhistory.TabIndex = 27;
            btnhistory.UseVisualStyleBackColor = false;
            btnhistory.Click += btnhistory_Click;
            // 
            // btnlihatdata
            // 
            btnlihatdata.BackColor = Color.Transparent;
            btnlihatdata.BackgroundImage = (Image)resources.GetObject("btnlihatdata.BackgroundImage");
            btnlihatdata.FlatAppearance.BorderSize = 0;
            btnlihatdata.FlatStyle = FlatStyle.Flat;
            btnlihatdata.Location = new Point(37, 259);
            btnlihatdata.Name = "btnlihatdata";
            btnlihatdata.Size = new Size(114, 29);
            btnlihatdata.TabIndex = 26;
            btnlihatdata.UseVisualStyleBackColor = false;
            btnlihatdata.Click += btnlihatdata_Click;
            // 
            // btnubahlimit
            // 
            btnubahlimit.BackColor = Color.Transparent;
            btnubahlimit.BackgroundImage = (Image)resources.GetObject("btnubahlimit.BackgroundImage");
            btnubahlimit.FlatAppearance.BorderSize = 0;
            btnubahlimit.FlatStyle = FlatStyle.Flat;
            btnubahlimit.Location = new Point(33, 189);
            btnubahlimit.Name = "btnubahlimit";
            btnubahlimit.Size = new Size(114, 29);
            btnubahlimit.TabIndex = 25;
            btnubahlimit.UseVisualStyleBackColor = false;
            // 
            // btnlihatkeluhan
            // 
            btnlihatkeluhan.BackColor = Color.Transparent;
            btnlihatkeluhan.BackgroundImage = (Image)resources.GetObject("btnlihatkeluhan.BackgroundImage");
            btnlihatkeluhan.FlatAppearance.BorderSize = 0;
            btnlihatkeluhan.FlatStyle = FlatStyle.Flat;
            btnlihatkeluhan.Location = new Point(33, 154);
            btnlihatkeluhan.Name = "btnlihatkeluhan";
            btnlihatkeluhan.Size = new Size(114, 29);
            btnlihatkeluhan.TabIndex = 23;
            btnlihatkeluhan.UseVisualStyleBackColor = false;
            btnlihatkeluhan.Click += btnlihatkeluhan_Click_1;
            // 
            // btnkelolauser
            // 
            btnkelolauser.BackColor = Color.Transparent;
            btnkelolauser.BackgroundImage = (Image)resources.GetObject("btnkelolauser.BackgroundImage");
            btnkelolauser.FlatAppearance.BorderSize = 0;
            btnkelolauser.FlatStyle = FlatStyle.Flat;
            btnkelolauser.Location = new Point(37, 224);
            btnkelolauser.Name = "btnkelolauser";
            btnkelolauser.Size = new Size(118, 29);
            btnkelolauser.TabIndex = 24;
            btnkelolauser.UseVisualStyleBackColor = false;
            btnkelolauser.Click += btnkelolauser_Click_1;
            // 
            // btneditprofile
            // 
            btneditprofile.BackColor = Color.Transparent;
            btneditprofile.BackgroundImage = (Image)resources.GetObject("btneditprofile.BackgroundImage");
            btneditprofile.FlatAppearance.BorderSize = 0;
            btneditprofile.FlatStyle = FlatStyle.Flat;
            btneditprofile.ImageAlign = ContentAlignment.MiddleLeft;
            btneditprofile.Location = new Point(37, 84);
            btneditprofile.Name = "btneditprofile";
            btneditprofile.Size = new Size(112, 29);
            btneditprofile.TabIndex = 22;
            btneditprofile.UseVisualStyleBackColor = false;
            btneditprofile.Click += btneditprofile_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(191, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(623, 47);
            panel4.TabIndex = 0;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "EditProfile";
            Text = "EditeProfile";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox tbEmail;
        private TextBox tbUsername;
        private TextBox tbNama;
        private Button button1;
        private Panel panel2;
        private Panel panel4;
        private Button button2;
        private Button btnlogout;
        private Button btnhistory;
        private Button btnlihatdata;
        private Button btnubahlimit;
        private Button btnlihatkeluhan;
        private Button btnkelolauser;
        private Button btneditprofile;
        private Button btnsimpan;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblaktif;
    }
}