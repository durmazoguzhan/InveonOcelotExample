namespace Article.Api.Repositories.Interfaces
{
    public interface IArticleRepository
    {
        List<Models.Article> GetAll();

        //optional anlamına gelir
        Models.Article? Get(int id);

        int Delete(int id);
    }
}
