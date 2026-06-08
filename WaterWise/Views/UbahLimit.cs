using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WaterWise.Views
{
    public partial class UbahLimit : Form
    {
        public UbahLimit()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlihatdata_Click(object sender, EventArgs e)
        {
            Lihatdata lihatdata = new Lihatdata();
            lihatdata.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btndashboardadmin_Click(object sender, EventArgs e)
        {
            dashboardadmin da = new dashboardadmin();
            da.Show();
            this.Hide();
        }

        private void btndashboardadmin_Click_1(object sender, EventArgs e)
        {
            dashboardadmin da = new dashboardadmin();
            da.Show();
            this.Hide();
        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {
            EditProfile editprofile = new EditProfile();
            editprofile.Show();
            this.Hide();
        }

        private void btnlihatkeluhan_Click(object sender, EventArgs e)
        {
            LihatKeluhan lihatKeluhan = new LihatKeluhan();
            lihatKeluhan.Show();
            this.Hide();
        }

        private void btnubahlimit_Click(object sender, EventArgs e)
        {
            UbahLimit ubahlimit = new UbahLimit();
            ubahlimit.Show();
            this.Hide();
        }

        private void btnkelolauser_Click(object sender, EventArgs e)
        {
            KelolaUser kelolaUser = new KelolaUser();
            kelolaUser.Show();
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
    }
}
