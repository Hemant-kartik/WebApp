namespace WebApp.Data
{
    public class Book
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public required string Description { get; set; }

        public int NoOfPages { get; set; }

        public bool IsActive { get; set; }

        public DateTime Createdon { get; set; }

        // Foreign Key for Language
        public int LanguageId { get; set; }

        public required Language Language { get; set; }

        // Uncomment below if you're adding BookPrice & Currency again
        // public int BookPriceId { get; set; }
        // public required BookPrice BookPrice { get; set; }

        // public int CurrencyId { get; set; }
        // public required Currency Currency { get; set; }
    }
}
