using System;
using System.Data;
using WaterWise.Models.Admin;
using WaterWise.Repositories.Admin;
using WaterWiseV2.Model;
using WaterWiseV2.Repositories;

namespace WaterWiseV2.Control.Admin
{
    public class C_Admin
    {
        private AdminDashboardRepository _dashboardRepo;
        private M_Admin _currentAdmin;
        private AdminUserRepository _userRepo;


        public C_Admin()
        {
            _dashboardRepo = new AdminDashboardRepository();
            _userRepo = new AdminUserRepository();
        }

        public M_Admin CurrentAdmin
        {
            get { return _currentAdmin; }
            set { _currentAdmin = value; }
        }

        // ==================== DASHBOARD ====================

        public int GetTotalUsers()
        {
            return _dashboardRepo.GetTotalUsers();
        }

        public int GetActiveUsers()
        {
            return _dashboardRepo.GetActiveUsers();
        }

        public int GetInactiveUsers()
        {
            return _dashboardRepo.GetInactiveUsers();
        }

        public int GetPendingReports()
        {
            return _dashboardRepo.GetPendingReports();
        }

        public DataTable GetRecentUsages()
        {
            return _dashboardRepo.GetRecentUsages(5);
        }

        // ==================== PROFIL ADMIN ====================

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
            // Validasi
            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email tidak valid!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(noTelepon))
            {
                MessageBox.Show("No telepon tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool berhasil = _dashboardRepo.UpdateAdminProfile(idAkun, nama, email, noTelepon);

            if (berhasil && _currentAdmin != null)
            {
                // Update data di memory
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