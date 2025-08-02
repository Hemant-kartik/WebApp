namespace WebApp.Data
{
    public class BookPrice
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int BookId { get; set; }  // Foreign key for Book
        public required ICollection<Book> Books { get; set; }// Ensure to initialize the Book property
    }
}
