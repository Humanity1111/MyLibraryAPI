using MyLibraryAPI.Models;
using System.Text.Json.Serialization;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    public bool IsRead { get; set; }

    public int AuthorId { get; set; }

    [JsonIgnore]
    public Author? Author { get; set; }

    public string? CoverImagePath { get; set; }
}
