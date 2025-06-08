using CarbonQuest.GUI.Controllers;
using CarbonQuest.GUI.Models;
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
    private string _idArticle;

        // Konstruktor untuk form detail artikel
        public ArtikelDetail(string idArticle, string judul, string isi)
        {
            InitializeComponent();
            _idArticle = idArticle;

            // Jika idArticle null atau kosong, maka ini dianggap sebagai penambahan artikel baru
            btnHapus.Visible = !string.IsNullOrEmpty(_idArticle);

            if (string.IsNullOrEmpty(_idArticle))
            {
                tbxJudul.Clear();
                tbxArtikel.Clear();
                btnEdit.Text = "Tambah";
            }
            else
            {
                tbxJudul.Text = judul;
                tbxArtikel.Text = isi;
            }
        }
        // Tombol untuk kembali ke daftar artikel
        private void btnKembali_Click(object sender, EventArgs e)
        {
            Navigator.Instance.Navigate(AppRoute.DaftarArtikel);
            this.Close();
        }

        // Tombol untuk menghapus artikel
        private async void btnHapus_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda yakin ingin menghapus artikel ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Panggil API untuk menghapus artikel
                    bool isDeleted = await APIClient.DeleteArticleAsync(_idArticle);

                    if (isDeleted)
                    {
                        MessageBox.Show("Artikel berhasil dihapus.");
                        Navigator.Instance.Navigate(AppRoute.DaftarArtikel);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus artikel.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat menghapus artikel: " + ex.Message);
                }
            }
        }

        // Tombol untuk menambah atau mengedit artikel
        private async void btnEdit_Click(object sender, EventArgs e)
        {
            string newTitle = tbxJudul.Text;
            string newContent = tbxArtikel.Text;

            if (string.IsNullOrWhiteSpace(newTitle) || string.IsNullOrWhiteSpace(newContent))
            {
                MessageBox.Show("Judul dan Isi artikel tidak boleh kosong.");
                return;
            }

            try
            {
                // Buat objek artikel baru dengan data yang diperbarui
                var updatedArticle = new Article
                {
                    IdArticle = _idArticle ?? Guid.NewGuid().ToString(), // Buat ID baru jika artikel baru
                    Title = newTitle,
                    Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), // Menggunakan tanggal saat ini
                    Content = newContent
                };

                bool isSuccess;
                // Tentukan apakah akan menambah atau mengedit artikel
                if (_idArticle == null) // Menambahkan artikel baru
                {
                    isSuccess = await APIClient.AddArticleAsync(updatedArticle);
                }
                else // Mengedit artikel yang sudah ada
                {
                    isSuccess = await APIClient.EditArticleAsync(_idArticle, updatedArticle);
                }
                // Tampilkan notifikasi hasil aksi
                if (isSuccess)
                {
                    MessageBox.Show(_idArticle == null ? "Artikel berhasil ditambahkan." : "Artikel berhasil diedit.");
                    Navigator.Instance.Navigate(AppRoute.DaftarArtikel);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan artikel.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan artikel: " + ex.Message);
            }
        }
    }
}
