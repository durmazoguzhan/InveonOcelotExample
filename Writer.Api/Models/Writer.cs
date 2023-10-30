namespace Writer.Api.Models
{
    public class Writer
    {
        //Domain, Entity, Model
        public int Id { get; set; }
        public string Name { get; set; }

        public Writer()
        {

        }
        public Writer(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
