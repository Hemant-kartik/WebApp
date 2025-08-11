//// Corrected Language.cs
//namespace WebApp.Data
//{
//    public class Language
//    {
//        public int Id { get; set; }
//        public required string Title { get; set; }
//        public required string Description { get; set; }
//        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
//    }
//}
namespace WebApp.Data
{
    public class Language
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
        public string Titel { get; internal set; }
    }
}