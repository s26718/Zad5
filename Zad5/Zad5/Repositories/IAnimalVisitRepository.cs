using Zad5.Models;

namespace Zad5.Repositories;

public interface IAnimalVisitRepository
{
    IEnumerable<AnimalVisit> GetAnimalVisits();
    int CreateAnimalVisit(AnimalVisit animalVisit);
    IEnumerable<AnimalVisit> GetAnimalVisitsForAnimal(int animalId);

}