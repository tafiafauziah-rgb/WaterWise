using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WaterWise.Models;

namespace WaterWise.Views
{
    public partial class EditProfile : Form
    {
        // Menyimpan objek admin yang sedang aktif di halaman ini
        private Akun currentAdmin;

        public EditProfile()
        {
            InitializeComponent();

            // Daftarkan event Load secara manual ke method Form_Load jika belum terikat di designer
            this.Load += new System.EventHandler(this.EditProfile_Load);
        }

        // 1. MEMUAT DATA AWAL SAAT HALAMAN DIBUKA
        private void EditProfile_Load(object sender, EventArgs e)
        {
            // Membuat simulasi objek data dari class Akun
            currentAdmin = new Akun
            {
                Nama = "Syafia Hikmah Fauziah",
                Username = "admin_syafia",
                Email = "syafia@waterwise.com",
                Telepon = "081234567890",
                Alamat = "Jl. Merdeka No. 45, Bandung",
                IsActive = true
            };

            lblstatusadmin.Text = currentAdmin.IsActive ? "Aktif" : "Non-Aktif";
            lblstatusadmin.ForeColor = currentAdmin.IsActive ? Color.Green : Color.Red;

            tbNama.Text = currentAdmin.Nama;
            tbUsername.Text = currentAdmin.Username;
            tbEmail.Text = currentAdmin.Email;
            tbnotelepon.Text = currentAdmin.Telepon;
            tbalamat.Text = currentAdmin.Alamat;
        }
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNama.Text) || string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Nama, Username, dan Email wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Mengembalikan data dari TextBox UI ke dalam properti Objek Model
                currentAdmin.Nama = tbNama.Text;
                currentAdmin.Username = tbUsername.Text;
                currentAdmin.Email = tbEmail.Text;
                currentAdmin.Telepon = tbnotelepon.Text;
                currentAdmin.Alamat = tbalamat.Text;

                MessageBox.Show("Profil Admin berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void tbUsername_TextChanged(object sender, EventArgs e) { }
        private void tbNama_TextChanged(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void lblstatusadmin_Click(object sender, EventArgs e) 

        {
                // Semua logika penyimpanan data admin yang kamu edit 
                // dimasukkan di dalam kurung kurawal method ini.

                MessageBox.Show("Data Berhasil Disimpan!");
            }
        

        // NAVIGATION BUTTONS (SIDEBAR)
        private void btndashboardadmin_Click(object sender, EventArgs e)
        {
            dashboardadmin dashboard = new dashboardadmin();
            dashboard.Show();
            this.Hide();
        }

        private void btneditprofileadmin_Click(object sender, EventArgs e)
        {
            // Karena ini halaman EditProfile itu sendiri, cukup lakukan refresh data
            EditProfile_Load(sender, e);
        }

        private void btnlihatkeluhan_Click_1(object sender, EventArgs e)
        {
            LihatKeluhan lihatkeluhan = new LihatKeluhan();
            lihatkeluhan.Show();
            this.Hide();
        }

        private void btnubahlimit_Click_1(object sender, EventArgs e)
        {
            UbahLimit ubahlimit = new UbahLimit();
            ubahlimit.Show();
            this.Hide();
        }

        private void btnkelolauser_Click_1(object sender, EventArgs e)
        {
            KelolaUser kelolauser = new KelolaUser();
            kelolauser.Show();
            this.Hide();
        }

        private void btnlihatdata_Click(object sender, EventArgs e)
        {
            Lihatdata lihatdata = new Lihatdata();
            lihatdata.Show();
            this.Hide();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            HistoryPengguna historypengguna = new HistoryPengguna();
            historypengguna.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Penanganan tombol sisa dari desainer bawaan
        private void btnKelolaUser_Click(object sender, EventArgs e) { btnkelolauser_Click_1(sender, e); }
        private void btnUbahLimit_Click(object sender, EventArgs e) { btnubahlimit_Click_1(sender, e); }
        private void btnLihatKeluhan_Click(object sender, EventArgs e) { btnlihatkeluhan_Click_1(sender, e); }
    }
}