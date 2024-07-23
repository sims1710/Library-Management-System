using System.ComponentModel.DataAnnotations;

public class Book
{
    public int BookId { get; set; }

    [Required]
    [StringLength(255)]
    public string Title { get; set; }

    [Required]
    [StringLength(255)]
    public string Author { get; set; }

    [Required]
    [StringLength(20)]
    public string ISBN { get; set; }

    [Range(1000, 9999)]
    public int PublicationYear { get; set; }

    public int AvailableCopies { get; set; }
}
