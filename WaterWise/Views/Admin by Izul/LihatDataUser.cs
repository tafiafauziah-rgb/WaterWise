using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WaterWise.Controller.Admin_by_Izul;
using WaterWise.Models.Admin;

namespace WaterWise.Views.Admin_by_Izul
{
    public partial class LihatDataUser : Form
    {
        private C_LihatDataUser _userController;
        private M_Admin _currentAdmin;

        public LihatDataUser(M_Admin admin)
        {
            InitializeComponent();
            _currentAdmin = admin;
            _userController = new C_LihatDataUser();

            LoadUserData();
        }

        private void LoadUserData()
        {
            DataTable dt = _userController.GetAllUsers();
            dgvUser.DataSource = dt;

            // Setting header kolom
            if (dt.Rows.Count > 0)
            {
                // Sembunyikan kolom id_akun
                if (dgvUser.Columns["id_akun"] != null)
                    dgvUser.Columns["id_akun"].Visible = false;

                // Header text
                if (dgvUser.Columns["Nama"] != null)
                    dgvUser.Columns["Nama"].HeaderText = "Nama";
                if (dgvUser.Columns["Username"] != null)
                    dgvUser.Columns["Username"].HeaderText = "Username";
                if (dgvUser.Columns["NoTelepon"] != null)
                    dgvUser.Columns["NoTelepon"].HeaderText = "No. Telepon";
                if (dgvUser.Columns["Email"] != null)
                    dgvUser.Columns["Email"].HeaderText = "Email";
                if (dgvUser.Columns["Status"] != null)
                    dgvUser.Columns["Status"].HeaderText = "Status";
                if (dgvUser.Columns["NoKK"] != null)
                    dgvUser.Columns["NoKK"].HeaderText = "No. KK";
                if (dgvUser.Columns["JumlahAnggota"] != null)
                    dgvUser.Columns["JumlahAnggota"].HeaderText = "Jumlah Keluarga";
                if (dgvUser.Columns["LimitAir"] != null)
                    dgvUser.Columns["LimitAir"].HeaderText = "Limit Air (L)";
                if (dgvUser.Columns["PemakaianHariIni"] != null)
                    dgvUser.Columns["PemakaianHariIni"].HeaderText = "Pemakaian Hari Ini (L)";
                if (dgvUser.Columns["SisaLimit"] != null)
                    dgvUser.Columns["SisaLimit"].HeaderText = "Sisa Limit (L)";
            }
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
