using System.ComponentModel.DataAnnotations;

namespace LibraryUI.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
