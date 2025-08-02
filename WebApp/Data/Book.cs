
namespace WebApp.Data
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public int NoOfPages { get; set; }
        public bool IsActive { get; set; }// Additional properties can be added as needed

        public int LanguageId { get; set; }  // Foreign key for Language
        public required Language Language { get; set; }  // Ensure to initialize the Language property

        public int BookPriceId { get; set; }
        public required BookPrice BookPrice { get; set; }  // Ensure to initialize the BookPrice property

        public int CurrencyId { get; set; }
        public required Currency Currency { get; set; }  // Ensure to initialize the Currency property



    }
}
