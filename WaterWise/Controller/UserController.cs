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
        internal static Akun? CurrentUser { get; set; }
        public string Login(string username, string password)
        {
            try
            {

                string query = "SELECT * FROM users WHERE username=@u AND password=@p LIMIT 1";
                using var conn = new NpgsqlConnection(connstrig);
                conn.Open();
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("u", username);
                cmd.Parameters.AddWithValue("p", password);


                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Akun akun = new Akun();
                    {
                        akun.username = reader.GetString(1);
                        akun.password = reader.GetString(2);
                        akun.email = reader.GetString(3);
                        akun.role = akun.username == "admin" ? "admin" : "user";
                        akun.nama_lengkap = reader.GetString(5);

                        CurrentUser = akun;

                        return "Login Berhasil";
                    }
                    ;
                }
                else
                {
                    return "Login Gagal";
                }
            }
            catch (Exception ex) { MessageBox.Show("Terjadi kesalahan: " + ex.Message); }

            return null;
        }

    }
}
