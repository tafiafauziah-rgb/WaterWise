using System;
using System.Collections.Generic;
using System.Text;

namespace WaterWise.Models
{
    internal class users : Akun
    {
        public int Id_user { get; set; }
        public string no_kk { get; set; }
        public int jumlah_anggota { get; set; }

        public users()
        {
            // Konstruktor default
        }   

    }
}
