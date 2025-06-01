using CarbonQuest.GUI.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarbonQuest.GUI.Views
{
    public partial class ArtikelDetail : Form
    {
        public ArtikelDetail(string judul, string isi)
        {
            InitializeComponent();
            tbxJudul.Text = judul;
            tbxArtikel.Text = isi;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Navigator.Instance.Navigate(AppRoute.DaftarArtikel);
            this.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // TODO: Implementasi hapus artikel lewat API
            MessageBox.Show("Artikel dihapus (simulasi).");
            Navigator.Instance.Navigate(AppRoute.DaftarArtikel);
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Implementasi edit artikel
            MessageBox.Show("Fitur edit belum tersedia.");
        }
    }
}
