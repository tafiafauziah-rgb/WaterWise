using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WaterWiseV2.Model;

namespace WaterWiseV2.Model
{
    public class M_User : M_Akun
    {
        public int Id_user { get; set; }
        public string No_kk { get; set; }
        public int Jumlah_anggota { get; set; }
        public int Limit_air { get; set; }

        // Navigation property (opsional, untuk relasi)
        public List<M_PenggunaanAir> RiwayatPenggunaan { get; set; }

        public M_User()
        {
            Role = "user";
            RiwayatPenggunaan = new List<M_PenggunaanAir>();
            Limit_air = 0;
        }

        // ========== TAMBAHKAN INI (Override Methods) ==========
        public override string Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return "Username dan password tidak boleh kosong!";

            // Validasi tambahan untuk user (opsional)
            if (Status_akun != "aktif")
                return "Akun Anda tidak aktif!";

            return "success";
        }

        public override string GetDashboardInfo()
        {
            return $"User: {Nama} - Limit Air: {Limit_air} liter - Sisa: {Limit_air} liter";
        }
    }
}