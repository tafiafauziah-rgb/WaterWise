using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WaterWise.Models.Admin; // 1. TAMBAHKAN INI agar Form bisa membaca file DashboardMetric.cs

namespace WaterWise.Views
{
    public partial class dashboardadmin : Form
    {
        public dashboardadmin()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Bisa dikosongkan jika event yang terikat di visual designer adalah AdminForm_Load_1
        }

        // 2. ISI DI DALAM EVENT LOAD INI
        
        // 3. TAMBAHKAN METHOD BARU INI UNTUK MEMPROSES OOP KE UI
        

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
            
        }

        public void SwicthKelolaUser()
        {
            KelolaUser kelolaus = new KelolaUser();
            kelolaus.Show();
            this.Hide();
        }

        public void SwicthLihatData()
        {
            Lihatdata lihatdata = new Lihatdata(); // Catatan: pastikan nama class 'Lihatdata' atau 'LookData' konsisten
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

        private void btnlihatkeluhan_Click_1(object sender, EventArgs e)
        {
            LihatKeluhan lihatkeluhan = new LihatKeluhan();
            lihatkeluhan.Show();
            this.Hide();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            dashboardadmin forAdmin = new dashboardadmin();
            forAdmin.Show();
            this.Hide();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void btnlihatdata_Click_1(object sender, EventArgs e)
        {
            Lihatdata lihatdata = new Lihatdata();
            lihatdata.Show();
            this.Hide();
        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btneditprofil_Click(object sender, EventArgs e)
        {
        }

        private void btnubahlimit_Click_1(object sender, EventArgs e)
        {
            UbahLimit ubahlimit = new UbahLimit();
            ubahlimit.Show();
            this.Hide();
        }

        private void btnkelolauser_Click_1(object sender, EventArgs e)
        {
            KelolaUser kelolauser = new KelolaUser();
            kelolauser.Show();
            this.Hide();
        }

        private void paneltotalpengguna_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnhistory_Click_1(object sender, EventArgs e)
        {
            HistoryPengguna historypengguna = new HistoryPengguna();
            historypengguna.Show();
            this.Hide(); // Tambahkan ini agar form lama tersembunyi saat pindah history
        }
    }
}