using Zad5.Models;
using Zad5.Repositories;

namespace Zad5.Services;

public class AnimalVisitService : IAnimalVisitService
{
    private readonly IAnimalVisitRepository _animalVisitRepository;

    public AnimalVisitService(IAnimalVisitRepository animalVisitRepository)
    {
        _animalVisitRepository = animalVisitRepository;
    }

    public IEnumerable<AnimalVisit> GetAnimalVisits()
    {
        return _animalVisitRepository.GetAnimalVisits();
    }

    public int CreateAnimalVisit(AnimalVisit animalVisit)
    {
        return _animalVisitRepository.CreateAnimalVisit(animalVisit);
    }

    public IEnumerable<AnimalVisit> GetAnimalVisitsForAnimal(int animalId)
    {
        return _animalVisitRepository.GetAnimalVisitsForAnimal(animalId);
    }
    
}