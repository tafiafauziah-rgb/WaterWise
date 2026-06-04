using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WaterWise.Views;

namespace WaterWise.Views
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Event handler referenced from EditProfile.Designer.cs:
        // btnKelolaUser.Click += this.btnKelolaUser_Click;
        private void btnKelolaUser_Click(object sender, EventArgs e)
        {
            // Minimal, safe behavior to satisfy the event subscription.
            // Replace this with real navigation/logic as needed.
            MessageBox.Show("Kelola User button clicked.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // This method was referenced by the Designer:
        // btnUbahLimit.Click += this.btnUbahLimit_Click;
        // Adding it here resolves CS1061.
        private void btnUbahLimit_Click(object sender, EventArgs e)
        {
            // Minimal implementation to avoid side effects.
            // Replace with real logic for "Ubah Limit" as needed.
            MessageBox.Show("Ubah Limit clicked.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }


        private void btnLihatKeluhan_Click(object sender, EventArgs e)
        {
            {
                // Minimal implementation to avoid side effects.
                // Replace with real logic for "Ubah Limit" as needed.
                MessageBox.Show("Ubah Limit clicked.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
