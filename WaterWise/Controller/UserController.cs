using System;
using System.Collections.Generic;
using System.Text;
using WaterWise.Db;
using WaterWise.Models;
using Npgsql;

namespace WaterWise.Controller
{
    public class UserController
    {
        public readonly string connstrig;
        public UserController()
        {
            db database = new db();
            connstrig = db.getConn().ConnectionString;
        }
        internal static admin? CurrentAdmin { get; set; }
        internal static users? CurrentUser { get; set; }
        public string Login(string username, string password)
        {
            string query = @"SELECT a.*, u.no_kk, u.jumlah_anggota, adm.id_admin
                     FROM public.Akun a
                     LEFT JOIN public.users u ON a.id_akun = u.id_user
                     LEFT JOIN public.admin adm ON a.id_akun = adm.id_admin
                     WHERE a.username = @u AND a.password = @p LIMIT 1";

            using var conn = new NpgsqlConnection(connstrig);
            conn.Open();
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("u", username);
            cmd.Parameters.AddWithValue("p", password);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // Cek apakah data yang ditarik memiliki No KK (User biasa) atau tidak (Admin)
                if (reader["no_kk"] == DBNull.Value || string.IsNullOrEmpty(reader["no_kk"].ToString()))
                {
                    var akunAdmin = new WaterWise.Models.admin();

                    akunAdmin.Id_akun = Convert.ToInt32(reader["id_akun"]);
                    akunAdmin.Username = reader["username"].ToString();
                    akunAdmin.Password = reader["password"].ToString();
                    akunAdmin.Nama = reader["nama"].ToString();
                    akunAdmin.Telepon = reader["no_telepon"].ToString();
                    akunAdmin.Status = reader["status"].ToString();
                    akunAdmin.Alamat = reader["alamat"].ToString();

                    CurrentAdmin = akunAdmin;
                    CurrentUser = null; // Menghapus sisa session user sebelumnya
                }
                else
                {
                    var akunUser = new WaterWise.Models.users();

                    akunUser.Id_akun = Convert.ToInt32(reader["id_akun"]);
                    akunUser.Username = reader["username"].ToString();
                    akunUser.Password = reader["password"].ToString();
                    akunUser.Nama = reader["nama"].ToString();
                    akunUser.Telepon = reader["no_telepon"].ToString();
                    akunUser.no_kk = reader["no_kk"].ToString();

                    CurrentUser = akunUser;
                    CurrentAdmin = null; // Menghapus sisa session admin sebelumnya
                }

                return "Login Berhasil"; // Jalur return 1 (Jika akun ditemukan)
            }
            else
            {
                return "Login Gagal"; // Jalur return 2 (Jika akun tidak ditemukan)
            }
        }
    }
}
