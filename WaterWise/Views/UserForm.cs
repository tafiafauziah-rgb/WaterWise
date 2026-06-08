using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WaterWise.Views
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnLimit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Check Limit");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAmbilAir_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHistory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelKeluhan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
