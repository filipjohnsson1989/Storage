using System.ComponentModel.DataAnnotations;

namespace Storage.Models.ViewModels;

public class ProductViewModel
{

    [Display(Name = "Namn")]
    public string Name { get; set; }

    [Display(Name = "Pris")]
    public int Price { get; set; }

    [Display(Name = "Räkning")]
    public int Count { get; set; }
    
    [Display(Name = "Lagervärde")]
    public int InventoryValue { get; set; }
}
