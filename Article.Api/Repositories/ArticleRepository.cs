using Article.Api.Repositories.Interfaces;

namespace Article.Api.Repositories
{
    public class ArticleRepository : List<Models.Article>, IArticleRepository
    {
        private readonly static List<Models.Article> _articles = PopulerMakaleler();
        private static List<Models.Article> PopulerMakaleler()
        {
            var makaleListesi = new List<Models.Article>()
            {
                new Models.Article
                {
                    Id = 1,
                    Title = "Makale 1",
                    WriterId = 1,
                    LastUpdate = DateTime.Now
                },
                new Models.Article
                {
                    Id = 2,
                    Title = "Makale 2",
                    WriterId = 2,
                    LastUpdate = DateTime.Now
                },
                new Models.Article
                {
                    Id = 3,
                    Title = "Makale 3",
                    WriterId = 3,
                    LastUpdate = DateTime.Now
                },
            };

            return makaleListesi;
        }

        public int Delete(int id)
        {
            var removed = _articles.SingleOrDefault(x => x.Id == id);
            if (removed != null)
            {
                _articles.Remove(removed); //delete from Article where Id=id,
            }

            return removed?.Id ?? 0; //ternary operator tek satırda if else yazmamızı sağlar
        }

        public Models.Article? Get(int id)
        {
            return _articles.FirstOrDefault(x => x.Id == id); //select * from Article where Id=id
        }

        public List<Models.Article> GetAll()
        {
            return _articles;
        }

    }
}
