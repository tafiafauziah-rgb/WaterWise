namespace WaterWise
{
    partial class AdminForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnlogout = new Button();
            btnhistory = new Button();
            btnlihatdata = new Button();
            btnubahlimit = new Button();
            btnlihatkeluhan = new Button();
            btnkelolauser = new Button();
            btneditprofile = new Button();
            label2 = new Label();
            panel2 = new Panel();
            lbldashboardadmin = new Label();
            lbladmin = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnhistory);
            panel1.Controls.Add(btnlihatdata);
            panel1.Controls.Add(btnubahlimit);
            panel1.Controls.Add(btnlihatkeluhan);
            panel1.Controls.Add(btnkelolauser);
            panel1.Controls.Add(btneditprofile);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 451);
            panel1.TabIndex = 0;
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(28, 410);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(85, 29);
            btnlogout.TabIndex = 13;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnhistory
            // 
            btnhistory.Location = new Point(11, 283);
            btnhistory.Name = "btnhistory";
            btnhistory.Size = new Size(136, 31);
            btnhistory.TabIndex = 12;
            btnhistory.Text = "History Pengguna";
            btnhistory.UseVisualStyleBackColor = true;
            btnhistory.Click += btnhistory_Click;
            // 
            // btnlihatdata
            // 
            btnlihatdata.Location = new Point(17, 246);
            btnlihatdata.Name = "btnlihatdata";
            btnlihatdata.Size = new Size(114, 29);
            btnlihatdata.TabIndex = 11;
            btnlihatdata.Text = "Lihat Data";
            btnlihatdata.UseVisualStyleBackColor = true;
            btnlihatdata.Click += btnlihatdata_Click;
            // 
            // btnubahlimit
            // 
            btnubahlimit.Location = new Point(17, 177);
            btnubahlimit.Name = "btnubahlimit";
            btnubahlimit.Size = new Size(114, 29);
            btnubahlimit.TabIndex = 10;
            btnubahlimit.Text = "Ubah Limit";
            btnubahlimit.UseVisualStyleBackColor = true;
            btnubahlimit.Click += btnubahlimit_Click;
            // 
            // btnlihatkeluhan
            // 
            btnlihatkeluhan.Location = new Point(17, 142);
            btnlihatkeluhan.Name = "btnlihatkeluhan";
            btnlihatkeluhan.Size = new Size(114, 29);
            btnlihatkeluhan.TabIndex = 3;
            btnlihatkeluhan.Text = "Lihat Keluhan";
            btnlihatkeluhan.UseVisualStyleBackColor = true;
            btnlihatkeluhan.Click += btnlihatkeluhan_Click;
            // 
            // btnkelolauser
            // 
            btnkelolauser.Location = new Point(25, 211);
            btnkelolauser.Name = "btnkelolauser";
            btnkelolauser.Size = new Size(94, 29);
            btnkelolauser.TabIndex = 9;
            btnkelolauser.Text = "Kelola User";
            btnkelolauser.UseVisualStyleBackColor = true;
            btnkelolauser.Click += btnkelolauser_Click;
            // 
            // btneditprofile
            // 
            btneditprofile.Location = new Point(25, 104);
            btneditprofile.Name = "btneditprofile";
            btneditprofile.Size = new Size(94, 29);
            btneditprofile.TabIndex = 2;
            btneditprofile.Text = "Edit Profil";
            btneditprofile.UseVisualStyleBackColor = true;
            btneditprofile.Click += btneditprofile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(36, 34);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 4;
            label2.Text = "Menu";
            // 
            // panel2
            // 
            panel2.Location = new Point(153, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 450);
            panel2.TabIndex = 1;
            // 
            // lbldashboardadmin
            // 
            lbldashboardadmin.AutoSize = true;
            lbldashboardadmin.Font = new Font("Segoe UI", 14F);
            lbldashboardadmin.Location = new Point(366, 33);
            lbldashboardadmin.Name = "lbldashboardadmin";
            lbldashboardadmin.Size = new Size(206, 32);
            lbldashboardadmin.TabIndex = 1;
            lbldashboardadmin.Text = "Dashboard Admin";
            lbldashboardadmin.Click += label1_Click;
            // 
            // lbladmin
            // 
            lbladmin.AutoSize = true;
            lbladmin.Font = new Font("Segoe UI", 9F);
            lbladmin.Location = new Point(185, 124);
            lbladmin.Name = "lbladmin";
            lbladmin.Size = new Size(171, 20);
            lbladmin.TabIndex = 3;
            lbladmin.Text = "Selamat Datang, Admin!";
            lbladmin.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 173);
            label1.Name = "label1";
            label1.Size = new Size(261, 20);
            label1.TabIndex = 5;
            label1.Text = "Pilih menu di samping untuk memulai.";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lbladmin);
            Controls.Add(lbldashboardadmin);
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "lblpiihmenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label lbldashboardadmin;
        private Button btneditprofile;
        private Button btnkelolauser;
        private Button btnlihatkeluhan;
        private Button btnhistory;
        private Button btnlihatdata;
        private Button btnubahlimit;
        private Button btnlogout;
        private Label lbladmin;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
    }
}