namespace WebApp.Data
{
    public class BookPrice
    {
        public int Id { get; set; }  // Primary Key

        public int Price { get; set; }

        public int BookId { get; set; }  // Foreign Key for Book

        public int CurrencyId { get; set; }  // Foreign Key for Currency

        public int Amount { get; set; }

        public required Book Book { get; set; }

        public required Currency Currency { get; set; }
    }
}
