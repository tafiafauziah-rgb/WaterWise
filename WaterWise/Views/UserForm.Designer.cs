namespace WaterWise.Views
{
    partial class UserForm
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
            panelMenu = new Panel();
            label2 = new Label();
            btnLogOut = new Button();
            btnKeluhan = new Button();
            btnHistory = new Button();
            btnLimit = new Button();
            btnAmbilAir = new Button();
            btnProfile = new Button();
            panel1 = new Panel();
            panelProfile = new Panel();
            panelAmbilAir = new Panel();
            panelHistory = new Panel();
            panelKeluhan = new Panel();
            btnKirim = new Button();
            textBoxKeluhan = new TextBox();
            label6 = new Label();
            label5 = new Label();
            lblKeluhan = new Label();
            dgvHistory = new DataGridView();
            numericAmbilAir = new NumericUpDown();
            btnAmbil = new Button();
            lblInput = new Label();
            lblSisaLimit = new Label();
            label1 = new Label();
            btnEditProfile = new Button();
            lblStatus = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            lblNama = new Label();
            lblTitleProfile = new Label();
            labelSisa = new Label();
            labelLimit = new Label();
            label4 = new Label();
            label3 = new Label();
            lblNamaUser = new Label();
            lblWelcome = new Label();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panelProfile.SuspendLayout();
            panelAmbilAir.SuspendLayout();
            panelHistory.SuspendLayout();
            panelKeluhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAmbilAir).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(label2);
            panelMenu.Controls.Add(btnLogOut);
            panelMenu.Controls.Add(btnKeluhan);
            panelMenu.Controls.Add(btnHistory);
            panelMenu.Controls.Add(btnLimit);
            panelMenu.Controls.Add(btnAmbilAir);
            panelMenu.Controls.Add(btnProfile);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(138, 450);
            panelMenu.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(21, 7);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 0;
            label2.Text = "Menu";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(21, 409);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnKeluhan
            // 
            btnKeluhan.Location = new Point(21, 188);
            btnKeluhan.Name = "btnKeluhan";
            btnKeluhan.Size = new Size(94, 29);
            btnKeluhan.TabIndex = 4;
            btnKeluhan.Text = "Keluhan";
            btnKeluhan.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(21, 153);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(94, 29);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnLimit
            // 
            btnLimit.Location = new Point(21, 118);
            btnLimit.Name = "btnLimit";
            btnLimit.Size = new Size(94, 29);
            btnLimit.TabIndex = 2;
            btnLimit.Text = "Check Limit";
            btnLimit.UseVisualStyleBackColor = true;
            btnLimit.Click += btnLimit_Click;
            // 
            // btnAmbilAir
            // 
            btnAmbilAir.Location = new Point(21, 83);
            btnAmbilAir.Name = "btnAmbilAir";
            btnAmbilAir.Size = new Size(94, 29);
            btnAmbilAir.TabIndex = 2;
            btnAmbilAir.Text = "Ambil Air";
            btnAmbilAir.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(21, 48);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(94, 29);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelProfile);
            panel1.Controls.Add(labelSisa);
            panel1.Controls.Add(labelLimit);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblNamaUser);
            panel1.Controls.Add(lblWelcome);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(138, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 450);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // panelProfile
            // 
            panelProfile.Controls.Add(panelAmbilAir);
            panelProfile.Controls.Add(btnEditProfile);
            panelProfile.Controls.Add(lblStatus);
            panelProfile.Controls.Add(lblEmail);
            panelProfile.Controls.Add(lblUsername);
            panelProfile.Controls.Add(lblNama);
            panelProfile.Controls.Add(lblTitleProfile);
            panelProfile.Dock = DockStyle.Fill;
            panelProfile.Location = new Point(0, 0);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(662, 450);
            panelProfile.TabIndex = 3;
            panelProfile.Paint += panelProfile_Paint;
            // 
            // panelAmbilAir
            // 
            panelAmbilAir.Controls.Add(panelHistory);
            panelAmbilAir.Controls.Add(numericAmbilAir);
            panelAmbilAir.Controls.Add(btnAmbil);
            panelAmbilAir.Controls.Add(lblInput);
            panelAmbilAir.Controls.Add(lblSisaLimit);
            panelAmbilAir.Controls.Add(label1);
            panelAmbilAir.Dock = DockStyle.Fill;
            panelAmbilAir.Location = new Point(0, 0);
            panelAmbilAir.Name = "panelAmbilAir";
            panelAmbilAir.Size = new Size(662, 450);
            panelAmbilAir.TabIndex = 6;
            panelAmbilAir.Paint += panelAmbilAir_Paint;
            // 
            // panelHistory
            // 
            panelHistory.Controls.Add(panelKeluhan);
            panelHistory.Controls.Add(dgvHistory);
            panelHistory.Dock = DockStyle.Fill;
            panelHistory.Location = new Point(0, 0);
            panelHistory.Name = "panelHistory";
            panelHistory.Size = new Size(662, 450);
            panelHistory.TabIndex = 0;
            panelHistory.Paint += panelHistory_Paint;
            // 
            // panelKeluhan
            // 
            panelKeluhan.Controls.Add(btnKirim);
            panelKeluhan.Controls.Add(textBoxKeluhan);
            panelKeluhan.Controls.Add(label6);
            panelKeluhan.Controls.Add(label5);
            panelKeluhan.Controls.Add(lblKeluhan);
            panelKeluhan.Dock = DockStyle.Fill;
            panelKeluhan.Location = new Point(0, 0);
            panelKeluhan.Name = "panelKeluhan";
            panelKeluhan.Size = new Size(662, 450);
            panelKeluhan.TabIndex = 1;
            panelKeluhan.Paint += panelKeluhan_Paint;
            // 
            // btnKirim
            // 
            btnKirim.Location = new Point(543, 385);
            btnKirim.Name = "btnKirim";
            btnKirim.Size = new Size(94, 29);
            btnKirim.TabIndex = 5;
            btnKirim.Text = "Kirim";
            btnKirim.UseVisualStyleBackColor = true;
            // 
            // textBoxKeluhan
            // 
            textBoxKeluhan.Location = new Point(18, 156);
            textBoxKeluhan.Multiline = true;
            textBoxKeluhan.Name = "textBoxKeluhan";
            textBoxKeluhan.Size = new Size(619, 223);
            textBoxKeluhan.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(18, 130);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 3;
            label6.Text = "Isi keluhan:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(18, 87);
            label5.Name = "label5";
            label5.Size = new Size(200, 20);
            label5.TabIndex = 2;
            label5.Text = "Beri tahu kami masalah anda";
            // 
            // lblKeluhan
            // 
            lblKeluhan.AutoSize = true;
            lblKeluhan.Font = new Font("Segoe UI", 18F);
            lblKeluhan.Location = new Point(225, 36);
            lblKeluhan.Name = "lblKeluhan";
            lblKeluhan.Size = new Size(207, 41);
            lblKeluhan.TabIndex = 1;
            lblKeluhan.Text = "Lapor Keluhan";
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToOrderColumns = true;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = SystemColors.ControlLight;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.Location = new Point(0, 0);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(662, 450);
            dgvHistory.TabIndex = 0;
            // 
            // numericAmbilAir
            // 
            numericAmbilAir.Location = new Point(247, 131);
            numericAmbilAir.Name = "numericAmbilAir";
            numericAmbilAir.Size = new Size(150, 27);
            numericAmbilAir.TabIndex = 0;
            // 
            // btnAmbil
            // 
            btnAmbil.Location = new Point(275, 358);
            btnAmbil.Name = "btnAmbil";
            btnAmbil.Size = new Size(94, 29);
            btnAmbil.TabIndex = 5;
            btnAmbil.Text = "Ambil";
            btnAmbil.UseVisualStyleBackColor = true;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe UI", 9F);
            lblInput.Location = new Point(27, 133);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(207, 20);
            lblInput.TabIndex = 3;
            lblInput.Text = "Jumlah air yang mau diambil :";
            // 
            // lblSisaLimit
            // 
            lblSisaLimit.AutoSize = true;
            lblSisaLimit.Font = new Font("Segoe UI", 9F);
            lblSisaLimit.Location = new Point(27, 98);
            lblSisaLimit.Name = "lblSisaLimit";
            lblSisaLimit.Size = new Size(72, 20);
            lblSisaLimit.TabIndex = 2;
            lblSisaLimit.Text = "Sisa Limit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(247, 36);
            label1.Name = "label1";
            label1.Size = new Size(139, 41);
            label1.TabIndex = 1;
            label1.Text = "Ambil Air";
            // 
            // btnEditProfile
            // 
            btnEditProfile.Location = new Point(275, 374);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(94, 29);
            btnEditProfile.TabIndex = 5;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.Location = new Point(27, 208);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(86, 20);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status Akun";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.Location = new Point(27, 173);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F);
            lblUsername.Location = new Point(27, 133);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 9F);
            lblNama.Location = new Point(27, 98);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(116, 20);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Lengkap :";
            // 
            // lblTitleProfile
            // 
            lblTitleProfile.AutoSize = true;
            lblTitleProfile.Font = new Font("Segoe UI", 18F);
            lblTitleProfile.Location = new Point(211, 35);
            lblTitleProfile.Name = "lblTitleProfile";
            lblTitleProfile.Size = new Size(206, 41);
            lblTitleProfile.TabIndex = 0;
            lblTitleProfile.Text = "PROFILE USER";
            // 
            // labelSisa
            // 
            labelSisa.AutoSize = true;
            labelSisa.Location = new Point(199, 197);
            labelSisa.Name = "labelSisa";
            labelSisa.Size = new Size(58, 20);
            labelSisa.TabIndex = 5;
            labelSisa.Text = "75 Liter";
            // 
            // labelLimit
            // 
            labelLimit.AutoSize = true;
            labelLimit.Location = new Point(171, 153);
            labelLimit.Name = "labelLimit";
            labelLimit.Size = new Size(66, 20);
            labelLimit.TabIndex = 4;
            labelLimit.Text = "100 Liter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 197);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 3;
            label4.Text = "Sisa Kuota          :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 153);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Kuota Hari Ini :";
            label3.Click += label3_Click;
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.Font = new Font("Segoe UI", 12F);
            lblNamaUser.Location = new Point(27, 98);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(107, 28);
            lblNamaUser.TabIndex = 1;
            lblNamaUser.Text = "Halo, User!";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20F);
            lblWelcome.Location = new Point(90, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(465, 46);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Selamat Datang di WaterWise";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "UserForm";
            Text = "UserForm";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelProfile.ResumeLayout(false);
            panelProfile.PerformLayout();
            panelAmbilAir.ResumeLayout(false);
            panelAmbilAir.PerformLayout();
            panelHistory.ResumeLayout(false);
            panelKeluhan.ResumeLayout(false);
            panelKeluhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAmbilAir).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Button btnProfile;
        private Button btnLogOut;
        private Button btnKeluhan;
        private Button btnHistory;
        private Button btnLimit;
        private Button btnAmbilAir;
        private Panel panel1;
        private Label label2;
        private Label lblWelcome;
        private Label lblNamaUser;
        private Label labelSisa;
        private Label labelLimit;
        private Label label4;
        private Label label3;
        private Panel panelProfile;
        private Label lblTitleProfile;
        private Label lblNama;
        private Label lblStatus;
        private Label lblEmail;
        private Label lblUsername;
        private Button btnEditProfile;
        private Panel panelAmbilAir;
        private Button btnAmbil;
        private Label lblInput;
        private Label lblSisaLimit;
        private Label label1;
        private NumericUpDown numericAmbilAir;
        private Panel panelHistory;
        private DataGridView dgvHistory;
        private Panel panelKeluhan;
        private Label lblKeluhan;
        private TextBox textBoxKeluhan;
        private Label label6;
        private Label label5;
        private Button btnKirim;
    }
}