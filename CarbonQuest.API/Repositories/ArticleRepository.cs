using CarbonQuest.API.Models;
using CarbonQuest.Lib.Interfaces;
using CarbonQuest.Lib.Utils;
using System.Diagnostics;

namespace CarbonQuest.API.Repositories
{
    public class ArticleRepository : IRepository<Article>
    {
        private const string FilePath = "Datas/articles.json";
        private List<Article> _articles;

        public ArticleRepository()
        {
            _articles = JsonHelper.LoadFromFile<Article>(FilePath);
            Debug.Assert(_articles != null, "Articles tidak boleh null");
        }

        public List<Article> GetAll()
        {
            return _articles;
        }

        public Article? GetById(string id)
        {
            Validator.CheckStringNotEmpty(id, nameof(id));
            return _articles.FirstOrDefault(a => a.IdArticle == id);
        }

        public void Add(Article article)
        {
            Validator.CheckNotNull(article, nameof(article));
            _articles.Add(article);
            SaveChanges();
        }

        public void Update(Article article)
        {
            Validator.CheckNotNull(article, nameof(article));
            var existing = GetById(article.IdArticle);
            if (existing == null)
                throw new ArgumentException("Article tidak ditemukan.");

            existing.Title = article.Title;
            existing.Date = article.Date;
            existing.Content = article.Content;

            SaveChanges();
        }

        public void Delete(string id)
        {
            Validator.CheckStringNotEmpty(id, nameof(id));
            var article = GetById(id);
            if (article != null)
            {
                _articles.Remove(article);
                SaveChanges();
            }
        }

        public void SaveChanges()
        {
            JsonHelper.SaveToFile(FilePath, _articles);
            Debug.Assert(File.Exists(FilePath), "Save gagal, file tidak ditemukan.");
        }
    }
}
