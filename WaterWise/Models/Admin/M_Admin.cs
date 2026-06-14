using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.Model;

namespace WaterWise.Models.Admin
{
    public class M_Admin : M_Akun
    {
        public int Id_admin { get; set; }
        public string Status_kerja { get; set; }

        public M_Admin()
        {
            Role = "admin";
        }

        public override string Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return "Username dan password tidak boleh kosong!";

            if (Status_akun != "aktif")
                return "Akun admin tidak aktif!";

            return "success";
        }

        public override string GetDashboardInfo()
        {
            return $"Admin: {Nama} - Status Kerja: {Status_kerja}";
        }
    }
}
