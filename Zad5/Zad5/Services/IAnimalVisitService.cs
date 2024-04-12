using Zad5.Models;

namespace Zad5.Services;

public interface IAnimalVisitService
{
    IEnumerable<AnimalVisit> GetAnimalVisits();
    int CreateAnimalVisit(AnimalVisit animalVisit);
    IEnumerable<AnimalVisit> GetAnimalVisitsForAnimal(int animalId);
}