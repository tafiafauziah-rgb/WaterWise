using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace WaterWise.Models
{
    public abstract class Akun 
    {
        // Pastikan nama-nama properti ini ada dan ditulis dengan huruf besar di awalnya (PascalCase)
        public int Id_akun { get; set; }
        public string Nama { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Telepon { get; set; }
        public string Alamat { get; set; }
        public string Status { get; set; }
        public string Password { get; set; }

    }
}
