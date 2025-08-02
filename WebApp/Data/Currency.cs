namespace WebApp.Data
{
    public class Currency
    {
        public int Id { get; set; } // Primary Key
        public int Rupees { get; set; }
        public int Dollar { get; set; }
        public int Euro { get; set; }

        public required ICollection<Book> Books { get; set; }
    }
}
