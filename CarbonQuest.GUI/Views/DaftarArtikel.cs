using CarbonQuest.GUI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarbonQuest.GUI.Models;

namespace CarbonQuest.GUI.Views
{
    public partial class DaftarArtikel : Form
    {
        public DaftarArtikel()
        {
            InitializeComponent();
            LoadArticles();
        }

        // Method async untuk mengambil data artikel dari API
        private async void LoadArticles()
        {
            try
            {
                List<Article> articles = await APIClient.GetArticlesAsync();
                DisplayArticles(articles);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat artikel: " + ex.Message);
            }
        }

        // Menampilkan daftar artikel dalam bentuk tombol di dalam flowLayoutPanel
        private void DisplayArticles(List<Article> articles)
        {
            flowLayoutPanelArticle.Controls.Clear();

            foreach (var article in articles)
            {
                // Membuat tombol baru untuk setiap artikel
                var btnArticle = new Button
                {
                    Text = article.Title,
                    Width = 300,
                    Height = 60,
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    Margin = new Padding(10)
                };
                // Menambahkan event klik pada tombol
                btnArticle.Click += (sender, e) => OnArticleClicked(article);
                // Menambahkan tombol ke FlowLayoutPanel
                flowLayoutPanelArticle.Controls.Add(btnArticle);
            }
        }

        // Method untuk menangani klik pada tombol artikel
        private void OnArticleClicked(Article article)
        {
            Navigator.Instance.Navigate(AppRoute.ArtikelDetail, Tuple.Create(article.IdArticle ,article.Title, article.Content));
            this.Close();
        }

        // Method untuk menangani klik pada tombol Home
        private void btnHome_Click(object sender, EventArgs e)
        {
            Navigator.Instance.Navigate(AppRoute.Home);
            this.Close();
        }

        // Method untuk menangani klik pada tombol tambahkan artikel baru
        private void btnTambah_Click(object sender, EventArgs e)
        {
            Navigator.Instance.Navigate(AppRoute.ArtikelDetail, null);
            this.Close();
        }
    }
}
