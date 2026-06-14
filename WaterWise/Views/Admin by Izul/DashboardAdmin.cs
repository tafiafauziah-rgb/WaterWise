using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WaterWise.Models.Admin;
using WaterWiseV2;
using WaterWiseV2.Control.Admin;
using WaterWiseV2.Helper;
using WaterWiseV2.Repositories;

namespace WaterWise.Views.Admin_by_Izul
{
    public partial class DashboardAdmin : Form
    {
        private AdminDashboardRepository _dashboardRepo;
        private M_Admin _currentAdmin;

        public DashboardAdmin(M_Admin admin)
        {
            InitializeComponent();
            _currentAdmin = admin;
            _dashboardRepo = new AdminDashboardRepository();

            LoadDashboard();
            SetWelcomeMessage();
        }

        private void LoadDashboard()
        {
            // Load statistik
            lblTotalUserValue.Text = _dashboardRepo.GetTotalUsers().ToString();
            lblActiveUserValue.Text = _dashboardRepo.GetActiveUsers().ToString();
            lblInactiveUserValue.Text = _dashboardRepo.GetInactiveUsers().ToString();
            lblPendingReportValue.Text = _dashboardRepo.GetPendingReports().ToString();

            // Load penggunaan terbaru
            DataTable dt = _dashboardRepo.GetRecentUsages(5);
            dgvRecentUsage.DataSource = dt;

            // Setting header DataGridView
            if (dt.Rows.Count > 0)
            {
                if (dgvRecentUsage.Columns["NamaUser"] != null)
                    dgvRecentUsage.Columns["NamaUser"].HeaderText = "Nama User";
                if (dgvRecentUsage.Columns["JumlahAir"] != null)
                    dgvRecentUsage.Columns["JumlahAir"].HeaderText = "Jumlah Air (L)";
                if (dgvRecentUsage.Columns["Tanggal"] != null)
                    dgvRecentUsage.Columns["Tanggal"].HeaderText = "Tanggal & Waktu";
                if (dgvRecentUsage.Columns["KodeAmbil"] != null)
                    dgvRecentUsage.Columns["KodeAmbil"].HeaderText = "Kode Ambil";
                if (dgvRecentUsage.Columns["StatusKeluhan"] != null)
                    dgvRecentUsage.Columns["StatusKeluhan"].HeaderText = "Status Keluhan";
            }
        }

        private void SetWelcomeMessage()
        {
            lblWelcome.Text = $"Selamat datang kembali, {_currentAdmin.Nama}";
        }

        // Tombol navigasi (hubungkan di Designer)
        private void btnProfile_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToProfileAdmin(_currentAdmin, this);
        }

        private void btnKelolaUser_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToKelolaUserAdmin(_currentAdmin, this);
        }

        private void btnLihatKeluhan_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToLihatKeluhanAdmin(_currentAdmin, this);
        }

        private void btnUbahLimit_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToUbahLimitAdmin(_currentAdmin, this);
        }

        private void btnLihatDataUser_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToLihatDataUserAdmin(_currentAdmin, this);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToHistoryAdmin(_currentAdmin, this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnlihatkeluhan_Click_1(object sender, EventArgs e)
        {

        }

        private void btnubahlimit_Click_1(object sender, EventArgs e)
        {

        }

        private void btnlihatdatauser_Click_1(object sender, EventArgs e)
        {

        }

        private void btntotaluser_Click(object sender, EventArgs e)
        {

        }

        private void btnkeluhanmenunggu_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnutama_Click(object sender, EventArgs e)
        {

        }

        private void btnkelolauser_Click_1(object sender, EventArgs e)
        {

        }
    }
}
