using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WaterWiseV2.DatabaseHealper;

namespace WaterWise.Repositories.Admin
{
    internal class AdminUserRepository
    {
        private DatabaseHelper _dbHelper;

        public AdminUserRepository()
        {
            _dbHelper = new DatabaseHelper();
        }

        // ==================== LIHAT DATA USER ====================
        public DataTable GetAllUsers()
        {
            string query = @"
                SELECT 
                    a.id_akun,
                    a.nama AS Nama,
                    a.username AS Username,
                    a.no_telepon AS NoTelepon,
                    a.email AS Email,
                    a.status_akun AS Status,
                    u.no_kk AS NoKK,
                    u.jumlah_anggota AS JumlahAnggota,
                    u.limit_air AS LimitAir,
                    COALESCE(
                        (SELECT SUM(jumlah_air) 
                         FROM penggunaan_air 
                         WHERE id_user = u.id_user 
                         AND DATE(tanggal_penggunaan) = CURRENT_DATE), 0) AS PemakaianHariIni,
                    (u.limit_air - COALESCE(
                        (SELECT SUM(jumlah_air) 
                         FROM penggunaan_air 
                         WHERE id_user = u.id_user 
                         AND DATE(tanggal_penggunaan) = CURRENT_DATE), 0)) AS SisaLimit
                FROM akun a
                JOIN users u ON a.id_akun = u.id_akun
                WHERE a.role = 'user'
                ORDER BY a.nama";

            return _dbHelper.ExecuteQuery(query);
        }

        public DataTable SearchUsers(string keyword)
        {
            string query = @"
                SELECT 
                    a.id_akun,
                    a.nama AS Nama,
                    a.username AS Username,
                    a.no_telepon AS NoTelepon,
                    a.email AS Email,
                    a.status_akun AS Status,
                    u.no_kk AS NoKK,
                    u.jumlah_anggota AS JumlahAnggota,
                    u.limit_air AS LimitAir,
                    COALESCE(
                        (SELECT SUM(jumlah_air) 
                         FROM penggunaan_air 
                         WHERE id_user = u.id_user 
                         AND DATE(tanggal_penggunaan) = CURRENT_DATE), 0) AS PemakaianHariIni,
                    (u.limit_air - COALESCE(
                        (SELECT SUM(jumlah_air) 
                         FROM penggunaan_air 
                         WHERE id_user = u.id_user 
                         AND DATE(tanggal_penggunaan) = CURRENT_DATE), 0)) AS SisaLimit
                FROM akun a
                JOIN users u ON a.id_akun = u.id_akun
                WHERE a.role = 'user' 
                AND (a.nama ILIKE @keyword OR a.username ILIKE @keyword OR u.no_kk ILIKE @keyword)
                ORDER BY a.nama";

            var parameters = new Dictionary<string, object> { { "@keyword", $"%{keyword}%" } };
            return _dbHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetUserById(int idAkun)
        {
            string query = @"
                SELECT 
                    a.id_akun,
                    a.nama AS Nama,
                    a.username AS Username,
                    a.no_telepon AS NoTelepon,
                    a.email AS Email,
                    a.status_akun AS Status,
                    u.no_kk AS NoKK,
                    u.jumlah_anggota AS JumlahAnggota,
                    u.limit_air AS LimitAir
                FROM akun a
                JOIN users u ON a.id_akun = u.id_akun
                WHERE a.id_akun = @idAkun AND a.role = 'user'";

            var parameters = new Dictionary<string, object> { { "@idAkun", idAkun } };
            return _dbHelper.ExecuteQuery(query, parameters);
        }

        // ==================== KELOLA USER ====================
        public bool UpdateUserStatus(int idAkun, string status)
        {
            string query = "UPDATE akun SET status_akun = @status WHERE id_akun = @idAkun";
            var parameters = new Dictionary<string, object>
            {
                { "@status", status },
                { "@idAkun", idAkun }
            };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteUser(int idAkun)
        {
            string query = "DELETE FROM akun WHERE id_akun = @idAkun AND role = 'user'";
            var parameters = new Dictionary<string, object> { { "@idAkun", idAkun } };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // ==================== UBAH LIMIT ====================
        public bool UpdateUserLimit(int idUser, int limitBaru)
        {
            string query = "UPDATE users SET limit_air = @limit WHERE id_user = @idUser";
            var parameters = new Dictionary<string, object>
            {
                { "@limit", limitBaru },
                { "@idUser", idUser }
            };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public int GetUserLimit(int idUser)
        {
            string query = "SELECT limit_air FROM users WHERE id_user = @idUser";
            var parameters = new Dictionary<string, object> { { "@idUser", idUser } };
            object result = _dbHelper.ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }
    }
}
