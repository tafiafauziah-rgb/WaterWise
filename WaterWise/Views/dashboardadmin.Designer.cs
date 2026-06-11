using WaterWise.Views;
namespace WaterWise.Views
{
    partial class dashboardadmin : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardadmin));
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            btnhistory = new Button();
            btneditprofile = new Button();
            btnlogout = new Button();
            paneldashboard = new Panel();
            panellimitharian = new Panel();
            labellimitharian = new Label();
            panelpenggunaaktif = new Panel();
            labelpenggunaaktif = new Label();
            paneltotalpengguna = new Panel();
            labeltotal = new Label();
            panelheader = new Panel();
            btnlihatdata = new Button();
            btnubahlimit = new Button();
            btnlihatkeluhan = new Button();
            btnkelolauser = new Button();
            btndashboard = new Button();
            lblnamaadmin = new Label();
            panel1.SuspendLayout();
            paneldashboard.SuspendLayout();
            panellimitharian.SuspendLayout();
            panelpenggunaaktif.SuspendLayout();
            paneltotalpengguna.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btnhistory);
            panel1.Controls.Add(btneditprofile);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(paneldashboard);
            panel1.Controls.Add(panelheader);
            panel1.Controls.Add(btnlihatdata);
            panel1.Controls.Add(btnubahlimit);
            panel1.Controls.Add(btnlihatkeluhan);
            panel1.Controls.Add(btnkelolauser);
            panel1.Controls.Add(btndashboard);
            panel1.Location = new Point(-15, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 457);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // btnhistory
            // 
            btnhistory.BackColor = Color.Transparent;
            btnhistory.BackgroundImage = (Image)resources.GetObject("btnhistory.BackgroundImage");
            btnhistory.FlatAppearance.BorderSize = 0;
            btnhistory.FlatStyle = FlatStyle.Flat;
            btnhistory.Location = new Point(27, 296);
            btnhistory.Name = "btnhistory";
            btnhistory.Size = new Size(151, 31);
            btnhistory.TabIndex = 28;
            btnhistory.UseVisualStyleBackColor = false;
            btnhistory.Click += btnhistory_Click_1;
            // 
            // btneditprofile
            // 
            btneditprofile.BackColor = Color.Transparent;
            btneditprofile.BackgroundImage = (Image)resources.GetObject("btneditprofile.BackgroundImage");
            btneditprofile.FlatAppearance.BorderSize = 0;
            btneditprofile.FlatStyle = FlatStyle.Flat;
            btneditprofile.Location = new Point(37, 121);
            btneditprofile.Name = "btneditprofile";
            btneditprofile.Size = new Size(112, 29);
            btneditprofile.TabIndex = 3;
            btneditprofile.UseVisualStyleBackColor = false;
            btneditprofile.Click += btneditprofile_Click;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.Transparent;
            btnlogout.BackgroundImage = (Image)resources.GetObject("btnlogout.BackgroundImage");
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Location = new Point(15, 413);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(173, 41);
            btnlogout.TabIndex = 20;
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // paneldashboard
            // 
            paneldashboard.AutoScroll = true;
            paneldashboard.BackgroundImage = (Image)resources.GetObject("paneldashboard.BackgroundImage");
            paneldashboard.Controls.Add(lblnamaadmin);
            paneldashboard.Controls.Add(panellimitharian);
            paneldashboard.Controls.Add(panelpenggunaaktif);
            paneldashboard.Controls.Add(paneltotalpengguna);
            paneldashboard.Location = new Point(194, 59);
            paneldashboard.Name = "paneldashboard";
            paneldashboard.Size = new Size(623, 395);
            paneldashboard.TabIndex = 22;
            // 
            // panellimitharian
            // 
            panellimitharian.BackColor = Color.Transparent;
            panellimitharian.BackgroundImage = (Image)resources.GetObject("panellimitharian.BackgroundImage");
            panellimitharian.Controls.Add(labellimitharian);
            panellimitharian.Location = new Point(396, 97);
            panellimitharian.Name = "panellimitharian";
            panellimitharian.Size = new Size(141, 125);
            panellimitharian.TabIndex = 2;
            // 
            // labellimitharian
            // 
            labellimitharian.AutoSize = true;
            labellimitharian.Location = new Point(13, 74);
            labellimitharian.Name = "labellimitharian";
            labellimitharian.Size = new Size(44, 20);
            labellimitharian.TabIndex = 2;
            labellimitharian.Text = "value";
            // 
            // panelpenggunaaktif
            // 
            panelpenggunaaktif.BackColor = Color.Transparent;
            panelpenggunaaktif.BackgroundImage = (Image)resources.GetObject("panelpenggunaaktif.BackgroundImage");
            panelpenggunaaktif.Controls.Add(labelpenggunaaktif);
            panelpenggunaaktif.Location = new Point(203, 97);
            panelpenggunaaktif.Name = "panelpenggunaaktif";
            panelpenggunaaktif.Size = new Size(140, 125);
            panelpenggunaaktif.TabIndex = 2;
            panelpenggunaaktif.Paint += panel4_Paint;
            // 
            // labelpenggunaaktif
            // 
            labelpenggunaaktif.AutoSize = true;
            labelpenggunaaktif.Location = new Point(19, 70);
            labelpenggunaaktif.Name = "labelpenggunaaktif";
            labelpenggunaaktif.Size = new Size(44, 20);
            labelpenggunaaktif.TabIndex = 1;
            labelpenggunaaktif.Text = "value";
            // 
            // paneltotalpengguna
            // 
            paneltotalpengguna.BackColor = Color.Transparent;
            paneltotalpengguna.BackgroundImage = (Image)resources.GetObject("paneltotalpengguna.BackgroundImage");
            paneltotalpengguna.Controls.Add(labeltotal);
            paneltotalpengguna.Location = new Point(31, 97);
            paneltotalpengguna.Name = "paneltotalpengguna";
            paneltotalpengguna.Size = new Size(138, 125);
            paneltotalpengguna.TabIndex = 1;
            paneltotalpengguna.Paint += paneltotalpengguna_Paint;
            // 
            // labeltotal
            // 
            labeltotal.AutoSize = true;
            labeltotal.Location = new Point(22, 74);
            labeltotal.Name = "labeltotal";
            labeltotal.Size = new Size(44, 20);
            labeltotal.TabIndex = 0;
            labeltotal.Text = "value";
            // 
            // panelheader
            // 
            panelheader.BackgroundImage = (Image)resources.GetObject("panelheader.BackgroundImage");
            panelheader.Location = new Point(194, 3);
            panelheader.Name = "panelheader";
            panelheader.Size = new Size(624, 53);
            panelheader.TabIndex = 21;
            // 
            // btnlihatdata
            // 
            btnlihatdata.BackColor = Color.Transparent;
            btnlihatdata.BackgroundImage = (Image)resources.GetObject("btnlihatdata.BackgroundImage");
            btnlihatdata.FlatAppearance.BorderSize = 0;
            btnlihatdata.FlatStyle = FlatStyle.Flat;
            btnlihatdata.Location = new Point(37, 261);
            btnlihatdata.Name = "btnlihatdata";
            btnlihatdata.Size = new Size(114, 29);
            btnlihatdata.TabIndex = 18;
            btnlihatdata.UseVisualStyleBackColor = false;
            btnlihatdata.Click += btnlihatdata_Click;
            // 
            // btnubahlimit
            // 
            btnubahlimit.BackColor = Color.Transparent;
            btnubahlimit.BackgroundImage = (Image)resources.GetObject("btnubahlimit.BackgroundImage");
            btnubahlimit.FlatAppearance.BorderSize = 0;
            btnubahlimit.FlatStyle = FlatStyle.Flat;
            btnubahlimit.Location = new Point(35, 191);
            btnubahlimit.Name = "btnubahlimit";
            btnubahlimit.Size = new Size(114, 29);
            btnubahlimit.TabIndex = 17;
            btnubahlimit.UseVisualStyleBackColor = false;
            btnubahlimit.Click += btnubahlimit_Click_1;
            // 
            // btnlihatkeluhan
            // 
            btnlihatkeluhan.BackColor = Color.Transparent;
            btnlihatkeluhan.BackgroundImage = (Image)resources.GetObject("btnlihatkeluhan.BackgroundImage");
            btnlihatkeluhan.FlatAppearance.BorderSize = 0;
            btnlihatkeluhan.FlatStyle = FlatStyle.Flat;
            btnlihatkeluhan.Location = new Point(35, 156);
            btnlihatkeluhan.Name = "btnlihatkeluhan";
            btnlihatkeluhan.Size = new Size(114, 29);
            btnlihatkeluhan.TabIndex = 15;
            btnlihatkeluhan.UseVisualStyleBackColor = false;
            btnlihatkeluhan.Click += btnlihatkeluhan_Click;
            // 
            // btnkelolauser
            // 
            btnkelolauser.BackColor = Color.Transparent;
            btnkelolauser.BackgroundImage = (Image)resources.GetObject("btnkelolauser.BackgroundImage");
            btnkelolauser.FlatAppearance.BorderSize = 0;
            btnkelolauser.FlatStyle = FlatStyle.Flat;
            btnkelolauser.Location = new Point(37, 226);
            btnkelolauser.Name = "btnkelolauser";
            btnkelolauser.Size = new Size(118, 29);
            btnkelolauser.TabIndex = 16;
            btnkelolauser.UseVisualStyleBackColor = false;
            btnkelolauser.Click += btnkelolauser_Click;
            // 
            // btndashboard
            // 
            btndashboard.BackColor = Color.Transparent;
            btndashboard.BackgroundImage = (Image)resources.GetObject("btndashboard.BackgroundImage");
            btndashboard.FlatAppearance.BorderSize = 0;
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btndashboard.Location = new Point(37, 86);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(112, 29);
            btndashboard.TabIndex = 14;
            btndashboard.UseVisualStyleBackColor = false;
            btndashboard.Click += btndashboard_Click;
            // 
            // lblnamaadmin
            // 
            lblnamaadmin.AutoSize = true;
            lblnamaadmin.Font = new Font("Segoe UI", 10F);
            lblnamaadmin.Location = new Point(173, 27);
            lblnamaadmin.Name = "lblnamaadmin";
            lblnamaadmin.Size = new Size(66, 23);
            lblnamaadmin.TabIndex = 1;
            lblnamaadmin.Text = "ADMIN";
            // 
            // dashboardadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "dashboardadmin";
            Text = "lblpiihmenu";
            Load += AdminForm_Load_1;
            panel1.ResumeLayout(false);
            paneldashboard.ResumeLayout(false);
            paneldashboard.PerformLayout();
            panellimitharian.ResumeLayout(false);
            panellimitharian.PerformLayout();
            panelpenggunaaktif.ResumeLayout(false);
            panelpenggunaaktif.PerformLayout();
            paneltotalpengguna.ResumeLayout(false);
            paneltotalpengguna.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Button btnlogout;
        private Button btnlihatdata;
        private Button btnubahlimit;
        private Button btnlihatkeluhan;
        private Button btnkelolauser;
        private Button btndashboard;
        private Panel panelheader;
        private Panel paneldashboard;
        private Panel panellimitharian;
        private Panel panelpenggunaaktif;
        private Panel paneltotalpengguna;
        private Label labellimitharian;
        private Label labelpenggunaaktif;
        private Label labeltotal;
        private Button btneditprofile;
        private Button btnhistory;
        private Label lblnamaadmin;
    }
}