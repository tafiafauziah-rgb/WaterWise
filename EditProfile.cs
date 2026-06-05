using System;
using System.Drawing;
using System.Windows.Forms;

namespace WaterWise
{
    public class EditProfile : Form
    {
        private Label lblTitle;
        private Button btnClose;

        public EditProfile()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Edit Profile";
            this.ClientSize = new Size(400, 200);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            lblTitle = new Label
            {
                Text = "Edit Profile",
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Location = new Point(16, 16)
            };

            btnClose = new Button
            {
                Text = "Close",
                Size = new Size(80, 28),
                Location = new Point(this.ClientSize.Width - 96, this.ClientSize.Height - 44),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right
            };
            btnClose.Click += (s, e) => this.Close();

            this.Controls.Add(lblTitle);
            this.Controls.Add(btnClose);
        }
    }
}