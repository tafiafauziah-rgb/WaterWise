using System;
using System.Collections.Generic;
using System.Data;
using WaterWiseV2.DatabaseHealper;
using WaterWiseV2.Helper;

namespace WaterWiseV2.Repositories
{
    public class AdminDashboardRepository
    {
        private DatabaseHelper _dbHelper;

        public AdminDashboardRepository()
        {
            _dbHelper = new DatabaseHelper();
        }

        // ==================== DASHBOARD ====================
        public int GetTotalUsers()
        {
            string query = "SELECT COUNT(*) FROM akun WHERE role = 'user'";
            object result = _dbHelper.ExecuteScalar(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public int GetActiveUsers()
        {
            string query = "SELECT COUNT(*) FROM akun WHERE role = 'user' AND status_akun = 'aktif'";
            object result = _dbHelper.ExecuteScalar(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public int GetInactiveUsers()
        {
            string query = "SELECT COUNT(*) FROM akun WHERE role = 'user' AND status_akun = 'nonaktif'";
            object result = _dbHelper.ExecuteScalar(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public int GetPendingReports()
        {
            string query = "SELECT COUNT(*) FROM laporan WHERE status_laporan IN ('diproses', 'ditinjau')";
            object result = _dbHelper.ExecuteScalar(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public DataTable GetRecentUsages(int limit = 5)
        {
            string query = @"
                SELECT 
                    a.nama AS NamaUser,
                    p.jumlah_air AS JumlahAir,
                    p.tanggal_penggunaan AS Tanggal,
                    p.kode_ambil AS KodeAmbil,
                    COALESCE(l.status_laporan, '-') AS StatusKeluhan
                FROM penggunaan_air p
                JOIN users u ON p.id_user = u.id_user
                JOIN akun a ON u.id_akun = a.id_akun
                LEFT JOIN laporan l ON a.id_akun = l.id_akun 
                    AND DATE(l.tanggal_laporan) = DATE(p.tanggal_penggunaan)
                ORDER BY p.tanggal_penggunaan DESC
                LIMIT @limit";

            var parameters = new Dictionary<string, object> { { "@limit", limit } };
            return _dbHelper.ExecuteQuery(query, parameters);
        }

        // ==================== PROFIL ADMIN ====================
        public DataTable GetAdminById(int idAkun)
        {
            string query = @"
                SELECT 
                    a.id_akun,
                    a.username,
                    a.nama,
                    a.email,
                    a.no_telepon,
                    a.status_akun,
                    adm.status_kerja
                FROM akun a
                JOIN admin adm ON a.id_akun = adm.id_akun
                WHERE a.id_akun = @idAkun";

            var parameters = new Dictionary<string, object> { { "@idAkun", idAkun } };
            return _dbHelper.ExecuteQuery(query, parameters);
        }

        public bool UpdateAdminProfile(int idAkun, string nama, string email, string noTelepon)
        {
            string query = "UPDATE akun SET nama = @nama, email = @email, no_telepon = @noTelepon WHERE id_akun = @idAkun";
            var parameters = new Dictionary<string, object>
            {
                { "@nama", nama },
                { "@email", email },
                { "@noTelepon", noTelepon },
                { "@idAkun", idAkun }
            };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool IsAdmin(int idAkun)
        {
            string query = "SELECT COUNT(*) FROM akun WHERE id_akun = @idAkun AND role = 'admin'";
            var parameters = new Dictionary<string, object> { { "@idAkun", idAkun } };
            object result = _dbHelper.ExecuteScalar(query, parameters);
            return result != null && Convert.ToInt32(result) > 0;
        }
    }
}