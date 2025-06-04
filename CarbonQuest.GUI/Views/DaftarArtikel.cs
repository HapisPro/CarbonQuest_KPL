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

        private void DisplayArticles(List<Article> articles)
        {
            flowLayoutPanelArticle.Controls.Clear();

            foreach (var article in articles)
            {
                var btnArticle = new Button
                {
                    Text = article.Title,
                    Width = 300,
                    Height = 60,
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    Margin = new Padding(10)
                };
                btnArticle.Click += (sender, e) => OnArticleClicked(article);
                flowLayoutPanelArticle.Controls.Add(btnArticle);
            }
        }

        private void OnArticleClicked(Article article)
        {
            Navigator.Instance.Navigate(AppRoute.ArtikelDetail, Tuple.Create(article.IdArticle ,article.Title, article.Content));
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Navigator.Instance.Navigate(AppRoute.Home);
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Navigator.Instance.Navigate(AppRoute.ArtikelDetail, null);
            this.Close();
        }
    }
}
