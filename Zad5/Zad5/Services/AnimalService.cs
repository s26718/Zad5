using Zad5.Models;
using Zad5.Repositories;

namespace Zad5.Services;

public class AnimalService:IAnimalService
{
    private readonly IAnimalsRepository _animalsRepository;

    public AnimalService(IAnimalsRepository animalsRepository)
    {
        _animalsRepository = animalsRepository;
    }

    public IEnumerable<Animal> GetAnimals()
    {
        return _animalsRepository.GetAnimals();
    }

    public Animal? GetAnimal(int id)
    {
        return _animalsRepository.GetAnimal(id);
    }

    public int CreateAnimal(Animal animal)
    {
        return _animalsRepository.CreateAnimal(animal);
    }

    public int UpdateAnimal(Animal animal)
    {
        return _animalsRepository.UpdateAnimal(animal);
    }

    public int DeleteAnimal(int idAnimal)
    {
        return _animalsRepository.DeleteAnimal(idAnimal);
    }

}