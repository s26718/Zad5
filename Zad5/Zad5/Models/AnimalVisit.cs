using System.ComponentModel.DataAnnotations;

namespace Zad5.Models;

public class AnimalVisit
{
    [Required]
    public int AnimalId { get; }
    [Required]
    [MaxLength(100)]
    public DateTime VisitDate { get; }
    [Required]
    [MaxLength(3000)]
    public string VisitDescription { get; set; }
    [Required]
    [Range(0,2000)]
    public double VisitPrice { get; }

    public AnimalVisit(int animalId, DateTime visitDate, string visitDescription, double visitPrice)
    {
        AnimalId = animalId;
        VisitDate = visitDate;
        VisitDescription = visitDescription;
        VisitPrice = visitPrice;
    }
}