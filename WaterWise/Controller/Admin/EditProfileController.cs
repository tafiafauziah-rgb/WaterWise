//// Controller/EditProfileAdminController.cs
//using Npgsql;
//using System;
//using WaterWise.Db;
//using WaterWise.Models;
//using static WaterWise.Models.Akun;

//namespace WaterWise.Controller
//{
//    // ✅ INHERITANCE: mengimplementasikan interface IProfileEditable
//    // ✅ ENCAPSULATION: semua logika DB tersembunyi di dalam controller
//    public class EditProfileAdminController : IProfileEditable
//    {
//        private readonly string _connString;

//        public EditProfileAdminController()
//        {
//            db database = new db();
//            _connString = db.getConn().ConnectionString;
//        }

//        // ✅ POLYMORPHISM: implementasi GetProfile dari interface
//        public AkunBase? GetProfile(int idAkun)
//        {
//            string query = @"
//                SELECT a.id_akun, a.username, a.password, a.nama,
//                       a.no_telepon, a.alamat, a.status, a.email
//                FROM public.Akun a
//                INNER JOIN public.admin adm ON a.id_akun = adm.id_admin
//                WHERE a.id_akun = @id
//                LIMIT 1";

//            try
//            {
//                using var conn = new NpgsqlConnection(_connString);
//                conn.Open();
//                using var cmd = new NpgsqlCommand(query, conn);
//                cmd.Parameters.AddWithValue("id", idAkun);
//                using var reader = cmd.ExecuteReader();

//                if (reader.Read())
//                {
                  
//                    var adminData = new admin
//                    {
//                        Id_akun = Convert.ToInt32(reader["id_akun"]),
//                        Username = reader["username"]?.ToString() ?? string.Empty,
//                        Password = reader["password"]?.ToString() ?? string.Empty,
//                        Nama = reader["nama"]?.ToString() ?? string.Empty,
//                        Telepon = reader["no_telepon"]?.ToString() ?? string.Empty,
//                        Alamat = reader["alamat"]?.ToString() ?? string.Empty,
//                        Status = reader["status"]?.ToString() ?? string.Empty,
//                        Email = reader["email"]?.ToString() ?? string.Empty,
//                    };
//                    return adminData;
//                }
//                return null;
//            }
//            catch (Exception ex)
//            {
//                throw new Exception("Gagal mengambil data profil: " + ex.Message);
//            }
//        }

//        // ✅ POLYMORPHISM: implementasi UpdateProfile dari interface
//        public bool UpdateProfile(AkunBase akun)
//        {
//            // ✅ POLYMORPHISM: downcasting untuk akses field spesifik admin
//            if (akun is not admin adminData)
//                throw new ArgumentException("Data bukan tipe admin.");

//            string query = @"
//                UPDATE public.Akun
//                SET nama        = @nama,
//                    username    = @username,
//                    email       = @email,
//                    no_telepon  = @telepon,
//                    status      = @status
//                WHERE id_akun = @id";

//            try
//            {
//                using var conn = new NpgsqlConnection(_connString);
//                conn.Open();
//                using var cmd = new NpgsqlCommand(query, conn);
//                cmd.Parameters.AddWithValue("nama", adminData.Nama);
//                cmd.Parameters.AddWithValue("username", adminData.Username);
//                cmd.Parameters.AddWithValue("email", adminData.Email);
//                cmd.Parameters.AddWithValue("telepon", adminData.Telepon);
//                cmd.Parameters.AddWithValue("status", adminData.Status);
//                cmd.Parameters.AddWithValue("id", adminData.Id_akun);

//                int rowsAffected = cmd.ExecuteNonQuery();
//                return rowsAffected > 0;
//            }
//            catch (Exception ex)
//            {
//                throw new Exception("Gagal memperbarui profil: " + ex.Message);
//            }
//        }

//        // Method tambahan: cek apakah username sudah dipakai akun lain
//        public bool IsUsernameTaken(string username, int currentIdAkun)
//        {
//            string query = @"
//                SELECT COUNT(*) FROM public.Akun
//                WHERE username = @u AND id_akun <> @id";

//            try
//            {
//                using var conn = new NpgsqlConnection(_connString);
//                conn.Open();
//                using var cmd = new NpgsqlCommand(query, conn);
//                cmd.Parameters.AddWithValue("u", username);
//                cmd.Parameters.AddWithValue("id", currentIdAkun);
//                long count = (long)(cmd.ExecuteScalar() ?? 0L);
//                return count > 0;
//            }
//            catch (Exception ex)
//            {
//                throw new Exception("Gagal cek username: " + ex.Message);
//            }
//        }
//    }
//}