namespace WaterWiseV2.View.User
{
    partial class DashboardUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUser));
            labelPenggunaanHariIni = new Label();
            labelSisaLimit = new Label();
            labelStatus = new Label();
            btnLogOut = new Button();
            buttonUtama = new Button();
            btnProfile = new Button();
            btnAmbilAir = new Button();
            btnHistory = new Button();
            btnLapor = new Button();
            SuspendLayout();
            // 
            // labelPenggunaanHariIni
            // 
            labelPenggunaanHariIni.AutoSize = true;
            labelPenggunaanHariIni.BackColor = Color.White;
            labelPenggunaanHariIni.Font = new Font("Rockwell", 15F);
            labelPenggunaanHariIni.Location = new Point(303, 207);
            labelPenggunaanHariIni.Name = "labelPenggunaanHariIni";
            labelPenggunaanHariIni.Size = new Size(79, 29);
            labelPenggunaanHariIni.TabIndex = 0;
            labelPenggunaanHariIni.Text = "Value";
            // 
            // labelSisaLimit
            // 
            labelSisaLimit.AutoSize = true;
            labelSisaLimit.BackColor = Color.White;
            labelSisaLimit.Font = new Font("Rockwell", 15F);
            labelSisaLimit.Location = new Point(533, 207);
            labelSisaLimit.Name = "labelSisaLimit";
            labelSisaLimit.Size = new Size(79, 29);
            labelSisaLimit.TabIndex = 1;
            labelSisaLimit.Text = "Value";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.BackColor = Color.White;
            labelStatus.Font = new Font("Rockwell", 15F);
            labelStatus.Location = new Point(763, 207);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(79, 29);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Value";
            // 
            // btnLogOut
            // 
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Location = new Point(47, 673);
            btnLogOut.Margin = new Padding(3, 4, 3, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(185, 59);
            btnLogOut.TabIndex = 3;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // buttonUtama
            // 
            buttonUtama.BackgroundImage = (Image)resources.GetObject("buttonUtama.BackgroundImage");
            buttonUtama.FlatAppearance.BorderSize = 0;
            buttonUtama.FlatStyle = FlatStyle.Flat;
            buttonUtama.Location = new Point(14, 119);
            buttonUtama.Margin = new Padding(3, 4, 3, 4);
            buttonUtama.Name = "buttonUtama";
            buttonUtama.Size = new Size(181, 55);
            buttonUtama.TabIndex = 4;
            buttonUtama.UseVisualStyleBackColor = true;
            buttonUtama.Click += buttonUtama_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackgroundImage = (Image)resources.GetObject("btnProfile.BackgroundImage");
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Location = new Point(14, 181);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(181, 55);
            btnProfile.TabIndex = 5;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnAmbilAir
            // 
            btnAmbilAir.BackgroundImage = (Image)resources.GetObject("btnAmbilAir.BackgroundImage");
            btnAmbilAir.FlatAppearance.BorderSize = 0;
            btnAmbilAir.FlatStyle = FlatStyle.Flat;
            btnAmbilAir.Location = new Point(14, 244);
            btnAmbilAir.Margin = new Padding(3, 4, 3, 4);
            btnAmbilAir.Name = "btnAmbilAir";
            btnAmbilAir.Size = new Size(181, 55);
            btnAmbilAir.TabIndex = 6;
            btnAmbilAir.UseVisualStyleBackColor = true;
            btnAmbilAir.Click += btnAmbilAir_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackgroundImage = (Image)resources.GetObject("btnHistory.BackgroundImage");
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Location = new Point(14, 307);
            btnHistory.Margin = new Padding(3, 4, 3, 4);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(181, 55);
            btnHistory.TabIndex = 7;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnLapor
            // 
            btnLapor.BackgroundImage = (Image)resources.GetObject("btnLapor.BackgroundImage");
            btnLapor.FlatAppearance.BorderSize = 0;
            btnLapor.FlatStyle = FlatStyle.Flat;
            btnLapor.Location = new Point(14, 369);
            btnLapor.Margin = new Padding(3, 4, 3, 4);
            btnLapor.Name = "btnLapor";
            btnLapor.Size = new Size(181, 55);
            btnLapor.TabIndex = 8;
            btnLapor.UseVisualStyleBackColor = true;
            btnLapor.Click += btnLapor_Click;
            // 
            // DashboardUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 553);
            Controls.Add(btnLapor);
            Controls.Add(btnHistory);
            Controls.Add(btnAmbilAir);
            Controls.Add(btnProfile);
            Controls.Add(buttonUtama);
            Controls.Add(btnLogOut);
            Controls.Add(labelStatus);
            Controls.Add(labelSisaLimit);
            Controls.Add(labelPenggunaanHariIni);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardUser";
            Text = "DashboardUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPenggunaanHariIni;
        private Label labelSisaLimit;
        private Label labelStatus;
        private Button btnLogOut;
        private Button buttonUtama;
        private Button btnProfile;
        private Button btnAmbilAir;
        private Button btnHistory;
        private Button btnLapor;
    }
}