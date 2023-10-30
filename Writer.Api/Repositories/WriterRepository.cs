using Writer.Api.Repositories.Interfaces;

namespace Writer.Api.Repositories
{
    public class WriterRepository : List<Models.Writer>, IWriterRepository
    {

        private readonly static List<Models.Writer> writers = PopulerWriters();
        private static List<Models.Writer> PopulerWriters()
        {
            return new List<Models.Writer>
            {
                new Models.Writer
                {
                    Id = 1,
                    Name = "İbrahim Gökyar"
                },
                new Models.Writer
                {
                    Id = 2,
                    Name = "Hakan Yılmaz"
                },
                new Models.Writer
                {
                    Id = 3,
                    Name = "Mehmet Yılmaz"
                }

            };
        }
        public Models.Writer? Get(int id)
        {
            return writers.FirstOrDefault(x => x.Id == id);
        }

        public List<Models.Writer> GetAll()
        {
            return writers;
        }

        public Models.Writer Insert(Models.Writer writer)
        {
            var maxId = writers.Max(x => x.Id);
            writer.Id = ++maxId;
            writers.Add(writer);
            return writer;
        }
    }
}
