using Microsoft.EntityFrameworkCore;
using MyLibraryAPI.Models;

namespace MyLibraryAPI.Data;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options) { }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
}
