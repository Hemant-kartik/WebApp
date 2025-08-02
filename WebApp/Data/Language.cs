namespace WebApp.Data
{
    public class Language
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        public required string Titel { get; set; }
        public int Description { get; set; }

        public required ICollection<Book> Books { get; set; }
    }
}
