//using System;
//using System.Collections.Generic;
//using System.Text;
//namespace WaterWise.Models
//    {
//    public abstract class Pengguna
//    {
//        // ENCAPSULATION: Menggunakan auto-implemented properties untuk melindungi data
//        public string Username { get; set; }
//        public string NamaLengkap { get; set; }
//        public string Email { get; set; }
//        public string NomorTelepon { get; set; }

//        public Pengguna(string username, string nama, string email, string telp)
//        {
//            Username = username;
//            NamaLengkap = nama;
//            Email = email;
//            NomorTelepon = telp;
//        }

//        // POLYMORPHISM: Method virtual yang bisa di-override oleh class turunan
//        public virtual string GetInfoStatus()
//        {
//            return "Status: Pengguna Umum";
//        }
//    }

//    public class Admin : Pengguna
//    {
//        // Atribut khusus admin yang kamu minta (Aktif/Tidak Aktif)
//        public bool IsAktif { get; set; }

//        public Admin(string username, string nama, string email, string telp, bool isAktif)
//            : base(username, nama, email, telp)
//        {
//            this.IsAktif = isAktif;
//        }
//        public override string GetInfoStatus()
//        {
//            return IsAktif ? "Status: Admin Aktif" : "Status: Admin Non-Aktif";
//        }
//    }
//}