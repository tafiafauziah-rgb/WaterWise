using System;
using System.Collections.Generic;
using System.Text;
using WaterWise.Models;
using System.Windows.Forms;
using WaterWise.Repositories;
using WaterWiseV2.Model;
using WaterWiseV2.Repositories;

namespace WaterWiseV2.Control.Auth
{
    internal class C_Login
    {
        private AkunRepository _akunRepo;
        private UserRepository _userRepo;

        public C_Login()
        {
            _akunRepo = new AkunRepository();
            _userRepo = new UserRepository();
        }

        public object Login(string username, string password)
        {
            // Cari akun berdasarkan username
            M_Akun akun = _akunRepo.GetByUsername(username);

            if (akun == null)
            {
                MessageBox.Show("Username tidak ditemukan!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // ========== PAKAI METHOD OVERRIDE Login() ==========
            string loginResult = akun.Login(username, password);
            if (loginResult != "success")
            {
                MessageBox.Show(loginResult, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // Cek password secara langsung
            if (akun.Password != password)
            {
                MessageBox.Show("Password salah!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (akun.Role == "admin")
            {
                MessageBox.Show($"Selamat datang Admin {akun.Nama}!", "Login Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return akun;
            }
            else
            {
                M_User user = _userRepo.GetByAkunId(akun.Id_akun);
                if (user != null)
                {
                    MessageBox.Show($"Selamat datang {user.Nama}!", "Login Berhasil",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return user;
                }
                return akun;
            }
        }
    }
}