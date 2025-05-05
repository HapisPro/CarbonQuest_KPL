using CarbonQuest.API.Models;
using CarbonQuest.API.Repositories;

namespace CarbonQuest.API.Services
{
    public class ArticleService
    {
        private readonly ArticleRepository _articleRepository;

        public ArticleService()
        {
            _articleRepository = new ArticleRepository();
        }

        public List<Article> GetAll()
        {
            return _articleRepository.GetAll();
        }

        public Article? GetById(string id)
        {
            return _articleRepository.GetById(id);
        }

        public void Add(Article article)
        {
            _articleRepository.Add(article);
        }

        public void Update(Article article)
        {
            _articleRepository.Update(article);
        }

        public void Delete(string id)
        {
            _articleRepository.Delete(id);
        }
    }
}
