using Zad5.Models;

namespace Zad5.Repositories;

public class AnimalsRepository : IAnimalsRepository
{
    private static List<Animal> _animals = 
        new List<Animal>
        {
            new Animal("Whiskers", "Mammal", 5.2, "Tabby"),
            new Animal( "Rex", "Mammal", 15.7, "Golden"),
            new Animal( "Polly", "Bird", 0.5, "Green"),
            new Animal( "Slytherin", "Reptile", 8.3, "Black"),
            new Animal( "Nemo", "Fish", 0.2, "Orange and White")
        };
    public IEnumerable<Animal> GetAnimals()
    {
        return _animals;
    }

    public Animal? GetAnimal(int id)
    {
        return _animals.Find(animal => animal.Id == id);
    }
    

    public int CreateAnimal(Animal animal)
    {
        _animals.Add(animal);
        return 1;
    }

    public int UpdateAnimal(Animal animal)
    {
        var animalToUpdate = _animals.Find(an => an.Id == animal.Id);
        if (animalToUpdate == null)
        {
            return 0;
        }

        _animals.Remove(animalToUpdate);
        _animals.Add(animal);
        return 1;

    }

    public int DeleteAnimal(int idAnimal)
    {
        Animal? animalToDelete = _animals.Find(animal => animal.Id == idAnimal);
        if (animalToDelete == null)
        {
            return 0;
        }
        else
        {
            _animals.Remove(animalToDelete);
            return 1;
        }
    }
}