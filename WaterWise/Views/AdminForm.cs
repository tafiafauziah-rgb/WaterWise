using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WaterWise.Models;
using WaterWise.Views;


namespace WaterWise
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlihatkeluhan_Click(object sender, EventArgs e)
        {
            SwicthLihatKeluhan();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblnama_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnubahlimit_Click(object sender, EventArgs e)
        {
            SwicthUbahLimit();
        }

        private void btnkelolauser_Click(object sender, EventArgs e)
        {
            SwicthKelolaUser();
        }

        private void lblstatususer_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click_3(object sender, EventArgs e)
        {

        }

        private void lbltglkeluhan_Click(object sender, EventArgs e)
        {
            LihatKeluhan lihatKeluhanForm = new LihatKeluhan();
            lihatKeluhanForm.Show();
            this.Hide();
        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {
            SwicthEditProfile();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Akan ke Close");
            this.Close();

        }


        public void Logout()
        {
            this.Close();
        }

        public void SwicthEditProfile()
        {
            EditProfile editProfileForm = new EditProfile();
            editProfileForm.Show();
            this.Hide();
        }

        public void SwicthKelolaUser()
        {
            KelolaUser kelolaus = new KelolaUser();
            kelolaus.Show();
            this.Hide();
        }

        public void SwicthLihatData()
        {
            Lihatdata lihatdata = new Lihatdata();
            lihatdata.Show();
            this.Hide();
        }

        public void SwicthLihatKeluhan()
        {
            LihatKeluhan lihatKeluhanForm = new LihatKeluhan();
            lihatKeluhanForm.Show();
            this.Hide();
        }

        public void SwicthUbahLimit()
        {
            UbahLimit ubahLimitForm = new UbahLimit();
            ubahLimitForm.Show();
            this.Hide();
        }

        public void SwicthHistoryPengguna()
        {
            HistoryPengguna historyPenggunaForm = new HistoryPengguna();
            historyPenggunaForm.Show();
            this.Hide();
        }

        private void btnlihatdata_Click(object sender, EventArgs e)
        {
            SwicthLihatData();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            SwicthHistoryPengguna();
        }
    }
}
