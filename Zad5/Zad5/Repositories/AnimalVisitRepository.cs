using Zad5.Models;

namespace Zad5.Repositories;

public class AnimalVisitRepository : IAnimalVisitRepository
{
    
    private static List<AnimalVisit> _animalVisits = new List<AnimalVisit>
    {
        new AnimalVisit(1, DateTime.Parse("2024-04-10"), "Routine checkup", 50.00),
        new AnimalVisit(2, DateTime.Parse("2024-04-11"), "Vaccination", 35.00),
        new AnimalVisit(3, DateTime.Parse("2024-04-12"), "Wing trimming", 20.00),
        new AnimalVisit(4, DateTime.Parse("2024-04-10"), "Skin examination", 45.00),
        new AnimalVisit(5, DateTime.Parse("2024-04-11"), "Aquarium cleaning", 30.00)
    };
    public IEnumerable<AnimalVisit> GetAnimalVisits()
    {
        return _animalVisits;
    }

    public int CreateAnimalVisit(AnimalVisit animalVisit)
    {
        _animalVisits.Add(animalVisit);
        return 1;
    }

    public IEnumerable<AnimalVisit> GetAnimalVisitsForAnimal(int animalId)
    {
        return _animalVisits.FindAll(visit => visit.AnimalId == animalId);
    }
    
}