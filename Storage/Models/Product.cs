using System.ComponentModel.DataAnnotations;

namespace Storage.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    [Display(Name ="Namn")]
    [StringLength(maximumLength: 20, ErrorMessage = "Namnet måste vara max 20 långt")]
    [MinLength(length:2 , ErrorMessage = "Namnet måste vara minst 2 långt")]
    public string Name { get; set; }
    
    [Range(minimum:1, maximum:999, ErrorMessage = "Prisen måste vara mellan 1 och 999")]
    public int Price { get; set; }
    [DataType(DataType.Date)]
    public DateTime Orderdate { get; set; }
    [Required]
    public string Category { get; set; }
    public string Shelf { get; set; }
    public int Count { get; set; }
    public string Description { get; set; }

}
