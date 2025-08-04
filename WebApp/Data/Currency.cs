namespace WebApp.Data
{
    public class Currency
    {
        public int Id { get; set; } // Primary Key

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        // Navigation property
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
