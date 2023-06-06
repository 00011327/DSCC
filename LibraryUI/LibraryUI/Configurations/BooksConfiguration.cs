using LibraryUI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Threading;

namespace LibraryUI.Configurations
{
    public class BooksConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData
               (
                 new Book
                 {
                     Id = 1,
                     ISBN = "123456789",
                     Title = "Война и Мир",
                     Author = "Толстой",
                 },
                 new Book
                 {
                     Id = 2,
                     ISBN = "12345678910",
                     Title = "Harry Potter Philosopher's Stone",
                     Author = "J. K. Rowling",
                 },
                 new Book
                 {
                     Id = 3,
                     ISBN = "123456789a",
                     Title = "Harry Potter Chamber of Secrets",
                     Author = "J. K. Rowling",
                 },
                 new Book
                 {
                     Id = 4,
                     ISBN = "123456789b",
                     Title = "Harry Potter CPrisoner of Azkaban",
                     Author = "J. K. Rowling",
                 },
                 new Book
                 {
                     Id = 5,
                     ISBN = "123456789c",
                     Title = "Harry Potter Goblet of Fire",
                     Author = "J. K. Rowling",
                 },
                 new Book
                 {
                     Id = 6,
                     ISBN = "123456789d",
                     Title = "Harry Potter Order of the Phoenix",
                     Author = "J. K. Rowling",
                 },
                 new Book
                 {
                     Id = 7,
                     ISBN = "123456789e",
                     Title = "Harry Potter Half-Blood Prince",
                     Author = "J. K. Rowling",
                 },
                 new Book
                 {
                     Id = 8,
                     ISBN = "123456789f",
                     Title = "Harry Potter Deathly Hallows",
                     Author = "J. K. Rowling",
                 }
               );
        }
    }
}
