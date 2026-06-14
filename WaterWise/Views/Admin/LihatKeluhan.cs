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
    public partial class LihatKeluhan : Form
    {
        public LihatKeluhan()
        {
            InitializeComponent();
        }

        private void lbldashboardadmin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnlihatdata_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btndashboardadmin_Click(object sender, EventArgs e)
        {
            dashboardadmin dashboardaadmin = new dashboardadmin();
            dashboardaadmin.Show();
            this.Hide();
        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlihatkeluhan_Click(object sender, EventArgs e)
        {
            LihatKeluhan lihatkeluhan = new LihatKeluhan();
            lihatkeluhan.Show();
            this.Hide();
        }

        private void btnubahlimit_Click(object sender, EventArgs e)
        {
            LihatKeluhan lihatkeluhan = new LihatKeluhan();
            lihatkeluhan.Show();
            this.Hide();
        }

        private void btnkelolauser_Click(object sender, EventArgs e)
        {
            KelolaUser kelolaUser = new KelolaUser();
            kelolaUser.Show();
            this.Hide();
        }

        private void btnlihatdata_Click_1(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
