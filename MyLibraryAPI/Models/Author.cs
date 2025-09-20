namespace MyLibraryAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Country { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
