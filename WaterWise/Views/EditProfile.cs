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

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlihatdata_Click(object sender, EventArgs e)
        {

        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {

        }

        private void btnlihatkeluhan_Click_1(object sender, EventArgs e)
        {

        }

        private void btnkelolauser_Click_1(object sender, EventArgs e)
        {

        }

        private void btnhistory_Click(object sender, EventArgs e)
        {

        }

        private void lblaktif_Click(object sender, EventArgs e)
        {

        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {

        }
    }
}
