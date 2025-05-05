using CarbonQuest.API.Models;
using CarbonQuest.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarbonQuest.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly ArticleService _articleService;

        public ArticleController()
        {
            _articleService = new ArticleService();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var articles = _articleService.GetAll();
            return Ok(articles);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var article = _articleService.GetById(id);
            if (article == null)
                return NotFound("Artikel tidak ditemukan.");

            return Ok(article);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Article article)
        {
            _articleService.Add(article);
            return Ok(new { message = "Artikel berhasil ditambahkan." });
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] Article updatedArticle)
        {
            var existing = _articleService.GetById(id);
            if (existing == null)
                return NotFound("Artikel tidak ditemukan.");

            updatedArticle.IdArticle = id; // pastikan id tidak berubah
            _articleService.Update(updatedArticle);
            return Ok(new { message = "Artikel berhasil diupdate." });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var existing = _articleService.GetById(id);
            if (existing == null)
                return NotFound("Artikel tidak ditemukan.");

            _articleService.Delete(id);
            return Ok(new { message = "Artikel berhasil dihapus." });
        }
    }
}
