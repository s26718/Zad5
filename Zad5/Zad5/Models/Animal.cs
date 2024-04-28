using System.ComponentModel.DataAnnotations;

namespace Zad5.Models;

public class Animal
{
    private static int _idCounter;
    public int Id {  get; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get;  set; }
    [Required]
    [MaxLength(100)]
    public string Category { get; set; }
    [Required]
    [Range(0, 999)]
    public double Weight { get; set; }
    [Required]
    [MaxLength(100)]

    public string Coloration { get; set; }

    public Animal( string name, string category, double weight, string coloration)
    {
        Id = ++_idCounter;
        Name = name;
        Category = category;
        Weight = weight;
        Coloration = coloration;
    }

}