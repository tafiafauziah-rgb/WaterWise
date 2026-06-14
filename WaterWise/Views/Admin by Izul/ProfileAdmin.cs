using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WaterWise.Controller.Admin_by_Izul;
using WaterWise.Models.Admin;
using WaterWiseV2.Control.Admin;
using WaterWiseV2.Helper;

namespace WaterWise.Views.Admin_by_Izul
{
    public partial class ProfileAdmin : Form
    {
        private C_AdminProfile _adminController;
        private M_Admin _currentAdmin;
        private bool _isEditMode = false;

        public ProfileAdmin(M_Admin admin)
        {
            InitializeComponent();
            _currentAdmin = admin;
            _adminController = new C_AdminProfile();
            _adminController.CurrentAdmin = admin;

            LoadProfileData();
            SetEditMode(false);
        }

        private void LoadProfileData()
        {
            DataTable dt = _adminController.GetProfileData(_currentAdmin.Id_akun);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtNama.Text = row["nama"].ToString();
                txtEmail.Text = row["email"].ToString();
                txtStatus.Text = row["status_akun"].ToString();
                txtUsername.Text = row["username"].ToString();
                txtNoTelepon.Text = row["no_telepon"].ToString();
            }
        }

        private void SetEditMode(bool isEdit)
        {
            _isEditMode = isEdit;

            // Yang bisa diedit
            txtNama.ReadOnly = !isEdit;
            txtEmail.ReadOnly = !isEdit;
            txtNoTelepon.ReadOnly = !isEdit;

            // Yang tidak bisa diedit
            txtUsername.ReadOnly = true;
            txtStatus.ReadOnly = true;

            // Warna background
            if (isEdit)
            {
                txtNama.BackColor = Color.White;
                txtEmail.BackColor = Color.White;
                txtNoTelepon.BackColor = Color.White;
            }
            else
            {
                txtNama.BackColor = SystemColors.ControlLight;
                txtEmail.BackColor = SystemColors.ControlLight;
                txtNoTelepon.BackColor = SystemColors.ControlLight;
            }

            // Toggle tombol
            btnEdit.Visible = !isEdit;
            btnSimpan.Visible = isEdit;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetEditMode(true);
            txtNama.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Email tidak valid!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNoTelepon.Text))
            {
                MessageBox.Show("No telepon tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update ke database
            bool berhasil = _adminController.UpdateProfile(
                _currentAdmin.Id_akun,
                txtNama.Text.Trim(),
                txtEmail.Text.Trim(),
                txtNoTelepon.Text.Trim()
            );

            if (berhasil)
            {
                // Update data lokal
                _currentAdmin.Nama = txtNama.Text.Trim();
                _currentAdmin.Email = txtEmail.Text.Trim();
                _currentAdmin.No_telepon = txtNoTelepon.Text.Trim();

                MessageBox.Show("Profile berhasil diupdate!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                SetEditMode(false);
            }
            else
            {
                MessageBox.Show("Gagal menyimpan perubahan!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tombol kembali (hubungkan di Designer)
        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToDashboardAdmin(_currentAdmin, this);
        }
    }
}
