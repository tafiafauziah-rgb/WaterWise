using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WaterWise.Models.Admin;
using WaterWiseV2.Repositories;

namespace WaterWise.Controller.Admin_by_Izul
{
    internal class C_AdminProfile
    {
        private AdminDashboardRepository _dashboardRepo;
        private M_Admin _currentAdmin;

        public C_AdminProfile()
        {
            _dashboardRepo = new AdminDashboardRepository();
        }

        public M_Admin CurrentAdmin
        {
            get { return _currentAdmin; }
            set { _currentAdmin = value; }
        }

        public void LoadAdminData(int idAkun)
        {
            DataTable dt = _dashboardRepo.GetAdminById(idAkun);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                _currentAdmin = new M_Admin();
                _currentAdmin.Id_akun = idAkun;
                _currentAdmin.Username = row["username"].ToString();
                _currentAdmin.Nama = row["nama"].ToString();
                _currentAdmin.Email = row["email"].ToString();
                _currentAdmin.No_telepon = row["no_telepon"].ToString();
                _currentAdmin.Status_akun = row["status_akun"].ToString();
                _currentAdmin.Status_kerja = row["status_kerja"].ToString();
                _currentAdmin.Role = "admin";
            }
        }

        public DataTable GetProfileData(int idAkun)
        {
            return _dashboardRepo.GetAdminById(idAkun);
        }

        public bool UpdateProfile(int idAkun, string nama, string email, string noTelepon)
        {
            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email tidak valid!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(noTelepon))
            {
                MessageBox.Show("No telepon tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool berhasil = _dashboardRepo.UpdateAdminProfile(idAkun, nama, email, noTelepon);
            if (berhasil && _currentAdmin != null)
            {
                _currentAdmin.Nama = nama;
                _currentAdmin.Email = email;
                _currentAdmin.No_telepon = noTelepon;
            }
            return berhasil;
        }

        public bool IsAdmin(int idAkun)
        {
            return _dashboardRepo.IsAdmin(idAkun);
        }
    }
}
