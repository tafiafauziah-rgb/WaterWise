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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            btnlogout = new Button();
            panel2 = new Panel();
            panellimitharian = new Panel();
            panelpenggunaaktif = new Panel();
            paneltotalpengguna = new Panel();
            panelheader = new Panel();
            btnhistory = new Button();
            btnlihatdata = new Button();
            btnubahlimit = new Button();
            btnlihatkeluhan = new Button();
            btnkelolauser = new Button();
            btneditprofile = new Button();
            labeltotal = new Label();
            labelpenggunaaktif = new Label();
            labellimitharian = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panelheader);
            panel1.Controls.Add(btnhistory);
            panel1.Controls.Add(btnlihatdata);
            panel1.Controls.Add(btnubahlimit);
            panel1.Controls.Add(btnlihatkeluhan);
            panel1.Controls.Add(btnkelolauser);
            panel1.Controls.Add(btneditprofile);
            panel1.Location = new Point(-15, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 457);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
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
            btnlogout.Click += btnlogout_Click_1;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(panellimitharian);
            panel2.Controls.Add(panelpenggunaaktif);
            panel2.Controls.Add(paneltotalpengguna);
            panel2.Location = new Point(194, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(623, 395);
            panel2.TabIndex = 22;
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
            // paneltotalpengguna
            // 
            paneltotalpengguna.BackColor = Color.Transparent;
            paneltotalpengguna.BackgroundImage = (Image)resources.GetObject("paneltotalpengguna.BackgroundImage");
            paneltotalpengguna.Controls.Add(labeltotal);
            paneltotalpengguna.Location = new Point(31, 97);
            paneltotalpengguna.Name = "paneltotalpengguna";
            paneltotalpengguna.Size = new Size(138, 125);
            paneltotalpengguna.TabIndex = 1;
            // 
            // panelheader
            // 
            panelheader.BackgroundImage = (Image)resources.GetObject("panelheader.BackgroundImage");
            panelheader.Location = new Point(194, 3);
            panelheader.Name = "panelheader";
            panelheader.Size = new Size(624, 53);
            panelheader.TabIndex = 21;
            // 
            // btnhistory
            // 
            btnhistory.BackColor = Color.Transparent;
            btnhistory.BackgroundImage = (Image)resources.GetObject("btnhistory.BackgroundImage");
            btnhistory.FlatAppearance.BorderSize = 0;
            btnhistory.FlatStyle = FlatStyle.Flat;
            btnhistory.Location = new Point(27, 296);
            btnhistory.Name = "btnhistory";
            btnhistory.Size = new Size(136, 31);
            btnhistory.TabIndex = 19;
            btnhistory.UseVisualStyleBackColor = false;
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
            btnlihatdata.Click += btnlihatdata_Click_1;
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
            btnlihatkeluhan.Click += btnlihatkeluhan_Click_1;
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
            // 
            // btneditprofile
            // 
            btneditprofile.BackColor = Color.Transparent;
            btneditprofile.BackgroundImage = (Image)resources.GetObject("btneditprofile.BackgroundImage");
            btneditprofile.FlatAppearance.BorderSize = 0;
            btneditprofile.FlatStyle = FlatStyle.Flat;
            btneditprofile.ImageAlign = ContentAlignment.MiddleLeft;
            btneditprofile.Location = new Point(37, 86);
            btneditprofile.Name = "btneditprofile";
            btneditprofile.Size = new Size(112, 29);
            btneditprofile.TabIndex = 14;
            btneditprofile.UseVisualStyleBackColor = false;
            btneditprofile.Click += btneditprofile_Click_1;
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
            // labelpenggunaaktif
            // 
            labelpenggunaaktif.AutoSize = true;
            labelpenggunaaktif.Location = new Point(19, 70);
            labelpenggunaaktif.Name = "labelpenggunaaktif";
            labelpenggunaaktif.Size = new Size(44, 20);
            labelpenggunaaktif.TabIndex = 1;
            labelpenggunaaktif.Text = "value";
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
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(37, 121);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "lblpiihmenu";
            Load += AdminForm_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
        private Button btnhistory;
        private Button btnlihatdata;
        private Button btnubahlimit;
        private Button btnlihatkeluhan;
        private Button btnkelolauser;
        private Button btneditprofile;
        private Panel panelheader;
        private Panel panel2;
        private Panel panellimitharian;
        private Panel panelpenggunaaktif;
        private Panel paneltotalpengguna;
        private Label labellimitharian;
        private Label labelpenggunaaktif;
        private Label labeltotal;
        private Button button1;
    }
}