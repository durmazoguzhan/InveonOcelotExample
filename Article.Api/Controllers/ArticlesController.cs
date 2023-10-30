using Article.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Article.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleRepository _articleRepository;
        public ArticlesController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_articleRepository.GetAll());// Tüm makaleler dönecek json dönecek
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var detailArticle = _articleRepository.Get(id);
            if (detailArticle is null)
            {
                return NotFound(); // ilgili detay kayıt bulunamadı
            }
            return Ok(detailArticle);//200 kodu döner select * from Article wher Id=id
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var silinecekArticle = _articleRepository.Delete(id);
            if (silinecekArticle == 0)
                return NotFound(); // 404
            return NoContent();
        }
    }
}
