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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatKeluhan));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panelheader = new Panel();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 451);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(191, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(621, 389);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(panelheader);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(-11, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(812, 445);
            panel3.TabIndex = 12;
            // 
            // panelheader
            // 
            panelheader.BackgroundImage = (Image)resources.GetObject("panelheader.BackgroundImage");
            panelheader.Location = new Point(188, 0);
            panelheader.Name = "panelheader";
            panelheader.Size = new Size(624, 53);
            panelheader.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(288, 217);
            dataGridView1.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Controls.Add(button1);
            panel4.Location = new Point(320, 142);
            panel4.Name = "panel4";
            panel4.Size = new Size(279, 207);
            panel4.TabIndex = 24;
            panel4.Paint += panel4_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(126, 188);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panelheader;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Button button1;
    }
}